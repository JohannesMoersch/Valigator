using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	internal static class ValidationErrors
	{
		public static ValidationError UnsetValuesNotAllowed()
			=> new ValidationError("Unset values not allowed.");

		public static ValidationError NullValuesNotAllowed()
			=> new ValidationError("Null values not allowed.");

		public static ValidationError NullValueAtIndexIsNotAllowed(int index)
			=> new ValidationError($"Null value at index \"{index}\" is not allowed.");

		public static ValidationError NullValueAtKeyIsNotAllowed<TKey>(TKey key)
			=> new ValidationError($"Null value at key \"{key}\" is not allowed.");
	}
}
