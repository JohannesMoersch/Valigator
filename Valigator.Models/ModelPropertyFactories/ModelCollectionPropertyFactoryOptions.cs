using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.ModelPropertyFactories
{
	public class ModelCollectionPropertyFactoryOptions
	{
		public static ModelCollectionPropertyFactoryOptions Instance { get; } = new ModelCollectionPropertyFactoryOptions();

		private ModelCollectionPropertyFactoryOptions() { }

		public ModelNullableCollectionPropertyFactoryOptions Nullable()
			=> ModelNullableCollectionPropertyFactoryOptions.Instance;

		public ModelOptionCollectionPropertyFactoryOptions ItemsNullable()
			=> ModelOptionCollectionPropertyFactoryOptions.Instance;
	}

	public class ModelNullableCollectionPropertyFactoryOptions
	{
		public static ModelNullableCollectionPropertyFactoryOptions Instance { get; } = new ModelNullableCollectionPropertyFactoryOptions();

		private ModelNullableCollectionPropertyFactoryOptions() { }

		public ModelNullableOptionCollectionPropertyFactoryOptions ItemsNullable()
			=> ModelNullableOptionCollectionPropertyFactoryOptions.Instance;
	}

	public class ModelOptionCollectionPropertyFactoryOptions
	{
		public static ModelOptionCollectionPropertyFactoryOptions Instance { get; } = new ModelOptionCollectionPropertyFactoryOptions();

		private ModelOptionCollectionPropertyFactoryOptions() { }

		public ModelNullableOptionCollectionPropertyFactoryOptions Nullable()
			=> ModelNullableOptionCollectionPropertyFactoryOptions.Instance;
	}

	public class ModelNullableOptionCollectionPropertyFactoryOptions
	{
		public static ModelNullableOptionCollectionPropertyFactoryOptions Instance { get; } = new ModelNullableOptionCollectionPropertyFactoryOptions();

		private ModelNullableOptionCollectionPropertyFactoryOptions() { }
	}
}
