using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class RequiredNullableOptionCollectionValidationData<TValue> : IPropertyData<IReadOnlyList<Option<TValue>>, Option<IReadOnlyList<Option<TValue>>>>, IRootValidationData<RequiredNullableOptionCollectionValidationData<TValue>, IReadOnlyList<Option<TValue>>>
	{
		private readonly ValidationData<IReadOnlyList<Option<TValue>>> _validationData;

		public RequiredNullableOptionCollectionValidationData(ValidationData<IReadOnlyList<Option<TValue>>> validationData)
			=> _validationData = validationData;

		public RequiredNullableOptionCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new RequiredNullableOptionCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public RequiredNullableOptionCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new RequiredNullableOptionCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public Result<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]> CoerceUnset()
			=> Result.Failure<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(new[] { ValidationErrors.UnsetValuesNotAllowed() });

		public Result<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]> CoerceNone()
			=> Result.Success<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Option.None<IReadOnlyList<Option<TValue>>>());

		public Result<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> Result.Success<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Option.Some(value));

		public Result<Unit, ValidationError[]> Validate(Option<IReadOnlyList<Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}

		public Data<Option<IReadOnlyList<Option<TValue>>>> ToData()
			=> new Data<Option<IReadOnlyList<Option<TValue>>>>(this);

		public static implicit operator Data<Option<IReadOnlyList<Option<TValue>>>>(RequiredNullableOptionCollectionValidationData<TValue> propertyData)
			=> propertyData.ToData();
	}
}
