using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	public static class OptionExtensions
	{
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
		public static bool TryGetValue<TValue>(this Option<TValue> option, out TValue value)
		{
			var result = option.Match(static o => (exists: true, value: o), static () => (false, default));

			value = result.value;
			return result.exists;
		}
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.

		public static TValue AssertSome<TValue>(this Option<TValue> option)
			=> option
				.TryGetValue(out var some)
				? some
				: throw new Exception("Expected some but found none.");

		public static void AssertNone<TValue>(this Option<TValue> option)
		{
			if (option.TryGetValue(out var _))
				throw new Exception("Expected none but found some.");
		}
	}
}
