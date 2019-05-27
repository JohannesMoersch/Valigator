using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	public class ValidationError
	{
		public string Message { get; }

		public ValidationError(string message)
			=> Message = message;
	}
}
