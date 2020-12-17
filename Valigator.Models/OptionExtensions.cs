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

		public static Result<TValue[], int[]> GetValuesOrNullIndices<TValue>(this IReadOnlyList<Option<TValue>> values)
		{
			var newValues = new TValue[values.Count];
			var nullIndices = new List<int>();

			for (int i = 0; i < values.Count; ++i)
			{
				if (values[i].TryGetValue(out var value))
					newValues[i] = value;
				else
					(nullIndices ??= new List<int>()).Add(i);
			}

			if (nullIndices != null)
				return Result.Failure<TValue[], int[]>(nullIndices.ToArray());

			return Result.Success<TValue[], int[]>(newValues);
		}
	}
}
