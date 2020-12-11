using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public static class ValidatorValidationDataExtensions
	{
		public static IValidator<TValue> Not<TValue>(this ValidatorValidationData<TValue> data, Func<InvertableValidatorValidationData<TValue>, NotValidator<TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableValidatorValidationData<TValue>()));
	}
}
