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
	}
}
