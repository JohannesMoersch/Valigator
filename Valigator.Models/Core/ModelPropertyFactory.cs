using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;
using Valigator.ModelPropertyFactories;

namespace Valigator.Core
{
	public class ModelPropertyFactory<TModel>
	{
		public static ModelPropertyFactory<TModel> Instance { get; } = new ModelPropertyFactory<TModel>();

		private ModelPropertyFactory() { }

		public ModelValuePropertyFactory<TModel, TValue> Value<TValue>()
			=> ModelValuePropertyFactory<TModel, TValue>.Instance;

		public ModelValuePropertyFactory<TModel, TValue> Value<TValue>(Func<ModelValuePropertyFactoryOptions, ModelValuePropertyFactoryOptions> options)
			=> ModelValuePropertyFactory<TModel, TValue>.Instance;

		public ModelNullableValuePropertyFactory<TModel, TValue> Value<TValue>(Func<ModelValuePropertyFactoryOptions, ModelNullableValuePropertyFactoryOptions> options)
			=> ModelNullableValuePropertyFactory<TModel, TValue>.Instance;

		public ModelCollectionPropertyFactory<TModel, TValue> Collection<TValue>()
			=> ModelCollectionPropertyFactory<TModel, TValue>.Instance;

		public ModelCollectionPropertyFactory<TModel, TValue> Collection<TValue>(Func<ModelCollectionPropertyFactoryOptions, ModelCollectionPropertyFactoryOptions> options)
			=> ModelCollectionPropertyFactory<TModel, TValue>.Instance;

		public ModelNullableCollectionPropertyFactory<TModel, TValue> Collection<TValue>(Func<ModelCollectionPropertyFactoryOptions, ModelNullableCollectionPropertyFactoryOptions> options)
			=> ModelNullableCollectionPropertyFactory<TModel, TValue>.Instance;

		public ModelOptionCollectionPropertyFactory<TModel, TValue> Collection<TValue>(Func<ModelCollectionPropertyFactoryOptions, ModelOptionCollectionPropertyFactoryOptions> options)
			=> ModelOptionCollectionPropertyFactory<TModel, TValue>.Instance;

		public ModelNullableOptionCollectionPropertyFactory<TModel, TValue> Collection<TValue>(Func<ModelCollectionPropertyFactoryOptions, ModelNullableOptionCollectionPropertyFactoryOptions> NullableOptions)
			=> ModelNullableOptionCollectionPropertyFactory<TModel, TValue>.Instance;

		public ModelDictionaryPropertyFactory<TModel, string, TValue> Dictionary<TValue>()
			=> ModelDictionaryPropertyFactory<TModel, string, TValue>.Instance;

		public ModelDictionaryPropertyFactory<TModel, string, TValue> Dictionary<TValue>(Func<ModelDictionaryPropertyFactoryOptions, ModelDictionaryPropertyFactoryOptions> options)
			=> ModelDictionaryPropertyFactory<TModel, string, TValue>.Instance;

		public ModelNullableDictionaryPropertyFactory<TModel, string, TValue> Dictionary<TValue>(Func<ModelDictionaryPropertyFactoryOptions, ModelNullableDictionaryPropertyFactoryOptions> options)
			=> ModelNullableDictionaryPropertyFactory<TModel, string, TValue>.Instance;

		public ModelOptionDictionaryPropertyFactory<TModel, string, TValue> Dictionary<TValue>(Func<ModelDictionaryPropertyFactoryOptions, ModelOptionDictionaryPropertyFactoryOptions> options)
			=> ModelOptionDictionaryPropertyFactory<TModel, string, TValue>.Instance;

		public ModelNullableOptionDictionaryPropertyFactory<TModel, string, TValue> Dictionary<TValue>(Func<ModelDictionaryPropertyFactoryOptions, ModelNullableOptionDictionaryPropertyFactoryOptions> NullableOptions)
			=> ModelNullableOptionDictionaryPropertyFactory<TModel, string, TValue>.Instance;

		public ModelDictionaryPropertyFactory<TModel, TKey, TValue> Dictionary<TKey, TValue>()
			=> ModelDictionaryPropertyFactory<TModel, TKey, TValue>.Instance;

		public ModelDictionaryPropertyFactory<TModel, TKey, TValue> Dictionary<TKey, TValue>(Func<ModelDictionaryPropertyFactoryOptions, ModelDictionaryPropertyFactoryOptions> options)
			=> ModelDictionaryPropertyFactory<TModel, TKey, TValue>.Instance;

		public ModelNullableDictionaryPropertyFactory<TModel, TKey, TValue> Dictionary<TKey, TValue>(Func<ModelDictionaryPropertyFactoryOptions, ModelNullableDictionaryPropertyFactoryOptions> options)
			=> ModelNullableDictionaryPropertyFactory<TModel, TKey, TValue>.Instance;

		public ModelOptionDictionaryPropertyFactory<TModel, TKey, TValue> Dictionary<TKey, TValue>(Func<ModelDictionaryPropertyFactoryOptions, ModelOptionDictionaryPropertyFactoryOptions> options)
			=> ModelOptionDictionaryPropertyFactory<TModel, TKey, TValue>.Instance;

		public ModelNullableOptionDictionaryPropertyFactory<TModel, TKey, TValue> Dictionary<TKey, TValue>(Func<ModelDictionaryPropertyFactoryOptions, ModelNullableOptionDictionaryPropertyFactoryOptions> NullableOptions)
			=> ModelNullableOptionDictionaryPropertyFactory<TModel, TKey, TValue>.Instance;
	}
}
