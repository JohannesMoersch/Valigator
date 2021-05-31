using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using Valigator.Models.Generator.Analyzers.Extensions;

namespace Valigator.Models.Generator.Analyzers
{
	[DiagnosticAnalyzer(LanguageNames.CSharp)]
	public class ModelDefinitionPropertyTypeMismatchAnalyzer : DiagnosticAnalyzer
	{
		public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
			=> ImmutableArray
				.Create
				(
					AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyTypeMismatch
				);

		public override void Initialize(AnalysisContext context)
		{
			context.EnableConcurrentExecution();

			context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

			context
				.RegisterSyntaxNodeAction
				(
					context =>
					{
						if (context.Node.TryGetPropertyAndExpressionForPropertyAssignment(context.SemanticModel, context.CancellationToken, out var propertySymbol, out var expressionSyntax) && !propertySymbol.IsStatic && propertySymbol.DeclaredAccessibility == Accessibility.Public && propertySymbol.GetMethod?.DeclaredAccessibility == Accessibility.Public)
						{
							var generateModelAttributeType = context.Compilation.GetTypeByMetadataName(ExternalConstants.GenerateModelAttribute_TypeName);

							if (propertySymbol.ContainingType.HasAttribute(generateModelAttributeType))
								CheckForMismatch(context, expressionSyntax, propertySymbol);
						}
					},
					SyntaxKind.ArrowExpressionClause,
					SyntaxKind.EqualsValueClause,
					SyntaxKind.SimpleAssignmentExpression
				);
		}

		private static void CheckForMismatch(SyntaxNodeAnalysisContext context, ExpressionSyntax expressionSyntax, IPropertySymbol propertySymbol)
		{
			var modelPropertyDataType = context.Compilation.GetTypeByMetadataName(ExternalConstants.IModelPropertyData_TypeName);

			var propertyTypeFromInitializer = expressionSyntax.GetModelPropertyArgumentType(context.SemanticModel, modelPropertyDataType);

			if (propertyTypeFromInitializer != null)
			{
				var propertyTypeFromProperty = propertySymbol.IsModelDefinitionProperty(context.CancellationToken)
					? (propertySymbol.Type as INamedTypeSymbol).TypeArguments[0]
					: null;

				if (!SymbolEqualityComparer.Default.Equals(propertyTypeFromProperty, propertyTypeFromInitializer))
				{
					context
						.ReportDiagnostic
						(
							Diagnostic.Create
							(
								AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyTypeMismatch,
								Location.Create(expressionSyntax.SyntaxTree, expressionSyntax.Span)
							)
						);
				}
			}
		}
	}
}
