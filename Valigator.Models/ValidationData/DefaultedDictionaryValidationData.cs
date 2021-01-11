using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedDictionaryValidationData<TKey, TValue> : IPropertyData<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, IReadOnlyDictionary<TKey, TValue>>, IRootValidationData<DefaultedDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly IReadOnlyDictionary<TKey, TValue> _defaultValue;

		private readonly ValidationData<IReadOnlyDictionary<TKey, TValue>> _validationData;

		public DefaultedDictionaryValidationData(IReadOnlyDictionary<TKey, TValue> defaultValue, ValidationData<IReadOnlyDictionary<TKey, TValue>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new DefaultedDictionaryValidationData<TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new DefaultedDictionaryValidationData<TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<IReadOnlyDictionary<TKey, TValue>, ValidationError[]> Coerce(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (item.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices))
						return Result.Success<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(values);
					
					return Result.Failure<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());
				}

				return Result.Failure<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(_defaultValue);
		}

		public Result<Unit, ValidationError[]> Validate(IReadOnlyDictionary<TKey, TValue> value)
			=> _validationData.Process(value);
	}
}
