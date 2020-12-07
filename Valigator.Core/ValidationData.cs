using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public class ValidationData<TValue> : IValidationData<ValidationData<TValue>, TValue>, IInvertableValidationData<ValidationData<TValue>, TValue>
	{
		public ValidationData<TValue> WithValidator(IValidator<TValue> value)
			=> throw new NotImplementedException();

		public ValidationData<TValue> WithValidator(IInvertableValidator<TValue> value) 
			=> throw new NotImplementedException();
	}
}
