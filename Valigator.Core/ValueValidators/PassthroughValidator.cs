using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core.ValueValidators
{
	internal struct PassthroughValidator<TValue> : IValueValidator<TValue>
	{
		public Data<TValue> Data => throw new NotImplementedException();

		IValueDescriptor IValueValidator<TValue>.GetDescriptor()
			=> null;

		bool IValueValidator<TValue>.IsValid(TValue value)
			=> true;

		ValidationError IValueValidator<TValue>.GetError(TValue value, bool inverted)
			=> throw new NotImplementedException();
	}
}
