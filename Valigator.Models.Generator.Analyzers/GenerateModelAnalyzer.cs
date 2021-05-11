using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	[DiagnosticAnalyzer(LanguageNames.CSharp)]
	public class GenerateModelAnalyzer : DiagnosticAnalyzer
	{
		public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics 
			=> ImmutableArray
				.Create
				(
					AnalyzerDiagnosticDescriptors.ModelDefinitionNotPartialClass, 
					AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyDoesNotHaveGetter, 
					AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyHasSetter,
					AnalyzerDiagnosticDescriptors.ModelDefinitionModelIdentifierMatchFailed,
					AnalyzerDiagnosticDescriptors.ModelDefinitionModelIdentifierInvalid,
					AnalyzerDiagnosticDescriptors.ParentClassNotPartialClass
				);

		private CodeDomProvider CodeProvider { get; } = CodeDomProvider.CreateProvider("csharp");

		public override void Initialize(AnalysisContext context)
		{
			context.EnableConcurrentExecution();

			context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

			context
				.RegisterSyntaxNodeAction
				(
					context =>
					{
						GetAttributes(context, out var generateModelAttributeType, out var generateModelDefaultsAttributeType);

						var classSyntax = (ClassDeclarationSyntax)context.Node;

						var typeSymbol = context
							.SemanticModel
							.GetDeclaredSymbol(classSyntax);

						if (typeSymbol.TryGetAttribute(generateModelAttributeType, out var generateModelAttribute))
						{
							CheckForNotPartialClass(context, classSyntax);

							CheckForParentsNotPartialClass(context, classSyntax, typeSymbol, generateModelAttribute, generateModelDefaultsAttributeType);

							CheckForModelIdentifierIssues(context, classSyntax, typeSymbol, generateModelAttribute, generateModelDefaultsAttributeType);

							foreach (var propertySyntax in GetPublicModelDefinitionProperties(typeSymbol))
							{
								CheckForPropertyDoesNotHaveGetter(context, propertySyntax);

								CheckForPropertyHasSetter(context, propertySyntax);
							}
						}
					},
					SyntaxKind.ClassDeclaration
				);
		}

		private static void GetAttributes(SyntaxNodeAnalysisContext context, out INamedTypeSymbol generateModelAttributeType, out INamedTypeSymbol generateModelDefaultsAttributeType)
		{
			generateModelAttributeType = context.Compilation.GetTypeByMetadataName(ExternalConstants.GenerateModelAttribute_TypeName);
			generateModelDefaultsAttributeType = context.Compilation.GetTypeByMetadataName(ExternalConstants.GenerateModelDefaultsAttribute_TypeName);
		}

		private static IEnumerable<PropertyDeclarationSyntax> GetPublicModelDefinitionProperties(INamedTypeSymbol typeSymbol)
			=> typeSymbol
				.GetProperties()
				.Where(property => !property.IsStatic && !property.IsImplicitlyDeclared)
				.Select(symbol => symbol.GetDeclarationSyntax())
				.Where(property => property.IsPublic())
				.Where(property => property.Type.IsModelDefinitionProperty());

		private void CheckForNotPartialClass(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax classSyntax)
		{
			if (!classSyntax.IsPartial())
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionNotPartialClass,
							Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span)
						)
					);
			}
		}

		private void CheckForParentsNotPartialClass(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax classSyntax, INamedTypeSymbol typeSymbol, AttributeData generateModelAttribute, INamedTypeSymbol generateModelDefaultsAttributeType)
		{
			var typeName = typeSymbol.GetFullNameWithNamespace();

			if (generateModelAttribute.TryGetGeneratedModelNamespace(typeName, generateModelDefaultsAttributeType, out var modelNamespace, out _, out _) && generateModelAttribute.TryGetGeneratedModelParentClasses(typeName, generateModelDefaultsAttributeType, out var modelParentClasses, out _, out _))
			{
				var nonPartialParentClasses = context
					.SemanticModel
					.LookupNamespaceAndTypeSymbols(modelNamespace, modelParentClasses)
					.OfType<ITypeSymbol>()
					.Where(c => c.GetDeclaringSyntaxReferences(context.CancellationToken).Any(s => !s.IsPartial()))
					.ToArray();

				if (nonPartialParentClasses.Any())
				{
					var messageParameter = nonPartialParentClasses.Length > 1
						? $"classes {nonPartialParentClasses.Select(t => $"\"{t.Name}\"").JoinListWithOxfordComma()} are"
						: $"class \"{nonPartialParentClasses[0].Name}\" is";

					context
						.ReportDiagnostic
						(
							Diagnostic.Create
							(
								AnalyzerDiagnosticDescriptors.ParentClassNotPartialClass,
								Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
								messageParameter
							)
						);
				}
			}
		}

		private void CheckForPropertyDoesNotHaveGetter(SyntaxNodeAnalysisContext context, PropertyDeclarationSyntax propertySyntax)
		{
			if (propertySyntax.ExpressionBody == null && (!propertySyntax.TryGetGetAccessor(out var getAccessor) || getAccessor.IsPrivate()))
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyDoesNotHaveGetter,
							Location.Create(propertySyntax.SyntaxTree, getAccessor?.Modifiers.First(modifier => modifier.Text == "private").Span ?? propertySyntax.Identifier.Span)
						)
					);
			}
		}

		private void CheckForPropertyHasSetter(SyntaxNodeAnalysisContext context, PropertyDeclarationSyntax propertySyntax)
		{
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

		private void CheckForModelIdentifierIssues(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax classSyntax, INamedTypeSymbol typeSymbol, AttributeData generateModelAttribute, INamedTypeSymbol generateModelDefaultsAttributeType)
		{
			var fullTypeName = typeSymbol.GetFullNameWithNamespace();

			var modelNamespaceSuccess = generateModelAttribute
				.TryGetGeneratedModelNamespace
				(
					fullTypeName,
					generateModelDefaultsAttributeType,
					out var modelNamespace,
					out var modelNamespaceCaptureRegex,
					out var modelNamespaceErrorMessage
				);

			if (!modelNamespaceSuccess)
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionModelIdentifierMatchFailed,
							Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
							"model namespace",
							fullTypeName,
							modelNamespaceCaptureRegex,
							modelNamespaceErrorMessage
						)
					);
			}
			else
				VerifyModelIdentifiers(context, classSyntax, modelNamespace, "model namespace");

			var modelParentClassesSuccess = generateModelAttribute
				.TryGetGeneratedModelParentClasses
				(
					fullTypeName,
					generateModelDefaultsAttributeType,
					out var modelParentClasses,
					out var modelParentClassesCaptureRegex,
					out var modelParentClassesErrorMessage
				);

			if (!modelParentClassesSuccess)
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionModelIdentifierMatchFailed,
							Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
							"model parent classes",
							fullTypeName,
							modelParentClassesCaptureRegex,
							modelParentClassesErrorMessage
						)
					);
			}
			else
				VerifyModelIdentifiers(context, classSyntax, modelParentClasses, "model parent class");

			var modelNameSuccess = generateModelAttribute
				.TryGetGeneratedModelName
				(
					fullTypeName,
					generateModelDefaultsAttributeType,
					out var modelName,
					out var modelNameCaptureRegex,
					out var modelNameErrorMessage
				);

			if (!modelNameSuccess)
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionModelIdentifierMatchFailed,
							Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
							"model name",
							fullTypeName,
							modelNameCaptureRegex,
							modelNameErrorMessage
						)
					);
			}
			else
				VerifyModelIdentifiers(context, classSyntax, new[] { modelName }, "model name");
		}

		private void VerifyModelIdentifiers(SyntaxNodeAnalysisContext context, ClassDeclarationSyntax classSyntax, string[] identifiers, string identifierType)
		{
			foreach (var invalid in identifiers.Where(s => !CodeProvider.IsValidIdentifier(s)))
			{
				context
					.ReportDiagnostic
					(
						Diagnostic.Create
						(
							AnalyzerDiagnosticDescriptors.ModelDefinitionModelIdentifierInvalid,
							Location.Create(classSyntax.SyntaxTree, classSyntax.Identifier.Span),
							identifierType,
							invalid
						)
					);
			}
		}
	}
}
