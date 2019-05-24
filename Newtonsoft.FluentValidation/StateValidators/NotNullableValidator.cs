using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.FluentValidation.ValueValidators;

namespace Newtonsoft.FluentValidation.StateValidators
{
	public struct NotNullableValidator<TStateValidator, TValue> : IStateValidator<TValue>
		where TStateValidator : IStateValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;

		public NotNullableValidator(TStateValidator stateValidator)
			=> _stateValidator = stateValidator;

		public Result<TValue, ValidationError> Validate(object model, bool isSet, TValue value)
		{
			var stateValidator = _stateValidator;
			return Result
				.Create(!isSet || value != null, () => stateValidator, () => new ValidationError("Value cannot be null."))
				.Match
				(
					validator => validator.Validate(model, isSet, value),
					Result.Failure<TValue, ValidationError>
				);
		}

		public static implicit operator Data<TValue>(NotNullableValidator<TStateValidator, TValue> stateValidator)
			=> new Data<TValue>(new DataValidator<NotNullableValidator<TStateValidator, TValue>, PassthroughValidator<TValue>, TValue>(stateValidator, default));
	}
}
