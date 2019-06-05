using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;

namespace Valigator.Generator
{
	public static class ExtensionGenerator
	{
		private static readonly string _singleExtensionTemplate =
@"		public static __DataSource__<__StateValidator__, __ValueValidator__, __TValueType__> __ExtensionName____Open____TValue____Close__(this __StateValidator__ stateValidator__ExtensionParameters__)
			=> stateValidator.Add(new __ValidatorConstruction__(__Parameters__));
";

		public static IEnumerable<string> GenerateExtensionOne(SourceDefinition sourceDefinition, Option<string> dataType, ExtensionDefinition extension)
		{
			if (sourceDefinition.ValueType == ValueType.Value && extension.Validator.ValueType != ValueType.Value)
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = dataType.Match(_ => _, () => "TValue");

			var hasGenericParameters = dataType.Match(_ => false, () => true);

			return new[]
			{
				_singleExtensionTemplate
				.Replace("__DataSource__", $"{(sourceDefinition.IsNullable ? "Nullable" : String.Empty)}DataSourceStandard")
				.Replace("__StateValidator__", sourceDefinition.GetSourceName(Option.Some(valueGenericName)))
				.Replace("__ValueValidator__", extension.Validator.GetValidatorName(valueGenericName))
				.Replace("__TValueType__", sourceDefinition.ValueType == ValueType.Array ? $"{valueGenericName}[]" : valueGenericName)
				.Replace("__ExtensionName__", extension.ExtensionName)
				.Replace("__Open__", hasGenericParameters ? "<" : String.Empty)
				.Replace("__TValue__", hasGenericParameters ? valueGenericName : String.Empty)
				.Replace("__Close__", hasGenericParameters ? ">" : String.Empty)
				.Replace("__ExtensionParameters__", String.Join(String.Empty, extension.Parameters.Where(p => !p.Value.HasValue()).Select(p => $", {p.GetTypeName(valueGenericName)} {p.Name}{p.DefaultValue.Match(v => $" = {v}", () => String.Empty)}")))
				.Replace("__ValidatorConstruction__", extension.Validator.GetValidatorName(valueGenericName))
				.Replace("__Parameters__", String.Join(", ", extension.Parameters.Select(p => p.Value.Match(v => v, () => p.Name))))
			};
		}

		public static IEnumerable<string> GenerateExtensionTwo(SourceDefinition sourceDefinition, Option<string> dataType, ValidatorDefinition validatorOne, ExtensionDefinition extension)
		{
			if (sourceDefinition.ValueType == ValueType.Value && (validatorOne.ValueType != ValueType.Value || extension.Validator.ValueType != ValueType.Value))
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = dataType.Match(_ => _, () => "TValue");

			yield return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {validatorOne.GetValidatorName(valueGenericName)} - {extension.ExtensionName}";
			yield return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - Inverted<{validatorOne.GetValidatorName(valueGenericName)}> - {extension.ExtensionName}";
		}

		public static IEnumerable<string> GenerateExtensionThree(SourceDefinition sourceDefinition, Option<string> dataType, ValidatorDefinition validatorOne, ValidatorDefinition validatorTwo, ExtensionDefinition extension)
		{
			if (sourceDefinition.ValueType == ValueType.Value && (validatorOne.ValueType != ValueType.Value || validatorTwo.ValueType != ValueType.Value || extension.Validator.ValueType != ValueType.Value))
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = dataType.Match(_ => _, () => "TValue");

			yield return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {validatorOne.GetValidatorName(valueGenericName)} - {validatorTwo.GetValidatorName(valueGenericName)} - {extension.ExtensionName}";
			yield return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {validatorOne.GetValidatorName(valueGenericName)} - Inverted<{validatorTwo.GetValidatorName(valueGenericName)}> - {extension.ExtensionName}";
			yield return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - Inverted<{validatorOne.GetValidatorName(valueGenericName)}> - {validatorTwo.GetValidatorName(valueGenericName)} - {extension.ExtensionName}";
			yield return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - Inverted<{validatorOne.GetValidatorName(valueGenericName)}> - Inverted<{validatorTwo.GetValidatorName(valueGenericName)}> - {extension.ExtensionName}";
		}
		
		public static IEnumerable<string> GenerateInvertExtensionTwo(SourceDefinition sourceDefinition, Option<string> dataType, ValidatorDefinition validatorOne)
		{
			if (sourceDefinition.ValueType == ValueType.Value && validatorOne.ValueType != ValueType.Value)
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = dataType.Match(_ => _, () => "TValue");

			yield return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {validatorOne.GetValidatorName(valueGenericName)} - Not";
			yield return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - Inverted<{validatorOne.GetValidatorName(valueGenericName)}> - Not";
		}

		public static IEnumerable<string> GenerateInvertExtensionThree(SourceDefinition sourceDefinition, Option<string> dataType, ValidatorDefinition validatorOne, ValidatorDefinition validatorTwo)
		{
			if (sourceDefinition.ValueType == ValueType.Value && (validatorOne.ValueType != ValueType.Value || validatorTwo.ValueType != ValueType.Value))
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = dataType.Match(_ => _, () => "TValue");

			yield return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {validatorOne.GetValidatorName(valueGenericName)} - {validatorTwo.GetValidatorName(valueGenericName)} - Not";
			yield return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {validatorOne.GetValidatorName(valueGenericName)} - Inverted<{validatorTwo.GetValidatorName(valueGenericName)}> - Not";
			yield return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - Inverted<{validatorOne.GetValidatorName(valueGenericName)}> - {validatorTwo.GetValidatorName(valueGenericName)} - Not";
			yield return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - Inverted<{validatorOne.GetValidatorName(valueGenericName)}> - Inverted<{validatorTwo.GetValidatorName(valueGenericName)}> - Not";
		}
	}
}
