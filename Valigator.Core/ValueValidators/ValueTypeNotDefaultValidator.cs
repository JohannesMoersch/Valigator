using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.ValueValidators
{
	public struct ValueTypeNotDefaultValidator<TStateValidator, TValue> : IValueValidator<TValue>
		where TStateValidator : IDataSource<TValue>
		where TValue : struct
	{
		private readonly TStateValidator _stateValidator;

		public ValueTypeNotDefaultValidator(TStateValidator stateValidator) 
			=> _stateValidator = stateValidator;

		public Result<Unit, ValidationError> Validate(TValue value)
			=> Result.Create(!value.Equals(default(TValue)), () => Unit.Value, () => new ValidationError("Value must not be default."));

		public static implicit operator Data<TValue>(ValueTypeNotDefaultValidator<TStateValidator, TValue> valueValidator)
			=> new Data<TValue>(new DataValidator<TStateValidator, ValueTypeNotDefaultValidator<TStateValidator, TValue>, TValue>(valueValidator._stateValidator, valueValidator));
	}
}
