
using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedValueValidationData<TValue> : ValidationDataBase<TValue>, IPropertyData<TValue, TValue>, IRootValidationData<DefaultedValueValidationData<TValue>, TValue>
	{
		private readonly Func<TValue> _defaultValue;

		private readonly ValidationData<TValue> _validationData;

		public DefaultedValueValidationData(Func<TValue> defaultValue, ValidationData<TValue> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedValueValidationData<TValue> WithValidator(IValidator<TValue> value)
			=> new DefaultedValueValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedValueValidationData<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new DefaultedValueValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public override Result<TValue, ValidationError[]> CoerceUnset()
			=> Result.Success<TValue, ValidationError[]>(_defaultValue.Invoke());

		public override Result<TValue, ValidationError[]> CoerceNone()
			=> Result.Failure<TValue, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<TValue, ValidationError[]> CoerceValue(TValue value)
			=> Result.Success<TValue, ValidationError[]>(value);

		public override Result<Unit, ValidationError[]> Validate(TValue value)
			=> _validationData.Process(value);
	}
}
