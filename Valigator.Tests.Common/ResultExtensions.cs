using System;
using Functional;

namespace Valigator
{
	public static class ResultExtensions
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

		public static TSuccess AssertSuccess<TSuccess, TFailure>(this Result<TSuccess, TFailure> result)
			=> result
				.TryGetValue(out var success, out var _)
				? success
				: throw new Exception("Expected success but found failure.");

		public static TFailure AssertFailure<TSuccess, TFailure>(this Result<TSuccess, TFailure> result)
			=> result
				.TryGetValue(out var _, out var failure)
				? throw new Exception("Expected failure but found success.")
				: failure;
	}
}
