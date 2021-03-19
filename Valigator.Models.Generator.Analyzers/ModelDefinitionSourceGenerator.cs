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

namespace Valigator
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
					.GetTypeByMetadataName(TypeNames.GenerateModelAttribute);

				foreach (var candidate in receiver.Candidates)
				{
					var typeSymbol = context
						.Compilation
						.GetSemanticModel(candidate.SyntaxTree)
						.GetDeclaredSymbol(candidate);

					if (typeSymbol != null && typeSymbol.HasAttribute(generatedModelAttributeType) && candidate.IsPartial())
					{
						var modelNamespace = typeSymbol.GetFullNamespace();
						var modelName = typeSymbol.Name.Replace("Definition", String.Empty);

						System.IO.File.WriteAllText($"C:\\Users\\johan\\Desktop\\{typeSymbol.Name}.cs", GenerateDefinition(typeSymbol, modelNamespace, modelName));
						System.IO.File.WriteAllText($"C:\\Users\\johan\\Desktop\\{modelName}.cs", GenerateModel(typeSymbol, modelNamespace, modelName));

						context.AddSource($"a{typeSymbol.Name}.cs", GenerateDefinition(typeSymbol, modelNamespace, modelName));
						context.AddSource($"a{modelName}.cs", GenerateModel(typeSymbol, modelNamespace, modelName));
					}
				}
			}
		}

		private string GenerateDefinition(ITypeSymbol definitionType, string modelNamespace, string modelName)
		{
			var definitionNamespace = definitionType.GetFullNamespace();
			var modelNamespaceToUse = definitionNamespace == modelNamespace
				? String.Empty
				: $"{modelNamespace}.";

			StringBuilder builder = new StringBuilder();

			builder.AppendLine($"using Valigator;");
			builder.AppendLine($"");
			builder.AppendLine($"namespace {definitionNamespace}");
			builder.AppendLine($"{{");
			builder.AppendLine($"	public partial class {definitionType.Name} : ModelDefinition<{modelNamespaceToUse}{modelName}.ModelView>");
			builder.AppendLine($"	{{");
			builder.AppendLine($"	}}");
			builder.AppendLine($"}}");

			return builder.ToString();
		}

		private string GenerateModel(ITypeSymbol definitionType, string modelNamespace, string modelName)
		{
			bool hasNamespace = !String.IsNullOrEmpty(modelNamespace);
			string indentation = hasNamespace ? "\t" : "";

			string definitionName = definitionType.GetTypeNameRelativeTo(hasNamespace ? $"{modelNamespace}.{modelName}" : modelName);

			StringBuilder builder = new StringBuilder();

			builder.AppendLine($"using System;");
			builder.AppendLine($"using Functional;");
			builder.AppendLine($"using Valigator;");
			builder.AppendLine($"using Valigator.Models;");
			builder.AppendLine($"");

			if (hasNamespace)
			{
				builder.AppendLine($"namespace {modelNamespace}");
				builder.AppendLine($"{{");
			}

			builder.AppendLine($"{indentation}public partial class {modelName}");
			builder.AppendLine($"{indentation}{{");
			builder.AppendLine($"{indentation}	static {modelName}()");
			builder.AppendLine($"{indentation}	{{");
			builder.AppendLine($"{indentation}		ModelDefinition = new {definitionName}();");
			
			foreach (var property in definitionType.GetMembers().OfType<IPropertySymbol>().Where(property => !property.IsStatic))
			{
				var lowercaseName = $"_{Char.ToLower(property.Name[0])}{property.Name.Substring(1)}";

				builder.AppendLine($"{indentation}		{lowercaseName}_Property = ModelDefinition.{property.Name};");
			}
			
			builder.AppendLine($"{indentation}	}}");
			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	public static {definitionType.GetTypeNameRelativeTo(hasNamespace ? $"{modelNamespace}.{modelName}" : modelName)} ModelDefinition {{ get; }}");
			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	private ModelErrorDictionary _errorDictionary = new ModelErrorDictionary();");
			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	private ModelState _modelState = ModelState.Unset;");

			foreach (var property in definitionType.GetMembers().OfType<IPropertySymbol>().Where(property => !property.IsStatic))
			{
				var lowercaseName = $"_{Char.ToLower(property.Name[0])}{property.Name.Substring(1)}";

				var propertyTypeName = (property.Type as INamedTypeSymbol).TypeArguments[0].GetTypeNameRelativeTo("System");

				builder.AppendLine($"{indentation}	");
				builder.AppendLine($"{indentation}	private static ModelDefinition<ModelView>.Property<int> {lowercaseName}_Property;");
				builder.AppendLine($"{indentation}	private ModelPropertyState {lowercaseName}_State;");
				builder.AppendLine($"{indentation}	private {propertyTypeName} {lowercaseName};");
				builder.AppendLine($"{indentation}	public {propertyTypeName} {property.Name}");
				builder.AppendLine($"{indentation}	{{");
				builder.AppendLine($"{indentation}		get => Get(nameof({property.Name}), {lowercaseName}, {lowercaseName}_State);");
				builder.AppendLine($"{indentation}		set => Set(value, ref {lowercaseName}, ref {lowercaseName}_State);");
				builder.AppendLine($"{indentation}	}}");
			}

			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	private TValue Get<TValue>(string propertyName, TValue value, ModelPropertyState state)");
			builder.AppendLine($"{indentation}	{{");
			builder.AppendLine($"{indentation}		if (_modelState == ModelState.Unset)");
			builder.AppendLine($"{indentation}		{{");
			builder.AppendLine($"{indentation}			Coerce();");
			builder.AppendLine($"{indentation}			Validate();");
			builder.AppendLine($"{indentation}		}}");
			builder.AppendLine($"{indentation}		else if (_modelState == ModelState.Unvalidated)");
			builder.AppendLine($"{indentation}			Validate();");
			builder.AppendLine($"{indentation}		");
			builder.AppendLine($"{indentation}		return state == ModelPropertyState.Valid");
			builder.AppendLine($"{indentation}			? value");
			builder.AppendLine($"{indentation}			: throw new DataInvalidException(_errorDictionary[propertyName]);");
			builder.AppendLine($"{indentation}	}}");
			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	private void Set<TValue>(TValue newValue, ref TValue value, ref ModelPropertyState state)");
			builder.AppendLine($"{indentation}	{{");
			builder.AppendLine($"{indentation}		value = newValue;");
			builder.AppendLine($"{indentation}		state = ModelPropertyState.Unvalidated;");
			builder.AppendLine($"{indentation}		");
			builder.AppendLine($"{indentation}		if (_modelState == ModelState.Validated)");
			builder.AppendLine($"{indentation}			_modelState = ModelState.Unvalidated;");
			builder.AppendLine($"{indentation}		");
			builder.AppendLine($"{indentation}		_errorDictionary.Clear();");
			builder.AppendLine($"{indentation}	}}");
			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	private void Coerce()");
			builder.AppendLine($"{indentation}	{{");

			foreach (var property in definitionType.GetMembers().OfType<IPropertySymbol>().Where(property => !property.IsStatic))
			{
				var lowercaseName = $"_{Char.ToLower(property.Name[0])}{property.Name.Substring(1)}";

				builder.AppendLine($"{indentation}		if (_a_State == ModelPropertyState.Unset)");
				builder.AppendLine($"{indentation}			_a_Property.CoerceUnset(nameof({property.Name}), ref {lowercaseName}, ref {lowercaseName}_State, ref _errorDictionary);");
				builder.AppendLine($"{indentation}		");
			}

			builder.AppendLine($"{indentation}		_modelState = ModelState.Unvalidated;");
			builder.AppendLine($"{indentation}	}}");
			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	private void Validate()");
			builder.AppendLine($"{indentation}	{{");
			builder.AppendLine($"{indentation}		var view = new ModelView(this);");
			builder.AppendLine($"{indentation}		");

			foreach (var property in definitionType.GetMembers().OfType<IPropertySymbol>().Where(property => !property.IsStatic))
			{
				var lowercaseName = $"_{Char.ToLower(property.Name[0])}{property.Name.Substring(1)}";

				builder.AppendLine($"{indentation}		if (_a_State != ModelPropertyState.CoerceFailed)");
				builder.AppendLine($"{indentation}			_a_Property.Validate(view, nameof({property.Name}), {lowercaseName}, ref {lowercaseName}_State, ref _errorDictionary);");
				builder.AppendLine($"{indentation}		");
			}

			builder.AppendLine($"{indentation}		_modelState = ModelState.Validated;");
			builder.AppendLine($"{indentation}	}}");
			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	public struct ModelView");
			builder.AppendLine($"{indentation}	{{");
			builder.AppendLine($"{indentation}		private {modelName} _model;");
			builder.AppendLine($"{indentation}		");
			builder.AppendLine($"{indentation}		public ModelView({modelName} model)");
			builder.AppendLine($"{indentation}			=> _model = model;");

			foreach (var property in definitionType.GetMembers().OfType<IPropertySymbol>().Where(property => !property.IsStatic))
			{
				var lowercaseName = $"_{Char.ToLower(property.Name[0])}{property.Name.Substring(1)}";

				var propertyTypeName = (property.Type as INamedTypeSymbol).TypeArguments[0].GetTypeNameRelativeTo("System");

				builder.AppendLine($"{indentation}		");
				builder.AppendLine($"{indentation}		public Result<{propertyTypeName}, ModelPropertyNotSet> {property.Name} => Get(_model.{lowercaseName}, _model.{lowercaseName}_State);");
			}

			builder.AppendLine($"{indentation}		");
			builder.AppendLine($"{indentation}		private Result<TValue, ModelPropertyNotSet> Get<TValue>(TValue value, ModelPropertyState state)");
			builder.AppendLine($"{indentation}		{{");
			builder.AppendLine($"{indentation}			if (_model._modelState == ModelState.Unset)");
			builder.AppendLine($"{indentation}				_model.Coerce();");
			builder.AppendLine($"{indentation}				");
			builder.AppendLine($"{indentation}				return Result");
			builder.AppendLine($"{indentation}					.Create");
			builder.AppendLine($"{indentation}					(");
			builder.AppendLine($"{indentation}						state != ModelPropertyState.CoerceFailed,");
			builder.AppendLine($"{indentation}						value,");
			builder.AppendLine($"{indentation}						ModelPropertyNotSet.Value");
			builder.AppendLine($"{indentation}					);");
			builder.AppendLine($"{indentation}		}}");
			builder.AppendLine($"{indentation}	}}");
			builder.AppendLine($"{indentation}}}");
			
			if (hasNamespace)
				builder.AppendLine($"}}");

			return builder.ToString();
		}
	}
}
