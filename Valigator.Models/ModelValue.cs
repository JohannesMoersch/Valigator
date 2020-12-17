using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models
{
	public static class ModelValue
	{
		public static ModelValue<TModel, TValue> Create<TModel, TValue>(TModel model, TValue value)
			=> new ModelValue<TModel, TValue>(model, value);
	}

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
