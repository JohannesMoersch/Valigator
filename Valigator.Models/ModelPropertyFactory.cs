using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public class ModelPropertyFactory<TModel>
	{
		public static ModelPropertyFactory<TModel> Instance { get; } = new ModelPropertyFactory<TModel>();

		private ModelPropertyFactory() { }

		public ModelValuePropertyFactory<TModel, TValue> Value<TValue>()
			=> ModelValuePropertyFactory<TModel, TValue>.Instance;

		public ModelPropertyFactory<TModel, IReadOnlyList<TValue>> Collection<TValue>()
			=> ModelPropertyFactory<TModel, IReadOnlyList<TValue>>.Instance;

		public ModelPropertyFactory<TModel, Dictionary<string, TValue>> Dictionary<TValue>()
			=> ModelPropertyFactory<TModel, Dictionary<string, TValue>>.Instance;

		public NullableModelPropertyFactory<TModel> Nullable()
			=> throw new NotImplementedException();
	}

	public class ModelPropertyFactory<TModel, TValue>
	{
		public static ModelPropertyFactory<TModel, TValue> Instance { get; } = new ModelPropertyFactory<TModel, TValue>();

		private ModelPropertyFactory() { }

		public NonNullableModelValidatorSet<TModel, TValue> Required()
			=> throw new NotImplementedException();

		public NonNullableModelValidatorSet<TModel, TValue> Optional()
			=> throw new NotImplementedException();

		public NonNullableModelValidatorSet<TModel, TValue> Defaulted()
			=> throw new NotImplementedException();
	}
}
