using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IInvertableValidator<in TValue> : IValidator<TValue>
	{
		Result<Unit, ValidationError[]> InverseValidate(TValue value);
	}
}
