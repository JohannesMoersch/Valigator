using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core.Descriptors
{
	public class DefaultedStateDescriptor : IStateDescriptor
	{
		public bool Nullable { get; }

		public object DefaultValue { get; }

		public DefaultedStateDescriptor(bool nullable, object defaultValue)
		{
			Nullable = nullable;
			DefaultValue = defaultValue;
		}
	}
}
