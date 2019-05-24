using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.FluentValidation.DataValidators;

namespace Newtonsoft.FluentValidation
{
	public static class PrimaryValidatorExtensions
	{
		public static NullableValidator<RequiredValidator<TValue>, TValue> Nullable<TValue>(this RequiredValidator<TValue> primaryValidator)
			=> new NullableValidator<RequiredValidator<TValue>, TValue>(primaryValidator);
	}
}
