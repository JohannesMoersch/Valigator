using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Tests
{
	public static class ValidatorExtensions
	{
		public static bool IsValid<TValue>(this IValueValidator<TValue> validator, TValue value)
			=> validator.IsValid(value);
	}
}
