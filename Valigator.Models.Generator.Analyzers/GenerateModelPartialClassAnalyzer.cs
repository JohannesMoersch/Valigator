using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace Valigator.SourceGeneration
{
	[DiagnosticAnalyzer(LanguageNames.CSharp)]
	public class GenerateModelPartialClassAnalyzer : DiagnosticAnalyzer
	{
		private static readonly DiagnosticDescriptor _partialClassDiagnosticDescriptor = new DiagnosticDescriptor
		(
			id: "VL0001",
			title: "Model Definition Not Partial",
			messageFormat: "Model definition \"{0}\" must be declared as partial.",
			category: "Generator",
			DiagnosticSeverity.Error,
			isEnabledByDefault: true
		);

		public override ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics
			=> new ImmutableArray<DiagnosticDescriptor>().Add(_partialClassDiagnosticDescriptor);

		public override void Initialize(AnalysisContext context)
		{
			context.EnableConcurrentExecution();

			context.ConfigureGeneratedCodeAnalysis(GeneratedCodeAnalysisFlags.None);

			System.IO.File.AppendAllLines(@"C:\Users\johan\Desktop\Test.cs", new[] { DateTime.Now.ToString() });

			context
				.RegisterSyntaxNodeAction
				(
					context =>
					{
						var generatedModelAttributeType = context
							.Compilation
							.GetTypeByMetadataName("typeof(GenerateModelAttribute).FullName");

						var classDeclaration = (ClassDeclarationSyntax)context.Node;

						if (context.SemanticModel.GetDeclaredSymbol(classDeclaration) is ITypeSymbol typeSymbol)
						{
							var containsAttribute = typeSymbol
								.GetAttributes()
								.Any(att => att.AttributeClass?.Equals(generatedModelAttributeType, SymbolEqualityComparer.Default) ?? false);

							if (containsAttribute)
							{
								var isPartial = classDeclaration
									.Modifiers
									.Any(o => o.Text == "partial");

								if (!isPartial)
								{
									context
										.ReportDiagnostic
										(
											Diagnostic.Create
											(
												new DiagnosticDescriptor
												(
													id: "VL0001",
													title: "Model Definition Not Partial",
													messageFormat: "Model definition \"{0}\" must be declared as partial.",
													category: "Generator",
													DiagnosticSeverity.Error,
													isEnabledByDefault: true
												),
												Location.Create(classDeclaration.SyntaxTree, classDeclaration.Span),
												typeSymbol.Name
											)
										);
								}
							}
						}
					},
					SyntaxKind.ClassDeclaration
				);
		}
	}
}
