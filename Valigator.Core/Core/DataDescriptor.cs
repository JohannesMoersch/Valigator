using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public struct DataDescriptor : IEquatable<DataDescriptor>
	{
		public Type PropertyType { get; }

		public IStateDescriptor StateDescriptor { get; }

		public IReadOnlyList<IValueDescriptor> ValueDescriptors { get; }

		public DataDescriptor(Type propertyType, IStateDescriptor stateDescriptor, IValueDescriptor[] valueDescriptors)
		{
			PropertyType = propertyType ?? throw new ArgumentNullException(nameof(propertyType));
			StateDescriptor = stateDescriptor ?? throw new ArgumentNullException(nameof(stateDescriptor));
			ValueDescriptors = valueDescriptors ?? throw new ArgumentNullException(nameof(valueDescriptors));
		}

		public override bool Equals(object obj)
			=> obj is DataDescriptor descriptor && Equals(descriptor);

		public bool Equals(DataDescriptor other)
			=> EqualityComparer<Type>.Default.Equals(PropertyType, other.PropertyType) && EqualityComparer<IStateDescriptor>.Default.Equals(StateDescriptor, other.StateDescriptor) && ValueDescriptors.SequenceEqual(other.ValueDescriptors);

		public override int GetHashCode()
		{
			var hashCode = 1881245575;
			hashCode = hashCode * -1521134295 + EqualityComparer<Type>.Default.GetHashCode(PropertyType);
			hashCode = hashCode * -1521134295 + EqualityComparer<IStateDescriptor>.Default.GetHashCode(StateDescriptor);
			return ValueDescriptors.Aggregate(hashCode, (current, descriptor) => current * -1521134295 + EqualityComparer<IValueDescriptor>.Default.GetHashCode(descriptor));
		}
	}
}
