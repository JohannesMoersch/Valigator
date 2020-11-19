using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using Functional;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Valigator.Core;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Newtonsoft.Json
{
	internal static class ValigatorJsonReader
	{
		private delegate Data<TDataValue> IReadValue<TDataValue>(JsonReader reader, JsonSerializer serializer, Data<TDataValue> data);

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

		public static Data<TDataValue> ReadValue<TDataValue>(JsonReader reader, JsonSerializer serializer, Data<TDataValue> data)
			=> GetReadValueDelegate(data).Invoke(reader, serializer, data);

		private static Data<TDataValue> ReadSingleValue<TDataValue, TValue>(JsonReader reader, JsonSerializer serializer, Data<TDataValue> data)
		{
			if (reader.TokenType == JsonToken.Null)
				return SetValue(data, Option.None<TValue>());

			try
			{
				if (serializer.Deserialize<TValue>(reader) is TValue value)
					return SetValue(data, Option.Some(value));
			}
			catch (JsonSerializationException ex)
			{
				return SetError<object, TValue>(data, ex.Message);
			}


			return SetNull(data);
		}

		private static Data<TDataValue> ReadCollectionValue<TDataValue, TValue>(JsonReader reader, JsonSerializer serializer, Data<TDataValue> data)
		{
			if (reader.TokenType == JsonToken.Null)
				return SetNull(data);

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

			return SetValue(data, Option.Some(values.ToArray()));
		}

		private static Data<TDataValue> SetValue<TDataValue, TValue>(Data<TDataValue> data, Option<TValue> value)
			=> (data.DataContainer as IAcceptValue<TDataValue, TValue>).WithValue(data, value);

		private static Data<TDataValue> SetValue<TDataValue, TValue>(Data<TDataValue> data, Option<Option<TValue>[]> value)
			=> (data.DataContainer as IAcceptCollectionValue<TDataValue, TValue>).WithValue(data, value);

		private static Data<TDataValue> SetNull<TDataValue>(Data<TDataValue> data)
			=> (data.DataContainer as IAcceptValue<TDataValue>).WithNull(data);

		private static Data<TTo> SetError<TFrom, TTo>(Data<TTo> data, string message)
			=> data.WithErrors(MappingError.Create<TFrom, TTo>(message));
	}
}
