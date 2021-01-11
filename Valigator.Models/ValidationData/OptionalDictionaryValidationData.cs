using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalDictionaryValidationData<TKey, TValue> : IPropertyData<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, Optional<IReadOnlyDictionary<TKey, TValue>>>, IRootValidationData<OptionalDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly ValidationData<IReadOnlyDictionary<TKey, TValue>> _validationData;

		public OptionalDictionaryValidationData(ValidationData<IReadOnlyDictionary<TKey, TValue>> validationData)
			=> _validationData = validationData;

		public OptionalDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new OptionalDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public OptionalDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new OptionalDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public Result<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (item.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices))
						return Result.Success<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(Optional.Set<IReadOnlyDictionary<TKey, TValue>>(values));
					
					return Result.Failure<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());
				}

				return Result.Failure<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(Optional.Unset<IReadOnlyDictionary<TKey, TValue>>());
		}

		public Result<Unit, ValidationError[]> Validate(Optional<IReadOnlyDictionary<TKey, TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
