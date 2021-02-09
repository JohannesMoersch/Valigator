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
		public static ModelDefinition<TModel>.Property<TValue> ToProperty<TModel, TValue>(this ModelValidationDataBase<TModel, TValue> data)
			=> data;
	}
}
