using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class RequiredNullableValueModelValidationData<TModel, TValue> : ModelValidationDataBase<TModel, Option<TValue>>, IModelPropertyData<TModel, TValue, Option<TValue>>, IRootModelValidationData<RequiredNullableValueModelValidationData<TModel, TValue>, TModel, TValue>
	{
		private readonly ValidationData<ModelValue<TModel, TValue>> _validationData;

		public RequiredNullableValueModelValidationData(ValidationData<ModelValue<TModel, TValue>> validationData)
			=> _validationData = validationData;

		public RequiredNullableValueModelValidationData<TModel, TValue> WithValidator(IValidator<TValue> value)
			=> new RequiredNullableValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableValueModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new RequiredNullableValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableValueModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, TValue> value)
			=> new RequiredNullableValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableValueModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> new RequiredNullableValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public override Result<Option<TValue>, CoercionValidationError[]> CoerceUnset()
			=> Result.Failure<Option<TValue>, CoercionValidationError[]>(new[] { CoercionValidationErrors.UnsetValuesNotAllowed() });

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
