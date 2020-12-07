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
		public static ModelValidationData<TModel, TValue> Not<TModel, TValue>(this ModelValidationData<TModel, TValue> data, Func<InvertableModelValidatorValidationData<TModel, TValue>, IInvertableValidator<TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableModelValidatorValidationData<TModel, TValue>()));

		public static ModelValidationData<TModel, TValue> Not<TModel, TValue>(this ModelValidationData<TModel, TValue> data, Func<InvertableModelValidatorValidationData<TModel, TValue>, IInvertableModelValidator<TModel, TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableModelValidatorValidationData<TModel, TValue>()));
	}
}
