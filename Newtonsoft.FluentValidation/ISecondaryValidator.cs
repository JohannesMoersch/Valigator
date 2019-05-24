using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation
{
	public interface ISecondaryValidator<T>
	{
		Result<Option<T>, ValidationError> Validate(Option<T> value);
	}
}
