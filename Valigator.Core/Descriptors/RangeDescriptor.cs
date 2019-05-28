using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.Descriptors
{
	public class RangeDescriptor : IValueDescriptor
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
	}
}
