using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	internal static class ValidatorHelpers
	{
		public static Result<TInput, ValidationError[]> Validate<TInput, TSource, TValue>(TInput success, TSource some, IValueValidator<TValue> valueValidatorOne, Mapping<TSource, TValue> mapper)
			=> Validate(success, some, valueValidatorOne, null, null, mapper);

		public static Result<TInput, ValidationError[]> Validate<TInput, TSource, TValue>(TInput success, TSource some, IValueValidator<TValue> valueValidatorOne, IValueValidator<TValue> valueValidatorTwo, Mapping<TSource, TValue> mapper)
			=> Validate(success, some, valueValidatorOne, valueValidatorTwo, null, mapper);

		public static Result<TInput, ValidationError[]> Validate<TInput, TSource, TValue>(TInput success, TSource some, IValueValidator<TValue> valueValidatorOne, IValueValidator<TValue> valueValidatorTwo, IValueValidator<TValue> valueValidatorThree, Mapping<TSource, TValue> mapper)
		{
			var (valueOption, error) = mapper.Map(some);

			var errors = valueOption.Match(
				mappedValue =>
				{
					var oneValid = valueValidatorOne?.IsValid(mappedValue) ?? true;
					var twoValid = valueValidatorTwo?.IsValid(mappedValue) ?? true;
					var threeValid = valueValidatorThree?.IsValid(mappedValue) ?? true;

					return (!oneValid || !twoValid || !threeValid || error != null) ? new[] { !oneValid ? valueValidatorOne.GetError(mappedValue, false) : null, !twoValid ? valueValidatorTwo.GetError(mappedValue, false) : null, !threeValid ? valueValidatorThree.GetError(mappedValue, false) : null, error }.OfType<ValidationError>() : null;
				},
				() => new[] { error }
			);

			if (Model.Verify(some).TryGetValue(out var _, out var modelErrors))
				return errors == null ? Result.Success<TInput, ValidationError[]>(success) : Result.Failure<TInput, ValidationError[]>(errors.ToArray());

			return Result.Failure<TInput, ValidationError[]>(modelErrors.Concat(errors ?? Enumerable.Empty<ValidationError>()).ToArray());
		}
	}

	public class NullableDataValidator<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> : IDataValidatorOrErrors<Option<TSource>>
		where TStateValidator : IStateValidator<Option<TSource>>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
		where TValueValidatorThree : IValueValidator<TValue>
	{
		public DataDescriptor DataDescriptor => new DataDescriptor(typeof(TValue), _stateValidator.GetDescriptor(), _stateValidator.GetImplicitValueDescriptors().Concat(new[] { _valueValidatorOne.GetDescriptor(), _valueValidatorTwo.GetDescriptor(), _valueValidatorThree.GetDescriptor() }).ToArray());

		private readonly TStateValidator _stateValidator;

		private readonly TValueValidatorOne _valueValidatorOne;

		private readonly TValueValidatorTwo _valueValidatorTwo;

		private readonly TValueValidatorThree _valueValidatorThree;

		private readonly Mapping<TSource, TValue> _mapper;

		public NullableDataValidator(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree, Mapping<TSource, TValue> mapper)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
			_mapper = mapper;
		}

		public Result<Option<TSource>, ValidationError[]> Validate(object model, bool isSet, Option<TSource> value)
		{
			if (_stateValidator.Validate(model, isSet, value).TryGetValue(out var success, out var failure))
			{
				if (!success.TryGetValue(out var some))
					return Result.Success<Option<TSource>, ValidationError[]>(success);

				return ValidatorHelpers.Validate(success, some, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree, _mapper);
			}

			return Result.Failure<Option<TSource>, ValidationError[]>(failure);
		}

		public Option<ValidationError[]> GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
