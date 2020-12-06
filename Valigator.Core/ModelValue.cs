using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public struct ModelValue<TModel, TValue>
	{
		public TModel Model { get; }

		public TValue Value { get; }

		public ModelValue(TModel model, TValue value)
		{
			Model = model;
			Value = value;
		}
	}
}
