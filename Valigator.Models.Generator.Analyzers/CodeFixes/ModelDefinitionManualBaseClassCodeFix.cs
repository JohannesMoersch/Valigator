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
using Valigator.Models.Generator.Analyzers.Extensions;

namespace Valigator.Models.Generator.Analyzers.CodeFixes
{
	[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(ModelDefinitionManualBaseClassCodeFix)), Shared]
	public class ModelDefinitionManualBaseClassCodeFix : CodeFixProvider
	{
		public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(AnalyzerDiagnosticDescriptors.ModelDefinitionManualBaseClass.Id);

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
							title: "Remove base class",
							createChangedSolution: c => RemoveBaseClass(context.Document, classSyntax, c),
							equivalenceKey: "Remove base class"
						),
					diagnostic
				);
		}

		private async Task<Solution> RemoveBaseClass(Document document, ClassDeclarationSyntax classSyntax, CancellationToken cancellationToken)
		{
			var semanticModel = await document.GetSemanticModelAsync(cancellationToken);

			if (classSyntax.TryGetBaseTypeSyntax(semanticModel, cancellationToken, out var baseTypeSyntax))
			{
				var syntaxRoot = await document.GetSyntaxRootAsync(cancellationToken);

				var newBaseList = classSyntax.BaseList.Types.Remove(baseTypeSyntax);

				var newSyntaxRoot = newBaseList.Count == 0
					? syntaxRoot.RemoveNode(classSyntax.BaseList, SyntaxRemoveOptions.KeepEndOfLine)
					: syntaxRoot.ReplaceNode(classSyntax, classSyntax.WithBaseList(classSyntax.BaseList.WithTypes(newBaseList)));
				
				return document.Project.Solution.WithDocumentSyntaxRoot(document.Id, newSyntaxRoot);
			}

			return document.Project.Solution;
		}
	}
}
