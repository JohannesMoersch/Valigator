using Microsoft.CodeAnalysis;
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
	[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(ModelOrParentClassNotPartialCodeFix)), Shared]
	public class ModelOrParentClassNotPartialCodeFix : CodeFixProvider
	{
		public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(AnalyzerDiagnosticDescriptors.ModelNotPartial.Id, AnalyzerDiagnosticDescriptors.ModelParentNotPartial.Id, AnalyzerDiagnosticDescriptors.ModelAndModelParentNotPartial.Id);

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

			string title;
			if (diagnostic.Id == AnalyzerDiagnosticDescriptors.ModelNotPartial.Id)
				title = "Make model partial";
			else if (diagnostic.Id == AnalyzerDiagnosticDescriptors.ModelParentNotPartial.Id)
				title = "Make model parents partial";
			else
				title = "Make model and model parents partial";

			context
				.RegisterCodeFix
				(
					CodeAction
						.Create
						(
							title: title,
							createChangedSolution: c => MakeParentClassesPartial(context.Document, classSyntax, c),
							equivalenceKey: title
						),
					diagnostic
				);
		}

		private async Task<Solution> MakeParentClassesPartial(Document document, ClassDeclarationSyntax classSyntax, CancellationToken cancellationToken)
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

				var nonPartialParentClasses = semanticModel
					.LookupNamespaceAndTypeSymbols(modelNamespace, modelParentClasses.Select(p => (p, 0)).Concat(new[] { (modelName, typeSymbol.TypeParameters.Length) }).ToArray())
					.OfType<ITypeSymbol>()
					.SelectMany(c => c.GetDeclaringSyntaxReferences(cancellationToken))
					.Where(s => !s.IsPartial())
					.ToArray();

				var newSyntaxRoot = syntaxRoot.ReplaceNodes(nonPartialParentClasses, (_, typeSyntax) => typeSyntax.WithModifiers(typeSyntax.Modifiers.Add(SyntaxFactory.Token(SyntaxKind.PartialKeyword))));

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
