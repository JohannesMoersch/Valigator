using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalNullableDictionaryValidationData<TKey, TValue> : IPropertyData<IReadOnlyDictionary<TKey, Option<TValue>>, Optional<Option<IReadOnlyDictionary<TKey, TValue>>>>, IRootValidationData<OptionalNullableDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly ValidationData<IReadOnlyDictionary<TKey, TValue>> _validationData;

		public OptionalNullableDictionaryValidationData(ValidationData<IReadOnlyDictionary<TKey, TValue>> validationData)
			=> _validationData = validationData;

		public OptionalNullableDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new OptionalNullableDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public OptionalNullableDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new OptionalNullableDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public Result<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]>(Optional.Unset<Option<IReadOnlyDictionary<TKey, TValue>>>());

		public Result<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]> CoerceNone()
			=> Result.Success<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]>(Optional.Set(Option.None<IReadOnlyDictionary<TKey, TValue>>()));

		public Result<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]>(Optional.Set(Option.Some(values)))
				: Result.Failure<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]>(nullIndices.Select(i => ValidationErrors.NullValueAtKeyIsNotAllowed(i)).ToArray());

		public Result<Unit, ValidationError[]> Validate(Optional<Option<IReadOnlyDictionary<TKey, TValue>>> value)
		{
			if (value.TryGetValue(out var option) && option.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}

		public Data<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>> ToData()
			=> new Data<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>>(this);

		public static implicit operator Data<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>>(OptionalNullableDictionaryValidationData<TKey, TValue> propertyData)
			=> propertyData.ToData();
	}
}
