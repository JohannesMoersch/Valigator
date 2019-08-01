using Functional;
using System;
using Valigator.Core.Helpers;

namespace Valigator.Core
{
	public static class Mapping
	{
		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, TResult> mapper)
			=> new Mapping<TInput, TResult>(i => Result.Success<TResult, ValidationError>(mapper(i)), Option.None<TResult>());

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Result<TResult, ValidationError>> mapper, TResult defaultValue)
			=> new Mapping<TInput, TResult>(mapper, Option.Some(defaultValue));

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Result<TResult, ValidationError>> mapper)
			=> new Mapping<TInput, TResult>(mapper, Option.None<TResult>());
	}

	public struct Mapping<TSource, TValue>
	{
		private readonly Func<TSource, Result<TValue, ValidationError>> _mapper;
		private readonly Option<TValue> _defaultValue;

		public Mapping(Func<TSource, Result<TValue, ValidationError>> mapper, Option<TValue> defaultValue)
		{
			_mapper = mapper;
			_defaultValue = defaultValue;
		}

		public (Option<TValue> Value, ValidationError Error) Map(TSource input)
			=> _mapper
				.Invoke(input)
				.TryGetValue(out var s, out var f) 
					? (Option.Some(s), null) 
					: (_defaultValue, f);
	}
}
