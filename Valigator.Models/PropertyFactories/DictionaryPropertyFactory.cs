using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.ValidationData;

namespace Valigator.PropertyFactories
{
	public class DictionaryPropertyFactory<TKey, TValue>
	{
		public static DictionaryPropertyFactory<TKey, TValue> Instance { get; } = new DictionaryPropertyFactory<TKey, TValue>();

		private DictionaryPropertyFactory() { }

		public RequiredDictionaryValidationData<TKey, TValue> Required()
			=> new RequiredDictionaryValidationData<TKey, TValue>(new ValidationData<IReadOnlyDictionary<TKey, TValue>>());

		public OptionalDictionaryValidationData<TKey, TValue> Optional()
			=> new OptionalDictionaryValidationData<TKey, TValue>(new ValidationData<IReadOnlyDictionary<TKey, TValue>>());

		public DefaultedDictionaryValidationData<TKey, TValue> Defaulted(IReadOnlyDictionary<TKey, TValue> defaultValue)
			=> new DefaultedDictionaryValidationData<TKey, TValue>(() => defaultValue, new ValidationData<IReadOnlyDictionary<TKey, TValue>>());

		public DefaultedDictionaryValidationData<TKey, TValue> Defaulted(Func<IReadOnlyDictionary<TKey, TValue>> defaultValue)
			=> new DefaultedDictionaryValidationData<TKey, TValue>(defaultValue, new ValidationData<IReadOnlyDictionary<TKey, TValue>>());
	}

	public class NullableDictionaryPropertyFactory<TKey, TValue>
	{
		public static NullableDictionaryPropertyFactory<TKey, TValue> Instance { get; } = new NullableDictionaryPropertyFactory<TKey, TValue>();

		private NullableDictionaryPropertyFactory() { }

		public RequiredNullableDictionaryValidationData<TKey, TValue> Required()
			=> new RequiredNullableDictionaryValidationData<TKey, TValue>(new ValidationData<IReadOnlyDictionary<TKey, TValue>>());

		public OptionalNullableDictionaryValidationData<TKey, TValue> Optional()
			=> new OptionalNullableDictionaryValidationData<TKey, TValue>(new ValidationData<IReadOnlyDictionary<TKey, TValue>>());

		public DefaultedNullableDictionaryValidationData<TKey, TValue> Defaulted(Option<IReadOnlyDictionary<TKey, TValue>> defaultValue)
			=> new DefaultedNullableDictionaryValidationData<TKey, TValue>(() => defaultValue, new ValidationData<IReadOnlyDictionary<TKey, TValue>>());

		public DefaultedNullableDictionaryValidationData<TKey, TValue> Defaulted(Func<Option<IReadOnlyDictionary<TKey, TValue>>> defaultValue)
			=> new DefaultedNullableDictionaryValidationData<TKey, TValue>(defaultValue, new ValidationData<IReadOnlyDictionary<TKey, TValue>>());
	}

	public class OptionDictionaryPropertyFactory<TKey, TValue>
	{
		public static OptionDictionaryPropertyFactory<TKey, TValue> Instance { get; } = new OptionDictionaryPropertyFactory<TKey, TValue>();

		private OptionDictionaryPropertyFactory() { }

		public RequiredOptionDictionaryValidationData<TKey, TValue> Required()
			=> new RequiredOptionDictionaryValidationData<TKey, TValue>(new ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>>());

		public OptionalOptionDictionaryValidationData<TKey, TValue> Optional()
			=> new OptionalOptionDictionaryValidationData<TKey, TValue>(new ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>>());

		public DefaultedOptionDictionaryValidationData<TKey, TValue> Defaulted(IReadOnlyDictionary<TKey, Option<TValue>> defaultValue)
			=> new DefaultedOptionDictionaryValidationData<TKey, TValue>(() => defaultValue, new ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>>());

		public DefaultedOptionDictionaryValidationData<TKey, TValue> Defaulted(Func<IReadOnlyDictionary<TKey, Option<TValue>>> defaultValue)
			=> new DefaultedOptionDictionaryValidationData<TKey, TValue>(defaultValue, new ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>>());
	}

	public class NullableOptionDictionaryPropertyFactory<TKey, TValue>
	{
		public static NullableOptionDictionaryPropertyFactory<TKey, TValue> Instance { get; } = new NullableOptionDictionaryPropertyFactory<TKey, TValue>();

		private NullableOptionDictionaryPropertyFactory() { }

		public RequiredNullableOptionDictionaryValidationData<TKey, TValue> Required()
			=> new RequiredNullableOptionDictionaryValidationData<TKey, TValue>(new ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>>());

		public OptionalNullableOptionDictionaryValidationData<TKey, TValue> Optional()
			=> new OptionalNullableOptionDictionaryValidationData<TKey, TValue>(new ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>>());

		public DefaultedNullableOptionDictionaryValidationData<TKey, TValue> Defaulted(Option<IReadOnlyDictionary<TKey, Option<TValue>>> defaultValue)
			=> new DefaultedNullableOptionDictionaryValidationData<TKey, TValue>(() => defaultValue, new ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>>());

		public DefaultedNullableOptionDictionaryValidationData<TKey, TValue> Defaulted(Func<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> defaultValue)
			=> new DefaultedNullableOptionDictionaryValidationData<TKey, TValue>(defaultValue, new ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>>());
	}
}
