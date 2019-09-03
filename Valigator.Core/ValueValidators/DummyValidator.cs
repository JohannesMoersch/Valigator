using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.ValueValidators
{
	internal struct DummyValidator<TValue> : IValueValidator<TValue>
	{
		public static DummyValidator<TValue> Instance { get; } = new DummyValidator<TValue>();

		bool IValueValidator<TValue>.RequiresModel => false;

		bool IValueValidator<TValue>.IsValid(Option<object> model, TValue value)
			=> true;

		IValueDescriptor IValueValidator<TValue>.GetDescriptor() => throw new NotImplementedException();
		ValidationError IValueValidator<TValue>.GetError(TValue value, bool inverted) => throw new NotImplementedException();
	}
}
