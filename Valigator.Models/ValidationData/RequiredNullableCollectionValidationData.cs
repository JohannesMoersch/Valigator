using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class RequiredNullableCollectionValidationData<TValue> : ValidationDataBase<Option<IReadOnlyList<TValue>>>, IPropertyData<IReadOnlyList<Option<TValue>>, Option<IReadOnlyList<TValue>>>, IRootValidationData<RequiredNullableCollectionValidationData<TValue>, IReadOnlyList<TValue>>
	{
		private readonly ValidationData<IReadOnlyList<TValue>> _validationData;

		public RequiredNullableCollectionValidationData(ValidationData<IReadOnlyList<TValue>> validationData)
			=> _validationData = validationData;

		public RequiredNullableCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new RequiredNullableCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public RequiredNullableCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new RequiredNullableCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public override Result<Option<IReadOnlyList<TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Failure<Option<IReadOnlyList<TValue>>, ValidationError[]>(new[] { CoercionValidationErrors.UnsetValuesNotAllowed() });

		public override Result<Option<IReadOnlyList<TValue>>, ValidationError[]> CoerceNone()
			=> Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(Option.None<IReadOnlyList<TValue>>());

		public Result<Option<IReadOnlyList<TValue>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(Option.Some(values))
				: Result.Failure<Option<IReadOnlyList<TValue>>, ValidationError[]>(nullIndices.Select(i => CoercionValidationErrors.NullValueAtIndexIsNotAllowed(i)).ToArray());

		public override Result<Unit, ValidationError[]> Validate(Option<IReadOnlyList<TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
