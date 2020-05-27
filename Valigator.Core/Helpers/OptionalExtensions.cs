using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.Helpers
{
	internal static class OptionalExtensions
	{
		private class DelegateCache
		{
			public static readonly Func<bool> False = () => false;
		}

		private class DelegateCache<T>
		{
			public static readonly Func<T, bool> True = _ => true;
			public static readonly Func<T, T> Passthrough = _ => _;
			public static readonly Func<T> Default = () => default;
		}

		public static bool TryGetValue<TValue>(this Optional<TValue> option, out TValue value)
		{
			if (option.Match(DelegateCache<TValue>.True, DelegateCache.False))
			{
				value = option.Match(DelegateCache<TValue>.Passthrough, DelegateCache<TValue>.Default);
				return true;
			}

			value = default;
			return false;
		}
	}
}
