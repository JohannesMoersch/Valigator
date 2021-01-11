using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IValidationData<TNext, out TValue>
	{
		public TNext WithValidator(IValidator<TValue> value);
	}
}
