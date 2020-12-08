using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IInvertableValidator<TValue> : IValidator<TValue>
	{
		ValidatorResult InverseValidate(TValue value);
	}
}
