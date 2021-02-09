using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public abstract class ModelValidationDataBase<TModel, TValue> : IModelPropertyData<TModel, TValue>
	{
		public abstract Result<TValue, ValidationError[]> CoerceNone();

		public abstract Result<TValue, ValidationError[]> CoerceUnset();

		public abstract Result<Unit, ValidationError[]> Validate(TModel model, TValue value);
	}
}
