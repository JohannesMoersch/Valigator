using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Valigator.Core;

namespace Valigator.SourceGeneration
{
	[Generator]
	public sealed class ModelDefinitionSourceGenerator : ISourceGenerator
	{
		public void Initialize(GeneratorInitializationContext context)
			=> context.RegisterForSyntaxNotifications(() => new ModelDefinitionSyntaxReceiver());

		public void Execute(GeneratorExecutionContext context)
		{
			if (context.SyntaxReceiver is ModelDefinitionSyntaxReceiver receiver)
			{
				var generatedModelAttributeType = context
					.Compilation
					.GetTypeByMetadataName(typeof(GenerateModelAttribute).FullName);

				foreach (var candidate in receiver.Candidates)
				{
					var typeSymbol = context
						.Compilation
						.GetSemanticModel(candidate.SyntaxTree)
						.GetDeclaredSymbol(candidate);

					if (typeSymbol is ITypeSymbol type)
					{
						var containsAttribute = type
							.GetAttributes()
							.Any(att => att.AttributeClass?.Equals(generatedModelAttributeType, SymbolEqualityComparer.Default) ?? false);

						if (containsAttribute)
						{
							var isPartial = candidate
								.Modifiers
								.Any(o => o.Text == "partial");

							if (isPartial)
							{
								var modelNamespace = type.GetFullContainingNamespace();
								var modelName = type.Name.Replace("Definition", String.Empty);

								System.IO.File.WriteAllText($"C:\\Users\\johan\\Desktop\\{type.Name}.cs", GenerateDefinition(type, modelNamespace, modelName));
								System.IO.File.WriteAllText($"C:\\Users\\johan\\Desktop\\{modelName}.cs", GenerateModel(type, modelNamespace, modelName));

								context.AddSource($"a{type.Name}.cs", GenerateDefinition(type, modelNamespace, modelName));
								context.AddSource($"a{modelName}.cs", GenerateModel(type, modelNamespace, modelName));
							}
						}
					}
				}
			}
		}

		private string GenerateDefinition(ITypeSymbol definitionType, string modelNamespace, string modelName)
		{
			var definitionNamespace = definitionType.GetFullContainingNamespace();
			var modelNamespaceToUse = definitionNamespace == modelNamespace
				? String.Empty
				: $"{modelNamespace}.";

			StringBuilder builder = new StringBuilder();

			builder.AppendLine($"using {typeof(ModelDefinition<>).Namespace};");
			builder.AppendLine($"");
			builder.AppendLine($"namespace {definitionNamespace}");
			builder.AppendLine($"{{");
			builder.AppendLine($"	public partial class {definitionType.Name} : {typeof(ModelDefinition<>).Name.Split('`')[0]}<{modelNamespaceToUse}{modelName}.ModelView>");
			builder.AppendLine($"	{{");
			builder.AppendLine($"	}}");
			builder.AppendLine($"}}");

			return builder.ToString();
		}

		private string GenerateModel(ITypeSymbol definitionType, string modelNamespace, string modelName)
		{
			StringBuilder builder = new StringBuilder();

			builder.AppendLine($"namespace {modelNamespace}");
			builder.AppendLine($"{{");
			builder.AppendLine($"	public partial class {modelName}");
			builder.AppendLine($"	{{");
			builder.AppendLine($"		public sealed class ModelView");
			builder.AppendLine($"		{{");
			builder.AppendLine($"		}}");
			builder.AppendLine($"	}}");
			builder.AppendLine($"}}");

			return builder.ToString();
		}
	}
}
