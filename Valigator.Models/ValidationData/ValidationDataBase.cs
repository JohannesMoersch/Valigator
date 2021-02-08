using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public abstract class ValidationDataBase<TValue> : IPropertyData<TValue>
	{
		public abstract Result<TValue, ValidationError[]> CoerceNone();
		
		public abstract Result<TValue, ValidationError[]> CoerceUnset();

		public abstract Result<Unit, ValidationError[]> Validate(TValue value);
	}
}
