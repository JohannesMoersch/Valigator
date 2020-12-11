using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public class InvertableValidatorValidationData<TValue> : IInvertableValidationData<NotValidator<TValue>, TValue>
	{
		public NotValidator<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new NotValidator<TValue>(value);
	}
}
