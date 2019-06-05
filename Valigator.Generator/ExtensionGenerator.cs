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
@"		public static __Nullable__DataSourceStandard<__StateValidator__, __NewValueValidator__, __TValueType__> __ExtensionName____Open____TValue____Close__(this __StateValidator__ source__ExtensionParameters__)
			=> source.Add(new __NewValueValidator__(__Parameters__));
";

		private static readonly string _doubleExtensionTemplate =
@"		public static __Nullable__DataSource__InvertOne__Standard<__StateValidator__, __ValueValidatorOne__, __NewValueValidator__, __TValueType__> __ExtensionName____Open____TValue____Close__(this __Nullable__DataSource__InvertOne__<__StateValidator__, __ValueValidatorOne__, __TValueType__> source__ExtensionParameters__)
			=> source.Add(new __NewValueValidator__(__Parameters__));
";

		private static readonly string _tripleExtensionTemplate =
@"		public static __Nullable__DataSource__InvertOne____InvertTwo__Standard<__StateValidator__, __ValueValidatorOne__, __ValueValidatorTwo__, __NewValueValidator__, __TValueType__> __ExtensionName____Open____TValue____Close__(this __Nullable__DataSource__InvertOne____InvertTwo__<__StateValidator__, __ValueValidatorOne__, __ValueValidatorTwo__, __TValueType__> source__ExtensionParameters__)
			=> source.Add(new __NewValueValidator__(__Parameters__));
";

		private static string PopulateTemplate(string template, SourceDefinition sourceDefinition, string valueGenericName, bool hasGenericParameters, ValidatorDefinition validatorOne, ValidatorDefinition validatorTwo, ExtensionDefinition extension, bool invertOne, bool invertTwo)
			=> template
				.Replace("__Nullable__", $"{(sourceDefinition.IsNullable ? "Nullable" : String.Empty)}")
				.Replace("__InvertOne__", $"{(invertOne ? "Inverted" : "Standard")}")
				.Replace("__InvertTwo__", $"{(invertTwo ? "Inverted" : "Standard")}")
				.Replace("__StateValidator__", sourceDefinition.GetSourceName(Option.Some(valueGenericName)))
				.Replace("__ValueValidatorOne__", validatorOne?.GetValidatorName(valueGenericName) ?? String.Empty)
				.Replace("__ValueValidatorTwo__", validatorTwo?.GetValidatorName(valueGenericName) ?? String.Empty)
				.Replace("__NewValueValidator__", extension.Validator.GetValidatorName(valueGenericName))
				.Replace("__TValueType__", sourceDefinition.ValueType == ValueType.Array ? $"{valueGenericName}[]" : valueGenericName)
				.Replace("__ExtensionName__", extension.ExtensionName)
				.Replace("__Open__", hasGenericParameters ? "<" : String.Empty)
				.Replace("__TValue__", hasGenericParameters ? valueGenericName : String.Empty)
				.Replace("__Close__", hasGenericParameters ? ">" : String.Empty)
				.Replace("__ExtensionParameters__", String.Join(String.Empty, extension.Parameters.Where(p => !p.Value.HasValue()).Select(p => $", {p.GetTypeName(valueGenericName)} {p.Name}{p.DefaultValue.Match(v => $" = {v}", () => String.Empty)}")))
				.Replace("__Parameters__", String.Join(", ", extension.Parameters.Select(p => p.Value.Match(v => v, () => p.Name))));

		public static IEnumerable<string> GenerateExtensionOne(SourceDefinition sourceDefinition, Option<string> dataType, ExtensionDefinition extension)
		{
			if (sourceDefinition.ValueType == ValueType.Value && extension.Validator.ValueType != ValueType.Value)
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = dataType.Match(_ => _, () => "TValue");

			var hasGenericParameters = dataType.Match(_ => false, () => true);

			yield return PopulateTemplate(_singleExtensionTemplate, sourceDefinition, valueGenericName, hasGenericParameters, null, null, extension, false, false);
		}

		public static IEnumerable<string> GenerateExtensionTwo(SourceDefinition sourceDefinition, Option<string> dataType, ValidatorDefinition validatorOne, ExtensionDefinition extension)
		{
			if (sourceDefinition.ValueType == ValueType.Value && (validatorOne.ValueType != ValueType.Value || extension.Validator.ValueType != ValueType.Value))
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = dataType.Match(_ => _, () => "TValue");

			var hasGenericParameters = dataType.Match(_ => false, () => true);

			yield return PopulateTemplate(_doubleExtensionTemplate, sourceDefinition, valueGenericName, hasGenericParameters, validatorOne, null, extension, false, false);
			yield return PopulateTemplate(_doubleExtensionTemplate, sourceDefinition, valueGenericName, hasGenericParameters, validatorOne, null, extension, true, false);
		}

		public static IEnumerable<string> GenerateExtensionThree(SourceDefinition sourceDefinition, Option<string> dataType, ValidatorDefinition validatorOne, ValidatorDefinition validatorTwo, ExtensionDefinition extension)
		{
			if (sourceDefinition.ValueType == ValueType.Value && (validatorOne.ValueType != ValueType.Value || validatorTwo.ValueType != ValueType.Value || extension.Validator.ValueType != ValueType.Value))
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = dataType.Match(_ => _, () => "TValue");

			var hasGenericParameters = dataType.Match(_ => false, () => true);

			yield return PopulateTemplate(_tripleExtensionTemplate, sourceDefinition, valueGenericName, hasGenericParameters, validatorOne, validatorTwo, extension, false, false);
			yield return PopulateTemplate(_tripleExtensionTemplate, sourceDefinition, valueGenericName, hasGenericParameters, validatorOne, validatorTwo, extension, true, false);
			yield return PopulateTemplate(_tripleExtensionTemplate, sourceDefinition, valueGenericName, hasGenericParameters, validatorOne, validatorTwo, extension, false, true);
			yield return PopulateTemplate(_tripleExtensionTemplate, sourceDefinition, valueGenericName, hasGenericParameters, validatorOne, validatorTwo, extension, true, true);
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
