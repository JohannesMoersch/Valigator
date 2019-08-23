using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core
{
	internal static class ValidatorHelpers
	{
		public static Result<TInput, ValidationError[]> Validate<TInput, TSource, TValue>(TInput success, TSource some, Mapping<TSource, TValue> mapper)
			=> Validate(success, some, null, null, null, mapper);

		public static Result<TInput, ValidationError[]> Validate<TInput, TSource, TValue>(TInput success, TSource some, IValueValidator<TValue> valueValidatorOne, Mapping<TSource, TValue> mapper)
			=> Validate(success, some, valueValidatorOne, null, null, mapper);

		public static Result<TInput, ValidationError[]> Validate<TInput, TSource, TValue>(TInput success, TSource some, IValueValidator<TValue> valueValidatorOne, IValueValidator<TValue> valueValidatorTwo, Mapping<TSource, TValue> mapper)
			=> Validate(success, some, valueValidatorOne, valueValidatorTwo, null, mapper);

		public static Result<TInput, ValidationError[]> Validate<TInput, TSource, TValue>(TInput success, TSource some, IValueValidator<TValue> valueValidatorOne, IValueValidator<TValue> valueValidatorTwo, IValueValidator<TValue> valueValidatorThree, Mapping<TSource, TValue> mapper)
		{
			var (valueOption, error) = mapper.Map(some);

			ValidationError[] errors;
			if (valueOption.TryGetValue(out var mappedValue))
			{
				var oneValid = valueValidatorOne?.IsValid(mappedValue) ?? true;
				var twoValid = valueValidatorTwo?.IsValid(mappedValue) ?? true;
				var threeValid = valueValidatorThree?.IsValid(mappedValue) ?? true;

				errors = (!oneValid || !twoValid || !threeValid || error != null) ? new[] { !oneValid ? valueValidatorOne.GetError(mappedValue, false) : null, !twoValid ? valueValidatorTwo.GetError(mappedValue, false) : null, !threeValid ? valueValidatorThree.GetError(mappedValue, false) : null, error }.OfType<ValidationError>().ToArray() : null;
			}
			else
				errors = new[] { error };

			if (Model.Verify(some).TryGetValue(out var _, out var modelErrors))
				return errors == null ? Result.Success<TInput, ValidationError[]>(success) : Result.Failure<TInput, ValidationError[]>(errors);

			return Result.Failure<TInput, ValidationError[]>(modelErrors.Concat(errors ?? Enumerable.Empty<ValidationError>()).ToArray());
		}
	}
}
