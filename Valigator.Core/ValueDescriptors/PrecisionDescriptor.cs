using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.ValueDescriptors
{
	public class PrecisionDescriptor : IValueDescriptor, IEquatable<PrecisionDescriptor>
	{
		public Option<decimal> MinimumDecimalPlaces { get; }
		public Option<decimal> MaximumDecimalPlaces { get; }
		
		public PrecisionDescriptor(Option<decimal> minimumDecimalPlaces, Option<decimal> maximumDecimalPlaces)
		{
			MinimumDecimalPlaces = minimumDecimalPlaces;
			MaximumDecimalPlaces = maximumDecimalPlaces;
		}

		public override bool Equals(object obj) 
			=> Equals(obj as PrecisionDescriptor);

		public bool Equals(PrecisionDescriptor other) 
			=> other != null && EqualityComparer<Option<decimal>>.Default.Equals(MinimumDecimalPlaces, other.MinimumDecimalPlaces) && EqualityComparer<Option<decimal>>.Default.Equals(MaximumDecimalPlaces, other.MaximumDecimalPlaces);

		public bool Equals(IValueDescriptor other)
			=> other is PrecisionDescriptor precisionDescriptor && Equals(precisionDescriptor);

		public override int GetHashCode()
		{
			var hashCode = -404372162;
			hashCode = hashCode * -1521134295 + EqualityComparer<Option<decimal>>.Default.GetHashCode(MinimumDecimalPlaces);
			hashCode = hashCode * -1521134295 + EqualityComparer<Option<decimal>>.Default.GetHashCode(MaximumDecimalPlaces);
			return hashCode;
		}
	}
}
