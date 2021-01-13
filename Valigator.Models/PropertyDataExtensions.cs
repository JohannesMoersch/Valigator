using Functional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Valigator.Core;

namespace Valigator
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class PropertyDataExtensions
	{
		public static Result<TValue, ValidationError[]> Coerce<TInput, TValue>(this IPropertyData<TInput, TValue> propertyData, Optional<Option<TInput>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return propertyData.CoerceValue(item);

				return propertyData.CoerceNone();
			}

			return propertyData.CoerceUnset();
		}
	}
}
