using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class DefaultedNullableCollectionModelValidationData<TModel, TValue> : ModelValidationDataBase<TModel, Option<IReadOnlyList<TValue>>>, IModelPropertyData<TModel, IReadOnlyList<Option<TValue>>, Option<IReadOnlyList<TValue>>>, IRootModelValidationData<DefaultedNullableCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<TValue>>
	{
		private readonly Func<Option<IReadOnlyList<TValue>>> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> _validationData;

		public DefaultedNullableCollectionModelValidationData(Func<Option<IReadOnlyList<TValue>>> defaultValue, ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new DefaultedNullableCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new DefaultedNullableCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new DefaultedNullableCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new DefaultedNullableCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public override Result<Option<IReadOnlyList<TValue>>, CoercionValidationError[]> CoerceUnset()
			=> Result.Success<Option<IReadOnlyList<TValue>>, CoercionValidationError[]>(_defaultValue.Invoke());

		public override Result<Option<IReadOnlyList<TValue>>, CoercionValidationError[]> CoerceNone()
			=> Result.Success<Option<IReadOnlyList<TValue>>, CoercionValidationError[]>(Option.None<IReadOnlyList<TValue>>());

		public Result<Option<IReadOnlyList<TValue>>, CoercionValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Option<IReadOnlyList<TValue>>, CoercionValidationError[]>(Option.Some(values))
				: Result.Failure<Option<IReadOnlyList<TValue>>, CoercionValidationError[]>(nullIndices.Select(i => CoercionValidationErrors.NullValueAtIndexIsNotAllowed(i)).ToArray());

		public override Result<Unit, ValidationError[]> Validate(TModel model, Option<IReadOnlyList<TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
