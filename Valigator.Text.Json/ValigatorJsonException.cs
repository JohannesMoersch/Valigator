using System;
using System.Text.Json;

namespace Valigator.Text.Json
{
	public class ValigatorJsonException : Exception
	{
		public ValigatorJsonException(JsonException jsonException) : base(jsonException.Message, jsonException) { }
	}
}
