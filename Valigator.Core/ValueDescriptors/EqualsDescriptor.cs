using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.ValueDescriptors
{
	public class EqualsDescriptor : IValueDescriptor, IEquatable<EqualsDescriptor>
	{
		public object Value { get; }

		public EqualsDescriptor(object value) 
			=> Value = value ?? throw new ArgumentNullException(nameof(value));

		public override bool Equals(object obj) 
			=> Equals(obj as EqualsDescriptor);

		public bool Equals(EqualsDescriptor other) 
			=> other != null && EqualityComparer<object>.Default.Equals(Value, other.Value);

		public bool Equals(IValueDescriptor other)
			=> other is EqualsDescriptor equalsDescriptor && Equals(equalsDescriptor);

		public override int GetHashCode() 
			=> -1937169414 + EqualityComparer<object>.Default.GetHashCode(Value);
	}
}
