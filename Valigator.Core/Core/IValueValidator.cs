using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public interface IValueValidator<TValue>
	{
		bool RequiresModel { get; }

		IValueDescriptor GetDescriptor();

		bool IsValid(Option<object> model, TValue value);

		ValidationError GetError(TValue value, bool inverted);
	}
}
