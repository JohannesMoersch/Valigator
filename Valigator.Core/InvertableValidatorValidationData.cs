using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public class InvertableValidatorValidationData<TValue> : IInvertableValidationData<IInvertableValidator<TValue>, TValue>
	{
		public IInvertableValidator<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> value;
	}
}
