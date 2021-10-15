using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Valigator.Text.Json
{
	public class OptionalConverterFactory : JsonConverterFactory
	{
		public override bool CanConvert(Type typeToConvert)
			=> typeToConvert.IsConstructedGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(Optional<>);

#pragma warning disable CS8602, CS8603 // Dereference of a possibly null reference. Possible null reference return.
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
			=> typeof(OptionalConverter<>)
				.MakeGenericType(typeToConvert.GenericTypeArguments[0])
				.GetConstructor(Type.EmptyTypes)
				.Invoke(null) as JsonConverter;
#pragma warning restore CS8602, CS8603 // Dereference of a possibly null reference. Possible null reference return.

		private class OptionalConverter<T> : JsonConverter<Optional<T>>
		{
			public override Optional<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
			{
				if (reader.TokenType != JsonTokenType.Null && JsonSerializer.Deserialize(ref reader, typeof(T), options) is T value)
					return Optional.Set(value);

				return Optional.Unset<T>();
			}

			public override void Write(Utf8JsonWriter writer, Optional<T> value, JsonSerializerOptions options)
			{
				if (value.TryGetValue(out var internalValue))
					JsonSerializer.Serialize(writer, internalValue, typeof(T), options);
				else
					writer.WriteNullValue();
			}
		}
	}
}
