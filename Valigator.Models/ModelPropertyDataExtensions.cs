using Functional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Valigator.Core;

namespace Valigator
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ModelPropertyDataExtensions
	{
		public static Result<TValue, CoercionValidationError[]> Coerce<TModel, TInput, TValue>(this IModelPropertyData<TModel, TInput, TValue> propertyData, Optional<Option<TInput>> value)
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
