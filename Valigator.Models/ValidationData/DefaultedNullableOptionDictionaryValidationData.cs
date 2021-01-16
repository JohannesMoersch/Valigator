using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedNullableOptionDictionaryValidationData<TKey, TValue> : IPropertyData<IReadOnlyDictionary<TKey, Option<TValue>>, Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, IRootValidationData<DefaultedNullableOptionDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly Option<IReadOnlyDictionary<TKey, Option<TValue>>> _defaultValue;

		private readonly ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>> _validationData;

		public DefaultedNullableOptionDictionaryValidationData(Option<IReadOnlyDictionary<TKey, Option<TValue>>> defaultValue, ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableOptionDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedNullableOptionDictionaryValidationData<TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableOptionDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedNullableOptionDictionaryValidationData<TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(_defaultValue);

		public Result<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]> CoerceNone()
			=> Result.Success<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(Option.None<IReadOnlyDictionary<TKey, Option<TValue>>>());

		public Result<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> Result.Success<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(Option.Some(value));

		public Result<Unit, ValidationError[]> Validate(Option<IReadOnlyDictionary<TKey, Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}

		public Data<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> ToData()
			=> new Data<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>(this);

		public static implicit operator Data<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>(DefaultedNullableOptionDictionaryValidationData<TKey, TValue> propertyData)
			=> propertyData.ToData();
	}
}
