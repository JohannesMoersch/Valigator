using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Newtonsoft.Json
{
	public class ValigatorModelSchemaException : Exception
	{
		public ValigatorModelSchemaException(string message)
			: base(message)
		{
		}
	}
}
