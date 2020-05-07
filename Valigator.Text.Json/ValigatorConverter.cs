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
	public class ValigatorConverter<TObject> : JsonConverter<TObject>
		where TObject : class
	{
		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> CreatePropertyHandlers()
		{
			var result = new Dictionary<string, ValigatorJsonPropertyHandler<TObject>>();

			foreach (var property in typeof(TObject).GetProperties(BindingFlags.Public | BindingFlags.Instance))
				result.Add(property.Name, ValigatorJsonPropertyHandler<TObject>.Create(property));

			return result;
		}

		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> _propertyHandlers;
		private static Dictionary<string, ValigatorJsonPropertyHandler<TObject>> PropertyHandlers => _propertyHandlers ??= CreatePropertyHandlers();

		static ValigatorConverter()
			=> typeof(TObject).GetConstructors(BindingFlags.Public | BindingFlags.NonPublic).FirstOrDefault(info => info.GetParameters().Length == 0);

		private readonly bool _useNewInstances;

		public ValigatorConverter(ValigatorObjectConstructionBehaviour instanceConstructionBehaviour)
		{
			switch (instanceConstructionBehaviour)
			{
				case ValigatorObjectConstructionBehaviour.NewInstance:
					_useNewInstances = true;
					break;
				case ValigatorObjectConstructionBehaviour.CloneCached:
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
				? Model.CreateNew<TObject>()
				: Model.CreateClone<TObject>();

		public override void Write(Utf8JsonWriter writer, TObject value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();

			foreach (var handler in PropertyHandlers)
			{
				writer.WritePropertyName(handler.Key);

				handler.Value.WriteProperty(writer, options, value);
			}

			writer.WriteEndObject();
		}
	}

	internal abstract class ValigatorJsonPropertyHandler<TObject>
	{
		public abstract void ReadProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, TObject obj);

		public abstract void WriteProperty(Utf8JsonWriter writer, JsonSerializerOptions options, TObject obj);

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
		{
			if (_getValue != null && _setValue != null)
				_setValue.Invoke(obj, ValigatorJsonReader.ReadValue(ref reader, options, _getValue.Invoke(obj)));
			else
				throw new NotSupportedException();
		}

		public override void WriteProperty(Utf8JsonWriter writer, JsonSerializerOptions options, TObject obj)
		{
			if (_getValue != null)
				ValigatorJsonWriter.WriteValue(writer, options, _getValue.Invoke(obj));
			else
				throw new NotSupportedException();
		}

		public new static ValigatorJsonPropertyHandler<TObject, TDataValue> Create(PropertyInfo property)
		{
			var objParameter = Expression.Parameter(typeof(TObject), "obj");
			var propertyExpression = Expression.Property(objParameter, property);

			var valueParameter = Expression.Parameter(typeof(Data<TDataValue>), "value");

			var getter = property.CanRead ? Expression.Lambda<Func<TObject, Data<TDataValue>>>(propertyExpression, objParameter).Compile() : null;
			var setter = property.CanWrite ? Expression.Lambda<Action<TObject, Data<TDataValue>>>(Expression.Assign(propertyExpression, valueParameter), objParameter, valueParameter).Compile() : null;

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

	internal static class ValigatorJsonWriter
	{
		private delegate void IWriteValue<TDataValue>(Utf8JsonWriter writer, JsonSerializerOptions options, Data<TDataValue> data);

		private static readonly MethodInfo _writeNullableValueMethod = typeof(ValigatorJsonWriter).GetMethod(nameof(WriteNullableSingleValue), BindingFlags.NonPublic | BindingFlags.Static);
		private static readonly ConcurrentDictionary<Type, Delegate> _writeSingleValueDelegates = new ConcurrentDictionary<Type, Delegate>();

		private static readonly MethodInfo _writeCollectionValueMethod = typeof(ValigatorJsonWriter).GetMethod(nameof(WriteCollectionValue), BindingFlags.NonPublic | BindingFlags.Static);
		private static readonly MethodInfo _writeCollectionNullableValueMethod = typeof(ValigatorJsonWriter).GetMethod(nameof(WriteCollectionNullableValue), BindingFlags.NonPublic | BindingFlags.Static);
		private static readonly MethodInfo _writeNullableCollectionValueMethod = typeof(ValigatorJsonWriter).GetMethod(nameof(WriteNullableCollectionValue), BindingFlags.NonPublic | BindingFlags.Static);
		private static readonly MethodInfo _writeNullableCollectionNullableValueMethod = typeof(ValigatorJsonWriter).GetMethod(nameof(WriteNullableCollectionNullableValue), BindingFlags.NonPublic | BindingFlags.Static);
		private static readonly ConcurrentDictionary<Type, Delegate> _writeCollectionValueDelegates = new ConcurrentDictionary<Type, Delegate>();

		private static IWriteValue<TDataValue> GetWriteValueDelegate<TDataValue>(Data<TDataValue> data)
			=> data.DataContainer is IAcceptCollectionValue<TDataValue>
				? GetWriteCollectionValueDelegate(data)
				: GetWriteSingleValueDelegate(data);

		private static IWriteValue<TDataValue> GetWriteSingleValueDelegate<TDataValue>(Data<TDataValue> data)
			=> (IWriteValue<TDataValue>)_writeSingleValueDelegates
				.GetOrAdd
				(
					typeof(TDataValue),
					key => key.IsGenericType && key.GetGenericTypeDefinition() == typeof(Option<>)
						? Delegate.CreateDelegate(typeof(IWriteValue<TDataValue>), _writeNullableValueMethod.MakeGenericMethod(key, key.GetGenericArguments()[0]))
						: new IWriteValue<TDataValue>(WriteSingleValue)
				);

		private static IWriteValue<TDataValue> GetWriteCollectionValueDelegate<TDataValue>(Data<TDataValue> data)
			=> (IWriteValue<TDataValue>)_writeCollectionValueDelegates
				.GetOrAdd
				(
					typeof(TDataValue),
					key => key.IsGenericType && key.GetGenericTypeDefinition() == typeof(Option<>)
						? key.GetGenericArguments()[0].GetElementType().IsGenericType && key.GetGenericArguments()[0].GetElementType().GetGenericTypeDefinition() == typeof(Option<>)
							? Delegate.CreateDelegate(typeof(IWriteValue<TDataValue>), _writeNullableCollectionNullableValueMethod.MakeGenericMethod(key, key.GetGenericArguments()[0].GetElementType().GetGenericArguments()[0]))
							: Delegate.CreateDelegate(typeof(IWriteValue<TDataValue>), _writeNullableCollectionValueMethod.MakeGenericMethod(key, key.GetGenericArguments()[0].GetElementType()))
						: key.GetElementType().IsGenericType && key.GetElementType().GetGenericTypeDefinition() == typeof(Option<>)
							? Delegate.CreateDelegate(typeof(IWriteValue<TDataValue>), _writeCollectionNullableValueMethod.MakeGenericMethod(key, key.GetElementType().GetGenericArguments()[0]))
							: Delegate.CreateDelegate(typeof(IWriteValue<TDataValue>), _writeCollectionValueMethod.MakeGenericMethod(key, key.GetElementType()))
				);

		public static void WriteValue<TDataValue>(Utf8JsonWriter writer, JsonSerializerOptions options, Data<TDataValue> data)
			=> GetWriteValueDelegate(data).Invoke(writer, options, data);

		private static void WriteSingleValue<TDataValue>(Utf8JsonWriter writer, JsonSerializerOptions options, Data<TDataValue> data)
			=> JsonSerializer.Serialize(writer, data.Value, options);

		private static void WriteNullableSingleValue<TDataValue, TItemValue>(Utf8JsonWriter writer, JsonSerializerOptions options, Data<TDataValue> data)
		{
			if (((Option<TItemValue>)(object)data.Value).TryGetValue(out var value))
				JsonSerializer.Serialize(writer, value, options);
			else
				writer.WriteNullValue();
		}

		private static void WriteCollectionValue<TDataValue, TItemValue>(Utf8JsonWriter writer, JsonSerializerOptions options, Data<TDataValue> data)
		{
			writer.WriteStartArray();

			foreach (var item in (TItemValue[])(object)data.Value)
				JsonSerializer.Serialize(writer, item, options);

			writer.WriteEndArray();
		}

		private static void WriteCollectionNullableValue<TDataValue, TItemValue>(Utf8JsonWriter writer, JsonSerializerOptions options, Data<TDataValue> data)
		{
			writer.WriteStartArray();

			foreach (var item in (Option<TItemValue>[])(object)data.Value)
			{
				if (item.TryGetValue(out var value))
					JsonSerializer.Serialize(writer, value, options);
				else
					writer.WriteNullValue();
			}

			writer.WriteEndArray();
		}

		private static void WriteNullableCollectionValue<TDataValue, TItemValue>(Utf8JsonWriter writer, JsonSerializerOptions options, Data<TDataValue> data)
		{
			if (((Option<TItemValue[]>)(object)data.Value).TryGetValue(out var value))
			{
				writer.WriteStartArray();

				foreach (var item in value)
					JsonSerializer.Serialize(writer, item, options);

				writer.WriteEndArray();
			}
			else
				writer.WriteNullValue();
		}

		private static void WriteNullableCollectionNullableValue<TDataValue, TItemValue>(Utf8JsonWriter writer, JsonSerializerOptions options, Data<TDataValue> data)
		{
			if (((Option<Option<TItemValue>[]>)(object)data.Value).TryGetValue(out var value))
			{
				writer.WriteStartArray();

				foreach (var item in value)
				{
					if (item.TryGetValue(out var o))
						JsonSerializer.Serialize(writer, o, options);
					else
						writer.WriteNullValue();
				}

				writer.WriteEndArray();
			}
			else
				writer.WriteNullValue();
		}
	}
}
