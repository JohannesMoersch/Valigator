using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Valigator.ModelValidationData;

namespace Valigator
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ModelValidationDataExtensions
	{
		public static ModelDefinition<TModel, TModelView>.Property<TValue> ToProperty<TModel, TModelView, TValue>(this ModelValidationDataBase<TModel, TValue> data)
			where TModel : IModel<TModelView>
			=> data;
	}
}
