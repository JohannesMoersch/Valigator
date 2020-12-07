using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public class ValidationData<TInput, TValue> : IValidationData<ValidationData<TInput, TValue>, TInput, TValue>, IInvertableValidationData<ValidationData<TInput, TValue>, TInput, TValue>
	{
		public ValidationData<TInput, TValue> WithValidator(IValidator<TValue> value)
			=> throw new NotImplementedException();

		public ValidationData<TInput, TValue> WithValidator(IInvertableValidator<TValue> value) 
			=> throw new NotImplementedException();
	}
}
