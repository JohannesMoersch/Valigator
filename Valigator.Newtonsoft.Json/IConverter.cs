using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Newtonsoft.Json
{
	public interface IConverter
	{
		object Read(JsonReader reader, JsonSerializer serializer);

		void Write(JsonWriter writer, object value, JsonSerializer serializer);
	}
}
