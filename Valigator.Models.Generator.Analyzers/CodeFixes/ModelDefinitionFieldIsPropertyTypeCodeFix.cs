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
	[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(ModelDefinitionConstructorInaccessibleCodeFix)), Shared]
	public class ModelDefinitionFieldIsPropertyTypeCodeFix : CodeFixProvider
	{
		public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(AnalyzerDiagnosticDescriptors.ModelDefinitionFieldIsPropertyType.Id);

		public override FixAllProvider GetFixAllProvider()
			=> WellKnownFixAllProviders.BatchFixer;

		public override async Task RegisterCodeFixesAsync(CodeFixContext context)
		{
			var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken);

			var diagnostic = context.Diagnostics.First();
			var diagnosticSpan = diagnostic.Location.SourceSpan;

			var variableSyntax = root
				?.FindToken(diagnosticSpan.Start)
				.Parent
				?.AncestorsAndSelf()
				.OfType<VariableDeclaratorSyntax>()
				.First();

			if (variableSyntax == null)
				return;

			context
				.RegisterCodeFix
				(
					CodeAction
						.Create
						(
							title: $"Replace \"{variableSyntax.Identifier.ValueText}\" with property",
							createChangedSolution: c => MakeFieldIntoProperty(context.Document, variableSyntax, c),
							equivalenceKey: $"Replace \"{variableSyntax.Identifier.ValueText}\" with property"
						),
					diagnostic
				);
		}

		private async Task<Solution> MakeFieldIntoProperty(Document document, VariableDeclaratorSyntax variableSyntax, CancellationToken cancellationToken)
		{
			var declarationSyntax = (VariableDeclarationSyntax)variableSyntax.Parent;

			var fieldSyntax = (FieldDeclarationSyntax)declarationSyntax.Parent;

			var classSyntax = (ClassDeclarationSyntax)fieldSyntax.Parent;

			var syntaxRoot = await document.GetSyntaxRootAsync(cancellationToken);
			
			var newPropertySyntax = CreatePropertySyntax(variableSyntax);

			ClassDeclarationSyntax newClassSyntax;

			if (declarationSyntax.Variables.Count > 1)
			{
				var newFieldSyntax = fieldSyntax.WithDeclaration(declarationSyntax.WithVariables(declarationSyntax.Variables.Remove(variableSyntax)));

				var index = classSyntax.Members.IndexOf(fieldSyntax);

				newClassSyntax = classSyntax.WithMembers(classSyntax.Members.Replace(fieldSyntax, newFieldSyntax).Insert(index + 1, newPropertySyntax));
			}
			else
				newClassSyntax = classSyntax.WithMembers(classSyntax.Members.Replace(fieldSyntax, newPropertySyntax));
		
			var newSyntaxRoot = syntaxRoot.ReplaceNode(classSyntax, newClassSyntax);

			return document.Project.Solution.WithDocumentSyntaxRoot(document.Id, newSyntaxRoot);
		}

		private PropertyDeclarationSyntax CreatePropertySyntax(VariableDeclaratorSyntax variableSyntax)
			=> SyntaxFactory
			.PropertyDeclaration
			(
				((FieldDeclarationSyntax)variableSyntax.Parent.Parent).AttributeLists,
				new SyntaxTokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)),
				((VariableDeclarationSyntax)variableSyntax.Parent).Type,
				null,
				variableSyntax.Identifier,
				null,
				SyntaxFactory.ArrowExpressionClause(variableSyntax.Initializer.Value),
				null,
				SyntaxFactory.Token(SyntaxKind.SemicolonToken)
			);

	}
}
