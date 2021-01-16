using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalNullableOptionDictionaryValidationData<TKey, TValue> : IPropertyData<IReadOnlyDictionary<TKey, Option<TValue>>, Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>>, IRootValidationData<OptionalNullableOptionDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>> _validationData;

		public OptionalNullableOptionDictionaryValidationData(ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>> validationData)
			=> _validationData = validationData;

		public OptionalNullableOptionDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new OptionalNullableOptionDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public OptionalNullableOptionDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new OptionalNullableOptionDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public Result<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, ValidationError[]>(Optional.Unset<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>());

		public Result<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, ValidationError[]> CoerceNone()
			=> Result.Success<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, ValidationError[]>(Optional.Set(Option.None<IReadOnlyDictionary<TKey, Option<TValue>>>()));

		public Result<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, ValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> Result.Success<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, ValidationError[]>(Optional.Set(Option.Some(value)));

		public Result<Unit, ValidationError[]> Validate(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option) && option.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}

		public Data<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>> ToData()
			=> new Data<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>>(this);

		public static implicit operator Data<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>>(OptionalNullableOptionDictionaryValidationData<TKey, TValue> propertyData)
			=> propertyData.ToData();
	}
}
