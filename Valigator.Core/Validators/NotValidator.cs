using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Validators
{
	public class NotValidator<TValue> : IValidator<TValue>
	{
		private readonly IInvertableValidator<TValue> _validator;

		public NotValidator(IInvertableValidator<TValue> validator) 
			=> _validator = validator;

		public Result<Unit, ValidationError[]> Validate(TValue value)
			=> _validator.InverseValidate(value);
	}
}
