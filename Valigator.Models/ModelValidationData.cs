using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public class ModelValidationData<TModel, TValue> : IValidationData<ModelValidationData<TModel, TValue>, TValue>, IInvertableValidationData<ModelValidationData<TModel, TValue>, TValue>, IModelValidationData<ModelValidationData<TModel, TValue>, TModel, TValue>, IInvertableModelValidationData<ModelValidationData<TModel, TValue>, TModel, TValue>
	{
		public ModelValidationData<TModel, TValue> WithValidator(IValidator<TValue> value)
			=> throw new NotImplementedException();

		public ModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<TValue> value)
			=> throw new NotImplementedException();

		public ModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, TValue> value)
			=> throw new NotImplementedException();

		public ModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> throw new NotImplementedException();
	}
}
