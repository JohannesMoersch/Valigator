using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core.Helpers
{
	internal static class OptionExtensions
	{
		public static bool TryGetValue<TValue>(this Option<TValue> option, out TValue value)
		{
			if (option.Match(_ => true, () => false))
			{
				value = option.Match(some => some, () => default);
				return true;
			}

			value = default;
			return false;
		}
	}
}
