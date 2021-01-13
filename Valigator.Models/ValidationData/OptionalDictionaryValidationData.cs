using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalDictionaryValidationData<TKey, TValue> : IPropertyData<IReadOnlyDictionary<TKey, Option<TValue>>, Optional<IReadOnlyDictionary<TKey, TValue>>>, IRootValidationData<OptionalDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly ValidationData<IReadOnlyDictionary<TKey, TValue>> _validationData;

		public OptionalDictionaryValidationData(ValidationData<IReadOnlyDictionary<TKey, TValue>> validationData)
			=> _validationData = validationData;

		public OptionalDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new OptionalDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public OptionalDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new OptionalDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public Result<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(Optional.Unset<IReadOnlyDictionary<TKey, TValue>>());

		public Result<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]> CoerceNone()
			=> Result.Failure<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });

		public Result<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(Optional.Set(values))
				: Result.Failure<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());

		public Result<Unit, ValidationError[]> Validate(Optional<IReadOnlyDictionary<TKey, TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
