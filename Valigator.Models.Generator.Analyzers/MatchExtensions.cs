using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Valigator.Models.Generator.Analyzers
{
	public static class MatchExtensions
	{
		public static string ApplyToPattern(this Match match, string pattern)
		{
			var builder = new StringBuilder();

			for (int i = 0; i < pattern.Length; ++i)
			{
				if (i < pattern.Length - 3 && pattern[i] == '$' && pattern[i + 1] == '{' && Char.IsDigit(pattern[i + 2]))
				{
					var start = i;
					int num = 0;
					i += 2;

					while (i < pattern.Length && Char.IsDigit(pattern[i]))
					{
						num *= 10;
						num += pattern[i] - '0';
						++i;
					}

					if (i < pattern.Length && pattern[i] == '}' && match.Groups.Count >= num)
					{
						builder.Append(match.Groups[num].Value);
						continue;
					}
					else
						i = start;
				}
				
				builder.Append(pattern[i]);
			}

			return builder.ToString();
		}
	}
}
