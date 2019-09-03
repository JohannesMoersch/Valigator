using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core.ValueValidators
{
	public struct CustomValidator<TValue> : IValueValidator<TValue>
	{
		private readonly string _description;

		private readonly Func<TValue, bool> _validator;

		bool IValueValidator<TValue>.RequiresModel => false;

		public CustomValidator(string description, Func<TValue, bool> validator)
		{
			_description = description ?? throw new ArgumentNullException(nameof(description));
			_validator = validator ?? throw new ArgumentNullException(nameof(validator));
		}

		IValueDescriptor IValueValidator<TValue>.GetDescriptor()
			=> new CustomDescriptor(_description);

		bool IValueValidator<TValue>.IsValid(Option<object> model, TValue value)
			=> _validator.Invoke(value);

		ValidationError IValueValidator<TValue>.GetError(TValue value, bool inverted)
			=> new ValidationError(_description, (this as IValueValidator<TValue>).GetDescriptor());
	}
}
