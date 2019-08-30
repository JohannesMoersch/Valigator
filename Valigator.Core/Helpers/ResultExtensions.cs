using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.Helpers
{
	internal static class ResultExtensions
	{
		private class DelegateCache<T>
		{
			public static readonly Func<T, bool> True = _ => true;
			public static readonly Func<T, bool> False = _ => false;
			public static readonly Func<T, T> Passthrough = _ => _;
		}

		private class DelegateCache<TIn, TOut>
		{
			public static readonly Func<TIn, TOut> Default = _ => default;
		}

		public static bool TryGetValue<TSuccess, TFailure>(this Result<TSuccess, TFailure> result, out TSuccess success, out TFailure failure)
		{
			if (result.Match(DelegateCache<TSuccess>.True, DelegateCache<TFailure>.False))
			{
				success = result.Match(DelegateCache<TSuccess>.Passthrough, DelegateCache<TFailure, TSuccess>.Default);
				failure = default;
				return true;
			}

			success = default;
			failure = result.Match(DelegateCache<TSuccess, TFailure>.Default, DelegateCache<TFailure>.Passthrough);
			return false;
		}

		public static Result<TResult, TFailure> Select<TSuccess, TResult, TFailure>(this Result<TSuccess, TFailure> result, Func<TSuccess, TResult> resultSelector)
			=> result.TryGetValue(out var success, out var failure)
				? Result.Success<TResult, TFailure>(resultSelector.Invoke(success))
				: Result.Failure<TResult, TFailure>(failure);
	}
}
