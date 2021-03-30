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
	public class ModelDefinitionNotPartialClassCodeFix : CodeFixProvider
	{
		public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create("VL0001");

		public override FixAllProvider GetFixAllProvider()
			=> null;

		public override async Task RegisterCodeFixesAsync(CodeFixContext context)
		{
			var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken);

			var diagnostic = context.Diagnostics.First();
			var diagnosticSpan = diagnostic.Location.SourceSpan;

			var classDeclaration = root
				?.FindToken(diagnosticSpan.Start)
				.Parent
				?.AncestorsAndSelf()
				.OfType<ClassDeclarationSyntax>()
				.First();

			if (classDeclaration == null)
				return;

			context
				.RegisterCodeFix
				(
					CodeAction
						.Create
						(
							title: "Make partial",
							createChangedSolution: c => MakeClassPartial(context.Document, classDeclaration, c),
							equivalenceKey: "Make partial"
						),
					diagnostic
				);
		}

		private async Task<Solution> MakeClassPartial(Document document, ClassDeclarationSyntax classDeclaration, CancellationToken cancellationToken)
		{
			var newClassDeclaration = classDeclaration.WithModifiers(classDeclaration.Modifiers.Add(SyntaxFactory.Token(SyntaxKind.PartialKeyword)));

			var syntaxRoot = await document.GetSyntaxRootAsync();

			var newSyntaxRoot = syntaxRoot.ReplaceNode(classDeclaration, newClassDeclaration);

			return document.Project.Solution.WithDocumentSyntaxRoot(document.Id, newSyntaxRoot);
		}
	}
}
