using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	public static class OptionalExtensions
	{
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
		public static bool TryGetValue<TValue>(this Optional<TValue> Optional, out TValue value)
		{
			var result = Optional.Match(static o => (exists: true, value: o), static () => (false, default));

			value = result.value;
			return result.exists;
		}
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.

		public static TValue AssertSet<TValue>(this Optional<TValue> Optional)
			=> Optional
				.TryGetValue(out var some)
				? some
				: throw new Exception("Expected set but found unset.");

		public static void AssertUnset<TValue>(this Optional<TValue> Optional)
		{
			if (Optional.TryGetValue(out var _))
				throw new Exception("Expected unset but found set.");
		}
	}
}
