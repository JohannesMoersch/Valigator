using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	internal static class ValidationDataExtensions
	{
		public static ValidationData<ModelValue<TModel, TValue>> WithValidator<TModel, TValue>(this ValidationData<ModelValue<TModel, TValue>> data, IValidator<TValue> validator)
			=> data.WithValidator(new ValueValidatorToValidatorAdapter<TModel, TValue>(validator));

		public static ValidationData<ModelValue<TModel, TValue>> WithValidator<TModel, TValue>(this ValidationData<ModelValue<TModel, TValue>> data, IModelValidator<TModel, TValue> validator)
			=> data.WithValidator(new ModelValidatorToValidatorAdapter<TModel, TValue>(validator));
	}
}
