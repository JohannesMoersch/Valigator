using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class RequiredOptionCollectionModelValidationData<TModel, TValue> : ModelValidationDataBase<TModel, IReadOnlyList<Option<TValue>>>, IModelPropertyData<TModel, IReadOnlyList<Option<TValue>>, IReadOnlyList<Option<TValue>>>, IRootModelValidationData<RequiredOptionCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<Option<TValue>>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> _validationData;

		public RequiredOptionCollectionModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> validationData)
			=> _validationData = validationData;

		public RequiredOptionCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new RequiredOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new RequiredOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredOptionCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new RequiredOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new RequiredOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public override Result<IReadOnlyList<Option<TValue>>, CoercionValidationError[]> CoerceUnset()
			=> Result.Failure<IReadOnlyList<Option<TValue>>, CoercionValidationError[]>(new[] { CoercionValidationErrors.UnsetValuesNotAllowed() });

		public override Result<IReadOnlyList<Option<TValue>>, CoercionValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyList<Option<TValue>>, CoercionValidationError[]>(new[] { CoercionValidationErrors.NullValuesNotAllowed() });

		public Result<IReadOnlyList<Option<TValue>>, CoercionValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> Result.Success<IReadOnlyList<Option<TValue>>, CoercionValidationError[]>(value);

		public override Result<Unit, ValidationError[]> Validate(TModel model, IReadOnlyList<Option<TValue>> value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
