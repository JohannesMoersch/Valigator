using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	internal static class ResultExtensions
	{
#pragma warning disable CS8619, CS8601  // Nullability of reference types in value doesn't match target type. Possible null reference assignment.
		public static bool TryGetValue<TSuccess, TFailure>(this Result<TSuccess, TFailure> option, out TSuccess success, out TFailure failure)
		{
			var result = option.Match(static o => (exists: true, success: o, failure: default(TFailure)), static o => (false, default, o));

			success = result.success;
			failure = result.failure;
			return result.exists;
		}
#pragma warning restore CS8619, CS8601 // Nullability of reference types in value doesn't match target type. Possible null reference assignment.
	}
}
