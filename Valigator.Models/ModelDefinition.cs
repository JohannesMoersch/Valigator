using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator
{
	public abstract class ModelDefinition<TModel>
	{
		protected ModelPropertyFactory<TModel> Data => ModelPropertyFactory<TModel>.Instance;
	}
}
