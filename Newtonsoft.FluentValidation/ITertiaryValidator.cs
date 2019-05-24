using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation
{
	public interface ITertiaryValidator<T>
	{
		Result<Option<T>, ValidationError> Validate(T value);
	}
}
