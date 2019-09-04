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
			=> new Mapping<TValue, TValue>(DelegateCache<TValue, ValidationError[]>.Success, Data.Required<TValue>());

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Result<TResult, ValidationError[]>> mapper)
			=> Create(mapper, Data.Required<TInput>());

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, TResult> mapper)
			=> Create(mapper, Data.Required<TInput>());

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Result<TResult, ValidationError[]>> mapper, Func<RequiredStateValidator<TInput>, Data<TInput>> sourceValidations)
			=> Create(mapper, sourceValidations.Invoke(Data.Required<TInput>()));

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, TResult> mapper, Func<RequiredStateValidator<TInput>, Data<TInput>> sourceValidations)
			=> Create(mapper, sourceValidations.Invoke(Data.Required<TInput>()));

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, TResult> mapper, Data<TInput> sourceValidations)
			=> new Mapping<TInput, TResult>(mapper, sourceValidations);

		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, Result<TResult, ValidationError[]>> mapper, Data<TInput> sourceValidations)
			=> new Mapping<TInput, TResult>(mapper, sourceValidations);
	}

	public struct Mapping<TSource, TValue>
	{
		private readonly object _mapper;

		private readonly Data<TSource> _sourceValidations;

		internal Mapping(Func<TSource, TValue> mapper, Data<TSource> sourceValidations)
		{
			_mapper = mapper;
			_sourceValidations = sourceValidations;
		}

		internal Mapping(Func<TSource, Result<TValue, ValidationError[]>> mapper, Data<TSource> sourceValidations)
		{
			_mapper = mapper;
			_sourceValidations = sourceValidations;
		}

		public Result<TValue, ValidationError[]> Map(TSource input)
		{
			var verifiedInput = _sourceValidations
				.WithValue(Option.Some(input))
				.Verify(Option.None<TSource>())
				.TryGetValue();

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
