using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalCollectionValidationData<TValue> : IPropertyData<Optional<Option<IReadOnlyList<Option<TValue>>>>, Optional<IReadOnlyList<TValue>>>, IRootValidationData<OptionalCollectionValidationData<TValue>, IReadOnlyList<TValue>>
	{
		private readonly ValidationData<IReadOnlyList<TValue>> _validationData;

		public OptionalCollectionValidationData(ValidationData<IReadOnlyList<TValue>> validationData)
			=> _validationData = validationData;

		public OptionalCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new OptionalCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public OptionalCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new OptionalCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public Result<Optional<IReadOnlyList<TValue>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (item.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices))
						return Result.Success<Optional<IReadOnlyList<TValue>>, ValidationError[]>(Optional.Set<IReadOnlyList<TValue>>(values));
					
					return Result.Failure<Optional<IReadOnlyList<TValue>>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());
				}

				return Result.Failure<Optional<IReadOnlyList<TValue>>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<Optional<IReadOnlyList<TValue>>, ValidationError[]>(Optional.Unset<IReadOnlyList<TValue>>());
		}

		public Result<Unit, ValidationError[]> Validate(Optional<IReadOnlyList<TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
