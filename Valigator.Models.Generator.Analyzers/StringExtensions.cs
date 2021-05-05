using System;
using System.Collections.Generic;
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
	}
}
