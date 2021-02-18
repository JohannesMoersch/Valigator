using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valigator
{
	public static class ModelDefinitionPropertyExtensions
	{
		public static void Validate<TModel, TModelView, TValue>(this ModelDefinition<TModel, TModelView>.Property<TValue> property, TModel model, string propertyName, TValue value, ref ModelPropertyState state, ref ModelErrorDictionary errorDictionary)
			where TModel : IModel<TModelView>
		{
			if (property.Validate(model, value).TryGetValue(out _, out var failure))
				state = ModelPropertyState.Valid;
			else
			{
				state = ModelPropertyState.Invalid;
				errorDictionary.Add(propertyName, failure);
			}
		}

		public static void CoerceUnset<TModel, TModelView, TValue>(this ModelDefinition<TModel, TModelView>.Property<TValue> property, string propertyName, ref TValue value, ref ModelPropertyState state, ref ModelErrorDictionary errorDictionary)
			where TModel : IModel<TModelView>
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
