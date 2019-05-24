using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation.DataValidators
{
	public struct ValueTypeNotDefaultValidator<TStateValidator, TValue> : IValueValidator<TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValue : struct
	{
		private readonly TStateValidator _stateValidator;

		public ValueTypeNotDefaultValidator(TStateValidator stateValidator) 
			=> _stateValidator = stateValidator;

		public Result<Unit, ValidationError> Validate(TValue value)
			=> Result.Create(!value.Equals(default(TValue)), () => Unit.Value, () => new ValidationError("Value must not be default."));
	}
}
