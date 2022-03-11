using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class DefaultedNullableValueModelValidationData<TModel, TValue> : ModelValidationDataBase<TModel, Option<TValue>>, IModelPropertyData<TModel, TValue, Option<TValue>>, IRootModelValidationData<DefaultedNullableValueModelValidationData<TModel, TValue>, TModel, TValue>
	{
		private readonly Func<Option<TValue>> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, TValue>> _validationData;

		public DefaultedNullableValueModelValidationData(Func<Option<TValue>> defaultValue, ValidationData<ModelValue<TModel, TValue>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableValueModelValidationData<TModel, TValue> WithValidator(IValidator<TValue> value)
			=> new DefaultedNullableValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableValueModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new DefaultedNullableValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableValueModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, TValue> value)
			=> new DefaultedNullableValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableValueModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> new DefaultedNullableValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public override Result<Option<TValue>, CoercionValidationError[]> CoerceUnset()
			=> Result.Success<Option<TValue>, CoercionValidationError[]>(_defaultValue.Invoke());

		public override Result<Option<TValue>, CoercionValidationError[]> CoerceNone()
			=> Result.Success<Option<TValue>, CoercionValidationError[]>(Option.None<TValue>());

		public Result<Option<TValue>, CoercionValidationError[]> CoerceValue(TValue value)
			=> Result.Success<Option<TValue>, CoercionValidationError[]>(Option.Some(value));

		public override Result<Unit, ValidationError[]> Validate(TModel model, Option<TValue> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
