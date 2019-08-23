using Functional;
using System;
using Valigator.Core.Helpers;

namespace Valigator.Core
{
	public static class Mapping
	{
		public static Mapping<TInput, TResult> Create<TInput, TResult>(Func<TInput, TResult> mapper, Data<TInput> sourceValidations)
			=> new Mapping<TInput, TResult>(i => Result.Success<TResult, ValidationError>(mapper(i)), sourceValidations);
	}

	public struct Mapping<TSource, TValue>
	{
		private readonly Func<TSource, Result<TValue, ValidationError>> _mapper;
		private readonly Data<TSource> _sourceValidations;

		internal Mapping(Func<TSource, Result<TValue, ValidationError>> mapper, Data<TSource> sourceValidations)
		{
			_mapper = mapper;
			_sourceValidations = sourceValidations;
		}

		public Result<TValue, ValidationError[]> Map(object model, TSource input)
		{
			var verifiedInput = _sourceValidations.WithValue(input).Verify(model).TryGetValue();

			if (verifiedInput.TryGetValue(out var success, out var failure))
			{
				if (_mapper.Invoke(success).TryGetValue(out var s, out var f))
					return Result.Success<TValue, ValidationError[]>(s);

				return Result.Failure<TValue, ValidationError[]>(new[] { f });
			}

			return Result.Failure<TValue, ValidationError[]>(failure);
		}
	}
}
