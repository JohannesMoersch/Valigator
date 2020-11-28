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

		public ModelPropertyFactory<TModel, TValue> Value<TValue>()
			=> ModelPropertyFactory<TModel, TValue>.Instance;

		public ModelPropertyFactory<TModel, TValue[]> Collection<TValue>()
			=> ModelPropertyFactory<TModel, TValue[]>.Instance;

		public ModelPropertyFactory<TModel, TValue[]> Collection<TValue>(Func<IModelValidatorSet<TModel, TValue>, IModelValidatorSet<TModel, TValue>> valueValidations)
			=> throw new NotImplementedException();

		public ModelPropertyFactory<TModel, Dictionary<string, TValue>> Dictionary<TValue>()
			=> ModelPropertyFactory<TModel, Dictionary<string, TValue>>.Instance;

		public ModelPropertyFactory<TModel, Dictionary<string, TValue>> Dictionary<TValue>(Func<IModelValidatorSet<TModel, TValue>, IModelValidatorSet<TModel, TValue>> valueValidations)
			=> throw new NotImplementedException();
	}

	public class ModelPropertyFactory<TModel, TValue>
	{
		public static ModelPropertyFactory<TModel, TValue> Instance { get; } = new ModelPropertyFactory<TModel, TValue>(NonNullableModelValidatorSet.Empty<TModel, TValue>());

		private ModelPropertyFactory(IModelValidatorSet<TModel, TValue> modelValidatoions) { }

		public NonNullableModelValidatorSet<TModel, TValue> Required()
			=> throw new NotImplementedException();

		public NonNullableModelValidatorSet<TModel, TValue> Optional()
			=> throw new NotImplementedException();

		public NonNullableModelValidatorSet<TModel, TValue> Defaulted()
			=> throw new NotImplementedException();
	}
}
