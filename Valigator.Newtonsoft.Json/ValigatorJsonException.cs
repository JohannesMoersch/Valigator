using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Valigator.Newtonsoft.Json
{
	public class ValigatorJsonException : Exception
	{
		public ValigatorJsonException(JsonSerializationException jsonSerializationException) : base(jsonSerializationException.Message, jsonSerializationException)
		{
			JsonSerializationException = jsonSerializationException;
		}

		public JsonSerializationException JsonSerializationException { get; }
	}
}
