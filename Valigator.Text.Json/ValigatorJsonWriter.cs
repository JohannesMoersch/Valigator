using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Text.Json;
using Functional;
using Valigator.Core;

namespace Valigator.Text.Json
{
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
