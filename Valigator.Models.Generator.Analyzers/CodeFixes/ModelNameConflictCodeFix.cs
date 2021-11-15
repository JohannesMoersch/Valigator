using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.FindSymbols;
using Microsoft.CodeAnalysis.Options;
using Microsoft.CodeAnalysis.Rename;
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
	[ExportCodeFixProvider(LanguageNames.CSharp, Name = nameof(ModelNameConflictCodeFix)), Shared]
	public class ModelNameConflictCodeFix : CodeFixProvider
	{
		public override ImmutableArray<string> FixableDiagnosticIds => ImmutableArray.Create(AnalyzerDiagnosticDescriptors.ModelNameConflict.Id);

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
							title: "Rename members conflicting with generated model",
							createChangedSolution: c => RenameConflictingType(context.Document, classSyntax, c),
							equivalenceKey: "Rename members conflicting with generated model"
						),
					diagnostic
				);
		}

		private async Task<Solution> RenameConflictingType(Document document, ClassDeclarationSyntax classSyntax, CancellationToken cancellationToken)
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

				var symbols = semanticModel
					.LookupAllNamespaceAndTypeSymbols<ISymbol>(modelNamespace, modelParentClasses.Select(p => (p, 0)).Concat(new[] { (modelName, typeSymbol.TypeParameters.Length) }).ToArray())
					.Last()
					.ToArray();

				var project = document.Project;

				foreach (var symbol in symbols)
					project = await RenameSymbol(project, symbol, modelName, cancellationToken);

				return project.Solution;
			}

			return document.Project.Solution;
		}

#pragma warning disable RS1024 // Compare symbols correctly
        private static async Task<Project> RenameSymbol(Project project, ISymbol typeSymbol, string newName, CancellationToken cancellationToken)
        {
			var compilation = await project.GetCompilationAsync(cancellationToken);

			var candidates = SymbolFinder.FindSimilarSymbols(typeSymbol, compilation, cancellationToken);

			if (candidates.TryGetFirst(out var newSymbol))
			{
                var solution = await Renamer.RenameSymbolAsync(project.Solution, newSymbol, CreateUniqueName(newName, typeSymbol.GetHashCode()), project.Solution.Workspace.Options, cancellationToken);

                return solution.Projects.First(p => p.Id == project.Id);
			}

			return project;
		}
#pragma warning restore RS1024 // Compare symbols correctly

		private static void GetAttributes(Compilation compilation, out INamedTypeSymbol generateModelAttributeType, out INamedTypeSymbol generateModelDefaultsAttributeType)
		{
			generateModelAttributeType = compilation.GetTypeByMetadataName(ExternalConstants.GenerateModelAttribute_TypeName);
			generateModelDefaultsAttributeType = compilation.GetTypeByMetadataName(ExternalConstants.GenerateModelDefaultsAttribute_TypeName);
		}

		private static string CreateUniqueName(string name, int hash)
		{
			var random = new Random(hash);

			return $"{name}_{Enumerable.Range(0, 5).Select(s => random.Next(0, 62)).Select(ToCharacter).JoinList("")}";
		}

		private static string ToCharacter(int number)
			=> number switch
			{
				int i when i < 26 => ((char)('a' + i)).ToString(),
				int i when i < 52 => ((char)('A' + i - 26)).ToString(),
				int i => ((char)('0' + i - 52)).ToString()
			};
	}
}
