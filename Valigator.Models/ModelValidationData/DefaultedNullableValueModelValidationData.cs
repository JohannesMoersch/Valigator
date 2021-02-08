using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class DefaultedNullableValueModelValidationData<TModel, TValue> : IModelPropertyData<TModel, TValue, Option<TValue>>, IRootModelValidationData<DefaultedNullableValueModelValidationData<TModel, TValue>, TModel, TValue>
	{
		private readonly Option<TValue> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, TValue>> _validationData;

		public DefaultedNullableValueModelValidationData(Option<TValue> defaultValue, ValidationData<ModelValue<TModel, TValue>> validationData)
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

		public Result<Option<TValue>, ValidationError[]> CoerceUnset()
			=> Result.Success<Option<TValue>, ValidationError[]>(_defaultValue);

		public Result<Option<TValue>, ValidationError[]> CoerceNone()
			=> Result.Success<Option<TValue>, ValidationError[]>(Option.None<TValue>());

		public Result<Option<TValue>, ValidationError[]> CoerceValue(TValue value)
			=> Result.Success<Option<TValue>, ValidationError[]>(Option.Some(value));

		public Result<Unit, ValidationError[]> Validate(TModel model, Option<TValue> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}

		public static ModelDefinition<TModel>.Property<Option<TValue>> ToProperty(DefaultedNullableValueModelValidationData<TModel, TValue> data)
			=> new ModelDefinition<TModel>.Property<Option<TValue>>(data);

		public static implicit operator ModelDefinition<TModel>.Property<Option<TValue>>(DefaultedNullableValueModelValidationData<TModel, TValue> data)
			=> ToProperty(data);
	}
}
