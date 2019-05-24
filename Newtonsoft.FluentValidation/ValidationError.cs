using System;
using System.Collections.Generic;
using System.Text;

namespace Newtonsoft.FluentValidation
{
	public class ValidationError
	{
		public string Message { get; }

		public ValidationError(string message)
			=> Message = message;
	}
}
