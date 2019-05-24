using System;
using System.Collections.Generic;
using System.Text;

namespace Newtonsoft.FluentValidation.DataValidators
{
	public struct NullableStructValidator<TPrimaryValidator, TValue>
		where TPrimaryValidator : IPrimaryValidator<TValue>
		where TValue : struct
	{
		private readonly TPrimaryValidator _primaryValidator;

		public NullableStructValidator(TPrimaryValidator primaryValidator) 
			=> _primaryValidator = primaryValidator;

		public static implicit operator Data<TValue?>(NullableStructValidator<TPrimaryValidator, TValue> dataValidator)
			=> new Data<TValue?>(null);
	}
}
