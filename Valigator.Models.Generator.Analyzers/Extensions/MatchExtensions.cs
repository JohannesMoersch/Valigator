using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Valigator.Models.Generator.Analyzers.Extensions
{
	public static class MatchExtensions
	{
		public static bool TryApplyToPattern(this Match match, string pattern, out string value, out string errorMessage)
		{
			value = String.Empty;

			var builder = new StringBuilder();

			for (var i = 0; i < pattern.Length; ++i)
				if (pattern[i] == '$')
				{
					if (i >= pattern.Length - 3 || pattern[i + 1] != '{' || !Char.IsDigit(pattern[i + 2]))
					{
						errorMessage = "Invalid pattern.";
						return false;
					}

					var num = 0;
					i += 2;

					while (i < pattern.Length && Char.IsDigit(pattern[i]))
					{
						num *= 10;
						num += pattern[i] - '0';
						++i;
					}

					if (i >= pattern.Length || pattern[i] != '}')
					{
						errorMessage = "Invalid pattern.";
						return false;
					}

					if (!match.Success)
					{
						errorMessage = String.Empty;
						return false;
					}

					if (num >= match.Groups.Count)
					{
						errorMessage = $"No group captured for ${{{num}}}.";
						return false;
					}

					builder.Append(match.Groups[num].Value);
				}
				else
					builder.Append(pattern[i]);

			value = builder.ToString();
			errorMessage = String.Empty;
			return true;
		}
	}
}
