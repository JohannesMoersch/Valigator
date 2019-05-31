using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.StateDescriptors
{
	public class OptionalStateDescriptor : IStateDescriptor, IEquatable<OptionalStateDescriptor>
	{
		public bool Nullable { get; }

		public OptionalStateDescriptor(bool nullable)
			=> Nullable = nullable;

		public override bool Equals(object obj) 
			=> Equals(obj as OptionalStateDescriptor);

		public bool Equals(OptionalStateDescriptor other) 
			=> other != null && Nullable == other.Nullable;

		public bool Equals(IStateDescriptor other)
			=> other is OptionalStateDescriptor optionalStateDescriptor && Equals(optionalStateDescriptor);

		public override int GetHashCode() 
			=> 631946940 + Nullable.GetHashCode();
	}
}
