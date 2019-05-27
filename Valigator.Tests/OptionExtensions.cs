using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigators.Tests
{
	public static class OptionExtensions
	{
		public static TValue AssureSome<TValue>(this Option<TValue> option)
			=> option.Match(_ => _, () => throw new Exception("Expected some but found none."));

		public static void AssureNone<TValue>(this Option<TValue> option)
			=> option.Match(_ => throw new Exception("Expected none but found some."), () => default(TValue));
	}
}
