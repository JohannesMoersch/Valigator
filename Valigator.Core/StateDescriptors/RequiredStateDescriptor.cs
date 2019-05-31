using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.StateDescriptors
{
	public class RequiredStateDescriptor : IStateDescriptor, IEquatable<RequiredStateDescriptor>
	{
		public bool Nullable { get; }

		public RequiredStateDescriptor(bool nullable)
			=> Nullable = nullable;

		public override bool Equals(object obj) 
			=> Equals(obj as RequiredStateDescriptor);

		public bool Equals(RequiredStateDescriptor other)
			=> other != null && Nullable == other.Nullable;

		public bool Equals(IStateDescriptor other)
			=> other is RequiredStateDescriptor requiredStateDescriptor && Equals(requiredStateDescriptor);

		public override int GetHashCode() 
			=> 631946940 + Nullable.GetHashCode();
	}
}
