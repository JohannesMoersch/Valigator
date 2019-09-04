using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Functional;
using Newtonsoft.Json;
using Valigator.Core;

namespace Valigator.Newtonsoft.Json
{
	public class ValigatorConverter : JsonConverter
	{
		private class SupportsNull<TValue>
		{
			public static bool Value { get; } = typeof(TValue).IsClass || (typeof(TValue).IsConstructedGenericType && typeof(TValue).GetGenericTypeDefinition() == typeof(Option<>));
		}

		private readonly static ConcurrentDictionary<Type, bool> _typeCache = new ConcurrentDictionary<Type, bool>();

		public override bool CanConvert(Type objectType)
			=> objectType.IsConstructedGenericType && _typeCache.GetOrAdd(objectType, t => t.GetGenericTypeDefinition() == typeof(Data<>));

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			=> Read(reader, (dynamic)existingValue, serializer);

		private Data<TValue> Read<TValue>(JsonReader reader, Data<TValue> existingValue, JsonSerializer serializer)
			=> WithValue(existingValue, (dynamic)existingValue.DataContainer, reader, serializer);

		private Data<Option<TValue>> Read<TValue>(JsonReader reader, Data<Option<TValue>> existingValue, JsonSerializer serializer)
			=> WithValue(existingValue, (dynamic)existingValue.DataContainer, reader, serializer);

		private Data<TValue[]> Read<TValue>(JsonReader reader, Data<TValue[]> existingValue, JsonSerializer serializer)
			=> WithCollectionValue(existingValue, (dynamic)existingValue.DataContainer, reader, serializer);

		private Data<Option<TValue>[]> Read<TValue>(JsonReader reader, Data<Option<TValue>[]> existingValue, JsonSerializer serializer)
			=> WithCollectionValue(existingValue, (dynamic)existingValue.DataContainer, reader, serializer);

		private Data<Option<TValue[]>> Read<TValue>(JsonReader reader, Data<Option<TValue[]>> existingValue, JsonSerializer serializer)
			=> WithCollectionValue(existingValue, (dynamic)existingValue.DataContainer, reader, serializer);

		private Data<Option<Option<TValue>[]>> Read<TValue>(JsonReader reader, Data<Option<Option<TValue>[]>> existingValue, JsonSerializer serializer)
			=> WithCollectionValue(existingValue, (dynamic)existingValue.DataContainer, reader, serializer);

		private static Data<TDataValue> WithValue<TDataValue, TValue>(Data<TDataValue> data, IAcceptValue<TDataValue, TValue> dataContainer, JsonReader reader, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
				return data.WithNull();

			var value = serializer.Deserialize<TValue>(reader);

			return dataContainer.WithValue(data, Option.Create(value != null, value));
		}

		private static Data<TDataValue> WithCollectionValue<TDataValue, TValue>(Data<TDataValue> data, IAcceptCollectionValue<TDataValue, TValue> dataContainer, JsonReader reader, JsonSerializer serializer)
			=> dataContainer.WithValue(data, DeserializeCollection<TValue>(reader, serializer));

		private static Option<Option<TValue>[]> DeserializeCollection<TValue>(JsonReader reader, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
				return Option.None<Option<TValue>[]>();

			var values = new List<Option<TValue>>();

			while (reader.Read() && reader.TokenType != JsonToken.EndArray)
			{
				if (reader.TokenType != JsonToken.Null)
				{
					var value = serializer.Deserialize<TValue>(reader);

					values.Add(Option.Create(value != null, value));
				}
				else
					values.Add(Option.None<TValue>());
			}

			return Option.Some(values.ToArray());
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

		private void Write<TValue>(JsonWriter writer, Data<Option<Option<TValue>[]>> value, JsonSerializer serializer)
		{
			if (value.Value.Match(_ => true, () => false))
			{
				writer.WriteStartArray();

				foreach (var item in value.Value.Match(_ => _, () => default))
				{
					if (item.Match(_ => true, () => false))
						serializer.Serialize(writer, item.Match(_ => _, () => default), typeof(TValue));
					else
						serializer.Serialize(writer, null);
				}

				writer.WriteEndArray();
			}
			else
				serializer.Serialize(writer, null);
		}
	}
}
