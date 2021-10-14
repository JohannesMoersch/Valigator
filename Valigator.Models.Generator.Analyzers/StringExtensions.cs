using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class StringExtensions
	{
		public static string ToPascalCase(this string str)
			=> str.Length > 0
				? $"{Char.ToLower(str[0])}{str.Substring(1)}"
				: String.Empty;
	}
}
