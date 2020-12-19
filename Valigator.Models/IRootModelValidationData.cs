using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public interface IRootModelValidationData<TNext, TModel, out TValue> : IRootValidationData<TNext, TValue>, IModelValidationData<TNext, TModel, TValue>, IInvertableModelValidationData<TNext, TModel, TValue>
	{
	}
}
