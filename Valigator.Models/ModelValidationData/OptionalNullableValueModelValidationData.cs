using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalNullableValueModelValidationData<TModel, TValue> : IModelPropertyData<TModel, TValue, Optional<Option<TValue>>>, IRootModelValidationData<OptionalNullableValueModelValidationData<TModel, TValue>, TModel, TValue>
	{
		private readonly ValidationData<ModelValue<TModel, TValue>> _validationData;

		public OptionalNullableValueModelValidationData(ValidationData<ModelValue<TModel, TValue>> validationData)
			=> _validationData = validationData;

		public OptionalNullableValueModelValidationData<TModel, TValue> WithValidator(IValidator<TValue> value)
			=> new OptionalNullableValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalNullableValueModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new OptionalNullableValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalNullableValueModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, TValue> value)
			=> new OptionalNullableValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalNullableValueModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> new OptionalNullableValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public Result<Optional<Option<TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<Option<TValue>>, ValidationError[]>(Optional.Unset<Option<TValue>>());

		public Result<Optional<Option<TValue>>, ValidationError[]> CoerceNone()
			=> Result.Success<Optional<Option<TValue>>, ValidationError[]>(Optional.Set(Option.None<TValue>()));

		public Result<Optional<Option<TValue>>, ValidationError[]> CoerceValue(TValue value)
			=> Result.Success<Optional<Option<TValue>>, ValidationError[]>(Optional.Set(Option.Some(value)));

		public Result<Unit, ValidationError[]> Validate(TModel model, Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return _validationData.Process(ModelValue.Create(model, item));
			}

			return Result.Unit<ValidationError[]>();
		}

		public static ModelDefinition<TModel>.Property<Optional<Option<TValue>>> ToProperty(OptionalNullableValueModelValidationData<TModel, TValue> data)
			=> new ModelDefinition<TModel>.Property<Optional<Option<TValue>>>(data);

		public static implicit operator ModelDefinition<TModel>.Property<Optional<Option<TValue>>>(OptionalNullableValueModelValidationData<TModel, TValue> data)
			=> ToProperty(data);
	}
}
