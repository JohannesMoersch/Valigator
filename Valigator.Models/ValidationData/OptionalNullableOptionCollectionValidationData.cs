using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalNullableOptionCollectionValidationData<TValue> : IPropertyData<IReadOnlyList<Option<TValue>>, Optional<Option<IReadOnlyList<Option<TValue>>>>>, IRootValidationData<OptionalNullableOptionCollectionValidationData<TValue>, IReadOnlyList<Option<TValue>>>
	{
		private readonly ValidationData<IReadOnlyList<Option<TValue>>> _validationData;

		public OptionalNullableOptionCollectionValidationData(ValidationData<IReadOnlyList<Option<TValue>>> validationData)
			=> _validationData = validationData;

		public OptionalNullableOptionCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new OptionalNullableOptionCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public OptionalNullableOptionCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new OptionalNullableOptionCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public Result<Optional<Option<IReadOnlyList<Option<TValue>>>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<Option<IReadOnlyList<Option<TValue>>>>, ValidationError[]>(Optional.Unset<Option<IReadOnlyList<Option<TValue>>>>());

		public Result<Optional<Option<IReadOnlyList<Option<TValue>>>>, ValidationError[]> CoerceNone()
			=> Result.Success<Optional<Option<IReadOnlyList<Option<TValue>>>>, ValidationError[]>(Optional.Set(Option.None<IReadOnlyList<Option<TValue>>>()));

		public Result<Optional<Option<IReadOnlyList<Option<TValue>>>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> Result.Success<Optional<Option<IReadOnlyList<Option<TValue>>>>, ValidationError[]>(Optional.Set(Option.Some(value)));

		public Result<Unit, ValidationError[]> Validate(Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option) && option.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
