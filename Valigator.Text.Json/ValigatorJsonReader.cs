using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using Functional;
using Valigator.Core;

namespace Valigator.Text.Json
{
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
}
