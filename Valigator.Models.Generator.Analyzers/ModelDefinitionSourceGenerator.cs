using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
				var generateModelAttributeType = context
					.Compilation
					.GetTypeByMetadataName(ExternalConstants.GenerateModelAttribute_TypeName);

				var generateModelDefaultsAttributeType = context
					.Compilation
					.GetTypeByMetadataName(ExternalConstants.GenerateModelDefaultsAttribute_TypeName);

				var propertyAttributeType = context
					.Compilation
					.GetTypeByMetadataName(ExternalConstants.PropertyAttribute_TypeName);

				var codeProvider = CSharpCodeProvider.CreateProvider("csharp");

				foreach (var candidate in receiver.Candidates)
				{
					var typeSymbol = context
						.Compilation
						.GetSemanticModel(candidate.SyntaxTree)
						.GetDeclaredSymbol(candidate);

					if (typeSymbol != null && typeSymbol.TryGetAttribute(generateModelAttributeType, out var generatedModelAttribute) && candidate.IsPartial())
					{
						var sourceCaptureRegex = generatedModelAttribute.GetGenerateModelPropertyValue<string>(ExternalConstants.GenerateModelAttribute_SourceCaptureRegex_PropertyName, generateModelDefaultsAttributeType);
						if (!sourceCaptureRegex.StartsWith("^"))
							sourceCaptureRegex = "^" + sourceCaptureRegex;
						if (!sourceCaptureRegex.EndsWith("$"))
							sourceCaptureRegex += "$";

						var modelNamespacePattern = generatedModelAttribute.GetGenerateModelPropertyValue<string>(ExternalConstants.GenerateModelAttribute_ModelNamespace_PropertyName, generateModelDefaultsAttributeType);
						var modelParentClassesPattern = generatedModelAttribute.GetGenerateModelPropertyValue<string>(ExternalConstants.GenerateModelAttribute_ModelParentClasses_PropertyName, generateModelDefaultsAttributeType);
						var modelNamePattern = generatedModelAttribute.GetGenerateModelPropertyValue<string>(ExternalConstants.GenerateModelAttribute_ModelName_PropertyName, generateModelDefaultsAttributeType);

						var match = Regex.Match(typeSymbol.GetFullNameWithNamespace(), sourceCaptureRegex);

						var modelNamespace = match.ApplyToPattern(modelNamespacePattern);
						var modelParentClasss = match.ApplyToPattern(modelParentClassesPattern);
						var modelName = match.ApplyToPattern(modelNamePattern);

						if (codeProvider.IsValidIdentifier(modelName))
						{
							context.AddSource($"{typeSymbol.Name}.g.cs", GenerateDefinition(typeSymbol, modelNamespace, modelName));
							context.AddSource($"{modelName}.g.cs", GenerateModel(typeSymbol, generatedModelAttribute, generateModelDefaultsAttributeType, propertyAttributeType, modelNamespace, modelName));
						}
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

			var builder = new StringBuilder();

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

		private string GenerateModel(ITypeSymbol definitionType, AttributeData generatedModelAttribute, INamedTypeSymbol generateModelDefaultsAttributeType, INamedTypeSymbol propertyAttributeType, string modelNamespace, string modelName)
		{
			var properties = definitionType
				.GetMembers()
				.OfType<IPropertySymbol>()
				.Where(property => !property.IsStatic)
				.Where(property => property.GetDeclarationSyntax().IsPublic())
				.Where(property => (property.GetDeclarationSyntax().TryGetGetAccessor(out var getAccessor) && !getAccessor.IsPrivate()) || property.GetDeclarationSyntax().ExpressionBody != null)
				.Where(property => property.GetDeclarationSyntax().Type.IsModelDefinitionProperty());

			var defaultPropertyAccessors = generatedModelAttribute.GetGenerateModelPropertyValue<ExternalConstants.PropertyAccessors>(ExternalConstants.GenerateModelAttribute_DefaultPropertyAccessors_PropertyName, generateModelDefaultsAttributeType);

			var hasNamespace = !String.IsNullOrEmpty(modelNamespace);
			var indentation = hasNamespace ? "\t" : "";

			var definitionName = definitionType.GetTypeNameRelativeTo(hasNamespace ? $"{modelNamespace}.{modelName}" : modelName);

			var builder = new StringBuilder();

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

			foreach (var property in properties)
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

			foreach (var property in properties)
			{
				var propertyAccessors = defaultPropertyAccessors;

				if (property.TryGetAttribute(propertyAttributeType, out var propertyAttribute) && propertyAttribute.TryGetProperty<ExternalConstants.PropertyAccessors>(ExternalConstants.PropertyAttribute_Accessors_PropertyName, out var propertyAccessor))
					propertyAccessors = propertyAccessor;

				var lowercaseName = $"_{Char.ToLower(property.Name[0])}{property.Name.Substring(1)}";

				var propertyTypeName = (property.Type as INamedTypeSymbol).TypeArguments[0].GetTypeNameRelativeTo("System");

				builder.AppendLine($"{indentation}	");
				builder.AppendLine($"{indentation}	private static ModelDefinition<ModelView>.Property<int> {lowercaseName}_Property;");
				builder.AppendLine($"{indentation}	private ModelPropertyState {lowercaseName}_State;");
				builder.AppendLine($"{indentation}	private {propertyTypeName} {lowercaseName};");
				builder.AppendLine($"{indentation}	public {propertyTypeName} {property.Name}");
				builder.AppendLine($"{indentation}	{{");
				if (propertyAccessors.HasFlag(ExternalConstants.PropertyAccessors.Get))
					builder.AppendLine($"{indentation}		get => Get(nameof({property.Name}), {lowercaseName}, {lowercaseName}_State);");
				if (propertyAccessors.HasFlag(ExternalConstants.PropertyAccessors.GetAndSet))
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

			foreach (var property in properties)
			{
				var lowercaseName = $"_{Char.ToLower(property.Name[0])}{property.Name.Substring(1)}";

				builder.AppendLine($"{indentation}		if ({lowercaseName}_State == ModelPropertyState.Unset)");
				builder.AppendLine($"{indentation}			{lowercaseName}_Property.CoerceUnset(nameof({property.Name}), ref {lowercaseName}, ref {lowercaseName}_State, ref _errorDictionary);");
				builder.AppendLine($"{indentation}		");
			}

			builder.AppendLine($"{indentation}		_modelState = ModelState.Unvalidated;");
			builder.AppendLine($"{indentation}	}}");
			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	private void Validate()");
			builder.AppendLine($"{indentation}	{{");
			builder.AppendLine($"{indentation}		var view = new ModelView(this);");
			builder.AppendLine($"{indentation}		");

			foreach (var property in properties)
			{
				var lowercaseName = $"_{Char.ToLower(property.Name[0])}{property.Name.Substring(1)}";

				builder.AppendLine($"{indentation}		if ({lowercaseName}_State != ModelPropertyState.CoerceFailed)");
				builder.AppendLine($"{indentation}			{lowercaseName}_Property.Validate(view, nameof({property.Name}), {lowercaseName}, ref {lowercaseName}_State, ref _errorDictionary);");
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

			foreach (var property in properties)
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
