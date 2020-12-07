using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IInvertableValidationData<TNext, TValue>
	{
		public TNext WithValidator(IInvertableValidator<TValue> value);
	}
}
