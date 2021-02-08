using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalNullableCollectionValidationData<TValue> : ValidationDataBase<Optional<Option<IReadOnlyList<TValue>>>>, IPropertyData<IReadOnlyList<Option<TValue>>, Optional<Option<IReadOnlyList<TValue>>>>, IRootValidationData<OptionalNullableCollectionValidationData<TValue>, IReadOnlyList<TValue>>
	{
		private readonly ValidationData<IReadOnlyList<TValue>> _validationData;

		public OptionalNullableCollectionValidationData(ValidationData<IReadOnlyList<TValue>> validationData)
			=> _validationData = validationData;

		public OptionalNullableCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new OptionalNullableCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public OptionalNullableCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new OptionalNullableCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public override Result<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(Optional.Unset<Option<IReadOnlyList<TValue>>>());

		public override Result<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]> CoerceNone()
			=> Result.Success<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(Optional.Set(Option.None<IReadOnlyList<TValue>>()));

		public Result<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(Optional.Set(Option.Some(values)))
				: Result.Failure<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(nullIndices.Select(i => ValidationErrors.NullValueAtIndexIsNotAllowed(i)).ToArray());

		public override Result<Unit, ValidationError[]> Validate(Optional<Option<IReadOnlyList<TValue>>> value)
		{
			if (value.TryGetValue(out var option) && option.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
