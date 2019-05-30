using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.Helpers
{
	internal static class ResultExtensions
	{
		public static bool TryGetValue<TSuccess, TFailure>(this Result<TSuccess, TFailure> result, out TSuccess success, out TFailure failure)
		{
			if (result.Match(_ => true, _ => false))
			{
				success = result.Match(s => s, _ => default);
				failure = default;
				return true;
			}

			success = default;
			failure = result.Match(_ => default, f => f);
			return false;
		}

		public static Result<TResult, TFailure> Select<TSuccess, TResult, TFailure>(this Result<TSuccess, TFailure> result, Func<TSuccess, TResult> resultSelector)
			=> result.Match(success => Result.Success<TResult, TFailure>(resultSelector.Invoke(success)), Result.Failure<TResult, TFailure>);
	}
}
