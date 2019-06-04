using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;

namespace Valigator.Generator
{
	public static class ExtensionsClass
	{
		private static readonly string _header =
@"using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class __StateValidator__Extensions
	{";

		private static readonly string _footer =
@"	}
}";

		public static string Generate(SourceDefinition source)
		{
			var strs = Data
					.Extensions
					.Select(extension => ExtensionGenerator.GenerateStarterExtension(source, extension))
					.ToArray();

			return String.Join(Environment.NewLine, new[] { _header.Replace("__StateValidator__", source.GetSourceName(Option.None<string>())) }.Concat(strs).Append(_footer));
		}
	}
}
