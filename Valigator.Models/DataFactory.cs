using System;
using System.Collections.Generic;
using System.Text;
using Valigator.PropertyFactories;

namespace Valigator
{
	public static class Data
	{
		public static ValuePropertyFactory<TValue> Value<TValue>()
			=> ValuePropertyFactory<TValue>.Instance;

		public static ValuePropertyFactory<TValue> Value<TValue>(Func<ValuePropertyFactoryOptions, ValuePropertyFactoryOptions> options)
			=> ValuePropertyFactory<TValue>.Instance;

		public static NullableValuePropertyFactory<TValue> Value<TValue>(Func<ValuePropertyFactoryOptions, NullableValuePropertyFactoryOptions> options)
			=> NullableValuePropertyFactory<TValue>.Instance;

		public static CollectionPropertyFactory<TValue> Collection<TValue>()
			=> CollectionPropertyFactory<TValue>.Instance;

		public static CollectionPropertyFactory<TValue> Collection<TValue>(Func<CollectionPropertyFactoryOptions, CollectionPropertyFactoryOptions> options)
			=> CollectionPropertyFactory<TValue>.Instance;

		public static NullableCollectionPropertyFactory<TValue> Collection<TValue>(Func<CollectionPropertyFactoryOptions, NullableCollectionPropertyFactoryOptions> options)
			=> NullableCollectionPropertyFactory<TValue>.Instance;

		public static OptionCollectionPropertyFactory<TValue> Collection<TValue>(Func<CollectionPropertyFactoryOptions, OptionCollectionPropertyFactoryOptions> options)
			=> OptionCollectionPropertyFactory<TValue>.Instance;

		public static NullableOptionCollectionPropertyFactory<TValue> Collection<TValue>(Func<CollectionPropertyFactoryOptions, NullableOptionCollectionPropertyFactoryOptions> NullableOptions)
			=> NullableOptionCollectionPropertyFactory<TValue>.Instance;

		public static DictionaryPropertyFactory<string, TValue> Dictionary<TValue>()
			=> DictionaryPropertyFactory<string, TValue>.Instance;

		public static DictionaryPropertyFactory<string, TValue> Dictionary<TValue>(Func<DictionaryPropertyFactoryOptions, DictionaryPropertyFactoryOptions> options)
			=> DictionaryPropertyFactory<string, TValue>.Instance;

		public static NullableDictionaryPropertyFactory<string, TValue> Dictionary<TValue>(Func<DictionaryPropertyFactoryOptions, NullableDictionaryPropertyFactoryOptions> options)
			=> NullableDictionaryPropertyFactory<string, TValue>.Instance;

		public static OptionDictionaryPropertyFactory<string, TValue> Dictionary<TValue>(Func<DictionaryPropertyFactoryOptions, OptionDictionaryPropertyFactoryOptions> options)
			=> OptionDictionaryPropertyFactory<string, TValue>.Instance;

		public static NullableOptionDictionaryPropertyFactory<string, TValue> Dictionary<TValue>(Func<DictionaryPropertyFactoryOptions, NullableOptionDictionaryPropertyFactoryOptions> NullableOptions)
			=> NullableOptionDictionaryPropertyFactory<string, TValue>.Instance;

		public static DictionaryPropertyFactory<TKey, TValue> Dictionary<TKey, TValue>()
			=> DictionaryPropertyFactory<TKey, TValue>.Instance;

		public static DictionaryPropertyFactory<TKey, TValue> Dictionary<TKey, TValue>(Func<DictionaryPropertyFactoryOptions, DictionaryPropertyFactoryOptions> options)
			=> DictionaryPropertyFactory<TKey, TValue>.Instance;

		public static NullableDictionaryPropertyFactory<TKey, TValue> Dictionary<TKey, TValue>(Func<DictionaryPropertyFactoryOptions, NullableDictionaryPropertyFactoryOptions> options)
			=> NullableDictionaryPropertyFactory<TKey, TValue>.Instance;

		public static OptionDictionaryPropertyFactory<TKey, TValue> Dictionary<TKey, TValue>(Func<DictionaryPropertyFactoryOptions, OptionDictionaryPropertyFactoryOptions> options)
			=> OptionDictionaryPropertyFactory<TKey, TValue>.Instance;

		public static NullableOptionDictionaryPropertyFactory<TKey, TValue> Dictionary<TKey, TValue>(Func<DictionaryPropertyFactoryOptions, NullableOptionDictionaryPropertyFactoryOptions> NullableOptions)
			=> NullableOptionDictionaryPropertyFactory<TKey, TValue>.Instance;
	}
}
