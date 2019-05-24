using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation.DataValidators
{
	public struct RequiredValidator<TValue> : IStateValidator<TValue>
	{
		public Result<TValue, ValidationError> Validate(bool isSet, TValue value)
			=> Result.Create(isSet, value, new ValidationError("A value must be explicitly provided."));

		public static implicit operator Data<TValue>(RequiredValidator<TValue> dataValidator)
			=> new Data<TValue>(null);
	}
}
