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

							foreach (var propertySyntax in GetPublicPropertiesWithSetters(typeSymbol))
							{
								context
									.ReportDiagnostic
									(
										Diagnostic.Create
										(
											AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyHasSetter,
											Location.Create(propertySyntax.SyntaxTree, propertySyntax.Identifier.Span)
										)
									);
							}
						}
					},
					SyntaxKind.ClassDeclaration
				);
		}

		private IEnumerable<PropertyDeclarationSyntax> GetPublicPropertiesWithSetters(ITypeSymbol typeSymbol)
			=> typeSymbol
				.GetMembers()
				.OfType<IPropertySymbol>()
				.Where(property => !property.IsStatic && !property.IsImplicitlyDeclared && property.SetMethod != null)
				.SelectMany(property => property.DeclaringSyntaxReferences)
				.Select(syntax => syntax.GetSyntax())
				.OfType<PropertyDeclarationSyntax>()
				.Where(property => property.AccessorList?.Accessors.FirstOrDefault(accessor => accessor.Keyword.Text == "set")?.Modifiers.All(modifier => modifier.Text != "private") ?? false);
	}
}
