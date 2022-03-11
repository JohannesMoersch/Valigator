using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	internal static class CoercionValidationErrors
	{
		public static CoercionValidationError UnsetValuesNotAllowed()
			=> new CoercionValidationError("Unset values not allowed.");

		public static CoercionValidationError NullValuesNotAllowed()
			=> new CoercionValidationError("Null values not allowed.");

		public static CoercionValidationError NullValueAtIndexIsNotAllowed(int index)
			=> new CoercionValidationError($"Null value at index \"{index}\" is not allowed.");

		public static CoercionValidationError NullValueAtKeyIsNotAllowed<TKey>(TKey key)
			=> new CoercionValidationError($"Null value at key \"{key}\" is not allowed.");
	}
}
