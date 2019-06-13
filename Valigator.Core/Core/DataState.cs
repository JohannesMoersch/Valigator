using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public enum DataState : byte
	{
		Uninitialized,
		UnSet,
		Set,
		Valid,
		Invalid
	}
}
