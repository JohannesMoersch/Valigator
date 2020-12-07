using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public class ModelValidationData<TModel, TInput, TValue> : IValidationData<ModelValidationData<TModel, TInput, TValue>, TInput, TValue>, IInvertableValidationData<ModelValidationData<TModel, TInput, TValue>, TInput, TValue>, IModelValidationData<ModelValidationData<TModel, TInput, TValue>, TModel, TInput, TValue>, IInvertableModelValidationData<ModelValidationData<TModel, TInput, TValue>, TModel, TInput, TValue>
	{
		public ModelValidationData<TModel, TInput, TValue> WithValidator(IValidator<TValue> value) 
			=> throw new NotImplementedException();

		public ModelValidationData<TModel, TInput, TValue> WithValidator(IInvertableValidator<TValue> value)
			=> throw new NotImplementedException();

		public ModelValidationData<TModel, TInput, TValue> WithValidator(IModelValidator<TModel, TValue> value) 
			=> throw new NotImplementedException();

		public ModelValidationData<TModel, TInput, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value) 
			=> throw new NotImplementedException();
	}
}
