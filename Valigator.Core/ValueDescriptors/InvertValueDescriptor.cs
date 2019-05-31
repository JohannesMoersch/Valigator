using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.ValueDescriptors
{
	public class InvertValueDescriptor : IValueDescriptor, IEquatable<InvertValueDescriptor>
	{
		public IValueDescriptor InvertedDescriptor { get; }

		public InvertValueDescriptor(IValueDescriptor invertedDescriptor) 
			=> InvertedDescriptor = invertedDescriptor;

		public override bool Equals(object obj) 
			=> Equals(obj as InvertValueDescriptor);

		public bool Equals(InvertValueDescriptor other) 
			=> other != null && EqualityComparer<IValueDescriptor>.Default.Equals(InvertedDescriptor, other.InvertedDescriptor);

		public bool Equals(IValueDescriptor other)
			=> other is InvertValueDescriptor invertValueDescriptor && Equals(invertValueDescriptor);

		public override int GetHashCode() 
			=> -747274847 + EqualityComparer<IValueDescriptor>.Default.GetHashCode(InvertedDescriptor);
	}
}
