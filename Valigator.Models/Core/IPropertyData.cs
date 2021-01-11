using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Core
{
	public interface IPropertyData<TInput, TValue>
	{
		Result<TValue, ValidationError[]> Coerce(TInput value);

		Result<Unit, ValidationError[]> Validate(TValue value);
	}
}
