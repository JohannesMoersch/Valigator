using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.Helpers;

namespace Valigator
{
	public static class OptionalExtensions
	{
		public static Option<TValue> ToOption<TValue>(this Optional<TValue> optional)
			=> optional
				.TryGetValue(out var some)
				? Option.Some(some)
				: Option.None<TValue>();

		public static TResult Match<TValue, TResult>(this Optional<Option<TValue>> optional, Func<TValue, TResult> onSome, Func<TResult> onNone, Func<TResult> onUnset)
		{
			if (optional.TryGetValue(out var set))
			{
				if (set.TryGetValue(out var some))
					return onSome.Invoke(some);

				return onNone.Invoke();
			}

			return onUnset.Invoke();
		}
	}
}
