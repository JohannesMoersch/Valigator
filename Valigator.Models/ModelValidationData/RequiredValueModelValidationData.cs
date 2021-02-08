using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class RequiredValueModelValidationData<TModel, TValue> : IModelPropertyData<TModel, TValue, TValue>, IRootModelValidationData<RequiredValueModelValidationData<TModel, TValue>, TModel, TValue>
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

		public Result<TValue, ValidationError[]> CoerceUnset()
			=> Result.Failure<TValue, ValidationError[]>(new[] { ValidationErrors.UnsetValuesNotAllowed() });

		public Result<TValue, ValidationError[]> CoerceNone()
			=> Result.Failure<TValue, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<TValue, ValidationError[]> CoerceValue(TValue value)
			=> Result.Success<TValue, ValidationError[]>(value);

		public Result<Unit, ValidationError[]> Validate(TModel model, TValue value)
			=> _validationData.Process(ModelValue.Create(model, value));

		public static ModelDefinition<TModel>.Property<TValue> ToProperty(RequiredValueModelValidationData<TModel, TValue> data)
			=> new ModelDefinition<TModel>.Property<TValue>(data);

		public static implicit operator ModelDefinition<TModel>.Property<TValue>(RequiredValueModelValidationData<TModel, TValue> data)
			=> ToProperty(data);
	}
}
