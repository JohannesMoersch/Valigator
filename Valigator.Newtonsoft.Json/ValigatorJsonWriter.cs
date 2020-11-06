using System;
using System.Collections.Concurrent;
using System.Reflection;
using Functional;
using Newtonsoft.Json;
using Valigator.Core;

namespace Valigator.Newtonsoft.Json
{
	internal static class ValigatorJsonWriter
	{
		private delegate void IWriteValue<TDataValue>(JsonWriter writer, JsonSerializer serializer, Data<TDataValue> data);

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

		public static void WriteValue<TDataValue>(JsonWriter writer, JsonSerializer serializer, Data<TDataValue> data)
			=> GetWriteValueDelegate(data).Invoke(writer, serializer, data);

		private static void WriteSingleValue<TDataValue>(JsonWriter writer, JsonSerializer serializer, Data<TDataValue> data)
			=> serializer.Serialize(writer, data.Value);

		private static void WriteNullableSingleValue<TDataValue, TItemValue>(JsonWriter writer, JsonSerializer serializer, Data<TDataValue> data)
		{
			if (((Option<TItemValue>)(object)data.Value).TryGetValue(out var value))
				serializer.Serialize(writer, value);
			else
				writer.WriteNull();
		}

		private static void WriteCollectionValue<TDataValue, TItemValue>(JsonWriter writer, JsonSerializer serializer, Data<TDataValue> data)
		{
			writer.WriteStartArray();

			foreach (var item in (TItemValue[])(object)data.Value)
				serializer.Serialize(writer, item);

			writer.WriteEndArray();
		}

		private static void WriteCollectionNullableValue<TDataValue, TItemValue>(JsonWriter writer, JsonSerializer serializer, Data<TDataValue> data)
		{
			writer.WriteStartArray();

			foreach (var item in (Option<TItemValue>[])(object)data.Value)
			{
				if (item.TryGetValue(out var value))
					serializer.Serialize(writer, value);
				else
					writer.WriteNull();
			}

			writer.WriteEndArray();
		}

		private static void WriteNullableCollectionValue<TDataValue, TItemValue>(JsonWriter writer, JsonSerializer serializer, Data<TDataValue> data)
		{
			if (((Option<TItemValue[]>)(object)data.Value).TryGetValue(out var value))
			{
				writer.WriteStartArray();

				foreach (var item in value)
					serializer.Serialize(writer, item);

				writer.WriteEndArray();
			}
			else
				writer.WriteNull();
		}

		private static void WriteNullableCollectionNullableValue<TDataValue, TItemValue>(JsonWriter writer, JsonSerializer serializer, Data<TDataValue> data)
		{
			if (((Option<Option<TItemValue>[]>)(object)data.Value).TryGetValue(out var value))
			{
				writer.WriteStartArray();

				foreach (var item in value)
				{
					if (item.TryGetValue(out var o))
						serializer.Serialize(writer, o);
					else
						writer.WriteNull();
				}

				writer.WriteEndArray();
			}
			else
				writer.WriteNull();
		}
	}
}
