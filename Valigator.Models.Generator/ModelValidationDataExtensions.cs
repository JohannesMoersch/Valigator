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
		public static ModelDefinition<TModelView>.Property<TValue> ToProperty<TModel, TModelView, TValue>(this ModelValidationDataBase<TModelView, TValue> data)
			=> data;
	}
}
