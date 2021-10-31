using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Valigator
{
	public class ModelConverterFactory : JsonConverterFactory
	{
		public override bool CanConvert(Type typeToConvert)
			=> typeof(IModel).IsAssignableFrom(typeToConvert);

#pragma warning disable CS8602, CS8603 // Dereference of a possibly null reference. Possible null reference return.
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
			=> typeof(ModelConverter<>)
				.MakeGenericType(typeToConvert)
				.GetConstructor(Type.EmptyTypes)
				.Invoke(null) as JsonConverter;
#pragma warning restore CS8602, CS8603 // Dereference of a possibly null reference. Possible null reference return.

		private class ModelConverter<T> : JsonConverter<T>
		{
			private static PropertyInfo[] _propertiesToRead;

			private static PropertyInfo[] _propertiesToWrite;

			static ModelConverter()
			{
				_propertiesToRead = typeof(T)
					.GetProperties(BindingFlags.Public | BindingFlags.Instance)
					.Where(p => p.CanRead)
					.ToArray();

				_propertiesToWrite = typeof(T)
					.GetProperties(BindingFlags.Public | BindingFlags.Instance)
					.Where(p => p.CanWrite)
					.ToArray();
			}

			public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
			{
				return default;
			}

			public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
			{
				writer.WriteStartObject();

				foreach (var property in _propertiesToWrite)
				{
					writer.WritePropertyName(property.Name);
					JsonSerializer.Serialize(writer, property.GetValue(value), property.PropertyType, options);
				}

				writer.WriteEndObject();
			}
		}
	}
}
