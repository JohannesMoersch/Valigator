using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Valigator.Core;
using Valigator.Validators;

namespace Valigator
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ValidatorValidationDataExtensions
	{
		public static IValidator<TValue> Not<TValue>(this ValidatorValidationData<TValue> data, Func<InvertableValidatorValidationData<TValue>, NotValidator<TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableValidatorValidationData<TValue>()));
	}
}
