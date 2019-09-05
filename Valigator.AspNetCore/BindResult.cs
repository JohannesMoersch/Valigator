using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator
{
	public struct BindResult
	{
		private readonly Result<Option<Option<object>>, ValidationError[]> _result;

		private BindResult(Result<Option<Option<object>>, ValidationError[]> result)
			=> _result = result;

		public TValue Match<TValue>(Func<Option<object>, TValue> set, Func<TValue> notSet, Func<ValidationError[], TValue> failed)
			=> _result
				.Match
				(
					success => success.Match(set, notSet),
					failed
				);

		public static BindResult CreateSet(Option<object> value)
			=> new BindResult(Result.Success<Option<Option<object>>, ValidationError[]>(Option.Some(value)));

		public static BindResult CreateUnSet()
			=> new BindResult(Result.Success<Option<Option<object>>, ValidationError[]>(Option.None<Option<object>>()));

		public static BindResult CreateFailed(params ValidationError[] validationErrors)
			=> new BindResult(Result.Failure<Option<Option<object>>, ValidationError[]>(validationErrors));
	}
}
