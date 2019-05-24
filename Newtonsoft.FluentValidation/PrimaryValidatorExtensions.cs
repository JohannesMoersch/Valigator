using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.FluentValidation.DataValidators;

namespace Newtonsoft.FluentValidation
{
	public static class PrimaryValidatorExtensions
	{
		public static NullableStructValidator<RequiredValidator<TValue>, TValue> Nullable<TValue>(this RequiredValidator<TValue> primaryValidator)
			where TValue : struct
			=> new NullableStructValidator<RequiredValidator<TValue>, TValue>(primaryValidator);
	}
}
