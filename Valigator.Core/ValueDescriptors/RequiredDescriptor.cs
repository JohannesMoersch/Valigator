using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.ValueDescriptors
{
	public class RequiredDescriptor : IValueDescriptor, IEquatable<RequiredDescriptor>
	{
		public override bool Equals(object obj) 
			=> Equals(obj as RequiredDescriptor);

		public bool Equals(RequiredDescriptor other) 
			=> other != null;

		public bool Equals(IValueDescriptor other)
			=> other is RequiredDescriptor requiredDescriptor && Equals(requiredDescriptor);

		public override int GetHashCode()
			=> 2118541809;
	}
}
