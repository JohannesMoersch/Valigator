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
@"		public static __DataSource__<__StateValidator__, __ValueValidator__, __TValueType__> __ExtensionName____Open____ExtensionGenericParameters____TValue____Close__(this __StateValidator__ stateValidator__ExtensionParameters__)
			=> stateValidator.Add(__ValidatorConstruction__);
";

		public static string GenerateExtensionOne(SourceDefinition sourceDefinition, Option<string> dataType, ExtensionDefinition extension)
		{
			if (sourceDefinition.ValueType == ValueType.Value && extension.Validator.ValueType != ValueType.Value)
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = dataType.Match(_ => _, () => "TValue");

			return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {extension.ExtensionName}";

			/*
			var hasGenericParameters = extensionDefinition.DataType.Match(_ => extensionDefinition.GenericParameters.Any(), () => true);
			
			return _singleExtensionTemplate
				.Replace("__DataSource__", $"{(sourceDefinition.IsNullable ? "Nullable" : String.Empty)}DataSourceStandard")
				.Replace("__StateValidator__", sourceDefinition.GetSourceName(Option.Some(valueGenericName)))
				.Replace("__ValueValidator__", extensionDefinitionOne.GetValidatorName(valueGenericName))
				.Replace("__TValueType__", sourceDefinition.ValueType == ValueType.Array ? $"{valueGenericName}[]" : valueGenericName)
				.Replace("__ExtensionName__", extensionDefinitionOne.ExtensionName)
				.Replace("__Open__", hasGenericParameters ? "<" : String.Empty)
				.Replace("__ExtensionGenericParameters__", String.Join("", extensionDefinitionOne.GenericParameters.SelectMany(s => $"{s}, ")))
				.Replace("__TValue__", hasGenericParameters ? valueGenericName : String.Empty)
				.Replace("__Close__", hasGenericParameters ? ">" : String.Empty)
				.Replace("__ExtensionParameters__", String.Join(String.Empty, extensionDefinitionOne.Parameters.Select(p => $", {p.GetTypeName(valueGenericName)} {p.Name}{p.DefaultValue.Match(v => $" = {v}", () => String.Empty)}")))
				.Replace("__ValidatorConstruction__", extensionDefinitionOne.GetValidatorConstruction(valueGenericName));*/
		}

		public static string GenerateExtensionTwo(SourceDefinition sourceDefinition, Option<string> dataType, ValidatorDefinition validatorOne, ExtensionDefinition extension)
		{
			if (sourceDefinition.ValueType == ValueType.Value && (validatorOne.ValueType != ValueType.Value || extension.Validator.ValueType != ValueType.Value))
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = dataType.Match(_ => _, () => "TValue");

			return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {validatorOne.GetValidatorName(valueGenericName)} - {extension.ExtensionName}";
		}

		public static string GenerateExtensionThree(SourceDefinition sourceDefinition, Option<string> dataType, ValidatorDefinition validatorOne, ValidatorDefinition validatorTwo, ExtensionDefinition extension)
		{
			if (sourceDefinition.ValueType == ValueType.Value && (validatorOne.ValueType != ValueType.Value || validatorTwo.ValueType != ValueType.Value || extension.Validator.ValueType != ValueType.Value))
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = dataType.Match(_ => _, () => "TValue");

			return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {validatorOne.GetValidatorName(valueGenericName)} - {validatorTwo.GetValidatorName(valueGenericName)} - {extension.ExtensionName}";
		}
		/*
		public static string GenerateInvertExtensionTwo(SourceDefinition sourceDefinition, Option<string> dataType, ExtensionDefinition extensionDefinitionOne)
		{
			if (sourceDefinition.ValueType == ValueType.Value && extensionDefinitionOne.ValueType != ValueType.Value)
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = dataType.Match(_ => _, () => "TValue");

			return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {extensionDefinitionOne.GetValidatorName(valueGenericName)} - Not";
		}

		public static string GenerateInvertExtensionThree(SourceDefinition sourceDefinition, Option<string> dataType, ExtensionDefinition extensionDefinitionOne, ExtensionDefinition extensionDefinitionTwo)
		{
			if (sourceDefinition.ValueType == ValueType.Value && (extensionDefinitionOne.ValueType != ValueType.Value || extensionDefinitionTwo.ValueType != ValueType.Value))
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = dataType.Match(_ => _, () => "TValue");

			return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {extensionDefinitionOne.GetValidatorName(valueGenericName)} - {extensionDefinitionTwo.GetValidatorName(valueGenericName)} - Not";
		}
		*/
	}
}
