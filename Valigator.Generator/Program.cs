using System;
using System.Linq;
using Functional;

namespace Valigator.Generator
{
	class Program
	{
		static void Main(string[] args)
		{
			var sources = Constants.Sources;

			var extension1 = ExtensionGenerator.GenerateSingleExtension(sources.FirstOrDefault(s => s.ValueType == ValueType.Value), new ExtensionDefinition("InSet", $"InSetValidator<{Constants.ValueReplacementString}>", Array.Empty<string>(), new[] { new ParameterDefinition($"params {Constants.ValueReplacementString}[]", "options", Option.None<string>()) }, $"new InSetValidator<{Constants.ValueReplacementString}>(options)", ValueType.Value));

			var extension2 = ExtensionGenerator.GenerateSingleExtension(sources.FirstOrDefault(s => s.ValueType == ValueType.Value), new ExtensionDefinition("Precision", $"PrecisionValidator", Array.Empty<string>(), new[] { new ParameterDefinition($"decimal?", "minimumDecimalPlaces", Option.Some("null")), new ParameterDefinition($"decimal?", "maximumDecimalPlaces", Option.Some("null")) }, $"new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces)", ValueType.Value, "decimal"));
		}
	}
}
