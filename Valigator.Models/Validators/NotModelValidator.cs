using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Validators
{
	public class NotModelValidator<TModel, TValue> : IModelValidator<TModel, TValue>
	{
		private readonly IInvertableModelValidator<TModel, TValue> _validator;

		public NotModelValidator(IInvertableModelValidator<TModel, TValue> validator) 
			=> _validator = validator;

		public Result<Unit, ValidationError[]> Validate(TModel model, TValue value)
			=> _validator.InverseValidate(model, value);
	}
}
