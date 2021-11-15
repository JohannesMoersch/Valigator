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
using Valigator.Models.Generator.Analyzers.Extensions;

namespace Valigator.Models.Generator.Analyzers.CodeFixes
{
    [ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(ModelTypeMismatchCodeFix)), Shared]
    public class ModelTypeMismatchCodeFix : CodeFixProvider
    {
        public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(AnalyzerDiagnosticDescriptors.ModelTypeMismatch.Id);

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
							title: "Make model type match definition",
							createChangedSolution: c => MakeModelTypeMatchDefinition(context.Document, classSyntax, c),
							equivalenceKey: "Make model type match definition"
						),
					diagnostic
				);
		}

        private async Task<Solution> MakeModelTypeMatchDefinition(Document document, ClassDeclarationSyntax classSyntax, CancellationToken cancellationToken)
		{
			var semanticModel = await document.GetSemanticModelAsync(cancellationToken);

			var typeSymbol = semanticModel.GetDeclaredSymbol(classSyntax, cancellationToken);

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

				var modelSyntax = semanticModel
					.LookupAllNamespaceAndTypeSymbols(modelNamespace, modelParentClasses.Select(p => (p, 0)).Concat(new[] { (modelName, typeSymbol.TypeParameters.Length) }).ToArray())
					.Last()
					.OfType<INamedTypeSymbol>()
					.SelectMany(s => s.GetDeclaringSyntaxReferences(cancellationToken))
					.ToArray() ?? Array.Empty<TypeDeclarationSyntax>();

				var modelTypeMode = generateModelAttribute.GetGenerateModelPropertyValue(ExternalConstants.GenerateModelAttribute_Type_PropertyName, generateModelDefaultsAttributeType, ExternalConstants.ModelType.Unset);

				var expectedTypeKind = modelTypeMode == ExternalConstants.ModelType.Auto
					? modelSyntax.Any(s => s.Keyword.IsKind(SyntaxKind.ClassKeyword)) || modelSyntax.Any(s => !s.Keyword.IsKind(SyntaxKind.StructKeyword))
						? TypeKind.Class
						: TypeKind.Struct
					: modelTypeMode == ExternalConstants.ModelType.Struct
						? TypeKind.Struct
						: TypeKind.Class;

				var newSyntaxRoot = expectedTypeKind == TypeKind.Class
					? syntaxRoot.ReplaceNodes(modelSyntax.Where(s => !s.Keyword.IsKind(SyntaxKind.ClassKeyword)), (_, typeSyntax) => typeSyntax.ToClassDeclarationSyntax())
					: syntaxRoot.ReplaceNodes(modelSyntax.Where(s => !s.Keyword.IsKind(SyntaxKind.StructKeyword)), (_, typeSyntax) => typeSyntax.ToStructDeclarationSyntax());

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
