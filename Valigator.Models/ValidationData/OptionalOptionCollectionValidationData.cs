using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalOptionCollectionValidationData<TValue> : ValidationDataBase<Optional<IReadOnlyList<Option<TValue>>>>, IPropertyData<IReadOnlyList<Option<TValue>>, Optional<IReadOnlyList<Option<TValue>>>>, IRootValidationData<OptionalOptionCollectionValidationData<TValue>, IReadOnlyList<Option<TValue>>>
	{
		private readonly ValidationData<IReadOnlyList<Option<TValue>>> _validationData;

		public OptionalOptionCollectionValidationData(ValidationData<IReadOnlyList<Option<TValue>>> validationData)
			=> _validationData = validationData;

		public OptionalOptionCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new OptionalOptionCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public OptionalOptionCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new OptionalOptionCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public override Result<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Optional.Unset<IReadOnlyList<Option<TValue>>>());
		public override Result<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]> CoerceNone()
			=> Result.Failure<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]>(new[] { CoercionValidationErrors.NullValuesNotAllowed() });

		public Result<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> Result.Success<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Optional.Set(value));

		public override Result<Unit, ValidationError[]> Validate(Optional<IReadOnlyList<Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
