using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
			where T : new()
		{
			private static ConverterCodeGenerator.WriteDelegate<T> _writeMethod;

			private static ConverterCodeGenerator.ReadDelegate<T> _readMethod;

			static ModelConverter()
			{
				_writeMethod = ConverterCodeGenerator.CreateWriteMethod<T>();
				_readMethod = ConverterCodeGenerator.CreateReadMethod<T>();
			}

			public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
			{
				var model = new T();

				_readMethod.Invoke(ref reader, ref model, options);

				return model;
			}

			public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
			{
				writer.WriteStartObject();

				_writeMethod.Invoke(writer, ref value, options);

				writer.WriteEndObject();
			}
		}
	}
}
