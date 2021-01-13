using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class RequiredCollectionValidationData<TValue> : IPropertyData<IReadOnlyList<Option<TValue>>, IReadOnlyList<TValue>>, IRootValidationData<RequiredCollectionValidationData<TValue>, IReadOnlyList<TValue>>
	{
		private readonly ValidationData<IReadOnlyList<TValue>> _validationData;

		public RequiredCollectionValidationData(ValidationData<IReadOnlyList<TValue>> validationData)
			=> _validationData = validationData;

		public RequiredCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new RequiredCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public RequiredCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new RequiredCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public Result<IReadOnlyList<TValue>, ValidationError[]> CoerceUnset()
			=> Result.Failure<IReadOnlyList<TValue>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });

		public Result<IReadOnlyList<TValue>, ValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyList<TValue>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });

		public Result<IReadOnlyList<TValue>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<IReadOnlyList<TValue>, ValidationError[]>(values)
				: Result.Failure<IReadOnlyList<TValue>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());

		public Result<Unit, ValidationError[]> Validate(IReadOnlyList<TValue> value)
			=> _validationData.Process(value);
	}
}
