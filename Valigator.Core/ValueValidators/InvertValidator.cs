using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core.ValueValidators
{
	internal struct InvertValidator<TValueValidator, TValue> : IValueValidator<TValue>
		where TValueValidator : IValueValidator<TValue>
	{
		private readonly TValueValidator _valueValidator;

		public InvertValidator(TValueValidator valueValidator)
			=> _valueValidator = valueValidator;

		IValueDescriptor IValueValidator<TValue>.GetDescriptor()
			=> new InvertValueDescriptor(_valueValidator.GetDescriptor());

		bool IValueValidator<TValue>.IsValid(TValue value)
			=> !_valueValidator.IsValid(value);

		ValidationError IValueValidator<TValue>.GetError(TValue value, bool inverted)
			=> _valueValidator.GetError(value, !inverted);
	}
}
