using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;

namespace Valigator.Core.StateValidators
{
	public static class StateValidatorHelpers
	{
		public static TValue[] GetDefaultValue<TDataValue, TValue>(this ICollectionStateValidator<TDataValue, TValue> _, Option<TValue[]> defaultValue, Func<TValue[]> defaultValueFactory)
		{
			if (defaultValueFactory != null)
			{
				var value = defaultValueFactory.Invoke();

				if (value == null)
					throw new NullDefaultException();

				return value;
			}

			return defaultValue.TryGetValue(out var some) ? some : default;
		}

		public static TValue GetDefaultValue<TDataValue, TValue>(this IStateValidator<TDataValue, TValue> _, Option<TValue> defaultValue, Func<TValue> defaultValueFactory)
		{
			if (defaultValueFactory != null)
			{
				var value = defaultValueFactory.Invoke();

				if (value == null)
					throw new NullDefaultException();

				return value;
			}

			return defaultValue.TryGetValue(out var some) ? some : default;
		}
	}
}
