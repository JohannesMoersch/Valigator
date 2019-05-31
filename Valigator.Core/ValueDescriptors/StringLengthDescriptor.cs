using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.ValueDescriptors
{
	public class StringLengthDescriptor : IValueDescriptor
	{
		public Option<int> MinimumLength { get; }

		public Option<int> MaximumLength { get; }

		public StringLengthDescriptor(Option<int> minimumLength, Option<int> maximumLength)
		{
			MinimumLength = minimumLength;
			MaximumLength = maximumLength;
		}
	}
}
