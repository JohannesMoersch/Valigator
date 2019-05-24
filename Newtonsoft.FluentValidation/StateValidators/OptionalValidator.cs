using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.FluentValidation.ValueValidators;

namespace Newtonsoft.FluentValidation.StateValidators
{
	public class OptionalValidator<TValue> : IStateValidator<Option<TValue>>
	{
		public Result<Option<TValue>, ValidationError> Validate(object model, bool isSet, Option<TValue> value)
			=> Result.Success<Option<TValue>, ValidationError>(isSet ? value : Option.None<TValue>());

		public static implicit operator Data<Option<TValue>>(OptionalValidator<TValue> stateValidator)
			=> new Data<Option<TValue>>(new DataValidator<NotNullableValidator<OptionalValidator<TValue>, Option<TValue>>, PassthroughValidator<Option<TValue>>, Option<TValue>>(new NotNullableValidator<OptionalValidator<TValue>, Option<TValue>>(stateValidator), default));
	}
}
