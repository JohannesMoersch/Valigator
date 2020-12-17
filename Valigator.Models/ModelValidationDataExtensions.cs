using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Valigator.Core;
using Valigator.Models.ValidationData;

namespace Valigator.Models
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ModelValidationDataExtensions
	{
		public static RequiredValueModelValidationData<TModel, TValue> Not<TModel, TValue>(this RequiredValueModelValidationData<TModel, TValue> data, Func<InvertableModelValidatorValidationData<TModel, TValue>, IInvertableValidator<TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableModelValidatorValidationData<TModel, TValue>()));

		public static RequiredValueModelValidationData<TModel, TValue> Not<TModel, TValue>(this RequiredValueModelValidationData<TModel, TValue> data, Func<InvertableModelValidatorValidationData<TModel, TValue>, IInvertableModelValidator<TModel, TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableModelValidatorValidationData<TModel, TValue>()));
	}
}
