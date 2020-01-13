using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Functional;
using Valigator.Core;

namespace Valigator.Text.Json
{
	public enum ValigatorInstanceConstructionBehaviour
	{
		CloneCached,
		NewInstance
	}

	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class ValigatorConverterAttribute : JsonConverterAttribute
	{
		public ValigatorInstanceConstructionBehaviour InstanceConstructionBehaviour { get; set; }

		public ValigatorConverterAttribute()
			: base(typeof(ValigatorConverterFactory))
		{
		}
	}

	public class ValigatorConverterFactory : JsonConverterFactory
	{
		private ConcurrentDictionary<Type, JsonConverter> _converters = new ConcurrentDictionary<Type, JsonConverter>();

		public override bool CanConvert(Type typeToConvert)
			=> true;

		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
			=> _converters
				.GetOrAdd
				(
					typeToConvert, 
					type => Activator.CreateInstance(typeof(ValigatorConverter<>).MakeGenericType(type), type.GetCustomAttribute<ValigatorConverterAttribute>()?.InstanceConstructionBehaviour ?? ValigatorInstanceConstructionBehaviour.CloneCached) as JsonConverter // TODO - Validate type signature and properties (no public instance fields, no private instance properties)
				);
	}

	public class ValigatorConverter<TObject> : JsonConverter<TObject>
		where TObject : class, new()
	{
		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> CreatePropertyHandlers()
		{
			var result = new Dictionary<string, ValigatorJsonPropertyHandler<TObject>>();

			foreach (var property in typeof(TObject).GetProperties(BindingFlags.Public | BindingFlags.Instance))
			{
				result.Add(property.Name, ValigatorJsonPropertyHandler<TObject>.Create(property));
			}

			return result;
		}

		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> _propertyHandlers;
		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> PropertyHandlers => _propertyHandlers ??= CreatePropertyHandlers();

		private readonly bool _useNewInstances;

		public ValigatorConverter(ValigatorInstanceConstructionBehaviour instanceConstructionBehaviour)
		{
			switch (instanceConstructionBehaviour)
			{
				case ValigatorInstanceConstructionBehaviour.NewInstance:
					_useNewInstances = true;
					break;
				case ValigatorInstanceConstructionBehaviour.CloneCached:
					_useNewInstances = false;
					break;
				default:
					throw new Exception();
			}
		}

		public override TObject Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var obj = GetObjectInstance();

			while (true)
			{
				if (!reader.Read())
					throw new Exception();

				if (reader.TokenType == JsonTokenType.EndObject)
					break;

				if (reader.TokenType != JsonTokenType.PropertyName)
					throw new Exception();

				var propertyName = reader.GetString();

				if (PropertyHandlers.TryGetValue(propertyName, out var propertyHandler))
				{
					if (!reader.Read())
						throw new Exception();

					propertyHandler.ReadProperty(ref reader, options, obj);
				}
				else
					JsonSerializer.Deserialize(ref reader, typeof(object), options);
			}

			return obj;
		}

		private TObject GetObjectInstance()
			=> _useNewInstances
				? new TObject()
				: Model.CreateClone<TObject>();

		public override void Write(Utf8JsonWriter writer, TObject value, JsonSerializerOptions options) 
			=> throw new NotImplementedException();
	}

	internal abstract class ValigatorJsonPropertyHandler<TObject>
	{
		public abstract void ReadProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, TObject obj);

		public static ValigatorJsonPropertyHandler<TObject> Create(PropertyInfo property)
		{
			var handlerType = typeof(ValigatorJsonPropertyHandler<,>).MakeGenericType(typeof(TObject), property.PropertyType.GetGenericArguments()[0]);

			var createMethod = handlerType.GetMethod(nameof(ValigatorJsonPropertyHandler<TObject, bool>.Create), BindingFlags.Public | BindingFlags.Static, Type.DefaultBinder, new[] { typeof(PropertyInfo) }, null);

			return (ValigatorJsonPropertyHandler<TObject>)createMethod.Invoke(null, new[] { property });
		}
	}

	internal class ValigatorJsonPropertyHandler<TObject, TDataValue> : ValigatorJsonPropertyHandler<TObject>
	{
		private readonly Func<TObject, Data<TDataValue>> _getValue;
		private readonly Action<TObject, Data<TDataValue>> _setValue;

		public ValigatorJsonPropertyHandler(Func<TObject, Data<TDataValue>> getValue, Action<TObject, Data<TDataValue>> setValue)
		{
			_getValue = getValue;
			_setValue = setValue;
		}

		public override void ReadProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, TObject obj)
			=> _setValue.Invoke(obj, ValigatorJsonReader.ReadValue(ref reader, options, _getValue.Invoke(obj)));

		public new static ValigatorJsonPropertyHandler<TObject, TDataValue> Create(PropertyInfo property)
		{
			var objParameter = Expression.Parameter(typeof(TObject), "obj");
			var propertyExpression = Expression.Property(objParameter, property);

			var valueParameter = Expression.Parameter(typeof(Data<TDataValue>), "value");

			var getter = Expression.Lambda<Func<TObject, Data<TDataValue>>>(propertyExpression, objParameter).Compile();
			var setter = Expression.Lambda<Action<TObject, Data<TDataValue>>>(Expression.Assign(propertyExpression, valueParameter), objParameter, valueParameter).Compile();

			return new ValigatorJsonPropertyHandler<TObject, TDataValue>(getter, setter);
		}
	}

	internal static class ValigatorJsonReader
	{
		private delegate Data<TDataValue> IReadValue<TDataValue>(ref Utf8JsonReader reader, JsonSerializerOptions options, Data<TDataValue> data);

		private static readonly MethodInfo _readSingleValueMethod = typeof(ValigatorJsonReader).GetMethod(nameof(ReadSingleValue), BindingFlags.NonPublic | BindingFlags.Static);
		private static readonly ConcurrentDictionary<(Type dataValueType, Type valueType), Delegate> _readSingleValueDelegates = new ConcurrentDictionary<(Type, Type), Delegate>();

		private static readonly MethodInfo _readCollectionValueMethod = typeof(ValigatorJsonReader).GetMethod(nameof(ReadCollectionValue), BindingFlags.NonPublic | BindingFlags.Static);
		private static readonly ConcurrentDictionary<(Type dataValueType, Type valueType), Delegate> _readCollectionValueDelegates = new ConcurrentDictionary<(Type, Type), Delegate>();

		private static IReadValue<TDataValue> GetReadValueDelegate<TDataValue>(Data<TDataValue> data)
			=> data.DataContainer is IAcceptCollectionValue<TDataValue>
				? GetReadCollectionValueDelegate(data)
				: GetReadSingleValueDelegate(data);

		private static IReadValue<TDataValue> GetReadSingleValueDelegate<TDataValue>(Data<TDataValue> data)
			=> (IReadValue<TDataValue>)_readSingleValueDelegates
				.GetOrAdd
				(
					(typeof(TDataValue), (data.DataContainer as IAcceptValue<TDataValue>).ValueType),
					key => Delegate.CreateDelegate(typeof(IReadValue<TDataValue>), _readSingleValueMethod.MakeGenericMethod(key.dataValueType, key.valueType))
				);

		private static IReadValue<TDataValue> GetReadCollectionValueDelegate<TDataValue>(Data<TDataValue> data)
			=> (IReadValue<TDataValue>)_readCollectionValueDelegates
				.GetOrAdd
				(
					(typeof(TDataValue), (data.DataContainer as IAcceptCollectionValue<TDataValue>).ValueType),
					key => Delegate.CreateDelegate(typeof(IReadValue<TDataValue>), _readCollectionValueMethod.MakeGenericMethod(key.dataValueType, key.valueType))
				);

		public static Data<TDataValue> ReadValue<TDataValue>(ref Utf8JsonReader reader, JsonSerializerOptions options, Data<TDataValue> data)
			=> GetReadValueDelegate(data).Invoke(ref reader, options, data);

		private static Data<TDataValue> ReadSingleValue<TDataValue, TValue>(ref Utf8JsonReader reader, JsonSerializerOptions options, Data<TDataValue> data)
		{
			if (reader.TokenType == JsonTokenType.Null)
				return SetValue(data, Option.None<TValue>());

			if (JsonSerializer.Deserialize<TValue>(ref reader, options) is TValue value)
				return SetValue(data, Option.Some(value));

			return SetNull(data);
		}

		private static Data<TDataValue> ReadCollectionValue<TDataValue, TValue>(ref Utf8JsonReader reader, JsonSerializerOptions options, Data<TDataValue> data)
		{
			if (reader.TokenType == JsonTokenType.Null)
				return SetNull(data);

			var values = new List<Option<TValue>>();

			while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
			{
				if (reader.TokenType != JsonTokenType.Null)
				{
					var value = JsonSerializer.Deserialize<TValue>(ref reader, options);

					values.Add(Option.Create(value != null, value));
				}
				else
					values.Add(Option.None<TValue>());
			}

			return SetValue(data, Option.Some(values.ToArray()));
		}

		private static Data<TDataValue> SetValue<TDataValue, TValue>(Data<TDataValue> data, Option<TValue> value)
			=> (data.DataContainer as IAcceptValue<TDataValue, TValue>).WithValue(data, value);

		private static Data<TDataValue> SetValue<TDataValue, TValue>(Data<TDataValue> data, Option<Option<TValue>[]> value)
			=> (data.DataContainer as IAcceptCollectionValue<TDataValue, TValue>).WithValue(data, value);

		private static Data<TDataValue> SetNull<TDataValue>(Data<TDataValue> data)
			=> (data.DataContainer as IAcceptValue<TDataValue>).WithNull(data);
	}
	/*
	public class ValigatorConverter : JsonConverter
	{
		private readonly static ConcurrentDictionary<Type, bool> _typeCache = new ConcurrentDictionary<Type, bool>();

		private JsonSerializer _serializer;
		private readonly JsonSerializerSettings _jsonSerializerSettings;

		public JsonSerializer Serializer => _serializer ?? (_serializer = JsonSerializer.Create(_jsonSerializerSettings));

		public ValigatorConverter(JsonSerializerSettings jsonSerializerSettings) 
			=> _jsonSerializerSettings = jsonSerializerSettings;

		public override bool CanConvert(Type objectType)
			=> objectType.IsConstructedGenericType && _typeCache.GetOrAdd(objectType, t => t.GetGenericTypeDefinition() == typeof(Data<>));

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer _)
			=> Read(reader, (dynamic)existingValue, Serializer);

		private static Data<TValue> Read<TValue>(JsonReader reader, Data<TValue> existingValue, JsonSerializer serializer)
			=> WithValue(existingValue, (dynamic)existingValue.DataContainer, reader, serializer);

		private static Data<Option<TValue>> Read<TValue>(JsonReader reader, Data<Option<TValue>> existingValue, JsonSerializer serializer)
			=> WithValue(existingValue, (dynamic)existingValue.DataContainer, reader, serializer);

		private static Data<TValue[]> Read<TValue>(JsonReader reader, Data<TValue[]> existingValue, JsonSerializer serializer)
			=> WithCollectionValue(existingValue, (dynamic)existingValue.DataContainer, reader, serializer);

		private static Data<Option<TValue>[]> Read<TValue>(JsonReader reader, Data<Option<TValue>[]> existingValue, JsonSerializer serializer)
			=> WithCollectionValue(existingValue, (dynamic)existingValue.DataContainer, reader, serializer);

		private static Data<Option<TValue[]>> Read<TValue>(JsonReader reader, Data<Option<TValue[]>> existingValue, JsonSerializer serializer)
			=> WithCollectionValue(existingValue, (dynamic)existingValue.DataContainer, reader, serializer);

		private static Data<Option<Option<TValue>[]>> Read<TValue>(JsonReader reader, Data<Option<Option<TValue>[]>> existingValue, JsonSerializer serializer)
			=> WithCollectionValue(existingValue, (dynamic)existingValue.DataContainer, reader, serializer);

		private static Data<TDataValue> WithValue<TDataValue, TValue>(Data<TDataValue> data, IAcceptValue<TDataValue, TValue> dataContainer, JsonReader reader, JsonSerializer serializer)
		{
			if (reader.TokenType == JsonToken.Null)
				return dataContainer.WithNull(data);

			try
			{
				var value = serializer.Deserialize(reader, typeof(TValue));

				return value != null ? dataContainer.WithValue(data, Option.Some((TValue)value)) : dataContainer.WithNull(data);
			}
			catch (JsonSerializationException e)
			{
				return data.WithErrors(MappingError.Create(e.Message, typeof(string), typeof(TValue)));
			}
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

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer _)
			=> Write(writer, (dynamic)value, Serializer);

		private static void Write<TValue>(JsonWriter writer, Data<TValue> value, JsonSerializer serializer)
			=> serializer.Serialize(writer, value.Value, typeof(TValue));

		private static void Write<TValue>(JsonWriter writer, Data<Option<TValue>> value, JsonSerializer serializer)
		{
			if (value.Value.Match(_ => true, () => false))
				serializer.Serialize(writer, value.Value.Match(_ => _, () => default), typeof(TValue));
			else
				serializer.Serialize(writer, null);
		}

		private static void Write<TValue>(JsonWriter writer, Data<Option<TValue>[]> value, JsonSerializer serializer)
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

		private static void Write<TValue>(JsonWriter writer, Data<Option<Option<TValue>[]>> value, JsonSerializer serializer)
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
	*/
}
