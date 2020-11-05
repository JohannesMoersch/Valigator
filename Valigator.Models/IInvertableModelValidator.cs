using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public interface IInvertableModelValidator<TModel, TValue>
	{
		Result<Unit, ValidationError> InverseValidate(TModel model, TValue value);
	}
}
