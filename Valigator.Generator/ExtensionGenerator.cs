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

		public static string GenerateStarterExtension(SourceDefinition sourceDefinition, ExtensionDefinition extensionDefinition)
		{
			if (sourceDefinition.ValueType == ValueType.Value && extensionDefinition.ValueType != ValueType.Value)
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = extensionDefinition.DataType.Match(_ => _, () => "TValue");

			var hasGenericParameters = extensionDefinition.DataType.Match(_ => extensionDefinition.GenericParameters.Any(), () => true);

			return _singleExtensionTemplate
				.Replace("__DataSource__", $"{(sourceDefinition.IsNullable ? "Nullable" : String.Empty)}DataSourceStandard")
				.Replace("__StateValidator__", sourceDefinition.GetSourceName(Option.Some(valueGenericName)))
				.Replace("__ValueValidator__", extensionDefinition.GetValidatorName(valueGenericName))
				.Replace("__TValueType__", sourceDefinition.ValueType == ValueType.Array ? $"{valueGenericName}[]" : valueGenericName)
				.Replace("__ExtensionName__", extensionDefinition.ExtensionName)
				.Replace("__Open__", hasGenericParameters ? "<" : String.Empty)
				.Replace("__ExtensionGenericParameters__", String.Join("", extensionDefinition.GenericParameters.SelectMany(s => $"{s}, ")))
				.Replace("__TValue__", hasGenericParameters ? valueGenericName : String.Empty)
				.Replace("__Close__", hasGenericParameters ? ">" : String.Empty)
				.Replace("__ExtensionParameters__", String.Join(String.Empty, extensionDefinition.Parameters.Select(p => $", {p.GetTypeName(valueGenericName)} {p.Name}{p.DefaultValue.Match(v => $" = {v}", () => String.Empty)}")))
				.Replace("__ValidatorConstruction__", extensionDefinition.GetValidatorConstruction(valueGenericName));
		}
	}
}
