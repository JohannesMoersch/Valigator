using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedNullableValueValidationData<TValue> : IPropertyData<Optional<Option<TValue>>, Option<TValue>>, IRootValidationData<DefaultedNullableValueValidationData<TValue>, TValue>
	{
		private readonly TValue _defaultValue;

		private readonly ValidationData<TValue> _validationData;

		public DefaultedNullableValueValidationData(TValue defaultValue, ValidationData<TValue> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableValueValidationData<TValue> WithValidator(IValidator<TValue> value)
			=> new DefaultedNullableValueValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableValueValidationData<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new DefaultedNullableValueValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<Option<TValue>, ValidationError[]> Coerce(Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<Option<TValue>, ValidationError[]>(Option.Some(item));

				return Result.Success<Option<TValue>, ValidationError[]>(Option.None<TValue>());
			}

			return Result.Success<Option<TValue>, ValidationError[]>(Option.Some(_defaultValue));
		}

		public Result<Unit, ValidationError[]> Validate(Option<TValue> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
