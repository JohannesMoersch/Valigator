using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;

namespace Valigator.Core
{
	public interface IValueValidator<TValue>
	{
		IValueDescriptor GetDescriptor();

		bool IsValid(TValue value);

		ValidationError GetError(TValue value, bool inverted);
	}
}
