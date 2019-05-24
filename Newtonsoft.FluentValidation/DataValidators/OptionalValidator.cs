using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation.DataValidators
{
	public class OptionalValidator<TValue> : IDataValidator<Option<TValue>>
	{
		public Result<Unit, ValidationError> Validate(bool isSet, Option<TValue> value)
			=> Result.Unit<ValidationError>();

		public static implicit operator Data<TValue>(OptionalValidator<TValue> dataValidator)
			=> new Data<TValue>(dataValidator);
	}
}
