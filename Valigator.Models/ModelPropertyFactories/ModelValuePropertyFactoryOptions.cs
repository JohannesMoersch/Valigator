using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.ModelPropertyFactories
{
	public class ModelValuePropertyFactoryOptions
	{
		public static ModelValuePropertyFactoryOptions Instance { get; } = new ModelValuePropertyFactoryOptions();

		private ModelValuePropertyFactoryOptions() { }

		public ModelNullableValuePropertyFactoryOptions Nullable()
			=> ModelNullableValuePropertyFactoryOptions.Instance;
	}

	public class ModelNullableValuePropertyFactoryOptions
	{
		public static ModelNullableValuePropertyFactoryOptions Instance { get; } = new ModelNullableValuePropertyFactoryOptions();

		private ModelNullableValuePropertyFactoryOptions() { }
	}
}
