using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IHasDescriptor
	{
		DataDescriptor DataDescriptor { get; }
	}
}
