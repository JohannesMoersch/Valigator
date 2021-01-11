using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.ModelPropertyFactories
{
	public class ModelDictionaryPropertyFactoryOptions
	{
		public static ModelDictionaryPropertyFactoryOptions Instance { get; } = new ModelDictionaryPropertyFactoryOptions();

		private ModelDictionaryPropertyFactoryOptions() { }

		public ModelNullableDictionaryPropertyFactoryOptions Nullable()
			=> ModelNullableDictionaryPropertyFactoryOptions.Instance;

		public ModelOptionDictionaryPropertyFactoryOptions ItemsNullable()
			=> ModelOptionDictionaryPropertyFactoryOptions.Instance;
	}

	public class ModelNullableDictionaryPropertyFactoryOptions
	{
		public static ModelNullableDictionaryPropertyFactoryOptions Instance { get; } = new ModelNullableDictionaryPropertyFactoryOptions();

		private ModelNullableDictionaryPropertyFactoryOptions() { }

		public ModelNullableOptionDictionaryPropertyFactoryOptions ItemsNullable()
			=> ModelNullableOptionDictionaryPropertyFactoryOptions.Instance;
	}

	public class ModelOptionDictionaryPropertyFactoryOptions
	{
		public static ModelOptionDictionaryPropertyFactoryOptions Instance { get; } = new ModelOptionDictionaryPropertyFactoryOptions();

		private ModelOptionDictionaryPropertyFactoryOptions() { }

		public ModelNullableOptionDictionaryPropertyFactoryOptions Nullable()
			=> ModelNullableOptionDictionaryPropertyFactoryOptions.Instance;
	}

	public class ModelNullableOptionDictionaryPropertyFactoryOptions
	{
		public static ModelNullableOptionDictionaryPropertyFactoryOptions Instance { get; } = new ModelNullableOptionDictionaryPropertyFactoryOptions();

		private ModelNullableOptionDictionaryPropertyFactoryOptions() { }
	}
}
