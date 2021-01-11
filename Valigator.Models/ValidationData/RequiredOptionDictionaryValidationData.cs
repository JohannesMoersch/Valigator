using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class RequiredOptionDictionaryValidationData<TKey, TValue> : IPropertyData<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, IReadOnlyDictionary<TKey, Option<TValue>>>, IRootValidationData<RequiredOptionDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>> _validationData;

		public RequiredOptionDictionaryValidationData(ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>> validationData)
			=> _validationData = validationData;

		public RequiredOptionDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new RequiredOptionDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public RequiredOptionDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new RequiredOptionDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public Result<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(item);

				return Result.Failure<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Failure<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> _validationData.Process(value);
	}
}
