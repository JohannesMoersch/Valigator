using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models
{
	public class ModelPropertyFactory<TModel>
	{
		public static ModelPropertyFactory<TModel> Instance { get; } = new ModelPropertyFactory<TModel>();

		private ModelPropertyFactory() { }

		public NonNullableModelValidatorSet<TModel, TValue> Required<TValue>()
			=> NonNullableModelValidatorSet.Required<TModel, TValue>();

		public NonNullableModelValidatorSet<TModel, Option<TValue>> Optional<TValue>()
			=> NonNullableModelValidatorSet.Optional<TModel, Option<TValue>>();

		public NonNullableModelValidatorSet<TModel, TValue> Defaulted<TValue>()
			=> NonNullableModelValidatorSet.Defaulted<TModel, TValue>();

		public ModelPropertyFactory<TModel, TValue[]> Collection<TValue>()
			=> ModelPropertyFactory<TModel, TValue[]>.Instance;

		public ModelPropertyFactory<TModel, TValue[]> Collection<TValue>(Func<IModelValidatorSet<TModel, TValue>, IModelValidatorSet<TModel, TValue>> valueValidations) { }

		public ModelPropertyFactory<TModel, Dictionary<string, TValue>> Dictionary<TValue>()
			=> ModelPropertyFactory<TModel, Dictionary<string, TValue>>.Instance;

		public ModelPropertyFactory<TModel, Dictionary<string, TValue>> Dictionary<TValue>(Func<IModelValidatorSet<TModel, TValue>, IModelValidatorSet<TModel, TValue>> valueValidations) { }
	}

	public class ModelPropertyFactory<TModel, TValue>
	{
		public static ModelPropertyFactory<TModel, TValue> Instance { get; } = new ModelPropertyFactory<TModel, TValue>(NonNullableModelValidatorSet.Empty<TModel, TValue>());

		private ModelPropertyFactory(IModelValidatorSet<TModel, TValue> modelValidatoions) { }

		public NonNullableModelValidatorSet<TModel, TValue> Required() { }

		public NonNullableModelValidatorSet<TModel, TValue> Optional() { }

		public NonNullableModelValidatorSet<TModel, TValue> Defaulted() { }
	}
}
