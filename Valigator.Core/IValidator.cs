using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IValidator
	{
		IValidatorDescriptor Descriptor { get; }
	}

	public interface IValidator<TValue> : IValidator
	{
		Result<Unit, ValidationError> Validate(TValue value);
	}
}
