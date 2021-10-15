using Functional;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Valigator.Text.Json
{
	public class OptionConverterFactory : JsonConverterFactory
	{
		public override bool CanConvert(Type typeToConvert)
			=> typeToConvert.IsConstructedGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(Option<>);

#pragma warning disable CS8602, CS8603 // Dereference of a possibly null reference. Possible null reference return.
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
			=> typeof(OptionConverter<>)
				.MakeGenericType(typeToConvert.GenericTypeArguments[0])
				.GetConstructor(Type.EmptyTypes)
				.Invoke(null) as JsonConverter;
#pragma warning restore CS8602, CS8603 // Dereference of a possibly null reference. Possible null reference return.

		private class OptionConverter<T> : JsonConverter<Option<T>>
		{
			public override Option<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
			{
				if (reader.TokenType != JsonTokenType.Null && JsonSerializer.Deserialize(ref reader, typeof(T), options) is T value)
					return Option.Some(value);

				return Option.None<T>();
			}

			public override void Write(Utf8JsonWriter writer, Option<T> value, JsonSerializerOptions options)
			{
				if (value.TryGetValue(out var internalValue))
					JsonSerializer.Serialize(writer, internalValue, typeof(T), options);
				else
					writer.WriteNullValue();
			}
		}
	}
}
