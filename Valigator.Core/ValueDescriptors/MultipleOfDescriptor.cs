using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.ValueDescriptors
{
	public class MultipleOfDescriptor : IValueDescriptor, IEquatable<MultipleOfDescriptor>
	{
		public object Divisor { get; }

		public MultipleOfDescriptor(object divisor) 
			=> Divisor = divisor ?? throw new ArgumentNullException(nameof(divisor));

		public override bool Equals(object obj) 
			=> Equals(obj as MultipleOfDescriptor);

		public bool Equals(MultipleOfDescriptor other) 
			=> other != null && EqualityComparer<object>.Default.Equals(Divisor, other.Divisor);

		public bool Equals(IValueDescriptor other)
			=> other is MultipleOfDescriptor multipleOfDescriptor && Equals(multipleOfDescriptor);

		public override int GetHashCode() 
			=> 2033165445 + EqualityComparer<object>.Default.GetHashCode(Divisor);
	}
}
