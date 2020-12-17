using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models
{
	public interface IModelValidationData<TNext, out TModel, out TValue>
	{
		TNext WithValidator(IModelValidator<TModel, TValue> value);
	}
}
