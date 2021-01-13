using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.PropertyFactories
{
	public class CollectionPropertyFactoryOptions
	{
		public static CollectionPropertyFactoryOptions Instance { get; } = new CollectionPropertyFactoryOptions();

		private CollectionPropertyFactoryOptions() { }

		public NullableCollectionPropertyFactoryOptions Nullable()
			=> NullableCollectionPropertyFactoryOptions.Instance;

		public OptionCollectionPropertyFactoryOptions ItemsNullable()
			=> OptionCollectionPropertyFactoryOptions.Instance;
	}

	public class NullableCollectionPropertyFactoryOptions
	{
		public static NullableCollectionPropertyFactoryOptions Instance { get; } = new NullableCollectionPropertyFactoryOptions();

		private NullableCollectionPropertyFactoryOptions() { }

		public NullableOptionCollectionPropertyFactoryOptions ItemsNullable()
			=> NullableOptionCollectionPropertyFactoryOptions.Instance;
	}

	public class OptionCollectionPropertyFactoryOptions
	{
		public static OptionCollectionPropertyFactoryOptions Instance { get; } = new OptionCollectionPropertyFactoryOptions();

		private OptionCollectionPropertyFactoryOptions() { }

		public NullableOptionCollectionPropertyFactoryOptions Nullable()
			=> NullableOptionCollectionPropertyFactoryOptions.Instance;
	}

	public class NullableOptionCollectionPropertyFactoryOptions
	{
		public static NullableOptionCollectionPropertyFactoryOptions Instance { get; } = new NullableOptionCollectionPropertyFactoryOptions();

		private NullableOptionCollectionPropertyFactoryOptions() { }
	}
}
