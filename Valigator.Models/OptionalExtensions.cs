using Functional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Valigator
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class OptionalExtensions
	{
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
		internal static bool TryGetValue<TValue>(this Optional<TValue> option, out TValue value)
		{
			var result = option.Match(static o => (exists: true, value: o), static () => (false, default));

			value = result.value;
			return result.exists;
		}
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.

		public static Option<TValue> ToOption<TValue>(this Optional<TValue> optional)
			=> optional
				.TryGetValue(out var value)
				? Option.Some(value)
				: Option.None<TValue>();
	}
}
