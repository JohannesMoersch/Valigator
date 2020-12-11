using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public class ValidatorValidationData<TValue> : IValidationData<IValidator<TValue>, TValue>, IInvertableValidationData<NotValidator<TValue>, TValue>
	{
		public IValidator<TValue> WithValidator(IValidator<TValue> value)
			=> value;

		public NotValidator<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new NotValidator<TValue>(value);
	}
}
