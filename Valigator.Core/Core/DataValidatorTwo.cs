using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public class DataValidator<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue> : IDataValidatorOrErrors<TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
	{
		public DataDescriptor DataDescriptor => new DataDescriptor(typeof(TValue), _stateValidator.GetDescriptor(), _stateValidator.GetImplicitValueDescriptors().Concat(new[] { _valueValidatorOne.GetDescriptor(), _valueValidatorTwo.GetDescriptor() }).ToArray());

		private readonly TStateValidator _stateValidator;

		private readonly TValueValidatorOne _valueValidatorOne;

		private readonly TValueValidatorTwo _valueValidatorTwo;

		public DataValidator(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
		}

		public Result<TValue, ValidationError[]> Validate(object model, bool isSet, TValue value)
		{
			if (_stateValidator.Validate(model, isSet, value).TryGetValue(out var success, out var failure))
			{
				var oneValid = _valueValidatorOne.IsValid(success);
				var twoValid = _valueValidatorTwo.IsValid(success);

				IEnumerable<ValidationError> errors = null;
				if (!oneValid || !twoValid)
					errors = new[] { !oneValid ? _valueValidatorOne.GetError(success, false) : null, !twoValid ? _valueValidatorTwo.GetError(success, false) : null }.OfType<ValidationError>();

				if (Model<TValue>.Verify(success).TryGetValue(out var _, out var modelErrors))
					return errors == null ? Result.Success<TValue, ValidationError[]>(success) : Result.Failure<TValue, ValidationError[]>(errors.ToArray());

				return Result.Failure<TValue, ValidationError[]>(modelErrors.Concat(errors ?? Enumerable.Empty<ValidationError>()).ToArray());
			}

			return Result.Failure<TValue, ValidationError[]>(failure);
		}

		public Option<ValidationError[]> GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
