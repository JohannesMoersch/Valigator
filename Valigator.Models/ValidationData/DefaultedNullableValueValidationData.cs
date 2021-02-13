using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedNullableValueValidationData<TValue> : ValidationDataBase<Option<TValue>>, IPropertyData<TValue, Option<TValue>>, IRootValidationData<DefaultedNullableValueValidationData<TValue>, TValue>
	{
		private readonly Func<Option<TValue>> _defaultValue;

		private readonly ValidationData<TValue> _validationData;

		public DefaultedNullableValueValidationData(Func<Option<TValue>> defaultValue, ValidationData<TValue> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableValueValidationData<TValue> WithValidator(IValidator<TValue> value)
			=> new DefaultedNullableValueValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableValueValidationData<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new DefaultedNullableValueValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public override Result<Option<TValue>, ValidationError[]> CoerceUnset()
			=> Result.Success<Option<TValue>, ValidationError[]>(_defaultValue.Invoke());

		public override Result<Option<TValue>, ValidationError[]> CoerceNone()
			=> Result.Success<Option<TValue>, ValidationError[]>(Option.None<TValue>());

		public Result<Option<TValue>, ValidationError[]> CoerceValue(TValue value)
			=> Result.Success<Option<TValue>, ValidationError[]>(Option.Some(value));

		public override Result<Unit, ValidationError[]> Validate(Option<TValue> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
