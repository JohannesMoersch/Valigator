using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Models.Generator.Tests
{
	public static class OptionalExtensions
	{
		public static T AssertSet<T>(this Optional<T> optional)
			=> optional
				.ToOption()
				.Match
				(
					o => o,
					() => throw new Exception("Expected some and found none.")
				);

		public static void AssertUnset<T>(this Optional<T> optional)
			=> optional
				.ToOption()
				.Apply
				(
					_ => throw new Exception("Expected none and found some."),
					() => { }
				);
	}
}
