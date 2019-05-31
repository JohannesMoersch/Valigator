using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.ValueDescriptors
{
	public class StringLengthDescriptor : IValueDescriptor, IEquatable<StringLengthDescriptor>
	{
		public Option<int> MinimumLength { get; }

		public Option<int> MaximumLength { get; }

		public StringLengthDescriptor(Option<int> minimumLength, Option<int> maximumLength)
		{
			MinimumLength = minimumLength;
			MaximumLength = maximumLength;
		}

		public override bool Equals(object obj)
			=> Equals(obj as StringLengthDescriptor);

		public bool Equals(StringLengthDescriptor other) 
			=> other != null && MinimumLength.Equals(other.MinimumLength) && MaximumLength.Equals(other.MaximumLength);

		public bool Equals(IValueDescriptor other)
			=> other is StringLengthDescriptor stringLengthDescriptor && Equals(stringLengthDescriptor);

		public override int GetHashCode()
		{
			var hashCode = -1002496056;
			hashCode = hashCode * -1521134295 + EqualityComparer<Option<int>>.Default.GetHashCode(MinimumLength);
			hashCode = hashCode * -1521134295 + EqualityComparer<Option<int>>.Default.GetHashCode(MaximumLength);
			return hashCode;
		}
	}
}
