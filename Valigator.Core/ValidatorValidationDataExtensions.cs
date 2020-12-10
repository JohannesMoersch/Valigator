using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public static class ValidatorValidationDataExtensions
	{
		public static IInvertableValidator<TValue> Not<TValue>(this ValidatorValidationData<TValue> data, Func<InvertableValidatorValidationData<TValue>, IInvertableValidator<TValue>> selector)
			=> selector.Invoke(new InvertableValidatorValidationData<TValue>());
	}
}
