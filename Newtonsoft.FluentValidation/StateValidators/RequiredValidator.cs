using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.FluentValidation.ValueValidators;

namespace Newtonsoft.FluentValidation.StateValidators
{
	public struct RequiredValidator<TValue> : IStateValidator<TValue>
	{
		public Result<TValue, ValidationError> Validate(object model, bool isSet, TValue value)
			=> Result.Create(isSet, value, new ValidationError("A value must be explicitly provided."));

		public static implicit operator Data<TValue>(RequiredValidator<TValue> stateValidator)
			=> new Data<TValue>(new DataValidator<NotNullableValidator<RequiredValidator<TValue>, TValue>, PassthroughValidator<TValue>, TValue>(new NotNullableValidator<RequiredValidator<TValue>, TValue>(stateValidator), default));
	}
}
