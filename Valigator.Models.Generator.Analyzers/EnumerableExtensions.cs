using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models.Generator.Analyzers
{
	public static class EnumerableExtensions
	{
		public static bool TryGetFirst<T>(this IEnumerable<T> values, out T value)
			=> values.TryGetFirst(_ => true, out value);

		public static bool TryGetFirst<T>(this IEnumerable<T> values, Func<T, bool> predicate, out T value)
		{
			foreach (var item in values)
			{
				if (predicate.Invoke(item))
				{
					value = item;
					return true;
				}
			}

			value = default;
			return false;
		}
	}
}
