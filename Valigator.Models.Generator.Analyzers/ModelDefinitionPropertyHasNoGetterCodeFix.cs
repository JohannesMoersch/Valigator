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
	public class ModelDefinitionPropertyHasNoGetterCodeFix : CodeFixProvider
	{
		public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyDoesNotHaveGetter.Id);

		public override FixAllProvider GetFixAllProvider()
			=> WellKnownFixAllProviders.BatchFixer;

		public override async Task RegisterCodeFixesAsync(CodeFixContext context)
		{
			var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken);

			var diagnostic = context.Diagnostics.First();
			var diagnosticSpan = diagnostic.Location.SourceSpan;

			var propertySyntax = root
				?.FindToken(diagnosticSpan.Start)
				.Parent
				?.AncestorsAndSelf()
				.OfType<PropertyDeclarationSyntax>()
				.First();

			if (propertySyntax == null)
				return;

			if (propertySyntax.AccessorList?.Accessors.Any(accessor => accessor.Keyword.Text == "get") ?? false)
			{
				context
					.RegisterCodeFix
					(
						CodeAction
							.Create
							(
								title: "Make getter public",
								createChangedSolution: c => MakeGetterPublic(context.Document, propertySyntax, c),
								equivalenceKey: "Make getter public"
							),
						diagnostic
					);
			}
			else
			{
				context
					.RegisterCodeFix
					(
						CodeAction
							.Create
							(
								title: "Add getter",
								createChangedSolution: c => AddGetter(context.Document, propertySyntax, c),
								equivalenceKey: "Add getter"
							),
						diagnostic
					);
			}
		}

		private async Task<Solution> MakeGetterPublic(Document document, PropertyDeclarationSyntax propertySyntax, CancellationToken cancellationToken)
		{
			var newAccessors = propertySyntax
				.AccessorList
				?.Accessors
				.Select(accessor => accessor.Keyword.Text != "get"
					? accessor
					: accessor.WithModifiers(new SyntaxTokenList(accessor.Modifiers.Where(modifier => modifier.Text != "private")))
				);

			var newSyntaxList = new SyntaxList<AccessorDeclarationSyntax>(newAccessors);

			var newPropertyDeclaration = propertySyntax.WithAccessorList(propertySyntax.AccessorList?.WithAccessors(newSyntaxList) ?? SyntaxFactory.AccessorList(newSyntaxList));

			var syntaxRoot = await document.GetSyntaxRootAsync(cancellationToken);

			var newSyntaxRoot = syntaxRoot.ReplaceNode(propertySyntax, newPropertyDeclaration);

			return document.Project.Solution.WithDocumentSyntaxRoot(document.Id, newSyntaxRoot);
		}

		private async Task<Solution> AddGetter(Document document, PropertyDeclarationSyntax propertyDeclaration, CancellationToken cancellationToken)
		{
			var newAccessor = SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithExpressionBody(SyntaxFactory.ArrowExpressionClause(SyntaxFactory.LiteralExpression(SyntaxKind.DefaultLiteralExpression))).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken));

			var newSyntaxList = (propertyDeclaration.AccessorList?.Accessors ?? new SyntaxList<AccessorDeclarationSyntax>()).Insert(0, newAccessor);

			var newPropertyDeclaration = propertyDeclaration.WithAccessorList(propertyDeclaration.AccessorList?.WithAccessors(newSyntaxList) ?? SyntaxFactory.AccessorList(newSyntaxList));

			var syntaxRoot = await document.GetSyntaxRootAsync(cancellationToken);

			var newSyntaxRoot = syntaxRoot.ReplaceNode(propertyDeclaration, newPropertyDeclaration);

			return document.Project.Solution.WithDocumentSyntaxRoot(document.Id, newSyntaxRoot);
		}
	}
}
