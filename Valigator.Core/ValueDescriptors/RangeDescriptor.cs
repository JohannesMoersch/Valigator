using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.ValueDescriptors
{
	public class RangeDescriptor : IValueDescriptor, IEquatable<RangeDescriptor>
	{
		public Option<object> LessThanValue { get; }

		public bool LessThanOrEqualTo { get; }

		public Option<object> GreaterThanValue { get; }

		public bool GreaterThanOrEqualTo { get; }

		public RangeDescriptor(Option<object> lessThanValue, bool lessThanOrEqualTo, Option<object> greaterThanValue, bool greaterThanOrEqualTo)
		{
			LessThanValue = lessThanValue;
			LessThanOrEqualTo = lessThanOrEqualTo;
			GreaterThanValue = greaterThanValue;
			GreaterThanOrEqualTo = greaterThanOrEqualTo;
		}

		public override bool Equals(object obj) 
			=> Equals(obj as RangeDescriptor);

		public bool Equals(RangeDescriptor other)
			=> other != null && LessThanValue.Equals(other.LessThanValue) && LessThanOrEqualTo == other.LessThanOrEqualTo && GreaterThanValue.Equals(other.GreaterThanValue) && GreaterThanOrEqualTo == other.GreaterThanOrEqualTo;

		public bool Equals(IValueDescriptor other)
			=> other is RangeDescriptor rangeDescriptor && Equals(rangeDescriptor);

		public override int GetHashCode()
		{
			var hashCode = 1146995530;
			hashCode = hashCode * -1521134295 + EqualityComparer<Option<object>>.Default.GetHashCode(LessThanValue);
			hashCode = hashCode * -1521134295 + LessThanOrEqualTo.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<Option<object>>.Default.GetHashCode(GreaterThanValue);
			hashCode = hashCode * -1521134295 + GreaterThanOrEqualTo.GetHashCode();
			return hashCode;
		}
	}
}
