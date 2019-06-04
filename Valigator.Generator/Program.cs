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

			var extension = ExtensionGenerator.GenerateSingleExtension(sources.FirstOrDefault(s => s.ValueType == ValueType.Value), new ExtensionDefinition("InSet", $"InSetValidator<{Constants.ValueReplacementString}>", Array.Empty<string>(), new[] { new ParameterDefinition($"params {Constants.ValueReplacementString}[]", "options", Option.None<string>()) }, $"new InSetValidator<{Constants.ValueReplacementString}>(options)", ValueType.Value));
		}
	}
}
