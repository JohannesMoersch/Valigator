using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Core
{
	public struct PropertyDescriptor
	{
		public string PropertyName { get; }

		public DataDescriptor DataDescriptor { get; }

		public PropertyDescriptor(string propertyName, DataDescriptor dataDescriptor)
		{
			PropertyName = propertyName ?? throw new ArgumentNullException(nameof(propertyName));
			DataDescriptor = dataDescriptor;
		}
	}
}
