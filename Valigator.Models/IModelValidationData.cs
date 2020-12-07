using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models
{
	public interface IModelValidationData<TNext, TModel, TValue>
	{
		TNext WithValidator(IModelValidator<TModel, TValue> value);
	}
}
