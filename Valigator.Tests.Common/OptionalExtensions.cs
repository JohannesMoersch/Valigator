using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Tests.Common
{
	public static class OptionalExtensions
	{
		public static TValue AssertSet<TValue>(this Optional<TValue> option)
			=> option.Match(_ => _, () => throw new Exception("Expected set but found unset."));

		public static void AssertUnset<TValue>(this Optional<TValue> option)
			=> option.Match(_ => throw new Exception("Expected unset but found set."), () => default(TValue));
	}
}
