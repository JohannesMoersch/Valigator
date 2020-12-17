using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public class ValueValidatorToValidatorAdapter<TModel, TValue> : IValidator<ModelValue<TModel, TValue>>
	{
		private readonly IValidator<TValue> _validator;

		public ValueValidatorToValidatorAdapter(IValidator<TValue> validator) 
			=> _validator = validator;

		public Result<Unit, ValidationError[]> Validate(ModelValue<TModel, TValue> value)
			=> _validator.Validate(value.Value);
	}
}
