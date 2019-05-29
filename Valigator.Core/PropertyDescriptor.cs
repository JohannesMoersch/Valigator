using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core.Descriptors;

namespace Valigator
{
	public struct PropertyDescriptor
	{
		public string PropertyName { get; }

		public IStateDescriptor StateDescriptor { get; }

		public IReadOnlyList<IValueDescriptor> ValueDescriptors { get; }

		public PropertyDescriptor(string propertyName, IStateDescriptor stateDescriptor, IEnumerable<IValueDescriptor> valueDescriptors)
		{
			PropertyName = propertyName ?? throw new ArgumentNullException(nameof(propertyName));
			StateDescriptor = stateDescriptor ?? throw new ArgumentNullException(nameof(stateDescriptor));
			ValueDescriptors = (valueDescriptors ?? throw new ArgumentNullException(nameof(valueDescriptors))).ToArray();
		}
	}
}
