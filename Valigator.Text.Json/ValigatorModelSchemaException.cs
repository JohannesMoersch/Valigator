using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Text.Json
{
	public class ValigatorModelSchemaException : Exception
	{
		public ValigatorModelSchemaException(string message)
			: base(message)
		{
		}
	}
}
