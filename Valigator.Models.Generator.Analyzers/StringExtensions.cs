using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class StringExtensions
	{
		public static string EnsureRegexMatchesFullInput(this string pattern)
		{
			if (!pattern.StartsWith("^"))
				pattern = "^" + pattern;
			
			if (!pattern.EndsWith("$"))
				pattern += "$";

			return pattern;
		}

		public static string JoinListWithOxfordComma(this IEnumerable<string> values)
		{
			var items = values.ToArray();

			return items.Length switch
			{
				0 => String.Empty,
				1 => items[0],
				2 => $"{items[0]} and {items[1]}",
				_ => $"{String.Join(", ", items.Take(items.Length - 1))}, and {items[items.Length - 1]}"
			};
		}
	}
}
