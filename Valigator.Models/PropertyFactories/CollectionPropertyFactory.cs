using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.ValidationData;

namespace Valigator.PropertyFactories
{
	public class CollectionPropertyFactory<TValue>
	{
		public static CollectionPropertyFactory<TValue> Instance { get; } = new CollectionPropertyFactory<TValue>();

		private CollectionPropertyFactory() { }

		public RequiredCollectionValidationData<TValue> Required()
			=> new RequiredCollectionValidationData<TValue>(new ValidationData<IReadOnlyList<TValue>>());

		public OptionalCollectionValidationData<TValue> Optional()
			=> new OptionalCollectionValidationData<TValue>(new ValidationData<IReadOnlyList<TValue>>());

		public DefaultedCollectionValidationData<TValue> Defaulted(IReadOnlyList<TValue> defaultValue)
			=> new DefaultedCollectionValidationData<TValue>(() => defaultValue, new ValidationData<IReadOnlyList<TValue>>());

		public DefaultedCollectionValidationData<TValue> Defaulted(Func<IReadOnlyList<TValue>> defaultValue)
			=> new DefaultedCollectionValidationData<TValue>(defaultValue, new ValidationData<IReadOnlyList<TValue>>());
	}

	public class NullableCollectionPropertyFactory<TValue>
	{
		public static NullableCollectionPropertyFactory<TValue> Instance { get; } = new NullableCollectionPropertyFactory<TValue>();

		private NullableCollectionPropertyFactory() { }

		public RequiredNullableCollectionValidationData<TValue> Required()
			=> new RequiredNullableCollectionValidationData<TValue>(new ValidationData<IReadOnlyList<TValue>>());

		public OptionalNullableCollectionValidationData<TValue> Optional()
			=> new OptionalNullableCollectionValidationData<TValue>(new ValidationData<IReadOnlyList<TValue>>());

		public DefaultedNullableCollectionValidationData<TValue> Defaulted(Option<IReadOnlyList<TValue>> defaultValue)
			=> new DefaultedNullableCollectionValidationData<TValue>(() => defaultValue, new ValidationData<IReadOnlyList<TValue>>());

		public DefaultedNullableCollectionValidationData<TValue> Defaulted(Func<Option<IReadOnlyList<TValue>>> defaultValue)
			=> new DefaultedNullableCollectionValidationData<TValue>(defaultValue, new ValidationData<IReadOnlyList<TValue>>());
	}

	public class OptionCollectionPropertyFactory<TValue>
	{
		public static OptionCollectionPropertyFactory<TValue> Instance { get; } = new OptionCollectionPropertyFactory<TValue>();

		private OptionCollectionPropertyFactory() { }

		public RequiredOptionCollectionValidationData<TValue> Required()
			=> new RequiredOptionCollectionValidationData<TValue>(new ValidationData<IReadOnlyList<Option<TValue>>>());

		public OptionalOptionCollectionValidationData<TValue> Optional()
			=> new OptionalOptionCollectionValidationData<TValue>(new ValidationData<IReadOnlyList<Option<TValue>>>());

		public DefaultedOptionCollectionValidationData<TValue> Defaulted(IReadOnlyList<Option<TValue>> defaultValue)
			=> new DefaultedOptionCollectionValidationData<TValue>(() => defaultValue, new ValidationData<IReadOnlyList<Option<TValue>>>());

		public DefaultedOptionCollectionValidationData<TValue> Defaulted(Func<IReadOnlyList<Option<TValue>>> defaultValue)
			=> new DefaultedOptionCollectionValidationData<TValue>(defaultValue, new ValidationData<IReadOnlyList<Option<TValue>>>());
	}

	public class NullableOptionCollectionPropertyFactory<TValue>
	{
		public static NullableOptionCollectionPropertyFactory<TValue> Instance { get; } = new NullableOptionCollectionPropertyFactory<TValue>();

		private NullableOptionCollectionPropertyFactory() { }

		public RequiredNullableOptionCollectionValidationData<TValue> Required()
			=> new RequiredNullableOptionCollectionValidationData<TValue>(new ValidationData<IReadOnlyList<Option<TValue>>>());

		public OptionalNullableOptionCollectionValidationData<TValue> Optional()
			=> new OptionalNullableOptionCollectionValidationData<TValue>(new ValidationData<IReadOnlyList<Option<TValue>>>());

		public DefaultedNullableOptionCollectionValidationData<TValue> Defaulted(Option<IReadOnlyList<Option<TValue>>> defaultValue)
			=> new DefaultedNullableOptionCollectionValidationData<TValue>(() => defaultValue, new ValidationData<IReadOnlyList<Option<TValue>>>());

		public DefaultedNullableOptionCollectionValidationData<TValue> Defaulted(Func<Option<IReadOnlyList<Option<TValue>>>> defaultValue)
			=> new DefaultedNullableOptionCollectionValidationData<TValue>(defaultValue, new ValidationData<IReadOnlyList<Option<TValue>>>());
	}
}
