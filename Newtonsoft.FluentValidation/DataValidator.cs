using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation
{
	public interface IDataValidator<T>
	{
		Result<Unit, ValidationError> Validate(bool isSet, Option<T> value);
	}
}
