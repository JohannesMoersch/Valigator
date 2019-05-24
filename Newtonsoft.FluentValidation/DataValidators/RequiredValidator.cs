using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation.DataValidators
{
	public struct RequiredValidator<TValue> : IPrimaryValidator<TValue>
	{
		public Result<Option<TValue>, ValidationError> Validate(bool isSet, Option<TValue> value)
			=> Result.Create(isSet, value, new ValidationError("A value must be explicitly provided."));

		public static implicit operator Data<TValue>(RequiredValidator<TValue> dataValidator)
			=> new Data<TValue>(dataValidator);
	}
}
