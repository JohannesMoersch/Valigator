using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class RequiredNullableCollectionModelValidationData<TModel, TValue> : ModelValidationDataBase<TModel, Option<IReadOnlyList<TValue>>>, IModelPropertyData<TModel, IReadOnlyList<Option<TValue>>, Option<IReadOnlyList<TValue>>>, IRootModelValidationData<RequiredNullableCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<TValue>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> _validationData;

		public RequiredNullableCollectionModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> validationData)
			=> _validationData = validationData;

		public RequiredNullableCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new RequiredNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new RequiredNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new RequiredNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new RequiredNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public override Result<Option<IReadOnlyList<TValue>>, CoercionValidationError[]> CoerceUnset()
			=> Result.Failure<Option<IReadOnlyList<TValue>>, CoercionValidationError[]>(new[] { CoercionValidationErrors.UnsetValuesNotAllowed() });

		public override Result<Option<IReadOnlyList<TValue>>, CoercionValidationError[]> CoerceNone()
			=> Result.Success<Option<IReadOnlyList<TValue>>, CoercionValidationError[]>(Option.None<IReadOnlyList<TValue>>());

		public Result<Option<IReadOnlyList<TValue>>, CoercionValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Option<IReadOnlyList<TValue>>, CoercionValidationError[]>(Option.Some<IReadOnlyList<TValue>>(values))
				: Result.Failure<Option<IReadOnlyList<TValue>>, CoercionValidationError[]>(nullIndices.Select(i => CoercionValidationErrors.NullValueAtIndexIsNotAllowed(i)).ToArray());

		public override Result<Unit, ValidationError[]> Validate(TModel model, Option<IReadOnlyList<TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
