using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Core
{
	public interface IModelPropertyData<TModel, TInput, TValue>
	{
		Result<TValue, ValidationError[]> Coerce(TInput value);

		Result<Unit, ValidationError[]> Validate(TModel model, TValue value);
	}
}
