using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public interface IModelValidator<TModel, TValue>
	{
		ValidatorResult Validate(TModel model, TValue value);
	}
}
