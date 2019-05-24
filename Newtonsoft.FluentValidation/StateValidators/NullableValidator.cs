using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.FluentValidation.ValueValidators;

namespace Newtonsoft.FluentValidation.StateValidators
{
	public struct NullableValidator<TStateValidator, TValue> : IStateValidator<Option<TValue>>
		where TStateValidator : IStateValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;

		public NullableValidator(TStateValidator stateValidator) 
			=> _stateValidator = stateValidator;

		public Result<Option<TValue>, ValidationError> Validate(object model, bool isSet, Option<TValue> value)
			=> _stateValidator
				.Validate(model, isSet, value.Match(_ => _, () => default))
				.Match
				(
					success => Result.Success<Option<TValue>, ValidationError>(Option.Some(success)),
					Result.Failure<Option<TValue>, ValidationError>
				);

		public static implicit operator Data<Option<TValue>>(NullableValidator<TStateValidator, TValue> stateValidator)
			=> new Data<Option<TValue>>(new DataValidator<NullableValidator<TStateValidator, TValue>, PassthroughValidator<Option<TValue>>, Option<TValue>>(stateValidator, default));
	}
}
