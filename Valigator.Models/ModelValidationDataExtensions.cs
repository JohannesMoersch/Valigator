using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ModelValidationDataExtensions
	{
		public static ModelValidationData<TModel, TInput, TValue> Not<TModel, TInput, TValue>(this ModelValidationData<TModel, TInput, TValue> data, Func<InvertableModelValidatorValidationData<TModel, TInput, TValue>, IInvertableValidator<TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableModelValidatorValidationData<TModel, TInput, TValue>()));

		public static ModelValidationData<TModel, TInput, TValue> Not<TModel, TInput, TValue>(this ModelValidationData<TModel, TInput, TValue> data, Func<InvertableModelValidatorValidationData<TModel, TInput, TValue>, IInvertableModelValidator<TModel, TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableModelValidatorValidationData<TModel, TInput, TValue>()));
	}
}
