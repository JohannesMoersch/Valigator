using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	public static class OptionalExtensions
	{
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
		public static bool TryGetValue<TValue>(this Optional<TValue> optional, out TValue value)
		{
			var result = optional.Match(static o => (exists: true, value: o), static () => (false, default));

			value = result.value;
			return result.exists;
		}
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.

		public static TValue AssertSet<TValue>(this Optional<TValue> optional)
			=> optional
				.TryGetValue(out var set)
				? set
				: throw new Exception("Expected set but found unset.");

		public static void AssertUnset<TValue>(this Optional<TValue> optional)
		{
			if (optional.TryGetValue(out var _))
				throw new Exception("Expected unset but found set.");
		}
	}
}
