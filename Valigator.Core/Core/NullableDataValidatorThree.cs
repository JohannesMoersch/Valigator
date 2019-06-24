using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
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

		private readonly Func<TSource, TValue> _mapper;

		public NullableDataValidator(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree, Func<TSource, TValue> mapper)
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

				var mappedValue = _mapper.Invoke(some);

				var oneValid = _valueValidatorOne.IsValid(mappedValue);
				var twoValid = _valueValidatorTwo.IsValid(mappedValue);
				var threeValid = _valueValidatorThree.IsValid(mappedValue);

				IEnumerable<ValidationError> errors = null;
				if (!oneValid || !twoValid || !threeValid)
					errors = new[] { !oneValid ? _valueValidatorOne.GetError(mappedValue, false) : null, !twoValid ? _valueValidatorTwo.GetError(mappedValue, false) : null, !threeValid ? _valueValidatorThree.GetError(mappedValue, false) : null }.OfType<ValidationError>();

				if (Model<TSource>.Verify(some).TryGetValue(out var _, out var modelErrors))
					return errors == null ? Result.Success<Option<TSource>, ValidationError[]>(success) : Result.Failure<Option<TSource>, ValidationError[]>(errors.ToArray());

				return Result.Failure<Option<TSource>, ValidationError[]>(modelErrors.Concat(errors ?? Enumerable.Empty<ValidationError>()).ToArray());
			}

			return Result.Failure<Option<TSource>, ValidationError[]>(failure);
		}

		public Option<ValidationError[]> GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
