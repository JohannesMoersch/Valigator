using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.StateDescriptors
{
	public class DefaultedCollectionStateDescriptor : IStateDescriptor
	{
		public bool Nullable { get; }

		public object DefaultValue { get; }

		public DataDescriptor ItemDescriptor { get; }

		public DefaultedCollectionStateDescriptor(bool nullable, object defaultValue, DataDescriptor itemDescriptor)
		{
			Nullable = nullable;
			DefaultValue = defaultValue;
			ItemDescriptor = itemDescriptor;
		}
	}
}
