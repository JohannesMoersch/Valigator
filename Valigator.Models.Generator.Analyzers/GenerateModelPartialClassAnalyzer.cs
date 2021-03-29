using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	[DiagnosticAnalyzer(LanguageNames.CSharp)]
	public class GenerateModelPartialClassAnalyzer : DiagnosticAnalyzer
	{
		private static readonly DiagnosticDescriptor _partialClassDiagnosticDescriptor = new DiagnosticDescriptor
		(
			id: "VL0001",
			title: "Model Definition Not Partial",
			messageFormat: "Model definition must be declared as partial.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics => ImmutableArray.Create(_partialClassDiagnosticDescriptor);

		public override void Initialize(AnalysisContext context)
		{
			context.EnableConcurrentExecution();

			context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

			context
				.RegisterSyntaxNodeAction
				(
					context =>
					{
						var generatedModelAttributeType = context
							.Compilation
							.GetTypeByMetadataName(ExternalConstants.GenerateModelAttribute_TypeName);

						var classDeclaration = (ClassDeclarationSyntax)context.Node;

						var typeSymbol = context
							.SemanticModel
							.GetDeclaredSymbol(classDeclaration);

						if (typeSymbol.HasAttribute(generatedModelAttributeType) && !classDeclaration.IsPartial())
							context
								.ReportDiagnostic
								(
									Diagnostic.Create
									(
										_partialClassDiagnosticDescriptor,
										Location.Create(classDeclaration.SyntaxTree, classDeclaration.Identifier.Span)
									)
								);
					},
					SyntaxKind.ClassDeclaration
				);
		}
	}
}
