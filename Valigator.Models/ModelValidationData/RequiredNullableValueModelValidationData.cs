using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class RequiredNullableValueModelValidationData<TModel, TValue> : IModelPropertyData<TModel, TValue, Option<TValue>>, IRootModelValidationData<RequiredNullableValueModelValidationData<TModel, TValue>, TModel, TValue>
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

		public Result<Option<TValue>, ValidationError[]> CoerceUnset()
			=> Result.Failure<Option<TValue>, ValidationError[]>(new[] { ValidationErrors.UnsetValuesNotAllowed() });

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
	}
}
