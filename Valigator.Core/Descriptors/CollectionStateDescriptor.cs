using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.Descriptors
{
	public class CollectionStateDescriptor : IStateDescriptor
	{
		public bool Nullable { get; }

		public DataDescriptor ItemDescriptor { get; }

		public CollectionStateDescriptor(bool nullable, DataDescriptor itemDescriptor)
		{
			Nullable = nullable;
			ItemDescriptor = itemDescriptor;
		}
	}
}
