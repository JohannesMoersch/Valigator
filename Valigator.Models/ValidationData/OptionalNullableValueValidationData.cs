using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class OptionalNullableValueValidationData<TValue> : IPropertyData<Optional<Option<TValue>>, Optional<Option<TValue>>>, IRootValidationData<OptionalNullableValueValidationData<TValue>, TValue>
	{
		private readonly ValidationData<TValue> _validationData;

		public OptionalNullableValueValidationData(ValidationData<TValue> validationData)
			=> _validationData = validationData;

		public OptionalNullableValueValidationData<TValue> WithValidator(IValidator<TValue> value)
			=> new OptionalNullableValueValidationData<TValue>(_validationData.WithValidator(value));

		public OptionalNullableValueValidationData<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new OptionalNullableValueValidationData<TValue>(_validationData.WithValidator(value));

		public Result<Optional<Option<TValue>>, ValidationError[]> Coerce(Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<Optional<Option<TValue>>, ValidationError[]>(Optional.Set(Option.Some(item)));

				return Result.Success<Optional<Option<TValue>>, ValidationError[]>(Optional.Set(Option.None<TValue>()));
			}

			return Result.Success<Optional<Option<TValue>>, ValidationError[]>(Optional.Unset<Option<TValue>>());
		}

		public Result<Unit, ValidationError[]> Validate(Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return _validationData.Process(item);
			}

			return Result.Unit<ValidationError[]>();
		}
	}
}
