using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public interface IValueValidator<TValue>
	{
		Result<Unit, ValidationError> Validate(TValue value);
	}
}
