using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	public static class Errors
	{
		public static ValidationError One { get; } = new ValidationError("One");

		public static ValidationError Two { get; } = new ValidationError("Two");

		public static ValidationError Three { get; } = new ValidationError("Three");
	}
}
