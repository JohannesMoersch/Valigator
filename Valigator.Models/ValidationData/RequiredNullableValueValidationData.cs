using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class RequiredNullableValueValidationData<TValue> : IPropertyData<TValue, Option<TValue>>, IRootValidationData<RequiredNullableValueValidationData<TValue>, TValue>
	{
		private readonly ValidationData<TValue> _validationData;

		public RequiredNullableValueValidationData(ValidationData<TValue> validationData)
			=> _validationData = validationData;

		public RequiredNullableValueValidationData<TValue> WithValidator(IValidator<TValue> value)
			=> new RequiredNullableValueValidationData<TValue>(_validationData.WithValidator(value));

		public RequiredNullableValueValidationData<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new RequiredNullableValueValidationData<TValue>(_validationData.WithValidator(value));

		public Result<Option<TValue>, ValidationError[]> CoerceUnset()
			=> Result.Failure<Option<TValue>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });

		public Result<Option<TValue>, ValidationError[]> CoerceNone()
			=> Result.Success<Option<TValue>, ValidationError[]>(Option.None<TValue>());

		public Result<Option<TValue>, ValidationError[]> CoerceValue(TValue value)
			=> Result.Success<Option<TValue>, ValidationError[]>(Option.Some(value));

		public Result<Unit, ValidationError[]> Validate(Option<TValue> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
