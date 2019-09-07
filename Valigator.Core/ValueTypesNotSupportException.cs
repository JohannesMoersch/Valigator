using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator
{
	public class ValueTypesNotSupportException : Exception
	{
		public ValueTypesNotSupportException(string message) 
			: base(message)
		{
		}
	}
}
