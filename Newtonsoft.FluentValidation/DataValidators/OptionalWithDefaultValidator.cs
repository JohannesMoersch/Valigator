using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation.DataValidators
{
	public class OptionalWithDefaultValidator<TValue> : IDataValidator<TValue>
	{
		public Result<Unit, ValidationError> Validate(bool isSet, Option<TValue> value)
			=> Result.Unit<ValidationError>();

		public static implicit operator Data<TValue>(OptionalWithDefaultValidator<TValue> dataValidator)
			=> new Data<TValue>(dataValidator);
	}
}
