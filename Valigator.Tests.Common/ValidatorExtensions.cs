using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core;

namespace Valigator.Tests.Common
{
	public static class ValidatorExtensions
	{
		public static bool IsValid<TValue>(this IValueValidator<TValue> validator, TValue value)
			=> validator.IsValid(Option.None<object>(), value);
	}
}
