using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public interface IDataValidator<TValue>
	{
		Result<TValue, ValidationError> Validate(object model, bool isSet, TValue value);
	}
}
