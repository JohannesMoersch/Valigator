﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Valigator.Models.Generator.Analyzers.Extensions;

namespace Valigator.Models.Generator.Analyzers
{
	public static class CodeGenerator
	{
		public static string GenerateDefinitionWithoutModel(INamedTypeSymbol definitionType)
			=> GenerateDefinition(definitionType, null, null, null);

		public static string GenerateDefinition(INamedTypeSymbol definitionType, string[] modelNamespaceParts, string[] modelParentClasses, string modelName)
		{
			bool useDefaultModel = modelName == null;

			var definitionNamespace = definitionType.GetFullNamespace();
			var parentClasses = definitionType.ContainingType?.GetContainingTypeHierarchy().ToArray() ?? Array.Empty<INamedTypeSymbol>();

			string modelNameAndNamespace;
			if (!useDefaultModel)
			{
				var modelParentClassFullName = String.Join(".", modelNamespaceParts.Concat(modelParentClasses));

				modelNameAndNamespace = $"global::{(!String.IsNullOrEmpty(modelParentClassFullName) ? $"{modelParentClassFullName}." : String.Empty)}{modelName}{definitionType.TypeParameters.ToCSharpGenericParameterCode()}.ModelView";
			}
			else
				modelNameAndNamespace = "object";

			var hasNamespace = !String.IsNullOrEmpty(definitionNamespace);
			var indentation = String.Empty;

			var builder = new StringBuilder();

			builder.AppendLine("#nullable enable");
			builder.AppendLine();

			if (hasNamespace)
			{
				builder.AppendLine($"namespace {definitionNamespace}");
				builder.AppendLine($"{{");

				indentation += "\t";
			}

			foreach (var parentClass in parentClasses)
			{
				builder.AppendLine($"{indentation}public partial {parentClass.TypeKind.ToCSharpCodeString()} {parentClass.Name}{parentClass.TypeParameters.ToCSharpGenericParameterCode()}");
				builder.AppendLine($"{indentation}{{");

				indentation += "\t";
			}

			builder.AppendLine($"{indentation}public sealed partial class {definitionType.Name}{definitionType.TypeParameters.ToCSharpGenericParameterCode()} : global::Valigator.Models.ModelDefinition<{modelNameAndNamespace}>");
			builder.AppendLine($"{indentation}{{");

			if (!definitionType.InstanceConstructors.Any(m => !m.Parameters.Any()))
				builder.AppendLine($"{indentation}	public {definitionType.Name}() {{ }}");

			builder.AppendLine($"{indentation}}}");

			foreach (var parentClass in parentClasses)
			{
				indentation = indentation.Substring(1);

				builder.AppendLine($"{indentation}}}");
			}

			if (hasNamespace)
				builder.AppendLine($"}}");

			builder.AppendLine();
			builder.AppendLine("#nullable disable");

			return builder.ToString();
		}

		public static string GenerateModel(SemanticModel semanticModel, INamedTypeSymbol definitionType, AttributeData generatedModelAttribute, INamedTypeSymbol generateModelDefaultsAttributeType, INamedTypeSymbol propertyAttributeType, string[] modelNamespaceParts, string[] parentClasses, string modelName, CancellationToken cancellationToken)
		{
			var modelNamespace = String.Join(".", modelNamespaceParts);
			var modelFullName = String.Join(".", modelNamespaceParts.Concat(parentClasses).Concat(new[] { modelName }));

			var properties = definitionType
				.GetMembers()
				.OfType<IPropertySymbol>()
				.Where(property => property.IsEligibleModelDefinitionProperty(cancellationToken))
				.ToArray();

			var defaultPropertyAccessors = generatedModelAttribute.GetGenerateModelPropertyValue(ExternalConstants.GenerateModelAttribute_DefaultPropertyAccessors_PropertyName, generateModelDefaultsAttributeType, ExternalConstants.PropertyAccessors.Unset);

			var modelTypeMode = generatedModelAttribute.GetGenerateModelPropertyValue(ExternalConstants.GenerateModelAttribute_Type_PropertyName, generateModelDefaultsAttributeType, ExternalConstants.ModelType.Unset);

			var hasNamespace = !String.IsNullOrEmpty(modelNamespace);
			var indentation = String.Empty;

			var definitionName = $"{definitionType.GetFullNameWithNamespace(".", true)}{definitionType.TypeParameters.ToCSharpGenericParameterCode()}";

			var builder = new StringBuilder();

			builder.AppendLine("#nullable enable");
			builder.AppendLine();

			if (hasNamespace)
			{
				builder.AppendLine($"namespace {modelNamespace}");
				builder.AppendLine($"{{");

				indentation += "\t";
			}

			var typeSymbols = semanticModel.LookupNamespaceAndTypeSymbols(modelNamespaceParts, parentClasses.Select(p => (p, 0)).Concat(new[] { (modelName, definitionType.TypeParameters.Length) }).ToArray());

			for (int i = 0; i < parentClasses.Length; ++i)
			{
				var parentClassSymbol = typeSymbols[i + modelNamespaceParts.Length] as INamedTypeSymbol;

				builder.AppendLine($"{indentation}public partial {(parentClassSymbol?.TypeKind.ToCSharpCodeString() ?? "class")} {parentClasses[i]}");
				builder.AppendLine($"{indentation}{{");

				indentation += "\t";
			}

			var model = typeSymbols.Last() as INamedTypeSymbol;

			var modelIsValueType = (modelTypeMode == ExternalConstants.ModelType.Auto && model?.TypeKind == TypeKind.Struct) || modelTypeMode == ExternalConstants.ModelType.Struct;

			builder.Append($"{indentation}[global::Valigator.GeneratedFrom(typeof({definitionType.GetFullNameWithNamespace(".", true)}");

			if (definitionType.TypeParameters.Any())
				builder.AppendLine($"<{Enumerable.Range(0, definitionType.TypeParameters.Length).Select(_ => "").JoinList(",")}>))]");
			else
				builder.AppendLine("))]");

			builder.AppendLine($"{indentation}public {(!modelIsValueType ? "sealed " : String.Empty)}partial {(!modelIsValueType ? "class" : "struct")} {modelName}{definitionType.TypeParameters.ToCSharpGenericParameterCode()} : global::Valigator.IModel, global::System.IEquatable<{modelName}{definitionType.TypeParameters.ToCSharpGenericParameterCode()}{(!modelIsValueType ? "?" : "")}>");

			var definedConstraints = (model?.GetDeclaringSyntaxReferences(cancellationToken) ?? Enumerable.Empty<TypeDeclarationSyntax>())
				.SelectMany(s => s.ConstraintClauses)
				.Select(c => c.Name.Identifier.Text)
				.ToArray();

			foreach (var constraint in definitionType.TypeParameters.Where(t => !definedConstraints.Contains(t.Name)).ToCSharpGenericParameterConstraintsCode())
				builder.AppendLine($"{indentation}\t{constraint}");

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
			builder.AppendLine($"{indentation}	public static {definitionName} ModelDefinition {{ get; }}");
			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	private global::Valigator.Models.ModelErrorDictionary _errorDictionary;");
			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	private global::Valigator.Models.ModelState _modelState;");

			foreach (var property in properties)
			{
				var propertyAccessors = defaultPropertyAccessors;

				if (property.TryGetAttribute(propertyAttributeType, out var propertyAttribute) && propertyAttribute.TryGetProperty<ExternalConstants.PropertyAccessors>(ExternalConstants.PropertyAttribute_Accessors_PropertyName, out var propertyAccessor))
					propertyAccessors = propertyAccessor;

				var lowercaseName = $"_{Char.ToLower(property.Name[0])}{property.Name.Substring(1)}";

				var propertyType = (property.Type as INamedTypeSymbol).TypeArguments[0] as INamedTypeSymbol;
				var propertyTypeName = propertyType.ToCSharpTypeCode();

				builder.AppendLine($"{indentation}	");
				builder.AppendLine($"{indentation}	private static global::Valigator.Models.ModelDefinition<ModelView>.Property<{propertyTypeName}> {lowercaseName}_Property;");
				builder.AppendLine($"{indentation}	private global::Valigator.Models.ModelPropertyState {lowercaseName}_State;");
				builder.AppendLine($"{indentation}	private {propertyTypeName} {lowercaseName};");
				builder.AppendLine($"{indentation}	public {propertyTypeName} {property.Name}");
				builder.AppendLine($"{indentation}	{{");
				builder.AppendLine($"{indentation}		get => Get(nameof({property.Name}), ref {lowercaseName}, ref {lowercaseName}_State);");
				builder.AppendLine($"{indentation}		{(propertyAccessors == ExternalConstants.PropertyAccessors.Get ? "private " : "")}{(propertyAccessors == ExternalConstants.PropertyAccessors.GetAndInit ? "init" : "set")} => Set(value, ref {lowercaseName}, ref {lowercaseName}_State);");
				builder.AppendLine($"{indentation}	}}");
			}

			if (!modelIsValueType)
			{
				builder.AppendLine($"{indentation}	");
				builder.AppendLine($"{indentation}	public {modelName}()");
				builder.AppendLine($"{indentation}	{{");
				builder.AppendLine($"{indentation}	}}");
			}

			if (properties.Length > 0)
			{
				builder.AppendLine($"{indentation}	");
				builder.AppendLine($"{indentation}	public {modelName}({properties.Select(p => $"{(p.Type as INamedTypeSymbol).TypeArguments[0].ToCSharpTypeCode()} {p.Name.ToPascalCase()}").JoinList(", ")})");
				
				if (modelIsValueType)
					builder.AppendLine($"{indentation}		: this()");

				builder.AppendLine($"{indentation}	{{");

				foreach (var property in properties)
					builder.AppendLine($"{indentation}		this.{property.Name} = {property.Name.ToPascalCase()};");

				builder.AppendLine($"{indentation}	}}");
			}

			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	private TValue Get<TValue>(string propertyName, ref TValue value, ref global::Valigator.Models.ModelPropertyState state)");
			builder.AppendLine($"{indentation}	{{");
			builder.AppendLine($"{indentation}		if (_modelState == global::Valigator.Models.ModelState.Unset)");
			builder.AppendLine($"{indentation}		{{");
			builder.AppendLine($"{indentation}			Coerce();");
			builder.AppendLine($"{indentation}			Validate();");
			builder.AppendLine($"{indentation}		}}");
			builder.AppendLine($"{indentation}		else if (_modelState == global::Valigator.Models.ModelState.Unvalidated)");
			builder.AppendLine($"{indentation}			Validate();");
			builder.AppendLine($"{indentation}		");
			builder.AppendLine($"{indentation}		return state == global::Valigator.Models.ModelPropertyState.Valid");
			builder.AppendLine($"{indentation}			? value");
			builder.AppendLine($"{indentation}			: throw new global::Valigator.DataInvalidException(_errorDictionary[propertyName]);");
			builder.AppendLine($"{indentation}	}}");
			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	private void Set<TValue>(TValue newValue, ref TValue value, ref global::Valigator.Models.ModelPropertyState state)");
			builder.AppendLine($"{indentation}	{{");
			builder.AppendLine($"{indentation}		value = newValue;");
			builder.AppendLine($"{indentation}		state = global::Valigator.Models.ModelPropertyState.Unvalidated;");
			builder.AppendLine($"{indentation}		");
			builder.AppendLine($"{indentation}		if (_modelState == global::Valigator.Models.ModelState.Validated)");
			builder.AppendLine($"{indentation}			_modelState = global::Valigator.Models.ModelState.Unvalidated;");
			builder.AppendLine($"{indentation}		");
			builder.AppendLine($"{indentation}		_errorDictionary.Clear();");
			builder.AppendLine($"{indentation}	}}");
			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	private void Coerce()");
			builder.AppendLine($"{indentation}	{{");

			foreach (var property in properties)
			{
				var lowercaseName = $"_{Char.ToLower(property.Name[0])}{property.Name.Substring(1)}";

				builder.AppendLine($"{indentation}		if ({lowercaseName}_State == global::Valigator.Models.ModelPropertyState.Unset)");
				builder.AppendLine($"{indentation}			global::Valigator.Models.ModelDefinitionPropertyExtensions.CoerceUnset({lowercaseName}_Property, nameof({property.Name}), ref {lowercaseName}, ref {lowercaseName}_State, ref _errorDictionary);");
				builder.AppendLine($"{indentation}		");
			}

			builder.AppendLine($"{indentation}		_modelState = global::Valigator.Models.ModelState.Unvalidated;");
			builder.AppendLine($"{indentation}	}}");
			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	private void Validate()");
			builder.AppendLine($"{indentation}	{{");
			builder.AppendLine($"{indentation}		var view = new ModelView(this);");
			builder.AppendLine($"{indentation}		");

			foreach (var property in properties)
			{
				var lowercaseName = $"_{Char.ToLower(property.Name[0])}{property.Name.Substring(1)}";

				builder.AppendLine($"{indentation}		if ({lowercaseName}_State != global::Valigator.Models.ModelPropertyState.CoerceFailed)");
				builder.AppendLine($"{indentation}			global::Valigator.Models.ModelDefinitionPropertyExtensions.Validate({lowercaseName}_Property, view, nameof({property.Name}), {lowercaseName}, ref {lowercaseName}_State, ref _errorDictionary);");
				builder.AppendLine($"{indentation}		");
			}

			builder.AppendLine($"{indentation}		_modelState = global::Valigator.Models.ModelState.Validated;");
			builder.AppendLine($"{indentation}	}}");
			builder.AppendLine($"{indentation}	");

			builder.AppendLine($"{indentation}	public override bool Equals(object? obj)");
			builder.AppendLine($"{indentation}		=> obj is {modelName}{definitionType.TypeParameters.ToCSharpGenericParameterCode()} value && Equals(value);");
			builder.AppendLine($"{indentation}	");

			if (modelIsValueType)
			{
				builder.AppendLine($"{indentation}	public bool Equals({modelName}{definitionType.TypeParameters.ToCSharpGenericParameterCode()} other)");

				bool first = true;

				foreach (var property in properties)
				{
					if (!first)
					{
						builder.AppendLine($" &&");
						builder.Append($"{indentation}		{property.Name} == other.{property.Name}");
					}
					else
						builder.Append($"{indentation}	=> {property.Name} == other.{property.Name}");

					first = false;
				}

				if (first)
					builder.Append($"{indentation}	=> true");
			}
			else
			{
				builder.AppendLine($"{indentation}	public bool Equals({modelName}{definitionType.TypeParameters.ToCSharpGenericParameterCode()}? other)");
				builder.Append($"{indentation}		=> other is {modelName}{definitionType.TypeParameters.ToCSharpGenericParameterCode()}");

				if (properties.Length > 0)
					builder.Append(" value");

				foreach (var property in properties)
				{
					builder.AppendLine($" &&");
					builder.Append($"{indentation}			{property.Name} == value.{property.Name}");
				}
			}

			builder.AppendLine(";");

			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	public override int GetHashCode()");

			if (properties.Length > 0)
			{
				builder.AppendLine($"{indentation}	{{");
				builder.AppendLine($"{indentation}		var hash = new System.HashCode();");
				
				foreach (var property in properties)
					builder.AppendLine($"{indentation}		hash.Add({property.Name});");

				builder.AppendLine($"{indentation}		return hash.ToHashCode();");
				builder.AppendLine($"{indentation}	}}");
			}
			else
				builder.AppendLine($"{indentation}		=> 0;");

			builder.AppendLine($"{indentation}	");
			builder.AppendLine($"{indentation}	public struct ModelView");
			builder.AppendLine($"{indentation}	{{");
			builder.AppendLine($"{indentation}		private {modelName}{definitionType.TypeParameters.ToCSharpGenericParameterCode()} _model;");
			builder.AppendLine($"{indentation}		");
			builder.AppendLine($"{indentation}		public ModelView({modelName}{definitionType.TypeParameters.ToCSharpGenericParameterCode()} model)");
			builder.AppendLine($"{indentation}			=> _model = model;");

			foreach (var property in properties)
			{
				var lowercaseName = $"_{Char.ToLower(property.Name[0])}{property.Name.Substring(1)}";

				var propertyTypeName = (property.Type as INamedTypeSymbol).TypeArguments[0].ToCSharpTypeCode();

				builder.AppendLine($"{indentation}		");
				builder.AppendLine($"{indentation}		public global::Functional.Result<{propertyTypeName}, global::Valigator.Models.ModelPropertyNotSet> {property.Name} => Get(ref _model.{lowercaseName}, _model.{lowercaseName}_State);");
			}

			builder.AppendLine($"{indentation}		");
			builder.AppendLine($"{indentation}		private global::Functional.Result<TValue, global::Valigator.Models.ModelPropertyNotSet> Get<TValue>(ref TValue value, global::Valigator.Models.ModelPropertyState state)");
			builder.AppendLine($"{indentation}		{{");
			builder.AppendLine($"{indentation}			if (_model._modelState == global::Valigator.Models.ModelState.Unset)");
			builder.AppendLine($"{indentation}				_model.Coerce();");
			builder.AppendLine($"{indentation}				");
			builder.AppendLine($"{indentation}			return global::Functional.Result");
			builder.AppendLine($"{indentation}				.Create");
			builder.AppendLine($"{indentation}				(");
			builder.AppendLine($"{indentation}					state != global::Valigator.Models.ModelPropertyState.CoerceFailed,");
			builder.AppendLine($"{indentation}					value,");
			builder.AppendLine($"{indentation}					global::Valigator.Models.ModelPropertyNotSet.Value");
			builder.AppendLine($"{indentation}				);");
			builder.AppendLine($"{indentation}		}}");
			builder.AppendLine($"{indentation}	}}");
			builder.AppendLine($"{indentation}}}");

			foreach (var parentClass in parentClasses)
			{
				indentation = indentation.Substring(1);

				builder.AppendLine($"{indentation}}}");
			}

			if (hasNamespace)
				builder.AppendLine($"}}");

			builder.AppendLine();
			builder.AppendLine("#nullable disable");

			return builder.ToString();
		}
	}
}
