using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public interface IModelValidator<in TModel, in TValue>
	{
		Result<Unit, ValidationError[]> Validate(TModel model, TValue value);
	}
}
