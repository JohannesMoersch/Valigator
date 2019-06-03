using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.ValueDescriptors
{
	public class UniqueDescriptor : IValueDescriptor, IEquatable<UniqueDescriptor>
	{
		public override bool Equals(object obj)
			=> obj is UniqueDescriptor;

		public bool Equals(UniqueDescriptor other)
			=> other != null;

		public bool Equals(IValueDescriptor other)
			=> other is UniqueDescriptor uniqueDescriptor && Equals(uniqueDescriptor);

		public override int GetHashCode()
			=> -1757793268;
	}
}
