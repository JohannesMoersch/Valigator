using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models
{
	public interface IInvertableModelValidationData<TNext, TModel, TValue>
	{
		public TNext WithValidator(IInvertableModelValidator<TModel, TValue> value);
	}
}
