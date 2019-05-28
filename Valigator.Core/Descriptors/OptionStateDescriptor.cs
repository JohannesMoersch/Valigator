using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.Descriptors
{
	public class OptionalStateDescriptor : IStateDescriptor
	{
		public bool Nullable { get; }

		public OptionalStateDescriptor(bool nullable)
			=> Nullable = nullable;
	}
}
