using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.Descriptors
{
	public class RequiredStateDescriptor : IStateDescriptor
	{
		public bool Nullable { get; }

		public RequiredStateDescriptor(bool nullable)
			=> Nullable = nullable;
	}
}
