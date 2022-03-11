using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalNullableValueModelValidationData<TModel, TValue> : ModelValidationDataBase<TModel, Optional<Option<TValue>>>, IModelPropertyData<TModel, TValue, Optional<Option<TValue>>>, IRootModelValidationData<OptionalNullableValueModelValidationData<TModel, TValue>, TModel, TValue>
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

		public override Result<Optional<Option<TValue>>, CoercionValidationError[]> CoerceUnset()
			=> Result.Success<Optional<Option<TValue>>, CoercionValidationError[]>(Optional.Unset<Option<TValue>>());

		public override Result<Optional<Option<TValue>>, CoercionValidationError[]> CoerceNone()
			=> Result.Success<Optional<Option<TValue>>, CoercionValidationError[]>(Optional.Set(Option.None<TValue>()));

		public Result<Optional<Option<TValue>>, CoercionValidationError[]> CoerceValue(TValue value)
			=> Result.Success<Optional<Option<TValue>>, CoercionValidationError[]>(Optional.Set(Option.Some(value)));

		public override Result<Unit, ValidationError[]> Validate(TModel model, Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return _validationData.Process(ModelValue.Create(model, item));
			}

			return Result.Unit<ValidationError[]>();
		}
	}
}
