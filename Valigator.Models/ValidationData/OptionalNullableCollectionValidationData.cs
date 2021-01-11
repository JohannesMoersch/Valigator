using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalNullableCollectionValidationData<TValue> : IPropertyData<Optional<Option<IReadOnlyList<Option<TValue>>>>, Optional<Option<IReadOnlyList<TValue>>>>, IRootValidationData<OptionalNullableCollectionValidationData<TValue>, IReadOnlyList<TValue>>
	{
		private readonly ValidationData<IReadOnlyList<TValue>> _validationData;

		public OptionalNullableCollectionValidationData(ValidationData<IReadOnlyList<TValue>> validationData)
			=> _validationData = validationData;

		public OptionalNullableCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new OptionalNullableCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public OptionalNullableCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new OptionalNullableCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public Result<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (item.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices))
						return Result.Success<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(Optional.Set(Option.Some<IReadOnlyList<TValue>>(values)));
					
					return Result.Failure<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());
				}

				return Result.Success<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(Optional.Set(Option.None<IReadOnlyList<TValue>>()));
			}

			return Result.Failure<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(Optional<Option<IReadOnlyList<TValue>>> value)
		{
			if (value.TryGetValue(out var option) && option.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
