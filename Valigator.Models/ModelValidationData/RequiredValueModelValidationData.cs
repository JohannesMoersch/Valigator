using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class RequiredValueModelValidationData<TModel, TValue> : ModelValidationDataBase<TModel, TValue>, IModelPropertyData<TModel, TValue, TValue>, IRootModelValidationData<RequiredValueModelValidationData<TModel, TValue>, TModel, TValue>
	{
		private readonly ValidationData<ModelValue<TModel, TValue>> _validationData;

		public RequiredValueModelValidationData(ValidationData<ModelValue<TModel, TValue>> validationData)
			=> _validationData = validationData;

		public RequiredValueModelValidationData<TModel, TValue> WithValidator(IValidator<TValue> value)
			=> new RequiredValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredValueModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new RequiredValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredValueModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, TValue> value)
			=> new RequiredValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredValueModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> new RequiredValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public override Result<TValue, CoercionValidationError[]> CoerceUnset()
			=> Result.Failure<TValue, CoercionValidationError[]>(new[] { CoercionValidationErrors.UnsetValuesNotAllowed() });

		public override Result<TValue, CoercionValidationError[]> CoerceNone()
			=> Result.Failure<TValue, CoercionValidationError[]>(new[] { CoercionValidationErrors.NullValuesNotAllowed() });

		public Result<TValue, CoercionValidationError[]> CoerceValue(TValue value)
			=> Result.Success<TValue, CoercionValidationError[]>(value);

		public override Result<Unit, ValidationError[]> Validate(TModel model, TValue value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
