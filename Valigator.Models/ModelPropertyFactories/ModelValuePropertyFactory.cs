using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.ModelValidationData;

namespace Valigator.ModelPropertyFactories
{
	public class ModelValuePropertyFactory<TModel, TValue>
	{
		public static ModelValuePropertyFactory<TModel, TValue> Instance { get; } = new ModelValuePropertyFactory<TModel, TValue>();

		private ModelValuePropertyFactory() { }

		public RequiredValueModelValidationData<TModel, TValue> Required()
			=> new RequiredValueModelValidationData<TModel, TValue>(new ValidationData<ModelValue<TModel, TValue>>());

		public OptionalValueModelValidationData<TModel, TValue> Optional()
			=> new OptionalValueModelValidationData<TModel, TValue>(new ValidationData<ModelValue<TModel, TValue>>());

		public DefaultedValueModelValidationData<TModel, TValue> Defaulted(TValue defaultValue)
			=> new DefaultedValueModelValidationData<TModel, TValue>(() => defaultValue, new ValidationData<ModelValue<TModel, TValue>>());

		public DefaultedValueModelValidationData<TModel, TValue> Defaulted(Func<TValue> defaultValue)
			=> new DefaultedValueModelValidationData<TModel, TValue>(defaultValue, new ValidationData<ModelValue<TModel, TValue>>());
	}

	public class ModelNullableValuePropertyFactory<TModel, TValue>
	{
		public static ModelNullableValuePropertyFactory<TModel, TValue> Instance { get; } = new ModelNullableValuePropertyFactory<TModel, TValue>();

		private ModelNullableValuePropertyFactory() { }

		public RequiredNullableValueModelValidationData<TModel, TValue> Required()
			=> new RequiredNullableValueModelValidationData<TModel, TValue>(new ValidationData<ModelValue<TModel, TValue>>());

		public OptionalNullableValueModelValidationData<TModel, TValue> Optional()
			=> new OptionalNullableValueModelValidationData<TModel, TValue>(new ValidationData<ModelValue<TModel, TValue>>());

		public DefaultedNullableValueModelValidationData<TModel, TValue> Defaulted(Option<TValue> defaultValue)
			=> new DefaultedNullableValueModelValidationData<TModel, TValue>(() => defaultValue, new ValidationData<ModelValue<TModel, TValue>>());

		public DefaultedNullableValueModelValidationData<TModel, TValue> Defaulted(Func<Option<TValue>> defaultValue)
			=> new DefaultedNullableValueModelValidationData<TModel, TValue>(defaultValue, new ValidationData<ModelValue<TModel, TValue>>());
	}
}
