using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class RequiredNullableCollectionValidationData<TValue> : IPropertyData<IReadOnlyList<Option<TValue>>, Option<IReadOnlyList<TValue>>>, IRootValidationData<RequiredNullableCollectionValidationData<TValue>, IReadOnlyList<TValue>>
	{
		private readonly ValidationData<IReadOnlyList<TValue>> _validationData;

		public RequiredNullableCollectionValidationData(ValidationData<IReadOnlyList<TValue>> validationData)
			=> _validationData = validationData;

		public RequiredNullableCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new RequiredNullableCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public RequiredNullableCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new RequiredNullableCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public Result<Option<IReadOnlyList<TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Failure<Option<IReadOnlyList<TValue>>, ValidationError[]>(new[] { ValidationErrors.UnsetValuesNotAllowed() });

		public Result<Option<IReadOnlyList<TValue>>, ValidationError[]> CoerceNone()
			=> Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(Option.None<IReadOnlyList<TValue>>());

		public Result<Option<IReadOnlyList<TValue>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(Option.Some(values))
				: Result.Failure<Option<IReadOnlyList<TValue>>, ValidationError[]>(nullIndices.Select(i => ValidationErrors.NullValueAtIndexIsNotAllowed(i)).ToArray());

		public Result<Unit, ValidationError[]> Validate(Option<IReadOnlyList<TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}

		public Data<Option<IReadOnlyList<TValue>>> ToData()
			=> new Data<Option<IReadOnlyList<TValue>>>(this);

		public static implicit operator Data<Option<IReadOnlyList<TValue>>>(RequiredNullableCollectionValidationData<TValue> propertyData)
			=> propertyData.ToData();
	}
}
