using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation
{
	public interface IDataValidator<TValue>
	{
		Result<TValue, ValidationError> Validate(bool isSet, TValue value);
	}
}
