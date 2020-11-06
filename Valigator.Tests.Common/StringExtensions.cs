using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Tests.Common
{
	public static class StringExtensions
	{
		public static string RemoveWhiteSpace(this string str)
			=> str
				.Replace("\r", "")
				.Replace("\n", "")
				.Replace("\t", "")
				.Replace(" ", "");
	}
}
