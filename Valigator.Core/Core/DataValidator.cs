using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core
{
	public class DataValidator<TStateValidator, TValueValidator, TValue> : IDataValidator<TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValueValidator : IValueValidator<TValue>
	{
		public DataDescriptor DataDescriptor => new DataDescriptor(typeof(TValue), _stateValidator.GetDescriptor(), _valueValidator.GetDescriptors());

		private readonly TStateValidator _stateValidator;

		private readonly TValueValidator _valueValidator;

		public DataValidator(TStateValidator stateValidator, TValueValidator valueValidator)
		{
			_stateValidator = stateValidator;
			_valueValidator = valueValidator;
		}

		public Result<TValue, ValidationError> Validate(object model, bool isSet, TValue value)
		{
			if (_stateValidator.Validate(model, isSet, value).TryGetValue(out var success, out var failure))
			{
				if (_valueValidator.Validate(success).TryGetValue(out var _, out var error))
					return Result.Success<TValue, ValidationError>(success);

				return Result.Failure<TValue, ValidationError>(error);
			}

			return Result.Failure<TValue, ValidationError>(failure);
		}
	}
}
