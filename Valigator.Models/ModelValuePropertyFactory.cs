using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Models
{
	public class ModelValuePropertyFactory<TModel, TValue>
	{
		public static ModelValuePropertyFactory<TModel, TValue> Instance { get; } = new ModelValuePropertyFactory<TModel, TValue>(NonNullableModelValidatorSet.Empty<TModel, TValue>());

		private ModelValuePropertyFactory(IModelValidatorSet<TModel, TValue> modelValidatoions) { }

		public IModelValidatorSet<TModel, TValue> Required() { }

		public IModelValidatorSet<TModel, TValue> Optional() { }

		public IModelValidatorSet<TModel, TValue> Defaulted() { }
	}
}
