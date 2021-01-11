using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedNullableCollectionValidationData<TValue> : IPropertyData<Optional<Option<IReadOnlyList<Option<TValue>>>>, Option<IReadOnlyList<TValue>>>, IRootValidationData<DefaultedNullableCollectionValidationData<TValue>, IReadOnlyList<TValue>>
	{
		private readonly Option<IReadOnlyList<TValue>> _defaultValue;

		private readonly ValidationData<IReadOnlyList<TValue>> _validationData;

		public DefaultedNullableCollectionValidationData(Option<IReadOnlyList<TValue>> defaultValue, ValidationData<IReadOnlyList<TValue>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new DefaultedNullableCollectionValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new DefaultedNullableCollectionValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<Option<IReadOnlyList<TValue>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (item.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices))
						return Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(Option.Some<IReadOnlyList<TValue>>(values));
					
					return Result.Failure<Option<IReadOnlyList<TValue>>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());
				}

				return Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(Option.None<IReadOnlyList<TValue>>());
			}

			return Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(_defaultValue);
		}

		public Result<Unit, ValidationError[]> Validate(Option<IReadOnlyList<TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
