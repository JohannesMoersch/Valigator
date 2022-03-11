using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class DefaultedNullableOptionCollectionModelValidationData<TModel, TValue> : ModelValidationDataBase<TModel, Option<IReadOnlyList<Option<TValue>>>>, IModelPropertyData<TModel, IReadOnlyList<Option<TValue>>, Option<IReadOnlyList<Option<TValue>>>>, IRootModelValidationData<DefaultedNullableOptionCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<Option<TValue>>>
	{
		private readonly Func<Option<IReadOnlyList<Option<TValue>>>> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> _validationData;

		public DefaultedNullableOptionCollectionModelValidationData(Func<Option<IReadOnlyList<Option<TValue>>>> defaultValue, ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedNullableOptionCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedNullableOptionCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedNullableOptionCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedNullableOptionCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public override Result<Option<IReadOnlyList<Option<TValue>>>, CoercionValidationError[]> CoerceUnset()
			=> Result.Success<Option<IReadOnlyList<Option<TValue>>>, CoercionValidationError[]>(_defaultValue.Invoke());

		public override Result<Option<IReadOnlyList<Option<TValue>>>, CoercionValidationError[]> CoerceNone()
			=> Result.Success<Option<IReadOnlyList<Option<TValue>>>, CoercionValidationError[]>(Option.None<IReadOnlyList<Option<TValue>>>());

		public Result<Option<IReadOnlyList<Option<TValue>>>, CoercionValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> Result.Success<Option<IReadOnlyList<Option<TValue>>>, CoercionValidationError[]>(Option.Some(value));

		public override Result<Unit, ValidationError[]> Validate(TModel model, Option<IReadOnlyList<Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
