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

		private object Read<TValue>(JsonReader reader, Data<TValue> existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
			{
				if (SupportsNull<TValue>.Value)
					return existingValue.WithValue(default);
				else
					return existingValue.WithErrors(ValidationErrors.NotNull());
			}

			return existingValue.WithValue(serializer.Deserialize<TValue>(reader));
		}

		private object Read<TValue>(JsonReader reader, Data<Option<TValue>> existingValue, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
				return existingValue.WithValue(Option.None<TValue>());

			var value = serializer.Deserialize<TValue>(reader);

			return existingValue.WithValue(Option.Create(value != null, value));
		}

		private object Read<TValue>(JsonReader reader, Data<TValue[]> existingValue, JsonSerializer serializer)
		{
			var collectionOption = DeserializeCollection<TValue>(reader, serializer);

			if (collectionOption.Match(_ => false, () => true))
				return existingValue.WithValue(null);

			var collection = collectionOption.Match(_ => _, () => default);

			var result = new TValue[collection.Length];

			List<ValidationError> errors = null;
			for (int i = 0; i < collection.Length; ++i)
			{
				if (collection[i].Match(_ => true, () => false))
					result[i] = collection[i].Match(_ => _, () => default);
				else if (SupportsNull<TValue>.Value)
					result[i] = default;
				else
				{
					var error = ValidationErrors.NotNull();
					error.Path.AddIndex(i);
					(errors = (errors ?? new List<ValidationError>())).Add(error);
				}
			}

			if (errors != null)
				return existingValue.WithErrors(errors.ToArray());

			return existingValue.WithValue(result);
		}

		private object Read<TValue>(JsonReader reader, Data<Option<TValue>[]> existingValue, JsonSerializer serializer)
			=> existingValue.WithValue(DeserializeCollection<TValue>(reader, serializer).Match(_ => _, () => null));

		private object Read<TValue>(JsonReader reader, Data<Option<Option<TValue>[]>> existingValue, JsonSerializer serializer)
			=> existingValue.WithValue(DeserializeCollection<TValue>(reader, serializer));

		private Option<Option<TValue>[]> DeserializeCollection<TValue>(JsonReader reader, JsonSerializer serializer)
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
