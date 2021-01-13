using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Valigator.Core;
using Valigator.Validators;

namespace Valigator
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ModelValidatorValidationDataExtensions
	{
		public static IValidator<TValue> Not<TModel, TValue>(this ModelValidatorValidationData<TModel, TValue> data, Func<InvertableModelValidatorValidationData<TModel, TValue>, NotValidator<TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableModelValidatorValidationData<TModel, TValue>()));

		public static IModelValidator<TModel, TValue> Not<TModel, TValue>(this ModelValidatorValidationData<TModel, TValue> data, Func<InvertableModelValidatorValidationData<TModel, TValue>, NotModelValidator<TModel, TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableModelValidatorValidationData<TModel, TValue>()));
	}
}
