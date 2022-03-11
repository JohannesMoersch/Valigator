using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator.Models
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ModelDefinitionPropertyExtensions
	{
		public static void Validate<TModelView, TValue>(this ModelDefinition<TModelView>.Property<TValue> property, TModelView model, string propertyName, TValue value, CoercedModelErrorDictionary? coercedErrorDictionary, ref ValidatedModelErrorDictionary? errorDictionary)
		{
			if (!property.Validate(model, value).TryGetValue(out _, out var failure))
				(errorDictionary ??= coercedErrorDictionary?.ToValidatedModelErrorDictionary() ?? new ValidatedModelErrorDictionary()).Add(propertyName, failure);
		}

		public static void CoerceUnset<TModelView, TValue>(this ModelDefinition<TModelView>.Property<TValue> property, string propertyName, ref TValue value, ref ModelPropertyState state, ref CoercedModelErrorDictionary? errorDictionary)
		{
			if (property.CoerceUnset().TryGetValue(out var success, out var failure))
				value = success;
			else
			{
				state = ModelPropertyState.CoerceFailed;
				(errorDictionary ??= new CoercedModelErrorDictionary()).Add(propertyName, failure);
			}
		}
	}
}
