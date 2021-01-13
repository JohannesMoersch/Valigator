using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Core
{
	public interface IModelPropertyData<TModel, TValue>
	{
		Result<TValue, ValidationError[]> CoerceUnset();

		Result<TValue, ValidationError[]> CoerceNone();

		Result<Unit, ValidationError[]> Validate(TModel model, TValue value);
	}

	public interface IModelPropertyData<TModel, TInput, TValue> : IModelPropertyData<TModel, TValue>
	{
		Result<TValue, ValidationError[]> CoerceValue(TInput value);
	}
}
