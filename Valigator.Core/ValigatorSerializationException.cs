using System;

namespace Valigator.Core
{
	public class ValigatorSerializationException : Exception
	{
		public ValigatorSerializationException(Exception innerException) : base(innerException.Message, innerException)
		{
		}
	}
}
