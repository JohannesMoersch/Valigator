using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.AspNetCore
{
	public class ModelError
	{
		public ModelSource Source { get; }

		public ValidationError ValidationError { get; }
	}
}
