using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core.Descriptors;

namespace Valigator.Core
{
	public struct DataDescriptor
	{
		public IStateDescriptor StateDescriptor { get; }

		public IReadOnlyList<IValueDescriptor> ValueDescriptors { get; }

		public DataDescriptor(IStateDescriptor stateDescriptor, IEnumerable<IValueDescriptor> valueDescriptors)
		{
			StateDescriptor = stateDescriptor ?? throw new ArgumentNullException(nameof(stateDescriptor));
			ValueDescriptors = (valueDescriptors ?? throw new ArgumentNullException(nameof(valueDescriptors))).ToArray();
		}
	}
}
