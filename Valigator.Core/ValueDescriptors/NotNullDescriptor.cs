using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.ValueDescriptors
{
	public class NotNullDescriptor : IValueDescriptor, IEquatable<NotNullDescriptor>
	{
		public override bool Equals(object obj) 
			=> Equals(obj as NotNullDescriptor);

		public bool Equals(NotNullDescriptor other)
			=> other != null;

		public bool Equals(IValueDescriptor other)
			=> other is NotNullDescriptor notNullDescriptor && Equals(notNullDescriptor);

		public override int GetHashCode() 
			=> -1757793268;
	}
}
