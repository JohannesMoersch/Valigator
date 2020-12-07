using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public class InvertableValidatorValidationData<TInput, TValue> : IInvertableValidationData<IInvertableValidator<TValue>, TInput, TValue>
	{
		public IInvertableValidator<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> value;
	}
}
