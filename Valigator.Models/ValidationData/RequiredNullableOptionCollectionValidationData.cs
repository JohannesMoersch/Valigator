using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class RequiredNullableOptionCollectionValidationData<TValue> : IPropertyData<Optional<Option<IReadOnlyList<Option<TValue>>>>, Option<IReadOnlyList<Option<TValue>>>>, IRootValidationData<RequiredNullableOptionCollectionValidationData<TValue>, IReadOnlyList<Option<TValue>>>
	{
		private readonly ValidationData<IReadOnlyList<Option<TValue>>> _validationData;

		public RequiredNullableOptionCollectionValidationData(ValidationData<IReadOnlyList<Option<TValue>>> validationData)
			=> _validationData = validationData;

		public RequiredNullableOptionCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new RequiredNullableOptionCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public RequiredNullableOptionCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new RequiredNullableOptionCollectionValidationData<TValue>(_validationData.WithValidator(value));

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
