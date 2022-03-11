using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class DefaultedValueModelValidationData<TModel, TValue> : ModelValidationDataBase<TModel, TValue>, IModelPropertyData<TModel, TValue, TValue>, IRootModelValidationData<DefaultedValueModelValidationData<TModel, TValue>, TModel, TValue>
	{
		private readonly Func<TValue> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, TValue>> _validationData;

		public DefaultedValueModelValidationData(Func<TValue> defaultValue, ValidationData<ModelValue<TModel, TValue>> validationData)
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

		public override Result<TValue, CoercionValidationError[]> CoerceUnset()
			=> Result.Success<TValue, CoercionValidationError[]>(_defaultValue.Invoke());

		public override Result<TValue, CoercionValidationError[]> CoerceNone()
			=> Result.Failure<TValue, CoercionValidationError[]>(new[] { CoercionValidationErrors.NullValuesNotAllowed() });

		public Result<TValue, CoercionValidationError[]> CoerceValue(TValue value)
			=> Result.Success<TValue, CoercionValidationError[]>(value);

		public override Result<Unit, ValidationError[]> Validate(TModel model, TValue value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
