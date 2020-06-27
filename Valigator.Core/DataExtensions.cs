using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Functional;
using Valigator.Core;

namespace Valigator
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class DataExtensions
	{
		public static Data<TValue> WithUncheckedValue<TValue>(this Data<TValue> data, TValue value)
			=> data.DataContainer is IDataContainer<TValue> dataContainer 
				? dataContainer.WithUncheckedValue(data, value)
				: throw new NotSupportedException($"{nameof(data)}.{nameof(data.DataContainer)} must be a {nameof(IDataContainer<TValue>)}.");

		public static Data<TValue> WithValue<TValue>(this Data<TValue> data, TValue value)
			=> data.WithValue(Option.Create(value != null, value));

		public static Data<TValue> WithValue<TValue>(this Data<TValue> data, TValue? value)
			where TValue : struct
			=> data.WithValue(Option.FromNullable(value));

		public static Data<TValue> WithValue<TValue>(this Data<TValue> data, Option<TValue> value)
			=> data.DataContainer is IAcceptValue<TValue, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<Option<TValue>> WithValue<TValue>(this Data<Option<TValue>> data, TValue value)
			=> data.WithValue(Option.Create(value != null, value));

		public static Data<Option<TValue>> WithValue<TValue>(this Data<Option<TValue>> data, TValue? value)
			where TValue : struct
			=> data.WithValue(Option.FromNullable(value));

		public static Data<Option<TValue>> WithValue<TValue>(this Data<Option<TValue>> data, Option<TValue> value)
			=> data.DataContainer is IAcceptValue<Option<TValue>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<Optional<TValue>> WithValue<TValue>(this Data<Optional<TValue>> data, TValue value)
			=> data.WithValue(Option.Create(value != null, value));

		public static Data<Optional<TValue>> WithValue<TValue>(this Data<Optional<TValue>> data, TValue? value)
			where TValue : struct
			=> data.WithValue(Option.FromNullable(value));

		public static Data<Optional<TValue>> WithValue<TValue>(this Data<Optional<TValue>> data, Option<TValue> value)
			=> data.DataContainer is IAcceptValue<Optional<TValue>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Optional<T>> data types.");

		public static Data<Optional<Option<TValue>>> WithValue<TValue>(this Data<Optional<Option<TValue>>> data, TValue value)
			=> data.WithValue(Option.Create(value != null, value));

		public static Data<Optional<Option<TValue>>> WithValue<TValue>(this Data<Optional<Option<TValue>>> data, TValue? value)
			where TValue : struct
			=> data.WithValue(Option.FromNullable(value));

		public static Data<Optional<Option<TValue>>> WithValue<TValue>(this Data<Optional<Option<TValue>>> data, Option<TValue> value)
			=> data.DataContainer is IAcceptValue<Optional<Option<TValue>>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Optional<T>> data types.");

		public static Data<TValue[]> WithValue<TValue>(this Data<TValue[]> data, TValue[] value)
			=> data.WithValue(ToOptionArray(value));

		public static Data<TValue[]> WithValue<TValue>(this Data<TValue[]> data, TValue?[] value)
			where TValue : struct
			=> data.WithValue(ToOptionArray(value));

		public static Data<TValue[]> WithValue<TValue>(this Data<TValue[]> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<TValue[], TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<Option<TValue[]>> WithValue<TValue>(this Data<Option<TValue[]>> data, TValue[] value)
			=> data.WithValue(ToOptionArray(value));

		public static Data<Option<TValue[]>> WithValue<TValue>(this Data<Option<TValue[]>> data, TValue?[] value)
			where TValue : struct
			=> data.WithValue(ToOptionArray(value));

		public static Data<Option<TValue[]>> WithValue<TValue>(this Data<Option<TValue[]>> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<Option<TValue[]>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<Option<TValue>[]> WithValue<TValue>(this Data<Option<TValue>[]> data, TValue[] value)
			=> data.WithValue(ToOptionArray(value));

		public static Data<Option<TValue>[]> WithValue<TValue>(this Data<Option<TValue>[]> data, TValue?[] value)
			where TValue : struct
			=> data.WithValue(ToOptionArray(value));

		public static Data<Option<TValue>[]> WithValue<TValue>(this Data<Option<TValue>[]> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<Option<TValue>[], TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<Option<Option<TValue>[]>> WithValue<TValue>(this Data<Option<Option<TValue>[]>> data, TValue[] value)
			=> data.WithValue(ToOptionArray(value));

		public static Data<Option<Option<TValue>[]>> WithValue<TValue>(this Data<Option<Option<TValue>[]>> data, TValue?[] value)
			where TValue : struct
			=> data.WithValue(ToOptionArray(value));

		public static Data<Option<Option<TValue>[]>> WithValue<TValue>(this Data<Option<Option<TValue>[]>> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<Option<Option<TValue>[]>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<Optional<TValue[]>> WithValue<TValue>(this Data<Optional<TValue[]>> data, TValue[] value)
			=> data.WithValue(ToOptionArray(value));

		public static Data<Optional<TValue[]>> WithValue<TValue>(this Data<Optional<TValue[]>> data, TValue?[] value)
			where TValue : struct
			=> data.WithValue(ToOptionArray(value));

		public static Data<Optional<TValue[]>> WithValue<TValue>(this Data<Optional<TValue[]>> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<Optional<TValue[]>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<Optional<Option<TValue[]>>> WithValue<TValue>(this Data<Optional<Option<TValue[]>>> data, TValue[] value)
			=> data.WithValue(ToOptionArray(value));

		public static Data<Optional<Option<TValue[]>>> WithValue<TValue>(this Data<Optional<Option<TValue[]>>> data, TValue?[] value)
			where TValue : struct
			=> data.WithValue(ToOptionArray(value));

		public static Data<Optional<Option<TValue[]>>> WithValue<TValue>(this Data<Optional<Option<TValue[]>>> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<Optional<Option<TValue[]>>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<Optional<Option<TValue>[]>> WithValue<TValue>(this Data<Optional<Option<TValue>[]>> data, TValue[] value)
			=> data.WithValue(ToOptionArray(value));

		public static Data<Optional<Option<TValue>[]>> WithValue<TValue>(this Data<Optional<Option<TValue>[]>> data, TValue?[] value)
			where TValue : struct
			=> data.WithValue(ToOptionArray(value));

		public static Data<Optional<Option<TValue>[]>> WithValue<TValue>(this Data<Optional<Option<TValue>[]>> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<Optional<Option<TValue>[]>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<Optional<Option<Option<TValue>[]>>> WithValue<TValue>(this Data<Optional<Option<Option<TValue>[]>>> data, TValue[] value)
			=> data.WithValue(ToOptionArray(value));

		public static Data<Optional<Option<Option<TValue>[]>>> WithValue<TValue>(this Data<Optional<Option<Option<TValue>[]>>> data, TValue?[] value)
			where TValue : struct
			=> data.WithValue(ToOptionArray(value));

		public static Data<Optional<Option<Option<TValue>[]>>> WithValue<TValue>(this Data<Optional<Option<Option<TValue>[]>>> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<Optional<Option<Option<TValue>[]>>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<TDataValue> WithMappedValue<TDataValue, TValue>(this Data<TDataValue> data, TValue value)
			=> data.WithMappedValue(Option.Create(value != null, value));

		public static Data<TDataValue> WithMappedValue<TDataValue, TValue>(this Data<TDataValue> data, TValue? value)
			where TValue : struct
			=> data.WithMappedValue(Option.FromNullable(value));

		public static Data<TDataValue> WithMappedValue<TDataValue, TValue>(this Data<TDataValue> data, Option<TValue> value)
			=> data.DataContainer is IAcceptValue<TDataValue, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithMappedValue)} only supports Data<Option<T>> data types.");

		public static Data<Option<TDataValue>> WithMappedValue<TDataValue, TValue>(this Data<Option<TDataValue>> data, TValue value)
			=> data.WithMappedValue(Option.Create(value != null, value));

		public static Data<Option<TDataValue>> WithMappedValue<TDataValue, TValue>(this Data<Option<TDataValue>> data, TValue? value)
			where TValue : struct
			=> data.WithMappedValue(Option.FromNullable(value));

		public static Data<Option<TDataValue>> WithMappedValue<TDataValue, TValue>(this Data<Option<TDataValue>> data, Option<TValue> value)
			=> data.DataContainer is IAcceptValue<Option<TDataValue>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithMappedValue)} only supports Data<Option<T>> data types.");

		public static Data<TDataValue[]> WithMappedValue<TDataValue, TValue>(this Data<TDataValue[]> data, TValue[] value)
			=> data.WithMappedValue(ToOptionArray(value));

		public static Data<TDataValue[]> WithMappedValue<TDataValue, TValue>(this Data<TDataValue[]> data, TValue?[] value)
			where TValue : struct
			=> data.WithMappedValue(ToOptionArray(value));

		public static Data<TDataValue[]> WithMappedValue<TDataValue, TValue>(this Data<TDataValue[]> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<TDataValue[], TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithMappedValue)} only supports Data<Option<T>> data types.");

		public static Data<Option<TDataValue[]>> WithMappedValue<TDataValue, TValue>(this Data<Option<TDataValue[]>> data, TValue[] value)
			=> data.WithMappedValue(ToOptionArray(value));

		public static Data<Option<TDataValue[]>> WithMappedValue<TDataValue, TValue>(this Data<Option<TDataValue[]>> data, TValue?[] value)
			where TValue : struct
			=> data.WithMappedValue(ToOptionArray(value));

		public static Data<Option<TDataValue[]>> WithMappedValue<TDataValue, TValue>(this Data<Option<TDataValue[]>> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<Option<TDataValue[]>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithMappedValue)} only supports Data<Option<T>> data types.");

		public static Data<Option<TDataValue>[]> WithMappedValue<TDataValue, TValue>(this Data<Option<TDataValue>[]> data, TValue[] value)
			=> data.WithMappedValue(ToOptionArray(value));

		public static Data<Option<TDataValue>[]> WithMappedValue<TDataValue, TValue>(this Data<Option<TDataValue>[]> data, TValue?[] value)
			where TValue : struct
			=> data.WithMappedValue(ToOptionArray(value));

		public static Data<Option<TDataValue>[]> WithMappedValue<TDataValue, TValue>(this Data<Option<TDataValue>[]> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<Option<TDataValue>[], TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithMappedValue)} only supports Data<Option<T>> data types.");

		public static Data<Option<Option<TDataValue>[]>> WithMappedValue<TDataValue, TValue>(this Data<Option<Option<TDataValue>[]>> data, TValue[] value)
			=> data.WithMappedValue(ToOptionArray(value));

		public static Data<Option<Option<TDataValue>[]>> WithMappedValue<TDataValue, TValue>(this Data<Option<Option<TDataValue>[]>> data, TValue?[] value)
			where TValue : struct
			=> data.WithMappedValue(ToOptionArray(value));

		public static Data<Option<Option<TDataValue>[]>> WithMappedValue<TDataValue, TValue>(this Data<Option<Option<TDataValue>[]>> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<Option<Option<TDataValue>[]>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithMappedValue)} only supports Data<Option<T>> data types.");

		public static Data<TValue> WithNull<TValue>(this Data<TValue> data)
			=> data.DataContainer is IAcceptValue<TValue> dataContainer
				? dataContainer.WithNull(data)
				: throw new NotSupportedException($"This variant of {nameof(WithNull)} does not support this type.");
		private static Option<Option<TValue>[]> ToOptionArray<TValue>(TValue[] values)
		{
			if (values == null)
				return Option.None<Option<TValue>[]>();

			var arr = new Option<TValue>[values.Length];
			for (int i = 0; i < values.Length; ++i)
				arr[i] = Option.Create(values[i] != null, values[i]);
			return Option.Some(arr);
		}

		private static Option<Option<TValue>[]> ToOptionArray<TValue>(TValue?[] values)
			where TValue : struct
		{
			if (values == null)
				return Option.None<Option<TValue>[]>();

			var arr = new Option<TValue>[values.Length];
			for (int i = 0; i < values.Length; ++i)
				arr[i] = Option.FromNullable(values[i]);
			return Option.Some(arr);
		}
	}
}
