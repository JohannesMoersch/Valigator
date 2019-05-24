using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation.DataValidators
{
	public class OptionalWithDefaultValidator<TValue> : IStateValidator<TValue>
	{
		private readonly TValue _defaultValue;

		public OptionalWithDefaultValidator(TValue defaultValue) 
			=> _defaultValue = defaultValue;

		public Result<TValue, ValidationError> Validate(bool isSet, TValue value)
		{
			if (!isSet)
				return Result.Success<TValue, ValidationError>(_defaultValue);

			return Result.Create(value != null, () => value, () => new ValidationError("Value cannot be null."));
		}

		public static implicit operator Data<TValue>(OptionalWithDefaultValidator<TValue> dataValidator)
			=> new Data<TValue>(null);
	}
}
