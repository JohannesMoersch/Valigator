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
				if (!_valueValidatorOne.IsValid(success))
					return Result.Failure<TValue, ValidationError[]>(new[] { _valueValidatorOne.GetError(success, false) });

				if (!_valueValidatorTwo.IsValid(success))
					return Result.Failure<TValue, ValidationError[]>(new[] { _valueValidatorTwo.GetError(success, false) });

				return Model<TValue>
					.Verify(success)
					.Select(_ => success);
			}

			return Result.Failure<TValue, ValidationError[]>(failure);
		}

		public Option<ValidationError[]> GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
