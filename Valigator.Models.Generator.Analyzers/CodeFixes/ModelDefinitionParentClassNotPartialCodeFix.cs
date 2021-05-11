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
	[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(ModelDefinitionNotPartialClassCodeFix)), Shared]
	public class ModelDefinitionParentClassNotPartialCodeFix : CodeFixProvider
	{
		public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(AnalyzerDiagnosticDescriptors.ModelDefinitionParentClassNotPartialClass.Id);

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
							title: "Make model definition parent classes partial",
							createChangedSolution: c => MakeParentClassesPartial(context.Document, classSyntax, c),
							equivalenceKey: "Make model definition parent classes partial"
						),
					diagnostic
				);
		}

		private async Task<Solution> MakeParentClassesPartial(Document document, ClassDeclarationSyntax classSyntax, CancellationToken cancellationToken)
		{
			var semanticModel = await document.GetSemanticModelAsync(cancellationToken);

			var typeSymbol = semanticModel.GetDeclaredSymbol(classSyntax);

			var nonPartialParentClasses = (typeSymbol.ContainingType?.GetTypeHierarchy() ?? Enumerable.Empty<ITypeSymbol>())
				.SelectMany(c => c.GetDeclaringSyntaxReferences(cancellationToken))
				.Where(s => !s.IsPartial())
				.ToArray();

			var syntaxRoot = await document.GetSyntaxRootAsync(cancellationToken);

			var newSyntaxRoot = syntaxRoot.ReplaceNodes(nonPartialParentClasses, (_, typeSyntax) => typeSyntax.WithModifiers(typeSyntax.Modifiers.Add(SyntaxFactory.Token(SyntaxKind.PartialKeyword))));

			return document.Project.Solution.WithDocumentSyntaxRoot(document.Id, newSyntaxRoot);
		}

		private static void GetAttributes(Compilation compilation, out INamedTypeSymbol generateModelAttributeType, out INamedTypeSymbol generateModelDefaultsAttributeType)
		{
			generateModelAttributeType = compilation.GetTypeByMetadataName(ExternalConstants.GenerateModelAttribute_TypeName);
			generateModelDefaultsAttributeType = compilation.GetTypeByMetadataName(ExternalConstants.GenerateModelDefaultsAttribute_TypeName);
		}
	}
}
