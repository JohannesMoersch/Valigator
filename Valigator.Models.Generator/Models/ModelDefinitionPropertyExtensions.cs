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
		public static void Validate<TModelView, TValue>(this ModelDefinition<TModelView>.Property<TValue> property, TModelView model, string propertyName, TValue value, ref ModelPropertyState state, ref ModelErrorDictionary errorDictionary)
		{
			if (property.Validate(model, value).TryGetValue(out _, out var failure))
				state = ModelPropertyState.Valid;
			else
			{
				state = ModelPropertyState.Invalid;
				errorDictionary.Add(propertyName, failure);
			}
		}

		public static void CoerceUnset<TModelView, TValue>(this ModelDefinition<TModelView>.Property<TValue> property, string propertyName, ref TValue value, ref ModelPropertyState state, ref ModelErrorDictionary errorDictionary)
		{
			if (property.CoerceUnset().TryGetValue(out var success, out var failure))
			{
				value = success;
				state = ModelPropertyState.Unvalidated;
			}
			else
			{
				state = ModelPropertyState.CoerceFailed;
				errorDictionary.Add(propertyName, failure);
			}
		}
	}
}
