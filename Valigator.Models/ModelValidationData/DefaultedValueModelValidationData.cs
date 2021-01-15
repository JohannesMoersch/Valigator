using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class DefaultedValueModelValidationData<TModel, TValue> : IModelPropertyData<TModel, TValue, TValue>, IRootModelValidationData<DefaultedValueModelValidationData<TModel, TValue>, TModel, TValue>
	{
		private readonly TValue _defaultValue;

		private readonly ValidationData<ModelValue<TModel, TValue>> _validationData;

		public DefaultedValueModelValidationData(TValue defaultValue, ValidationData<ModelValue<TModel, TValue>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedValueModelValidationData<TModel, TValue> WithValidator(IValidator<TValue> value)
			=> new DefaultedValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedValueModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new DefaultedValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedValueModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, TValue> value)
			=> new DefaultedValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedValueModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> new DefaultedValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<TValue, ValidationError[]> CoerceUnset()
			=> Result.Success<TValue, ValidationError[]>(_defaultValue);

		public Result<TValue, ValidationError[]> CoerceNone()
			=> Result.Failure<TValue, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<TValue, ValidationError[]> CoerceValue(TValue value)
			=> Result.Success<TValue, ValidationError[]>(value);

		public Result<Unit, ValidationError[]> Validate(TModel model, TValue value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
