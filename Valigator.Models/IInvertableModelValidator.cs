using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator
{
	public interface IInvertableModelValidator<in TModel, in TValue> : IModelValidator<TModel, TValue>
	{
		Result<Unit, ValidationError[]> InverseValidate(TModel model, TValue value);
	}
}
