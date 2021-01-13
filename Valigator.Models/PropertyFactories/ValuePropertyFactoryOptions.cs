using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.PropertyFactories
{
	public class ValuePropertyFactoryOptions
	{
		public static ValuePropertyFactoryOptions Instance { get; } = new ValuePropertyFactoryOptions();

		private ValuePropertyFactoryOptions() { }

		public NullableValuePropertyFactoryOptions Nullable()
			=> NullableValuePropertyFactoryOptions.Instance;
	}

	public class NullableValuePropertyFactoryOptions
	{
		public static NullableValuePropertyFactoryOptions Instance { get; } = new NullableValuePropertyFactoryOptions();

		private NullableValuePropertyFactoryOptions() { }
	}
}
