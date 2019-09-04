using Functional;
using System;
using Valigator.Core.Helpers;
using Valigator.Core.StateValidators;

namespace Valigator.Core
{
	public static class Mapping
	{
		private class DelegateCache<TValue, TError>
		{
			public static readonly Func<TValue, Result<TValue, TError>> Success = value => Result.Success<TValue, TError>(value);
		}

		public static Mapping<TValue, TValue> CreatePassthrough<TValue>()
			=> new Mapping<TValue, TValue>(DelegateCache<TValue, ValidationError[]>.Success, Option.None<Data<TValue>>());

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Result<TResult, ValidationError[]>> mapper)
			=> Create(mapper, Option.None<Data<TInput>>());

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, TResult> mapper)
			=> Create(mapper, Option.None<Data<TInput>>());

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Result<TResult, ValidationError[]>> mapper, Func<RequiredStateValidator<TInput>, Data<TInput>> sourceValidations)
			=> Create(mapper, Option.Some(sourceValidations.Invoke(Data.Required<TInput>())));

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, TResult> mapper, Func<RequiredStateValidator<TInput>, Data<TInput>> sourceValidations)
			=> Create(mapper, Option.Some(sourceValidations.Invoke(Data.Required<TInput>())));

		private static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, TResult> mapper, Option<Data<TInput>> sourceValidations)
			=> new Mapping<TInput, TResult>(mapper, sourceValidations);

		private static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Result<TResult, ValidationError[]>> mapper, Option<Data<TInput>> sourceValidations)
			=> new Mapping<TInput, TResult>(mapper, sourceValidations);
	}

	public struct Mapping<TSource, TValue>
	{
		private readonly object _mapper;

		private readonly Option<Data<TSource>> _sourceValidations;

		internal Mapping(Func<TSource, TValue> mapper, Option<Data<TSource>> sourceValidations)
		{
			_mapper = mapper;
			_sourceValidations = sourceValidations;
		}

		internal Mapping(Func<TSource, Result<TValue, ValidationError[]>> mapper, Option<Data<TSource>> sourceValidations)
		{
			_mapper = mapper;
			_sourceValidations = sourceValidations;
		}

		public Result<TValue, ValidationError[]> Map(TSource input)
		{
			Result<TSource, ValidationError[]> verifiedInput;
			if (_sourceValidations.TryGetValue(out var some))
			{
				verifiedInput = some
					.WithValue(Option.Some(input))
					.Verify(Option.None<TSource>())
					.TryGetValue();
			}
			else
				verifiedInput = Result.Success<TSource, ValidationError[]>(input);

			if (verifiedInput.TryGetValue(out var success, out var failure))
			{
				if (_mapper is Func<TSource, TValue> mapper)
					return Result.Success<TValue, ValidationError[]>(mapper.Invoke(success));

				if (_mapper is Func<TSource, Result<TValue, ValidationError[]>> mapperWithErrors)
				{
					if (mapperWithErrors.Invoke(success).TryGetValue(out var s, out var f))
						return Result.Success<TValue, ValidationError[]>(s);

					return Result.Failure<TValue, ValidationError[]>(f);
				}

				return Result.Failure<TValue, ValidationError[]>(Array.Empty<ValidationError>());
			}

			return Result.Failure<TValue, ValidationError[]>(failure);
		}
	}
}
