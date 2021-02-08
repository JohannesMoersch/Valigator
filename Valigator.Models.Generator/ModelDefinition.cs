using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.ModelValidationData;

namespace Valigator
{
	public abstract class ModelDefinition<TModel>
	{
		protected static ModelPropertyFactory<TModel> Data => ModelPropertyFactory<TModel>.Instance;

		public class Property<TValue>
		{
			public Property(IModelPropertyData<TModel, TValue> data)
			{
			}
		}
	}
}
