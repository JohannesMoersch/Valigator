using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Models.Generator.Tests
{
	public static class OptionExtensions
	{
		public static T AssertSome<T>(this Option<T> option)
			=> option
				.Match
				(
					o => o,
					() => throw new Exception("Expected some and found none.")
				);

		public static void AssertNone<T>(this Option<T> option)
			=> option
				.Apply
				(
					_ => throw new Exception("Expected none and found some."),
					() => { }
				);
	}
}
