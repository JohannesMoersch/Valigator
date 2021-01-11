using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Validators;

namespace Valigator.Core
{
	public class InvertableModelValidatorValidationData<TModel, TValue> : IInvertableModelValidationData<NotModelValidator<TModel, TValue>, TModel, TValue>, IInvertableValidationData<NotValidator<TValue>, TValue>
	{
		public NotValidator<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new NotValidator<TValue>(value);


		public NotModelValidator<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> new NotModelValidator<TModel, TValue>(value);
	}
}
