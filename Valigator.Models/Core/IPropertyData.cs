using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Core
{
	public interface IPropertyData<TValue>
	{
		Result<TValue, ValidationError[]> CoerceUnset();

		Result<TValue, ValidationError[]> CoerceNone();

		Result<Unit, ValidationError[]> Validate(TValue value);
	}

	public interface IPropertyData<TInput, TValue> : IPropertyData<TValue>
	{
		Result<TValue, ValidationError[]> CoerceValue(TInput value);
	}
}
