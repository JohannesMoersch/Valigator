using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalCollectionValidationData<TValue> : ValidationDataBase<Optional<IReadOnlyList<TValue>>>, IPropertyData<IReadOnlyList<Option<TValue>>, Optional<IReadOnlyList<TValue>>>, IRootValidationData<OptionalCollectionValidationData<TValue>, IReadOnlyList<TValue>>
	{
		private readonly ValidationData<IReadOnlyList<TValue>> _validationData;

		public OptionalCollectionValidationData(ValidationData<IReadOnlyList<TValue>> validationData)
			=> _validationData = validationData;

		public OptionalCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new OptionalCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public OptionalCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new OptionalCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public override Result<Optional<IReadOnlyList<TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<IReadOnlyList<TValue>>, ValidationError[]>(Optional.Unset<IReadOnlyList<TValue>>());

		public override Result<Optional<IReadOnlyList<TValue>>, ValidationError[]> CoerceNone()
			=> Result.Failure<Optional<IReadOnlyList<TValue>>, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<Optional<IReadOnlyList<TValue>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Optional<IReadOnlyList<TValue>>, ValidationError[]>(Optional.Set(values))
				: Result.Failure<Optional<IReadOnlyList<TValue>>, ValidationError[]>(nullIndices.Select(i => ValidationErrors.NullValueAtIndexIsNotAllowed(i)).ToArray());

		public override Result<Unit, ValidationError[]> Validate(Optional<IReadOnlyList<TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
