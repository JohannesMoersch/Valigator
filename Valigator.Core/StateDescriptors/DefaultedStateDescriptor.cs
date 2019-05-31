using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.StateDescriptors
{
	public class DefaultedStateDescriptor : IStateDescriptor, IEquatable<DefaultedStateDescriptor>
	{
		public bool Nullable { get; }

		public object DefaultValue { get; }

		public DefaultedStateDescriptor(bool nullable, object defaultValue)
		{
			Nullable = nullable;
			DefaultValue = defaultValue;
		}

		public override bool Equals(object obj) 
			=> Equals(obj as DefaultedStateDescriptor);

		public bool Equals(DefaultedStateDescriptor other) 
			=> other != null && Nullable == other.Nullable && EqualityComparer<object>.Default.Equals(DefaultValue, other.DefaultValue);

		public bool Equals(IStateDescriptor other)
			=> other is DefaultedStateDescriptor defaultedStateDescriptor && Equals(defaultedStateDescriptor);

		public override int GetHashCode()
		{
			var hashCode = -223084965;
			hashCode = hashCode * -1521134295 + Nullable.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(DefaultValue);
			return hashCode;
		}
	}
}
