using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Models
{
	public class NullableModelPropertyFactory<TModel>
	{
		public static NullableModelPropertyFactory<TModel> Instance { get; } = new NullableModelPropertyFactory<TModel>();

		private NullableModelPropertyFactory() { }

		public ModelPropertyFactory<TModel, TValue> Value<TValue>()
			=> ModelPropertyFactory<TModel, TValue>.Instance;

		public ModelPropertyFactory<TModel, IReadOnlyList<TValue>> Collection<TValue>()
			=> ModelPropertyFactory<TModel, IReadOnlyList<TValue>>.Instance;

		public ModelPropertyFactory<TModel, Dictionary<string, TValue>> Dictionary<TValue>()
			=> ModelPropertyFactory<TModel, Dictionary<string, TValue>>.Instance;
	}

	public class NullableModelPropertyFactory<TModel, TValue>
	{
		public static NullableModelPropertyFactory<TModel, TValue> Instance { get; } = new NullableModelPropertyFactory<TModel, TValue>();

		private NullableModelPropertyFactory() { }

		public NonNullableModelValidatorSet<TModel, TValue> Required()
			=> throw new NotImplementedException();

		public NonNullableModelValidatorSet<TModel, TValue> Optional()
			=> throw new NotImplementedException();

		public NonNullableModelValidatorSet<TModel, TValue> Defaulted()
			=> throw new NotImplementedException();
	}
}
