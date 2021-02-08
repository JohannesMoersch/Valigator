using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalValueValidationData<TValue> : ValidationDataBase<Optional<TValue>>, IPropertyData<TValue, Optional<TValue>>, IRootValidationData<OptionalValueValidationData<TValue>, TValue>
	{
		private readonly ValidationData<TValue> _validationData;

		public OptionalValueValidationData(ValidationData<TValue> validationData)
			=> _validationData = validationData;

		public OptionalValueValidationData<TValue> WithValidator(IValidator<TValue> value)
			=> new OptionalValueValidationData<TValue>(_validationData.WithValidator(value));

		public OptionalValueValidationData<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new OptionalValueValidationData<TValue>(_validationData.WithValidator(value));

		public override Result<Optional<TValue>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<TValue>, ValidationError[]>(Optional.Unset<TValue>());

		public override Result<Optional<TValue>, ValidationError[]> CoerceNone()
			=> Result.Failure<Optional<TValue>, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<Optional<TValue>, ValidationError[]> CoerceValue(TValue value)
			=> Result.Success<Optional<TValue>, ValidationError[]>(Optional.Set(value));

		public override Result<Unit, ValidationError[]> Validate(Optional<TValue> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
