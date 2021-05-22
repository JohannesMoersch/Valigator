﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Composition;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Valigator.Models.Generator.Analyzers.CodeFixes
{
	[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(ModelTypeParameterMismatchCodeFix)), Shared]
	public class ModelTypeParameterMismatchCodeFix : CodeFixProvider
	{
		public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(AnalyzerDiagnosticDescriptors.ModelTypeParameterMismatch.Id);

		public override FixAllProvider GetFixAllProvider()
			=> WellKnownFixAllProviders.BatchFixer;

		public override async Task RegisterCodeFixesAsync(CodeFixContext context)
		{
			var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken);

			var diagnostic = context.Diagnostics.First();
			var diagnosticSpan = diagnostic.Location.SourceSpan;

			var classSyntax = root
				?.FindToken(diagnosticSpan.Start)
				.Parent
				?.AncestorsAndSelf()
				.OfType<ClassDeclarationSyntax>()
				.First();

			if (classSyntax == null)
				return;

			context
				.RegisterCodeFix
				(
					CodeAction
						.Create
						(
							title: "Make model type parameters match model definition",
							createChangedSolution: c => MakeTypeParametersMatch(context.Document, classSyntax, c),
							equivalenceKey: "Make model type parameters match model definition"
						),
					diagnostic
				);
		}

		private async Task<Solution> MakeTypeParametersMatch(Document document, ClassDeclarationSyntax classSyntax, CancellationToken cancellationToken)
		{
			var semanticModel = await document.GetSemanticModelAsync(cancellationToken);

			var typeSymbol = semanticModel.GetDeclaredSymbol(classSyntax);

			var typeName = typeSymbol.GetFullNameWithNamespace("+", false);

			GetAttributes(semanticModel.Compilation, out var generateModelAttributeType, out var generateModelDefaultsAttributeType);

			if
			(
				typeSymbol.TryGetAttribute(generateModelAttributeType, out var generateModelAttribute) &&
				generateModelAttribute.TryGetGeneratedModelNamespace(typeName, generateModelDefaultsAttributeType, out var modelNamespace, out _, out _) &&
				generateModelAttribute.TryGetGeneratedModelParentClasses(typeName, generateModelDefaultsAttributeType, out var modelParentClasses, out _, out _) &&
				generateModelAttribute.TryGetGeneratedModelName(typeName, generateModelDefaultsAttributeType, out var modelName, out _, out _)
			)
			{
				var syntaxRoot = await document.GetSyntaxRootAsync(cancellationToken);

				var models = semanticModel
					.LookupNamespaceAndTypeSymbols(modelNamespace, modelParentClasses.Select(p => (p, 0)).Concat(new[] { (modelName, typeSymbol.TypeParameters.Length) }).ToArray())
					.OfType<INamedTypeSymbol>()
					.Last()
					.GetDeclaringSyntaxReferences(cancellationToken);

				var newSyntaxRoot = syntaxRoot
					.ReplaceNodes
					(
						models.Select(m => m.TypeParameterList), 
						(_, typeParameterList) =>
						{
							var parameterList = typeParameterList.Parameters;
							for (int i = 0; i < typeParameterList.Parameters.Count; ++i)
								parameterList = parameterList.Replace(parameterList[i], parameterList[i].WithIdentifier(classSyntax.TypeParameterList.Parameters[i].Identifier.WithTriviaFrom(parameterList[i].Identifier)));

							return typeParameterList.WithParameters(parameterList);
						}
					);

				return document.Project.Solution.WithDocumentSyntaxRoot(document.Id, newSyntaxRoot);
			}

			return document.Project.Solution;
		}

		private static void GetAttributes(Compilation compilation, out INamedTypeSymbol generateModelAttributeType, out INamedTypeSymbol generateModelDefaultsAttributeType)
		{
			generateModelAttributeType = compilation.GetTypeByMetadataName(ExternalConstants.GenerateModelAttribute_TypeName);
			generateModelDefaultsAttributeType = compilation.GetTypeByMetadataName(ExternalConstants.GenerateModelDefaultsAttribute_TypeName);
		}
	}
}
