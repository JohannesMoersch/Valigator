using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core.ValueValidators
{
	public struct EqualsValidator<TValue> : IValueValidator<TValue>
	{
		private readonly TValue _value;

		public EqualsValidator(TValue value)
		{
			if (value == null)
				throw new ArgumentNullException(nameof(value));

			_value = value;
		}

		IValueDescriptor IValueValidator<TValue>.GetDescriptor()
			=> new EqualsDescriptor(_value);

		bool IValueValidator<TValue>.IsValid(TValue value)
			=> Equals(_value, value);

		ValidationError IValueValidator<TValue>.GetError(TValue value, bool inverted)
			=> new ValidationError("");
	}
}
