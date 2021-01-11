using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public class ModelValidatorValidationData<TModel, TValue> : IValidationData<IValidator<TValue>, TValue>, IInvertableValidationData<IValidator<TValue>, TValue>, IModelValidationData<IModelValidator<TModel, TValue>, TModel, TValue>, IInvertableModelValidationData<IModelValidator<TModel, TValue>, TModel, TValue>
	{
		public IValidator<TValue> WithValidator(IValidator<TValue> value)
			=> value;

		public IValidator<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> value;

		public IModelValidator<TModel, TValue> WithValidator(IModelValidator<TModel, TValue> value)
			=> value;

		public IModelValidator<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> value;
	}
}
