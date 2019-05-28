using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;

namespace Valigator.Core.ValueValidators
{
	public struct PassthroughValidator<TValue> : IValueValidator<TValue>
	{
		public Data<TValue> Data => throw new NotImplementedException();

		IEnumerable<IValueDescriptor> IValueValidator<TValue>.GetDescriptors()
			=> Enumerable.Empty<IValueDescriptor>();

		public Result<Unit, ValidationError> Validate(TValue value)
			=> Result.Unit<ValidationError>();
	}
}
