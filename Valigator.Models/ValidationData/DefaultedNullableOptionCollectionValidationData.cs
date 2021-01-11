using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedNullableOptionCollectionValidationData<TValue> : IPropertyData<Optional<Option<IReadOnlyList<Option<TValue>>>>, Option<IReadOnlyList<Option<TValue>>>>, IRootValidationData<DefaultedNullableOptionCollectionValidationData<TValue>, IReadOnlyList<Option<TValue>>>
	{
		private readonly Option<IReadOnlyList<Option<TValue>>> _defaultValue;

		private readonly ValidationData<IReadOnlyList<Option<TValue>>> _validationData;

		public DefaultedNullableOptionCollectionValidationData(Option<IReadOnlyList<Option<TValue>>> defaultValue, ValidationData<IReadOnlyList<Option<TValue>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableOptionCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedNullableOptionCollectionValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableOptionCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedNullableOptionCollectionValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Option.Some(item));

				return Result.Success<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Option.None<IReadOnlyList<Option<TValue>>>());
			}

			return Result.Failure<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(Option<IReadOnlyList<Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
