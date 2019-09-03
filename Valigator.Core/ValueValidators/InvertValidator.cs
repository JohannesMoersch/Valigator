using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core.ValueValidators
{
	internal struct InvertValidator<TValueValidator, TValue> : IValueValidator<TValue>
		where TValueValidator : IValueValidator<TValue>
	{
		private readonly TValueValidator _valueValidator;

		bool IValueValidator<TValue>.RequiresModel => false;

		public InvertValidator(TValueValidator valueValidator)
			=> _valueValidator = valueValidator;

		IValueDescriptor IValueValidator<TValue>.GetDescriptor()
			=> new InvertValueDescriptor(_valueValidator.GetDescriptor());

		bool IValueValidator<TValue>.IsValid(Option<object> model, TValue value)
			=> !_valueValidator.IsValid(model, value);

		ValidationError IValueValidator<TValue>.GetError(TValue value, bool inverted)
			=> _valueValidator.GetError(value, !inverted);
	}
}
