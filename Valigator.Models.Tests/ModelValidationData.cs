using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator;
using Valigator.Core;
using Valigator.ModelValidationData;

namespace Valigator.Models.Tests
{
	public class ModelValidationData<TModel, TValue> : IRootModelValidationData<ModelValidationData<TModel, TValue>, TModel, TValue>
	{
		private readonly ValidationData<ModelValue<TModel, TValue>> _validationData;

		public ModelValidationData()
			: this(new ValidationData<ModelValue<TModel, TValue>>())
		{
		}

		private ModelValidationData(ValidationData<ModelValue<TModel, TValue>> validationData)
			=> _validationData = validationData;

		public ModelValidationData<TModel, TValue> WithValidator(IValidator<TValue> value)
			=> new ModelValidationData<TModel, TValue>(_validationData.WithValidator(new ValueValidatorToValidatorAdapter<TModel, TValue>(value)));

		public ModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new ModelValidationData<TModel, TValue>(_validationData.WithValidator(new ValueValidatorToValidatorAdapter<TModel, TValue>(value)));

		public ModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, TValue> value)
			=> new ModelValidationData<TModel, TValue>(_validationData.WithValidator(new ModelValidatorToValidatorAdapter<TModel, TValue>(value)));

		public ModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> new ModelValidationData<TModel, TValue>(_validationData.WithValidator(new ModelValidatorToValidatorAdapter<TModel, TValue>(value)));

		public Result<Unit, ValidationError[]> Process(TModel model, TValue value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
