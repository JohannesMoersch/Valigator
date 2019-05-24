using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.FluentValidation.DataValidators;
using Newtonsoft.FluentValidation.StateValidators;

namespace Newtonsoft.FluentValidation
{
	public static class PrimaryValidatorExtensions
	{
		public static NullableValidator<RequiredValidator<TValue>, TValue> Nullable<TValue>(this RequiredValidator<TValue> requiredValidator)
			=> new NullableValidator<RequiredValidator<TValue>, TValue>(requiredValidator);

		public static ValueTypeNotDefaultValidator<NullableValidator<RequiredValidator<TValue>, TValue>, Option<TValue>> NotDefault<TValue>(this NullableValidator<RequiredValidator<TValue>, TValue> nullableValidator)
			where TValue : struct
			=> new ValueTypeNotDefaultValidator<NullableValidator<RequiredValidator<TValue>, TValue>, Option<TValue>>(nullableValidator);

		public static RangeValidator_Int32<RequiredValidator<int>> InRange(this RequiredValidator<int> requiredValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
			=> new RangeValidator_Int32<RequiredValidator<int>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
	}
}
