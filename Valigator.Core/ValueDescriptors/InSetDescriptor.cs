using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.ValueDescriptors
{
	public class InSetDescriptor : IValueDescriptor
	{
		public IReadOnlyList<object> Options { get; }

		public InSetDescriptor(object[] options) 
			=> Options = options ?? throw new ArgumentNullException(nameof(options));
	}
}
