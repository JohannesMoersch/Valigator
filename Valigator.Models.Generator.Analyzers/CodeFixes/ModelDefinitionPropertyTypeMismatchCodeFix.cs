using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Simplification;
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
	[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(ModelDefinitionPropertyHasSetterCodeFix)), Shared]
	public class ModelDefinitionPropertyTypeMismatchCodeFix : CodeFixProvider
	{
		public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(AnalyzerDiagnosticDescriptors.ModelDefinitionPropertyTypeMismatch.Id);

		public override FixAllProvider GetFixAllProvider()
			=> WellKnownFixAllProviders.BatchFixer;

		public override async Task RegisterCodeFixesAsync(CodeFixContext context)
		{
			var root = await context.Document.GetSyntaxRootAsync(context.CancellationToken);

			var diagnostic = context.Diagnostics.First();
			var diagnosticSpan = diagnostic.Location.SourceSpan;

			var expressionSyntax = root
				?.FindToken(diagnosticSpan.Start)
				.Parent
				?.AncestorsAndSelf()
				.OfType<ExpressionSyntax>()
				.First();

			if (expressionSyntax == null)
				return;

			context
				.RegisterCodeFix
				(
					CodeAction
						.Create
						(
							title: "Make property type match",
							createChangedSolution: c => MakePropertyTypeMatch(context.Document, expressionSyntax, c),
							equivalenceKey: "Make property type match"
						),
					diagnostic
				);
		}

		private async Task<Solution> MakePropertyTypeMatch(Document document, ExpressionSyntax expressionSyntax, CancellationToken cancellationToken)
		{
			var semanticModel = await document.GetSemanticModelAsync(cancellationToken);

			var modelPropertyDataType = semanticModel.Compilation.GetTypeByMetadataName(ExternalConstants.IModelPropertyData_TypeName);

			var setterSyntax = expressionSyntax
				.Ancestors()
				.Where(s => s is ArrowExpressionClauseSyntax || s is EqualsValueClauseSyntax || s is AssignmentExpressionSyntax)
				.FirstOrDefault();

			if (setterSyntax.TryGetPropertyAndExpressionForPropertyAssignment(semanticModel, cancellationToken, out var propertySymbol, out var newExpressionSyntax))
			{
				var propertySyntax = propertySymbol.GetDeclarationSyntax(cancellationToken);

				var propertyTypeFromInitializer = newExpressionSyntax.GetModelPropertyArgumentType(semanticModel, modelPropertyDataType);

				var newPropertyDeclaration = propertySyntax.WithType(SyntaxFactory.ParseTypeName($"Property<{propertyTypeFromInitializer.ToCSharpTypeCode()}>").WithTriviaFrom(propertySyntax.Type));

				var syntaxRoot = await document.GetSyntaxRootAsync(cancellationToken);

				var newSyntaxRoot = syntaxRoot.ReplaceNode(propertySyntax, newPropertyDeclaration.WithAdditionalAnnotations(Simplifier.Annotation));

				return document.Project.Solution.WithDocumentSyntaxRoot(document.Id, newSyntaxRoot);
			}

			return document.Project.Solution;
		}
	}
}
