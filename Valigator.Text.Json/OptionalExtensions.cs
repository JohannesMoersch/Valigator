using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Text.Json
{
	internal static class OptionalExtensions
	{
#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
		public static bool TryGetValue<TValue>(this Optional<TValue> option, out TValue value)
		{
			var result = option.Match(static o => (exists: true, value: o), static () => (false, default));

			value = result.value;
			return result.exists;
		}
#pragma warning restore CS8619 // Nullability of reference types in value doesn't match target type.
	}
}
