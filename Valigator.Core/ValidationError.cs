using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public class ValidationError
	{
		private readonly string _message;

		public ValidationError(string message) 
			=> _message = message;

		public override string ToString()
			=> _message;
	}
}
