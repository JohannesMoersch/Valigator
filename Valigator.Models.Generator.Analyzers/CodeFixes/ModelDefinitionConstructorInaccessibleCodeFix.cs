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
	[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(ModelDefinitionConstructorInaccessibleCodeFix)), Shared]
	public class ModelDefinitionConstructorInaccessibleCodeFix : CodeFixProvider
	{
		public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(AnalyzerDiagnosticDescriptors.ModelDefinitionConstructorInaccessible.Id);

		public override FixAllProvider GetFixAllProvider()
			=> WellKnownFixAllProviders.BatchFixer;

		public override async Task RegisterCodeFixesAsync(CodeFixContext context)
		{
			var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken);

			var diagnostic = context.Diagnostics.First();
			var diagnosticSpan = diagnostic.Location.SourceSpan;

			var constructorSyntax = root
				?.FindToken(diagnosticSpan.Start)
				.Parent
				?.AncestorsAndSelf()
				.OfType<ConstructorDeclarationSyntax>()
				.First();

			if (constructorSyntax == null)
				return;

			context
				.RegisterCodeFix
				(
					CodeAction
						.Create
						(
							title: "Make public",
							createChangedSolution: c => MakeConstructorPublic(context.Document, constructorSyntax, c),
							equivalenceKey: "Make public"
						),
					diagnostic
				);
		}

		private async Task<Solution> MakeConstructorPublic(Document document, ConstructorDeclarationSyntax constructorSyntax, CancellationToken cancellationToken)
		{
			var modifiers = constructorSyntax.Modifiers;
			while (modifiers.TryGetFirst(m => m.IsKind(SyntaxKind.InternalKeyword) || m.IsKind(SyntaxKind.ProtectedKeyword) || m.IsKind(SyntaxKind.PrivateKeyword), out var token))
				modifiers = modifiers.Remove(token);

			var newConstructorDeclaration = constructorSyntax.WithModifiers(modifiers.Add(SyntaxFactory.Token(SyntaxKind.PublicKeyword)));

			var syntaxRoot = await document.GetSyntaxRootAsync(cancellationToken);

			var newSyntaxRoot = syntaxRoot.ReplaceNode(constructorSyntax, newConstructorDeclaration);

			return document.Project.Solution.WithDocumentSyntaxRoot(document.Id, newSyntaxRoot);
		}
	}
}
