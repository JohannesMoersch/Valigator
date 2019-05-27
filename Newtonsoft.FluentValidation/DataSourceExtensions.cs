using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.FluentValidation.DataSources;
using Newtonsoft.FluentValidation.ValueValidators;

namespace Newtonsoft.FluentValidation
{
	public static class DataSourceExtensions
	{
		public static ValueTypeNotDefaultValidator<RequiredSource<TValue>, TValue> NotDefault<TValue>(this RequiredSource<TValue> dataSource)
			where TValue : struct
			=> new ValueTypeNotDefaultValidator<RequiredSource<TValue>, TValue>(dataSource);

		public static RangeValidator_Byte<RequiredSource<byte>> LessThan(this RequiredSource<byte> requiredValidator, byte value)
			=> new RangeValidator_Byte<RequiredSource<byte>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Byte<RequiredSource<byte>> LessThanOrEqualTo(this RequiredSource<byte> requiredValidator, byte value)
			=> new RangeValidator_Byte<RequiredSource<byte>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Byte<RequiredSource<byte>> GreaterThan(this RequiredSource<byte> requiredValidator, byte value)
			=> new RangeValidator_Byte<RequiredSource<byte>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Byte<RequiredSource<byte>> GreaterThanOrEqualTo(this RequiredSource<byte> requiredValidator, byte value)
			=> new RangeValidator_Byte<RequiredSource<byte>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Byte<RequiredSource<byte>> InRange(this RequiredSource<byte> requiredValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			return new RangeValidator_Byte<RequiredSource<byte>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_SByte<RequiredSource<sbyte>> LessThan(this RequiredSource<sbyte> requiredValidator, sbyte value)
			=> new RangeValidator_SByte<RequiredSource<sbyte>>(requiredValidator, value, false, null, false);

		public static RangeValidator_SByte<RequiredSource<sbyte>> LessThanOrEqualTo(this RequiredSource<sbyte> requiredValidator, sbyte value)
			=> new RangeValidator_SByte<RequiredSource<sbyte>>(requiredValidator, value, true, null, false);

		public static RangeValidator_SByte<RequiredSource<sbyte>> GreaterThan(this RequiredSource<sbyte> requiredValidator, sbyte value)
			=> new RangeValidator_SByte<RequiredSource<sbyte>>(requiredValidator, null, false, value, false);

		public static RangeValidator_SByte<RequiredSource<sbyte>> GreaterThanOrEqualTo(this RequiredSource<sbyte> requiredValidator, sbyte value)
			=> new RangeValidator_SByte<RequiredSource<sbyte>>(requiredValidator, null, false, value, true);

		public static RangeValidator_SByte<RequiredSource<sbyte>> InRange(this RequiredSource<sbyte> requiredValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			return new RangeValidator_SByte<RequiredSource<sbyte>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Int16<RequiredSource<short>> LessThan(this RequiredSource<short> requiredValidator, short value)
			=> new RangeValidator_Int16<RequiredSource<short>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Int16<RequiredSource<short>> LessThanOrEqualTo(this RequiredSource<short> requiredValidator, short value)
			=> new RangeValidator_Int16<RequiredSource<short>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Int16<RequiredSource<short>> GreaterThan(this RequiredSource<short> requiredValidator, short value)
			=> new RangeValidator_Int16<RequiredSource<short>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Int16<RequiredSource<short>> GreaterThanOrEqualTo(this RequiredSource<short> requiredValidator, short value)
			=> new RangeValidator_Int16<RequiredSource<short>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Int16<RequiredSource<short>> InRange(this RequiredSource<short> requiredValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			return new RangeValidator_Int16<RequiredSource<short>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_UInt16<RequiredSource<ushort>> LessThan(this RequiredSource<ushort> requiredValidator, ushort value)
			=> new RangeValidator_UInt16<RequiredSource<ushort>>(requiredValidator, value, false, null, false);

		public static RangeValidator_UInt16<RequiredSource<ushort>> LessThanOrEqualTo(this RequiredSource<ushort> requiredValidator, ushort value)
			=> new RangeValidator_UInt16<RequiredSource<ushort>>(requiredValidator, value, true, null, false);

		public static RangeValidator_UInt16<RequiredSource<ushort>> GreaterThan(this RequiredSource<ushort> requiredValidator, ushort value)
			=> new RangeValidator_UInt16<RequiredSource<ushort>>(requiredValidator, null, false, value, false);

		public static RangeValidator_UInt16<RequiredSource<ushort>> GreaterThanOrEqualTo(this RequiredSource<ushort> requiredValidator, ushort value)
			=> new RangeValidator_UInt16<RequiredSource<ushort>>(requiredValidator, null, false, value, true);

		public static RangeValidator_UInt16<RequiredSource<ushort>> InRange(this RequiredSource<ushort> requiredValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			return new RangeValidator_UInt16<RequiredSource<ushort>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Int32<RequiredSource<int>> LessThan(this RequiredSource<int> requiredValidator, int value)
			=> new RangeValidator_Int32<RequiredSource<int>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Int32<RequiredSource<int>> LessThanOrEqualTo(this RequiredSource<int> requiredValidator, int value)
			=> new RangeValidator_Int32<RequiredSource<int>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Int32<RequiredSource<int>> GreaterThan(this RequiredSource<int> requiredValidator, int value)
			=> new RangeValidator_Int32<RequiredSource<int>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Int32<RequiredSource<int>> GreaterThanOrEqualTo(this RequiredSource<int> requiredValidator, int value)
			=> new RangeValidator_Int32<RequiredSource<int>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Int32<RequiredSource<int>> InRange(this RequiredSource<int> requiredValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			return new RangeValidator_Int32<RequiredSource<int>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_UInt32<RequiredSource<uint>> LessThan(this RequiredSource<uint> requiredValidator, uint value)
			=> new RangeValidator_UInt32<RequiredSource<uint>>(requiredValidator, value, false, null, false);

		public static RangeValidator_UInt32<RequiredSource<uint>> LessThanOrEqualTo(this RequiredSource<uint> requiredValidator, uint value)
			=> new RangeValidator_UInt32<RequiredSource<uint>>(requiredValidator, value, true, null, false);

		public static RangeValidator_UInt32<RequiredSource<uint>> GreaterThan(this RequiredSource<uint> requiredValidator, uint value)
			=> new RangeValidator_UInt32<RequiredSource<uint>>(requiredValidator, null, false, value, false);

		public static RangeValidator_UInt32<RequiredSource<uint>> GreaterThanOrEqualTo(this RequiredSource<uint> requiredValidator, uint value)
			=> new RangeValidator_UInt32<RequiredSource<uint>>(requiredValidator, null, false, value, true);

		public static RangeValidator_UInt32<RequiredSource<uint>> InRange(this RequiredSource<uint> requiredValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			return new RangeValidator_UInt32<RequiredSource<uint>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Int64<RequiredSource<long>> LessThan(this RequiredSource<long> requiredValidator, long value)
			=> new RangeValidator_Int64<RequiredSource<long>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Int64<RequiredSource<long>> LessThanOrEqualTo(this RequiredSource<long> requiredValidator, long value)
			=> new RangeValidator_Int64<RequiredSource<long>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Int64<RequiredSource<long>> GreaterThan(this RequiredSource<long> requiredValidator, long value)
			=> new RangeValidator_Int64<RequiredSource<long>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Int64<RequiredSource<long>> GreaterThanOrEqualTo(this RequiredSource<long> requiredValidator, long value)
			=> new RangeValidator_Int64<RequiredSource<long>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Int64<RequiredSource<long>> InRange(this RequiredSource<long> requiredValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			return new RangeValidator_Int64<RequiredSource<long>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_UInt64<RequiredSource<ulong>> LessThan(this RequiredSource<ulong> requiredValidator, ulong value)
			=> new RangeValidator_UInt64<RequiredSource<ulong>>(requiredValidator, value, false, null, false);

		public static RangeValidator_UInt64<RequiredSource<ulong>> LessThanOrEqualTo(this RequiredSource<ulong> requiredValidator, ulong value)
			=> new RangeValidator_UInt64<RequiredSource<ulong>>(requiredValidator, value, true, null, false);

		public static RangeValidator_UInt64<RequiredSource<ulong>> GreaterThan(this RequiredSource<ulong> requiredValidator, ulong value)
			=> new RangeValidator_UInt64<RequiredSource<ulong>>(requiredValidator, null, false, value, false);

		public static RangeValidator_UInt64<RequiredSource<ulong>> GreaterThanOrEqualTo(this RequiredSource<ulong> requiredValidator, ulong value)
			=> new RangeValidator_UInt64<RequiredSource<ulong>>(requiredValidator, null, false, value, true);

		public static RangeValidator_UInt64<RequiredSource<ulong>> InRange(this RequiredSource<ulong> requiredValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			return new RangeValidator_UInt64<RequiredSource<ulong>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}
	}
}
