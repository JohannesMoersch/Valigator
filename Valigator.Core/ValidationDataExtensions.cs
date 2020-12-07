using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Valigator.Core
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ValidationDataExtensions
	{
		public static ValidationData<TInput, TValue> Not<TInput, TValue>(this ValidationData<TInput, TValue> data, Func<InvertableValidatorValidationData<TInput, TValue>, IInvertableValidator<TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableValidatorValidationData<TInput, TValue>()));
	}
}
