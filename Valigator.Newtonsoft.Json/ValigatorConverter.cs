using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Functional;
using Newtonsoft.Json;

namespace Valigator.Newtonsoft.Json
{
	public class ValigatorConverter : JsonConverter
	{
		private readonly static ConcurrentDictionary<Type, bool> _typeCache = new ConcurrentDictionary<Type, bool>();

		public override bool CanConvert(Type objectType)
			=> objectType.IsConstructedGenericType && _typeCache.GetOrAdd(objectType, t => t.GetGenericTypeDefinition() == typeof(Data<>));

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			=> Read(reader, (dynamic)existingValue, serializer);

		private object Read<TValue>(JsonReader reader, Data<TValue> existingValue, JsonSerializer serializer)
			=> existingValue.WithValue(serializer.Deserialize<TValue>(reader));

		private object Read<TValue>(JsonReader reader, Data<Option<TValue>> existingValue, JsonSerializer serializer)
		{
			Option<TValue> value = default;

			if (reader.TokenType != JsonToken.Null)
				value = Option.Some(serializer.Deserialize<TValue>(reader));

			return existingValue.WithValue(value);
		}

		private object Read<TValue>(JsonReader reader, Data<Option<TValue>[]> existingValue, JsonSerializer serializer)
		{
			var values = new List<Option<TValue>>();

			while (reader.Read() && reader.TokenType != JsonToken.EndArray)
			{
				if (reader.TokenType != JsonToken.Null)
					values.Add(Option.Some(serializer.Deserialize<TValue>(reader)));
				else
					values.Add(Option.None<TValue>());
			}

			return existingValue.WithValue(values.ToArray());
		}

		private object Read<TValue>(JsonReader reader, Data<Option<Option<TValue>[]>> existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
				existingValue.WithValue(Option.None<Option<TValue>[]>());

			var values = new List<Option<TValue>>();

			while (reader.Read() && reader.TokenType != JsonToken.EndArray)
			{
				if (reader.TokenType != JsonToken.Null)
					values.Add(Option.Some(serializer.Deserialize<TValue>(reader)));
				else
					values.Add(Option.None<TValue>());
			}

			return existingValue.WithValue(Option.Some(values.ToArray()));
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
			=> Write(writer, (dynamic)value, serializer);

		private void Write<TValue>(JsonWriter writer, Data<TValue> value, JsonSerializer serializer)
			=> serializer.Serialize(writer, value.Value, typeof(TValue));

		private void Write<TValue>(JsonWriter writer, Data<Option<TValue>> value, JsonSerializer serializer)
		{
			if (value.Value.Match(_ => true, () => false))
				serializer.Serialize(writer, value.Value.Match(_ => _, () => default), typeof(TValue));
			else
				serializer.Serialize(writer, null);
		}

		private void Write<TValue>(JsonWriter writer, Data<Option<TValue>[]> value, JsonSerializer serializer)
		{
			writer.WriteStartArray();

			foreach (var item in value.Value)
			{
				if (item.Match(_ => true, () => false))
					serializer.Serialize(writer, item.Match(_ => _, () => default), typeof(TValue));
				else
					serializer.Serialize(writer, null);
			}

			writer.WriteEndArray();
		}
	}
}
