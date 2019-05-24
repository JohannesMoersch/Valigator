using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation.ValueValidators
{
	public struct PassthroughValidator<TValue> : IValueValidator<TValue>
	{
		public Result<Unit, ValidationError> Validate(TValue value)
			=> Result.Unit<ValidationError>();
	}
}
