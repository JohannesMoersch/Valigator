using System;
using System.IO;
using System.Linq;
using Functional;

namespace Valigator.Generator
{
	class Program
	{
		static void Main()
		{
			foreach (var source in Data.Sources)
			{
				var file = ExtensionsClass.Generate(source);

				File.WriteAllText($"../../../../Valigator.Core/Extensions/{source.GetSourceName(Option.None<string>())}Extensions.cs", file);
			}
		}
	}
}
