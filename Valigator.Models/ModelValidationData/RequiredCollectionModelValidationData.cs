using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class RequiredCollectionModelValidationData<TModel, TValue> : IModelPropertyData<TModel, IReadOnlyList<Option<TValue>>, IReadOnlyList<TValue>>, IRootModelValidationData<RequiredCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<TValue>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> _validationData;

		public RequiredCollectionModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> validationData)
			=> _validationData = validationData;

		public RequiredCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new RequiredCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new RequiredCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new RequiredCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new RequiredCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public Result<IReadOnlyList<TValue>, ValidationError[]> CoerceUnset()
			=> Result.Failure<IReadOnlyList<TValue>, ValidationError[]>(new[] { ValidationErrors.UnsetValuesNotAllowed() });

		public Result<IReadOnlyList<TValue>, ValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyList<TValue>, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<IReadOnlyList<TValue>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<IReadOnlyList<TValue>, ValidationError[]>(values)
				: Result.Failure<IReadOnlyList<TValue>, ValidationError[]>(nullIndices.Select(i => ValidationErrors.NullValueAtIndexIsNotAllowed(i)).ToArray());

		public Result<Unit, ValidationError[]> Validate(TModel model, IReadOnlyList<TValue> value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
