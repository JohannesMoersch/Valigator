using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IInvertableValidationData<TNext, out TValue>
	{
		public TNext WithValidator(IInvertableValidator<TValue> value);
	}
}
