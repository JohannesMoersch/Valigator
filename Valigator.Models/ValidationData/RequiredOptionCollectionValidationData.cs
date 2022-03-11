using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class RequiredOptionCollectionValidationData<TValue> : ValidationDataBase<IReadOnlyList<Option<TValue>>>, IPropertyData<IReadOnlyList<Option<TValue>>, IReadOnlyList<Option<TValue>>>, IRootValidationData<RequiredOptionCollectionValidationData<TValue>, IReadOnlyList<Option<TValue>>>
	{
		private readonly ValidationData<IReadOnlyList<Option<TValue>>> _validationData;

		public RequiredOptionCollectionValidationData(ValidationData<IReadOnlyList<Option<TValue>>> validationData)
			=> _validationData = validationData;

		public RequiredOptionCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new RequiredOptionCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public RequiredOptionCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new RequiredOptionCollectionValidationData<TValue>(_validationData.WithValidator(value));

		public override Result<IReadOnlyList<Option<TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Failure<IReadOnlyList<Option<TValue>>, ValidationError[]>(new[] { CoercionValidationErrors.UnsetValuesNotAllowed() });

		public override Result<IReadOnlyList<Option<TValue>>, ValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyList<Option<TValue>>, ValidationError[]>(new[] { CoercionValidationErrors.NullValuesNotAllowed() });

		public Result<IReadOnlyList<Option<TValue>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> Result.Success<IReadOnlyList<Option<TValue>>, ValidationError[]>(value);

		public override Result<Unit, ValidationError[]> Validate(IReadOnlyList<Option<TValue>> value)
			=> _validationData.Process(value);
	}
}
