using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator
{
	public class ValidationError
	{
		public string Message { get; }

		public Path Path { get; } = new Path();

		public ValidationError(string message)
			=> Message = message;
	}
}
