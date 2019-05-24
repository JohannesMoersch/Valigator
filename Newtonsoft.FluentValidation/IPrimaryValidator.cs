using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation
{
	public interface IPrimaryValidator<T>
	{
		Result<Option<T>, ValidationError> Validate(bool isSet, Option<T> value);
	}
}
