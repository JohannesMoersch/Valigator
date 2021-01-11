using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalValueValidationData<TValue> : IPropertyData<Optional<Option<TValue>>, Optional<TValue>>, IRootValidationData<OptionalValueValidationData<TValue>, TValue>
	{
		private readonly ValidationData<TValue> _validationData;

		public OptionalValueValidationData(ValidationData<TValue> validationData)
			=> _validationData = validationData;

		public OptionalValueValidationData<TValue> WithValidator(IValidator<TValue> value)
			=> new OptionalValueValidationData<TValue>(_validationData.WithValidator(value));

		public OptionalValueValidationData<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new OptionalValueValidationData<TValue>(_validationData.WithValidator(value));

		public Result<Optional<TValue>, ValidationError[]> Coerce(Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<Optional<TValue>, ValidationError[]>(Optional.Set(item));

				return Result.Failure<Optional<TValue>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<Optional<TValue>, ValidationError[]>(Optional.Unset<TValue>());
		}

		public Result<Unit, ValidationError[]> Validate(Optional<TValue> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
