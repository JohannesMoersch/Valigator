using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.StateDescriptors
{
	public class OptionalCollectionStateDescriptor : IStateDescriptor
	{
		public bool Nullable { get; }

		public DataDescriptor ItemDescriptor { get; }

		public OptionalCollectionStateDescriptor(bool nullable, DataDescriptor itemDescriptor)
		{
			Nullable = nullable;
			ItemDescriptor = itemDescriptor;
		}
	}
}
