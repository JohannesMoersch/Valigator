using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedOptionDictionaryValidationData<TKey, TValue> : IPropertyData<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, IReadOnlyDictionary<TKey, Option<TValue>>>, IRootValidationData<DefaultedOptionDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly IReadOnlyDictionary<TKey, Option<TValue>> _defaultValue;

		private readonly ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>> _validationData;

		public DefaultedOptionDictionaryValidationData(IReadOnlyDictionary<TKey, Option<TValue>> defaultValue, ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedOptionDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedOptionDictionaryValidationData<TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedOptionDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedOptionDictionaryValidationData<TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(item);

				return Result.Failure<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(_defaultValue);
		}

		public Result<Unit, ValidationError[]> Validate(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> _validationData.Process(value);
	}
}
