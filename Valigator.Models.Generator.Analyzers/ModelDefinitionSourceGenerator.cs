using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Valigator.Models.Generator.Analyzers
{
	// TODO - Deal with generics. At least allow generics on model definition?

	[Generator]
	public sealed class ModelDefinitionSourceGenerator : ISourceGenerator
	{
		public void Initialize(GeneratorInitializationContext context)
			=> context.RegisterForSyntaxNotifications(() => new GenerateModelSyntaxReceiver());

		public void Execute(GeneratorExecutionContext context)
		{
			if (context.SyntaxReceiver is GenerateModelSyntaxReceiver receiver)
			{
				GetAttributes(context, out var generateModelAttributeType, out var generateModelDefaultsAttributeType, out var propertyAttributeType);

				var codeProvider = CodeDomProvider.CreateProvider("csharp");
				
				foreach (var candidate in receiver.Candidates)
				{
					var semanticModel = context
						.Compilation
						.GetSemanticModel(candidate.SyntaxTree);

					var typeSymbol = semanticModel.GetDeclaredSymbol(candidate);

					if (typeSymbol != null && typeSymbol.TryGetAttribute(generateModelAttributeType, out var generateModelAttribute) && candidate.IsPartial())
					{
						if
						(
							TryGetModelIdentifiers(typeSymbol, generateModelAttribute, generateModelDefaultsAttributeType, out var modelNamespaceParts, out var modelParentClasses, out var modelName) &&
							modelNamespaceParts.All(codeProvider.IsValidIdentifier) &&
							modelParentClasses.All(codeProvider.IsValidIdentifier) &&
							codeProvider.IsValidIdentifier(modelName)
						)
						{
							context.AddSource($"{typeSymbol.Name}.g.cs", CodeGenerator.GenerateDefinition(typeSymbol, modelNamespaceParts, modelParentClasses, modelName, "ModelView"));
							context.AddSource($"{modelName}.g.cs", CodeGenerator.GenerateModel(semanticModel, typeSymbol, generateModelAttribute, generateModelDefaultsAttributeType, propertyAttributeType, modelNamespaceParts, modelParentClasses, modelName, context.CancellationToken));
						}
						else
							context.AddSource($"{typeSymbol.Name}.g.cs", CodeGenerator.GenerateDefinition(typeSymbol, Array.Empty<string>(), Array.Empty<string>(), "object", String.Empty));
					}
				}
			}
		}

		private static void GetAttributes(GeneratorExecutionContext context, out INamedTypeSymbol generateModelAttributeType, out INamedTypeSymbol generateModelDefaultsAttributeType, out INamedTypeSymbol propertyAttributeType)
		{
			generateModelAttributeType = context.Compilation.GetTypeByMetadataName(ExternalConstants.GenerateModelAttribute_TypeName);
			generateModelDefaultsAttributeType = context.Compilation.GetTypeByMetadataName(ExternalConstants.GenerateModelDefaultsAttribute_TypeName);
			propertyAttributeType = context.Compilation.GetTypeByMetadataName(ExternalConstants.PropertyAttribute_TypeName);
		}

		private static bool TryGetModelIdentifiers(INamedTypeSymbol typeSymbol, AttributeData generateModelAttribute, INamedTypeSymbol generateModelDefaultsAttributeType, out string[] modelNamespaceParts, out string[] modelParentClasses, out string modelName)
		{
			var fullTypeName = typeSymbol.GetFullNameWithNamespace("+");

			var modelNamespaceSuccess = generateModelAttribute
				.TryGetGeneratedModelNamespace
				(
					fullTypeName,
					generateModelDefaultsAttributeType,
					out modelNamespaceParts,
					out _,
					out _
				);

			var modelParentClassesSuccess = generateModelAttribute
				.TryGetGeneratedModelParentClasses
				(
					fullTypeName,
					generateModelDefaultsAttributeType,
					out modelParentClasses,
					out _,
					out _
				);

			var modelNameSuccess = generateModelAttribute
				.TryGetGeneratedModelName
				(
					fullTypeName,
					generateModelDefaultsAttributeType,
					out modelName,
					out _,
					out _
				);

			return modelNamespaceSuccess && modelParentClassesSuccess && modelNameSuccess;
		}
	}
}
