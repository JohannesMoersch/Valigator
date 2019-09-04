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
		public static Data<TDataValue> WithValue<TDataValue, TValue>(this Data<TDataValue> data, TValue value)
			=> data.WithValue(Option.Create(value != null, value));

		public static Data<TDataValue> WithValue<TDataValue, TValue>(this Data<TDataValue> data, TValue? value)
			where TValue : struct
			=> data.WithValue(Option.FromNullable(value));

		public static Data<TDataValue> WithValue<TDataValue, TValue>(this Data<TDataValue> data, Option<TValue> value)
			=> data.DataContainer is IAcceptValue<TDataValue, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<Option<TDataValue>> WithValue<TDataValue, TValue>(this Data<Option<TDataValue>> data, TValue value)
			=> data.WithValue(Option.Create(value != null, value));

		public static Data<Option<TDataValue>> WithValue<TDataValue, TValue>(this Data<Option<TDataValue>> data, TValue? value)
			where TValue : struct
			=> data.WithValue(Option.FromNullable(value));

		public static Data<Option<TDataValue>> WithValue<TDataValue, TValue>(this Data<Option<TDataValue>> data, Option<TValue> value)
			=> data.DataContainer is IAcceptValue<Option<TDataValue>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<TDataValue[]> WithValue<TDataValue, TValue>(this Data<TDataValue[]> data, TValue[] value)
			=> data.WithValue(ToOptionArray(value));

		public static Data<TDataValue[]> WithValue<TDataValue, TValue>(this Data<TDataValue[]> data, TValue?[] value)
			where TValue : struct
			=> data.WithValue(ToOptionArray(value));

		public static Data<TDataValue[]> WithValue<TDataValue, TValue>(this Data<TDataValue[]> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<TDataValue[], TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<Option<TDataValue[]>> WithValue<TDataValue, TValue>(this Data<Option<TDataValue[]>> data, TValue[] value)
			=> data.WithValue(ToOptionArray(value));

		public static Data<Option<TDataValue[]>> WithValue<TDataValue, TValue>(this Data<Option<TDataValue[]>> data, TValue?[] value)
			where TValue : struct
			=> data.WithValue(ToOptionArray(value));

		public static Data<Option<TDataValue[]>> WithValue<TDataValue, TValue>(this Data<Option<TDataValue[]>> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<Option<TDataValue[]>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<Option<TDataValue>[]> WithValue<TDataValue, TValue>(this Data<Option<TDataValue>[]> data, TValue[] value)
			=> data.WithValue(ToOptionArray(value));

		public static Data<Option<TDataValue>[]> WithValue<TDataValue, TValue>(this Data<Option<TDataValue>[]> data, TValue?[] value)
			where TValue : struct
			=> data.WithValue(ToOptionArray(value));

		public static Data<Option<TDataValue>[]> WithValue<TDataValue, TValue>(this Data<Option<TDataValue>[]> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<Option<TDataValue>[], TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<Option<Option<TDataValue>[]>> WithValue<TDataValue, TValue>(this Data<Option<Option<TDataValue>[]>> data, TValue[] value)
			=> data.WithValue(ToOptionArray(value));

		public static Data<Option<Option<TDataValue>[]>> WithValue<TDataValue, TValue>(this Data<Option<Option<TDataValue>[]>> data, TValue?[] value)
			where TValue : struct
			=> data.WithValue(ToOptionArray(value));

		public static Data<Option<Option<TDataValue>[]>> WithValue<TDataValue, TValue>(this Data<Option<Option<TDataValue>[]>> data, Option<Option<TValue>[]> value)
			=> data.DataContainer is IAcceptCollectionValue<Option<Option<TDataValue>[]>, TValue> dataContainer
				? dataContainer.WithValue(data, value)
				: throw new NotSupportedException($"This variant of {nameof(WithValue)} only supports Data<Option<T>> data types.");

		public static Data<TValue> WithNull<TValue>(this Data<TValue> data)
			=> data.DataContainer is IAcceptValue<TValue> dataContainer
				? dataContainer.WithNull(data)
				: throw new NotSupportedException($"This variant of {nameof(WithNull)} only supports Data<Option<T>> data types.");

		public static Data<Option<TValue>> WithNull<TValue>(this Data<Option<TValue>> data)
			=> data.DataContainer is IAcceptValue<Option<TValue>> dataContainer
				? dataContainer.WithNull(data)
				: throw new NotSupportedException($"This variant of {nameof(WithNull)} only supports Data<Option<T>> data types.");

		public static Data<TValue[]> WithNull<TValue>(this Data<TValue[]> data)
			=> data.DataContainer is IAcceptValue<TValue[]> dataContainer
				? dataContainer.WithNull(data)
				: throw new NotSupportedException($"This variant of {nameof(WithNull)} only supports Data<Option<T>> data types.");

		public static Data<Option<TValue[]>> WithNull<TValue>(this Data<Option<TValue[]>> data)
			=> data.DataContainer is IAcceptValue<Option<TValue[]>> dataContainer
				? dataContainer.WithNull(data)
				: throw new NotSupportedException($"This variant of {nameof(WithNull)} only supports Data<Option<T>> data types.");

		public static Data<Option<TValue>[]> WithNull<TValue>(this Data<Option<TValue>[]> data)
			=> data.DataContainer is IAcceptValue<Option<TValue>[]> dataContainer
				? dataContainer.WithNull(data)
				: throw new NotSupportedException($"This variant of {nameof(WithNull)} only supports Data<Option<T>> data types.");

		public static Data<Option<Option<TValue>[]>> WithNull<TValue>(this Data<Option<Option<TValue>[]>> data)
			=> data.DataContainer is IAcceptValue<Option<Option<TValue>[]>> dataContainer
				? dataContainer.WithNull(data)
				: throw new NotSupportedException($"This variant of {nameof(WithNull)} only supports Data<Option<T>> data types.");

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
