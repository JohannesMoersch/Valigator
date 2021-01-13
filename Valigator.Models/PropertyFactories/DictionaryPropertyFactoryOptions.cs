using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.PropertyFactories
{
	public class DictionaryPropertyFactoryOptions
	{
		public static DictionaryPropertyFactoryOptions Instance { get; } = new DictionaryPropertyFactoryOptions();

		private DictionaryPropertyFactoryOptions() { }

		public NullableDictionaryPropertyFactoryOptions Nullable()
			=> NullableDictionaryPropertyFactoryOptions.Instance;

		public OptionDictionaryPropertyFactoryOptions ItemsNullable()
			=> OptionDictionaryPropertyFactoryOptions.Instance;
	}

	public class NullableDictionaryPropertyFactoryOptions
	{
		public static NullableDictionaryPropertyFactoryOptions Instance { get; } = new NullableDictionaryPropertyFactoryOptions();

		private NullableDictionaryPropertyFactoryOptions() { }

		public NullableOptionDictionaryPropertyFactoryOptions ItemsNullable()
			=> NullableOptionDictionaryPropertyFactoryOptions.Instance;
	}

	public class OptionDictionaryPropertyFactoryOptions
	{
		public static OptionDictionaryPropertyFactoryOptions Instance { get; } = new OptionDictionaryPropertyFactoryOptions();

		private OptionDictionaryPropertyFactoryOptions() { }

		public NullableOptionDictionaryPropertyFactoryOptions Nullable()
			=> NullableOptionDictionaryPropertyFactoryOptions.Instance;
	}

	public class NullableOptionDictionaryPropertyFactoryOptions
	{
		public static NullableOptionDictionaryPropertyFactoryOptions Instance { get; } = new NullableOptionDictionaryPropertyFactoryOptions();

		private NullableOptionDictionaryPropertyFactoryOptions() { }
	}
}
