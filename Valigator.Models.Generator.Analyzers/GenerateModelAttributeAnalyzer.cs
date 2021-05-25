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
	public class GenerateModelAttributeAnalyzer : DiagnosticAnalyzer
	{
		public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
			=> ImmutableArray
				.Create
				(
					AnalyzerDiagnosticDescriptors.GenerateModelAttributePropertiesSet
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
						var assignmentExpression = (AssignmentExpressionSyntax)context.Node;

						var assignmentMemberContainingType = context
							.SemanticModel
							.GetSymbolInfo(assignmentExpression.Left, context.CancellationToken)
							.Symbol
							?.ContainingType;

						if (assignmentMemberContainingType?.GetFullNameWithNamespace(".", false) == ExternalConstants.GenerateModelAttribute_TypeName)
						{
							var isGenerateModelProperty = context
								.Compilation
								.GetTypeByMetadataName(ExternalConstants.GenerateModelAttribute_TypeName)
								.Equals(assignmentMemberContainingType, SymbolEqualityComparer.Default);

							if (isGenerateModelProperty)
							{
								var span = assignmentExpression.Left is MemberAccessExpressionSyntax memberAccess
									? memberAccess.Name.Span
									: assignmentExpression.Left.Span;

								context
									.ReportDiagnostic
									(
										Diagnostic.Create
										(
											AnalyzerDiagnosticDescriptors.GenerateModelAttributePropertiesSet,
											Location.Create(assignmentExpression.SyntaxTree, span)
										)
									);
							}
						}
					},
					SyntaxKind.SimpleAssignmentExpression,
					SyntaxKind.AddAssignmentExpression
				);
		}
	}
}
