using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class DefaultedNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> : ModelValidationDataBase<TModel, Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, IModelPropertyData<TModel, IReadOnlyDictionary<TKey, Option<TValue>>, Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, IRootModelValidationData<DefaultedNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly Func<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>> _validationData;

		public DefaultedNullableOptionDictionaryModelValidationData(Func<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> defaultValue, ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IModelValidator<TModel, IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public override Result<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, CoercionValidationError[]> CoerceUnset()
			=> Result.Success<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, CoercionValidationError[]>(_defaultValue.Invoke());

		public override Result<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, CoercionValidationError[]> CoerceNone()
			=> Result.Success<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, CoercionValidationError[]>(Option.None<IReadOnlyDictionary<TKey, Option<TValue>>>());

		public Result<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, CoercionValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> Result.Success<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, CoercionValidationError[]>(Option.Some(value));

		public override Result<Unit, ValidationError[]> Validate(TModel model, Option<IReadOnlyDictionary<TKey, Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
