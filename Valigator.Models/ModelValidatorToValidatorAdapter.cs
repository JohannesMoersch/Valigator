using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public class ModelValidatorToValidatorAdapter<TModel, TValue> : IValidator<ModelValue<TModel, TValue>>
	{
		private readonly IModelValidator<TModel, TValue> _validator;

		public ModelValidatorToValidatorAdapter(IModelValidator<TModel, TValue> validator) 
			=> _validator = validator;

		public Result<Unit, ValidationError[]> Validate(ModelValue<TModel, TValue> value)
			=> _validator.Validate(value.Model, value.Value);
	}
}
