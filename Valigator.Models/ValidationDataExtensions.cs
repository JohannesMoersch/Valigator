using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Valigator.Core;
using Valigator.ValidationData;

namespace Valigator
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ValidationDataExtensions
	{
		internal static ValidationData<ModelValue<TModel, TValue>> WithValidator<TModel, TValue>(this ValidationData<ModelValue<TModel, TValue>> data, IValidator<TValue> validator)
			=> data.WithValidator(new ValueValidatorToValidatorAdapter<TModel, TValue>(validator));

		internal static ValidationData<ModelValue<TModel, TValue>> WithValidator<TModel, TValue>(this ValidationData<ModelValue<TModel, TValue>> data, IModelValidator<TModel, TValue> validator)
			=> data.WithValidator(new ModelValidatorToValidatorAdapter<TModel, TValue>(validator));

		public static Data<TValue> ToData<TValue>(this ValidationDataBase<TValue> data)
			=> data;
	}
}
