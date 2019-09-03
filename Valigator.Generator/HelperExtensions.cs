using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;

namespace Valigator.Generator
{
	public static class HelperExtensions
	{
		public static string GetDataContainerFactoryType(this SourceDefinition sourceDefinition)
		{
			string factoryName;
			switch (sourceDefinition.ValueType)
			{
				case ValueType.Value:
					factoryName = "DataContainerFactory";
					break;
				case ValueType.Array:
					factoryName = "CollectionDataContainerFactory";
					break;
				case ValueType.NullableArray:
					factoryName = "CollectionNullableDataContainerFactory";
					break;
				default:
					throw new Exception("Unrecognized source definition type.");
			}

			if (sourceDefinition.IsNullable)
				return $"Nullable{factoryName}";

			return factoryName;
		}

		public static string GetValidatorValueType(this SourceDefinition sourceDefinition, string valueName, Option<ValidatorDefinition> validator)
		{
			var validatorType = validator.Select(v => v.ValueType).ToNullable();

			switch (sourceDefinition.ValueType)
			{
				case ValueType.Value:
					switch (validatorType ?? ValueType.Value)
					{
						case ValueType.Value:
							return valueName;
					}
					break;
				case ValueType.Array:
					switch (validatorType ?? ValueType.Value)
					{
						case ValueType.Value:
							return $"{valueName}[]";
						case ValueType.Array:
							return valueName;
					}
					break;
				case ValueType.NullableArray:
					switch (validatorType ?? ValueType.Value)
					{
						case ValueType.Value:
							return $"Option<{valueName}>[]";
						case ValueType.Array:
							return $"Option<{valueName}>";
						case ValueType.NullableArray:
							return valueName;
					}
					break;
			}

			throw new Exception("Unsupported source and validator type combination.");
		}

		public static string GetDataValueType(this SourceDefinition sourceDefinition, string valueName)
		{
			var dataValueName = GetValidatorValueType(sourceDefinition, valueName, Option.None<ValidatorDefinition>());

			if (sourceDefinition.IsNullable)
				return $"Option<{dataValueName}>";

			return dataValueName;
		}

		public static string GetValidatorName(this ExtensionDefinition extension, SourceDefinition sourceDefinition, string valueGenericName)
			=> extension.Validator.GetValidatorName(sourceDefinition.GetValidatorValueType(valueGenericName, Option.Some(extension.Validator)));

		public static string GetParameters(this ExtensionDefinition extension, SourceDefinition sourceDefinition, string valueGenericName)
			=> String
				.Join
				(
					String.Empty, 
					extension
						.Parameters
						.Where(p => !p.Value.HasValue())
						.Select(p => $", {p.GetTypeName(GetValidatorValueType(sourceDefinition, valueGenericName, Option.Some(extension.Validator)))} {p.Name}{p.DefaultValue.Match(v => $" = {v}", () => String.Empty)}")
				);

		public static string GetArguments(this ExtensionDefinition extension)
			=> String.Join(", ", extension.Parameters.Select(p => p.Value.Match(v => v, () => p.Name)));

		public static string ConstructorGenericParameters(string[] genericParameters, Option<string> source)
		{
			var parameters = source
				.Match(s => new[] { s }, Array.Empty<string>)
				.Concat(genericParameters)
				.ToArray();

			if (parameters.Any())
				return $"<{String.Join(", ", genericParameters)}>";

			return String.Empty;
		}
	}
}
