using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Valigator.Core;
using Valigator.Core.Helpers;

namespace Valigator.Newtonsoft.Json
{
	public class ValigatorConverter : JsonConverter
	{
		private static ConcurrentDictionary<JsonSerializer, JsonSerializer> _serializerDictionary = new ConcurrentDictionary<JsonSerializer, JsonSerializer>();
		private ConcurrentDictionary<Type, IConverter> _converters = new ConcurrentDictionary<Type, IConverter>();

		public override bool CanConvert(Type typeToConvert)
			=> typeToConvert.IsClass && GetConverter(typeToConvert) != null;

		public IConverter GetConverter(Type typeToConvert)
			=> _converters
				.GetOrAdd
				(
					typeToConvert,
					type => type.GetCustomAttribute<ValigatorModelAttribute>() is ValigatorModelAttribute attribute || type.IsValigatorModelBase()
						? CreateConverterInstance(type)
						: null
				);

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			=> GetConverter(objectType).Read(reader, GetSerializer(serializer));

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if (value == null)
				writer.WriteNull();
			else
				GetConverter(value.GetType()).Write(writer, value, GetSerializer(serializer));
		}

		public static JsonSerializer GetSerializer(JsonSerializer originalSerializer)
			=> _serializerDictionary.GetOrAdd(originalSerializer, CopySerializer(originalSerializer));

		private static JsonSerializer CopySerializer(JsonSerializer originalSerializer)
		{
			var settings = new JsonSerializerSettings();
			settings.Converters = originalSerializer.Converters;
			return JsonSerializer.Create(settings);
		}

		private IConverter CreateConverterInstance(Type type)
		{
			ValidateModelSchema(type);

			return (IConverter)Activator
				.CreateInstance
				(
					typeof(Converter<>).MakeGenericType(type),
					type.GetCustomAttribute<ValigatorModelAttribute>()?.ModelConstructionBehaviour ?? ValigatorModelConstructionBehaviour.CloneCached
				);
		}

		private static void ValidateModelSchema(Type type)
		{
			foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Instance))
				throw new ValigatorModelSchemaException($"\"{type.FullName}\" has public non-static fields. Valigator models cannot have public non-static fields.");
		}
	}
}
