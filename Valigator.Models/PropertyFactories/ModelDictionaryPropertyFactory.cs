using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Models.ValidationData;

namespace Valigator.Models.PropertyFactories
{
	public class ModelDictionaryPropertyFactory<TModel, TKey, TValue>
	{
		public static ModelDictionaryPropertyFactory<TModel, TKey, TValue> Instance { get; } = new ModelDictionaryPropertyFactory<TModel, TKey, TValue>();

		private ModelDictionaryPropertyFactory() { }

		public RequiredDictionaryModelValidationData<TModel, TKey, TValue> Required()
			=> new RequiredDictionaryModelValidationData<TModel, TKey, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>>());

		public OptionalDictionaryModelValidationData<TModel, TKey, TValue> Optional()
			=> new OptionalDictionaryModelValidationData<TModel, TKey, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>>());

		public DefaultedDictionaryModelValidationData<TModel, TKey, TValue> Defaulted(IReadOnlyDictionary<TKey, TValue> defaultValue)
			=> new DefaultedDictionaryModelValidationData<TModel, TKey, TValue>(defaultValue, new ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>>());
	}

	public class ModelNullableDictionaryPropertyFactory<TModel, TKey, TValue>
	{
		public static ModelNullableDictionaryPropertyFactory<TModel, TKey, TValue> Instance { get; } = new ModelNullableDictionaryPropertyFactory<TModel, TKey, TValue>();

		private ModelNullableDictionaryPropertyFactory() { }

		public RequiredNullableDictionaryModelValidationData<TModel, TKey, TValue> Required()
			=> new RequiredNullableDictionaryModelValidationData<TModel, TKey, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>>());

		public OptionalNullableDictionaryModelValidationData<TModel, TKey, TValue> Optional()
			=> new OptionalNullableDictionaryModelValidationData<TModel, TKey, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>>());

		public DefaultedNullableDictionaryModelValidationData<TModel, TKey, TValue> Defaulted(Option<IReadOnlyDictionary<TKey, TValue>> defaultValue)
			=> new DefaultedNullableDictionaryModelValidationData<TModel, TKey, TValue>(defaultValue, new ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>>());
	}

	public class ModelOptionDictionaryPropertyFactory<TModel, TKey, TValue>
	{
		public static ModelOptionDictionaryPropertyFactory<TModel, TKey, TValue> Instance { get; } = new ModelOptionDictionaryPropertyFactory<TModel, TKey, TValue>();

		private ModelOptionDictionaryPropertyFactory() { }

		public RequiredOptionDictionaryModelValidationData<TModel, TKey, TValue> Required()
			=> new RequiredOptionDictionaryModelValidationData<TModel, TKey, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>>());

		public OptionalOptionDictionaryModelValidationData<TModel, TKey, TValue> Optional()
			=> new OptionalOptionDictionaryModelValidationData<TModel, TKey, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>>());

		public DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue> Defaulted(IReadOnlyDictionary<TKey, Option<TValue>> defaultValue)
			=> new DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue>(defaultValue, new ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>>());
	}

	public class ModelNullableOptionDictionaryPropertyFactory<TModel, TKey, TValue>
	{
		public static ModelNullableOptionDictionaryPropertyFactory<TModel, TKey, TValue> Instance { get; } = new ModelNullableOptionDictionaryPropertyFactory<TModel, TKey, TValue>();

		private ModelNullableOptionDictionaryPropertyFactory() { }

		public RequiredNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> Required()
			=> new RequiredNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>>());

		public OptionalNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> NullableOptional()
			=> new OptionalNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(new ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>>());

		public DefaultedNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> Defaulted(Option<IReadOnlyDictionary<TKey, Option<TValue>>> defaultValue)
			=> new DefaultedNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(defaultValue, new ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>>());
	}
}
