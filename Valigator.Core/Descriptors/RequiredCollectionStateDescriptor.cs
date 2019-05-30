using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.Descriptors
{
	public class RequiredCollectionStateDescriptor : IStateDescriptor
	{
		public bool Nullable { get; }

		public DataDescriptor ItemDescriptor { get; }

		public RequiredCollectionStateDescriptor(bool nullable, DataDescriptor itemDescriptor)
		{
			Nullable = nullable;
			ItemDescriptor = itemDescriptor;
		}
	}
}
