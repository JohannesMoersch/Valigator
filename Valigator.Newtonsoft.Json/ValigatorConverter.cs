using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Valigator.Newtonsoft.Json
{
	public class ValigatorConverter : JsonConverter
	{
		private ConcurrentDictionary<Type, IConverter> _converters = new ConcurrentDictionary<Type, IConverter>();

		public override bool CanConvert(Type typeToConvert)
			=> typeToConvert.IsClass && GetConverter(typeToConvert) != null;

		public IConverter GetConverter(Type typeToConvert)
			=> _converters
				.GetOrAdd
				(
					typeToConvert,
					type => type.GetCustomAttribute<ValigatorModelAttribute>() is ValigatorModelAttribute attribute
						? Activator.CreateInstance(typeof(Converter<>).MakeGenericType(type), type.GetCustomAttribute<ValigatorModelAttribute>()?.ModelConstructionBehaviour ?? ValigatorModelConstructionBehaviour.CloneCached) as IConverter // TODO - Validate type signature and properties (no public instance fields, no private instance properties)
						: null
				);

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			=> GetConverter(objectType).Read(reader, serializer);

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value == null)
				writer.WriteNull();
			else
				GetConverter(value.GetType()).Write(writer, value, serializer);
		}
	}
}
