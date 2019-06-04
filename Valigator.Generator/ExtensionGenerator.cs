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

		public static string GenerateExtensionOne(SourceDefinition sourceDefinition, ExtensionDefinition extensionDefinitionOne)
		{
			if (sourceDefinition.ValueType == ValueType.Value && extensionDefinitionOne.ValueType != ValueType.Value)
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = extensionDefinitionOne.DataType.Match(_ => _, () => "TValue");

			return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {extensionDefinitionOne.ExtensionName}";

			var hasGenericParameters = extensionDefinitionOne.DataType.Match(_ => extensionDefinitionOne.GenericParameters.Any(), () => true);

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
				.Replace("__ValidatorConstruction__", extensionDefinitionOne.GetValidatorConstruction(valueGenericName));
		}

		public static Option<string> GenerateExtensionTwo(SourceDefinition sourceDefinition, ExtensionDefinition extensionDefinitionOne, ExtensionDefinition extensionDefinitionTwo)
		{
			if (sourceDefinition.ValueType == ValueType.Value && (extensionDefinitionOne.ValueType != ValueType.Value || extensionDefinitionTwo.ValueType != ValueType.Value))
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericNameResult = GetValueGenericName(extensionDefinitionOne.DataType, extensionDefinitionTwo.DataType, default);

			if (!valueGenericNameResult.IsSuccess())
				return Option.None<string>();

			var valueGenericName = valueGenericNameResult.Success().ValueOrDefault().Match(_ => _, () => "TValue");

			return Option.Some($"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {extensionDefinitionOne.GetValidatorName(valueGenericName)} - {extensionDefinitionTwo.ExtensionName}");
		}

		public static Option<string> GenerateExtensionThree(SourceDefinition sourceDefinition, ExtensionDefinition extensionDefinitionOne, ExtensionDefinition extensionDefinitionTwo, ExtensionDefinition extensionDefinitionThree)
		{
			if (sourceDefinition.ValueType == ValueType.Value && (extensionDefinitionOne.ValueType != ValueType.Value || extensionDefinitionTwo.ValueType != ValueType.Value || extensionDefinitionThree.ValueType != ValueType.Value))
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericNameResult = GetValueGenericName(extensionDefinitionOne.DataType, extensionDefinitionTwo.DataType, extensionDefinitionThree.DataType);

			if (!valueGenericNameResult.IsSuccess())
				return Option.None<string>();

			var valueGenericName = valueGenericNameResult.Success().ValueOrDefault().Match(_ => _, () => "TValue");

			return Option.Some($"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {extensionDefinitionOne.GetValidatorName(valueGenericName)} - {extensionDefinitionTwo.GetValidatorName(valueGenericName)} - {extensionDefinitionThree.ExtensionName}");
		}

		public static string GenerateInvertExtensionTwo(SourceDefinition sourceDefinition, ExtensionDefinition extensionDefinitionOne)
		{
			if (sourceDefinition.ValueType == ValueType.Value && extensionDefinitionOne.ValueType != ValueType.Value)
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = extensionDefinitionOne.DataType.Match(_ => _, () => "TValue");

			return $"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {extensionDefinitionOne.GetValidatorName(valueGenericName)} - Not";
		}

		public static Option<string> GenerateInvertExtensionThree(SourceDefinition sourceDefinition, ExtensionDefinition extensionDefinitionOne, ExtensionDefinition extensionDefinitionTwo)
		{
			if (sourceDefinition.ValueType == ValueType.Value && (extensionDefinitionOne.ValueType != ValueType.Value || extensionDefinitionTwo.ValueType != ValueType.Value))
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericNameResult = GetValueGenericName(extensionDefinitionOne.DataType, extensionDefinitionTwo.DataType, default);

			if (!valueGenericNameResult.IsSuccess())
				return Option.None<string>();

			var valueGenericName = valueGenericNameResult.Success().ValueOrDefault().Match(_ => _, () => "TValue");

			return Option.Some($"{sourceDefinition.GetSourceName(Option.Some(valueGenericName))} - {extensionDefinitionOne.GetValidatorName(valueGenericName)} - {extensionDefinitionTwo.GetValidatorName(valueGenericName)} - Not");
		}

		private static Result<Option<string>, Unit> GetValueGenericName(Option<string> dataTypeOne, Option<string> dataTypeTwo, Option<string> dataTypeThree)
			=> dataTypeOne
				.Match
				(
					one => dataTypeTwo
						.Match
						(
							two => one == two
								? dataTypeThree
									.Match
									(
										three => one == three ? Result.Success<Option<string>, Unit>(Option.Some(one)) : Result.Failure<Option<string>, Unit>(Unit.Value),
										() => Result.Success<Option<string>, Unit>(Option.Some(one))
									)
								: Result.Failure<Option<string>, Unit>(Unit.Value),
							() => Result.Success<Option<string>, Unit>(Option.Some(one))
						),
					() => Result.Success<Option<string>, Unit>(Option.None<string>())
				);
	}
}
