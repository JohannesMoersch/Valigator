using System;
using System.Buffers.Text;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Functional;
using Valigator.Core;

namespace Valigator.Newtonsoft.Json
{
	public class ValigatorConverter : JsonConverter<IData>
	{
		private readonly static ConcurrentDictionary<Type, bool> _typeCache = new ConcurrentDictionary<Type, bool>();

		private readonly JsonSerializerOptions _jsonOptions;

		public ValigatorConverter(JsonSerializerOptions jsonSerializerSettings)
			=> _jsonOptions = jsonSerializerSettings;

		public override bool CanConvert(Type objectType)
			=> objectType.IsConstructedGenericType && _typeCache.GetOrAdd(objectType, t => t.GetGenericTypeDefinition() == typeof(Data<>));

		private object GetDefault(Type t)
		{
			return GetType().GetMethod(nameof(GetDefaultGeneric))?.MakeGenericMethod(t).Invoke(this, null);
		}

		private T GetDefaultGeneric<T>()
		{
			return default(T);
		}

		/// <inheritdoc />
		public override IData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var innerType = typeToConvert.GetGenericArguments()[0];
			var defaultValue = GetDefault(typeToConvert);
			if (reader.TokenType == JsonTokenType.StartArray)
				return  CallRead((dynamic)defaultValue, reader, options);

			using (var doc = JsonDocument.ParseValue(ref reader))
			{
				var root = doc.RootElement.Clone();
				var o = JsonSerializer.Deserialize<object>(ref reader);
			}

			return default;
		}

		/// <inheritdoc />
		public override void Write(Utf8JsonWriter writer, IData value, JsonSerializerOptions options)
		{

		}

		//private static Data<TValue> Read<TValue>(Utf8JsonReader reader, Data<TValue> existingValue, JsonSerializerOptions options)
		//	=> WithValue(existingValue, (dynamic)existingValue.DataContainer, ref reader, options);

		//private static Data<Option<TValue>> Read<TValue>(Utf8JsonReader reader, Data<Option<TValue>> existingValue, JsonSerializerOptions options)
		//	=> WithValue(existingValue, (dynamic)existingValue.DataContainer, ref reader, options);

		//private static Data<TValue[]> Read<TValue>(Utf8JsonReader reader, Data<TValue[]> existingValue, JsonSerializerOptions options)
		//	=> WithCollectionValue(existingValue, (dynamic)existingValue.DataContainer, ref reader, options);

		//private static Data<Option<TValue>[]> Read<TValue>(Utf8JsonReader reader, Data<Option<TValue>[]> existingValue, JsonSerializerOptions options)
		//	=> WithCollectionValue(existingValue, (dynamic)existingValue.DataContainer, ref reader, options);

		//private static Data<Option<TValue[]>> Read<TValue>(Utf8JsonReader reader, Data<Option<TValue[]>> existingValue, JsonSerializerOptions options)
		//	=> WithCollectionValue(existingValue, (dynamic)existingValue.DataContainer, ref reader, options);

		//private static Data<Option<Option<TValue>[]>> Read<TValue>(Utf8JsonReader reader, Data<Option<Option<TValue>[]>> existingValue, JsonSerializerOptions options)
		//	=> WithCollectionValue(existingValue, (dynamic)existingValue.DataContainer, ref reader, options);

		private static Data<TDataValue> WithValue<TDataValue, TValue>(Data<TDataValue> data, IAcceptValue<TDataValue, TValue> dataContainer, ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Null)
				return dataContainer.WithNull(data);

			try
			{
				var value = JsonSerializer.Deserialize<TValue>(ref reader);

				return value != null ? dataContainer.WithValue(data, Option.Some((TValue)value)) : dataContainer.WithNull(data);
			}
			catch (Exception e)
			{
				return data.WithErrors(MappingError.Create(e.Message, typeof(string), typeof(TValue)));
			}
		}

		private static Data<TDataValue> WithCollectionValue<TDataValue, TValue>(Data<TDataValue> data, IAcceptCollectionValue<TDataValue, TValue> dataContainer, Utf8JsonReader reader, JsonSerializerOptions options)
			=> dataContainer.WithValue(data, DeserializeCollection<TValue>(reader, options));

		private static Option<Option<TValue>[]> DeserializeCollection<TValue>(Utf8JsonReader reader, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Null)
				return Option.None<Option<TValue>[]>();

			var values = new List<Option<TValue>>();

			while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
			{
				if (reader.TokenType != JsonTokenType.Null)
				{
					var value = JsonSerializer.Deserialize<TValue>(ref reader);

					values.Add(Option.Create(value != null, value));
				}
				else
					values.Add(Option.None<TValue>());
			}

			return Option.Some(values.ToArray());
		}

		private static void Write<TValue>(Utf8JsonWriter writer, Data<TValue> value, JsonSerializerOptions options)
			=> JsonSerializer.Serialize<TValue>(writer, value.Value);

		private static void Write<TValue>(Utf8JsonWriter writer, Data<Option<TValue>> value, JsonSerializerOptions options)
		{
			if (value.Value.Match(_ => true, () => false))
				JsonSerializer.Serialize<TValue>(writer, value.Value.Match(_ => _, () => default));
			else
				JsonSerializer.Serialize(writer, null);
		}

		private static void Write<TValue>(Utf8JsonWriter writer, Data<Option<TValue>[]> value, JsonSerializerOptions options)
		{
			writer.WriteStartArray();

			foreach (var item in value.Value)
			{
				if (item.Match(_ => true, () => false))
					JsonSerializer.Serialize<TValue>(writer, item.Match(_ => _, () => default));
				else
					JsonSerializer.Serialize(writer, null);
			}

			writer.WriteEndArray();
		}

		private static void Write<TValue>(Utf8JsonWriter writer, Data<Option<Option<TValue>[]>> value, JsonSerializerOptions options)
		{
			if (value.Value.Match(_ => true, () => false))
			{
				writer.WriteStartArray();

				foreach (var item in value.Value.Match(_ => _, () => default))
				{
					if (item.Match(_ => true, () => false))
						JsonSerializer.Serialize<TValue>(writer, item.Match(_ => _, () => default));
					else
						JsonSerializer.Serialize(writer, null);
				}

				writer.WriteEndArray();
			}
			else
				JsonSerializer.Serialize(writer, null);
		}
	}
}
