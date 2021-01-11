
using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedValueValidationData<TValue> : IPropertyData<Optional<Option<TValue>>, TValue>, IRootValidationData<DefaultedValueValidationData<TValue>, TValue>
	{
		private readonly TValue _defaultValue;

		private readonly ValidationData<TValue> _validationData;

		public DefaultedValueValidationData(TValue defaultValue, ValidationData<TValue> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedValueValidationData<TValue> WithValidator(IValidator<TValue> value)
			=> new DefaultedValueValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedValueValidationData<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new DefaultedValueValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<TValue, ValidationError[]> Coerce(Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<TValue, ValidationError[]>(item);

				return Result.Failure<TValue, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<TValue, ValidationError[]>(_defaultValue);
		}

		public Result<Unit, ValidationError[]> Validate(TValue value)
			=> _validationData.Process(value);
	}
}
