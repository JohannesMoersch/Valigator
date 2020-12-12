using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IValidator<in TValue>
	{
		Result<Unit, ValidationError[]> Validate(TValue value);
	}
}
