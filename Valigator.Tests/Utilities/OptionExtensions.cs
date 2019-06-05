using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Tests
{
	public static class OptionExtensions
	{
		public static TValue AssertSome<TValue>(this Option<TValue> option)
			=> option.Match(_ => _, () => throw new Exception("Expected some but found none."));

		public static void AssertNone<TValue>(this Option<TValue> option)
			=> option.Match(_ => throw new Exception("Expected none but found some."), () => default(TValue));
	}
}
