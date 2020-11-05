using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models
{
	public abstract class ModelDefinition<TModel>
	{
		public ModelPropertyFactory<TModel> Data { get; }
	}
}
