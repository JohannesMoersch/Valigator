using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Generator
{
	public static class ExtensionGenerator
	{
		private static readonly string _singleExtensionTemplate =
@"		public static __DataSource__<__StateValidator__, __ValueValidator__, __TValueType__> __ExtensionName__<__ExtensionGenericParameters____TValue__>(this __StateValidator__ stateValidator__ExtensionParameters__)
			=> stateValidator.Add(__ValidatorConstruction__);
";

		public static string GenerateSingleExtension(SourceDefinition sourceDefinition, ExtensionDefinition extensionDefinition)
		{
			if (sourceDefinition.ValueType == ValueType.Value && extensionDefinition.ValueType != ValueType.Value)
				throw new Exception("Array extensions cannot be generated for value type sources.");

			var valueGenericName = "TValue";

			return _singleExtensionTemplate
				.Replace("__DataSource__", $"{(sourceDefinition.IsNullable ? "Nullable" : String.Empty)}DataSourceStandard")
				.Replace("__StateValidator__", sourceDefinition.GetSourceName(valueGenericName))
				.Replace("__ValueValidator__", extensionDefinition.GetValidatorName(valueGenericName))
				.Replace("__TValueType__", sourceDefinition.ValueType == ValueType.Array ? $"{valueGenericName}[]" : valueGenericName)
				.Replace("__ExtensionName__", extensionDefinition.ExtensionName)
				.Replace("__ExtensionGenericParameters__", String.Join("", extensionDefinition.GenericParameters.SelectMany(s => $"{s}, ")))
				.Replace("__TValue__", valueGenericName)
				.Replace("__ExtensionParameters__", String.Join(String.Empty, extensionDefinition.Parameters.Select(p => $", {p.GetTypeName(valueGenericName)} {p.Name}{p.DefaultValue.Match(v => $" = {v}", () => String.Empty)}")))
				.Replace("__ValidatorConstruction__", extensionDefinition.GetValidatorConstruction(valueGenericName));
		}
	}
}
