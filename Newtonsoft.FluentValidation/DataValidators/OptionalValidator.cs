using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation.DataValidators
{
	public class OptionalValidator<TValue> : IStateValidator<Option<TValue>>
	{
		public Result<Option<TValue>, ValidationError> Validate(bool isSet, Option<TValue> value) 
			=> throw new NotImplementedException();

		public static implicit operator Data<Option<TValue>>(OptionalValidator<TValue> dataValidator)
			=> new Data<Option<TValue>>(null);
	}
}
