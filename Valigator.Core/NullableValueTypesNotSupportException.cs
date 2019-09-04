using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	public class NullableValueTypesNotSupportException : Exception
	{
		public NullableValueTypesNotSupportException(string message) 
			: base(message)
		{
		}
	}
}
