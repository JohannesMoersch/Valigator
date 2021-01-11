using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class RequiredNullableOptionDictionaryValidationData<TKey, TValue> : IPropertyData<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, IRootValidationData<RequiredNullableOptionDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>> _validationData;

		public RequiredNullableOptionDictionaryValidationData(ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>> validationData)
			=> _validationData = validationData;

		public RequiredNullableOptionDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new RequiredNullableOptionDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public RequiredNullableOptionDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new RequiredNullableOptionDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public Result<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(Option.Some(item));

				return Result.Success<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(Option.None<IReadOnlyDictionary<TKey, Option<TValue>>>());
			}

			return Result.Failure<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(Option<IReadOnlyDictionary<TKey, Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
