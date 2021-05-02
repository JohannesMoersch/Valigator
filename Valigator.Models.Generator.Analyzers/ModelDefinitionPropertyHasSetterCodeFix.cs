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

namespace Valigator.Models.Generator.Analyzers
{
	[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(ModelDefinitionNotPartialClassCodeFix)), Shared]
	public class ModelDefinitionPropertyHasSetterCodeFix : CodeFixProvider
	{
		public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyHasSetter.Id);

		public override FixAllProvider GetFixAllProvider()
			=> WellKnownFixAllProviders.BatchFixer;

		public override async Task RegisterCodeFixesAsync(CodeFixContext context)
		{
			var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken);

			var diagnostic = context.Diagnostics.First();
			var diagnosticSpan = diagnostic.Location.SourceSpan;

			var propertyDeclaration = root
				?.FindToken(diagnosticSpan.Start)
				.Parent
				?.AncestorsAndSelf()
				.OfType<PropertyDeclarationSyntax>()
				.First();

			if (propertyDeclaration == null)
				return;

			context
				.RegisterCodeFix
				(
					CodeAction
						.Create
						(
							title: "Remove setter",
							createChangedSolution: c => RemoveSetter(context.Document, propertyDeclaration, c),
							equivalenceKey: "Remove setter"
						),
					diagnostic
				);
		}

		private async Task<Solution> RemoveSetter(Document document, PropertyDeclarationSyntax propertyDeclaration, CancellationToken cancellationToken)
		{
			var newSyntaxList = new SyntaxList<AccessorDeclarationSyntax>(propertyDeclaration.AccessorList?.Accessors.Where(accessor => accessor.Keyword.Text != "set"));

			var newPropertyDeclaration = propertyDeclaration.WithAccessorList(SyntaxFactory.AccessorList(newSyntaxList));

			var syntaxRoot = await document.GetSyntaxRootAsync(cancellationToken);

			var newSyntaxRoot = syntaxRoot.ReplaceNode(propertyDeclaration, newPropertyDeclaration);

			return document.Project.Solution.WithDocumentSyntaxRoot(document.Id, newSyntaxRoot);
		}
	}
}
