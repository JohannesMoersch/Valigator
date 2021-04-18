using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	[DiagnosticAnalyzer(LanguageNames.CSharp)]
	public class GenerateModelAnalyzer : DiagnosticAnalyzer
	{
		public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(AnalyzerDiagnosticDescriptors.ModelDefinitionNotPartialClass, AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyHasSetter);

		public override void Initialize(AnalysisContext context)
		{
			context.EnableConcurrentExecution();

			context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

			context
				.RegisterSyntaxNodeAction
				(
					context =>
					{
						var generatedModelAttributeType = context
							.Compilation
							.GetTypeByMetadataName(ExternalConstants.GenerateModelAttribute_TypeName);

						var modelDefinitionPropertyType = context
							.Compilation
							.GetTypeByMetadataName(ExternalConstants.ModelDefinition_Property_TypeName);

						var classDeclaration = (ClassDeclarationSyntax)context.Node;

						var typeSymbol = context
							.SemanticModel
							.GetDeclaredSymbol(classDeclaration);

						if (typeSymbol.HasAttribute(generatedModelAttributeType))
						{
							if (!classDeclaration.IsPartial())
							{
								context
									.ReportDiagnostic
									(
										Diagnostic.Create
										(
											AnalyzerDiagnosticDescriptors.ModelDefinitionNotPartialClass,
											Location.Create(classDeclaration.SyntaxTree, classDeclaration.Identifier.Span)
										)
									);
							}

							var properties = typeSymbol
								.GetProperties()
								.Where(property => !property.IsStatic && !property.IsImplicitlyDeclared)
								.Select(symbol => symbol.GetDeclarationSyntax())
								.Where(property => property.IsPublic())
								.Where(property => property.TryGetGetAccessor(out var getAccessor) && !getAccessor.IsPrivate())
								.Where(property => property.Type.IsModelDefinitionProperty());

							foreach (var propertySyntax in properties)
							{
								if (!propertySyntax.TryGetGetAccessor(out var getAccessor) || getAccessor.IsPrivate())
								{
									context
										.ReportDiagnostic
										(
											Diagnostic.Create
											(
												AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyHasSetter,
												Location.Create(propertySyntax.SyntaxTree, getAccessor.Modifiers.First(modifier => modifier.Text == "private").Span)
											)
										);
								}

								if (propertySyntax.TryGetSetAccessor(out var setAccessor) && !setAccessor.IsPrivate())
								{
									context
										.ReportDiagnostic
										(
											Diagnostic.Create
											(
												AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyHasSetter,
												Location.Create(propertySyntax.SyntaxTree, setAccessor.Keyword.Span)
											)
										);
								}
							}
						}
					},
					SyntaxKind.ClassDeclaration
				);
		}
	}
}
