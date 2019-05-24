using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.FluentValidation.ValueValidators;

namespace Newtonsoft.FluentValidation.StateValidators
{
	public class OptionalWithDefaultValidator<TValue> : IStateValidator<TValue>
	{
		private readonly TValue _defaultValue;

		public OptionalWithDefaultValidator(TValue defaultValue) 
			=> _defaultValue = defaultValue;

		public Result<TValue, ValidationError> Validate(object model, bool isSet, TValue value)
			=> Result.Success<TValue, ValidationError>(isSet ? value : _defaultValue);

		public static implicit operator Data<TValue>(OptionalWithDefaultValidator<TValue> stateValidator)
			=> new Data<TValue>(new DataValidator<NotNullableValidator<OptionalWithDefaultValidator<TValue>, TValue>, PassthroughValidator<TValue>, TValue>(new NotNullableValidator<OptionalWithDefaultValidator<TValue>, TValue>(stateValidator), default));
	}
}
