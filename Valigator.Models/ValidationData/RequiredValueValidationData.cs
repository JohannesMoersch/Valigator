using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class RequiredValueValidationData<TValue> : IPropertyData<Optional<Option<TValue>>, TValue>, IRootValidationData<RequiredValueValidationData<TValue>, TValue>
	{
		private readonly ValidationData<TValue> _validationData;

		public RequiredValueValidationData(ValidationData<TValue> validationData)
			=> _validationData = validationData;

		public RequiredValueValidationData<TValue> WithValidator(IValidator<TValue> value)
			=> new RequiredValueValidationData<TValue>(_validationData.WithValidator(value));

		public RequiredValueValidationData<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new RequiredValueValidationData<TValue>(_validationData.WithValidator(value));

		public Result<TValue, ValidationError[]> Coerce(Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<TValue, ValidationError[]>(item);

				return Result.Failure<TValue, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Failure<TValue, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(TValue value)
			=> _validationData.Process(value);
	}
}
