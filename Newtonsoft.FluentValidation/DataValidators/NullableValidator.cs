using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation.DataValidators
{
	public struct NullableValidator<TStateValidator, TValue> : IStateValidator<Option<TValue>>
		where TStateValidator : IStateValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;

		public NullableValidator(TStateValidator stateValidator) 
			=> _stateValidator = stateValidator;

		public Result<Option<TValue>, ValidationError> Validate(bool isSet, Option<TValue> value) 
			=> throw new NotImplementedException();

		public static implicit operator Data<Option<TValue>>(NullableValidator<TStateValidator, TValue> dataValidator)
			=> new Data<Option<TValue>>(null);
	}
}
