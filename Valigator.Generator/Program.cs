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

			var strs = Constants
				.Extensions
				.Select(extension => ExtensionGenerator.GenerateSingleExtension(sources.First(s => s.ValueType == ValueType.Value), extension))
				.ToArray();

			var extensions = String.Join(Environment.NewLine, strs);
		}
	}
}
