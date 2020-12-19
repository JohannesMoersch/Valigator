using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models
{
	internal static class OptionExtensions
	{
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
		public static bool TryGetValue<TValue>(this Option<TValue> option, out TValue value)
		{
			var result = option.Match(static o => (exists: true, value: o), static () => (false, default));

			value = result.value;
			return result.exists;
		}
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.

		public static Result<IReadOnlyList<TValue>, int[]> GetValuesOrNullIndices<TValue>(this IReadOnlyList<Option<TValue>> values)
		{
			var nullIndices = new List<int>();

			for (int i = 0; i < values.Count; ++i)
			{
				if (values[i].Match(static _ => false, static () => true))
					(nullIndices ??= new List<int>()).Add(i);
			}

			if (nullIndices != null)
				return Result.Failure<IReadOnlyList<TValue>, int[]>(nullIndices.ToArray());

			return Result.Success<IReadOnlyList<TValue>, int[]>(new OptionListWrapper<TValue>(values));
		}

		public static Result<IReadOnlyDictionary<TKey, TValue>, TKey[]> GetValuesOrNullIndices<TKey, TValue>(this IReadOnlyDictionary<TKey, Option<TValue>> values)
		{
			var nullIndices = new List<TKey>();

			foreach (var kvp in values)
			{
				if (kvp.Value.Match(static _ => false, static () => true))
					(nullIndices ??= new List<TKey>()).Add(kvp.Key);
			}

			if (nullIndices != null)
				return Result.Failure<IReadOnlyDictionary<TKey, TValue>, TKey[]>(nullIndices.ToArray());

			return Result.Success<IReadOnlyDictionary<TKey, TValue>, TKey[]>(new OptionDictionaryWrapper<TKey, TValue>(values));
		}
	}
}
