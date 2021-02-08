using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class RequiredValueValidationData<TValue> : ValidationDataBase<TValue>, IPropertyData<TValue, TValue>, IRootValidationData<RequiredValueValidationData<TValue>, TValue>
	{
		private readonly ValidationData<TValue> _validationData;

		public RequiredValueValidationData(ValidationData<TValue> validationData)
			=> _validationData = validationData;

		public RequiredValueValidationData<TValue> WithValidator(IValidator<TValue> value)
			=> new RequiredValueValidationData<TValue>(_validationData.WithValidator(value));

		public RequiredValueValidationData<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new RequiredValueValidationData<TValue>(_validationData.WithValidator(value));

		public override Result<TValue, ValidationError[]> CoerceUnset()
			=> Result.Failure<TValue, ValidationError[]>(new[] { ValidationErrors.UnsetValuesNotAllowed() });

		public override Result<TValue, ValidationError[]> CoerceNone()
			=> Result.Failure<TValue, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<TValue, ValidationError[]> CoerceValue(TValue value)
			=> Result.Success<TValue, ValidationError[]>(value);

		public override Result<Unit, ValidationError[]> Validate(TValue value)
			=> _validationData.Process(value);
	}
}
