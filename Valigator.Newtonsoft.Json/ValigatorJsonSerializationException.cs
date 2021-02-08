using System;
using Newtonsoft.Json;

namespace Valigator.Newtonsoft.Json
{
	public class ValigatorJsonSerializationException : Exception
	{
		public ValigatorJsonSerializationException(JsonSerializationException innerException) : base(innerException.Message, innerException) { }
	}
}
