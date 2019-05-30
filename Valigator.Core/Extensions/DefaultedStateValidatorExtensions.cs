using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedStateValidatorExtensions
	{
		public static DataSource<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this DefaultedStateValidator<byte> defaultedValidator, byte value)
			=> new DataSource<DefaultedStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(value, false, null, false));

		public static DataSource<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this DefaultedStateValidator<byte> defaultedValidator, byte value)
			=> new DataSource<DefaultedStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(value, true, null, false));

		public static DataSource<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this DefaultedStateValidator<byte> defaultedValidator, byte value)
			=> new DataSource<DefaultedStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(null, false, value, false));

		public static DataSource<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this DefaultedStateValidator<byte> defaultedValidator, byte value)
			=> new DataSource<DefaultedStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(null, false, value, true));

		public static DataSource<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> InRange(this DefaultedStateValidator<byte> defaultedValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<DefaultedStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this DefaultedStateValidator<sbyte> defaultedValidator, sbyte value)
			=> new DataSource<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(value, false, null, false));

		public static DataSource<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this DefaultedStateValidator<sbyte> defaultedValidator, sbyte value)
			=> new DataSource<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(value, true, null, false));

		public static DataSource<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this DefaultedStateValidator<sbyte> defaultedValidator, sbyte value)
			=> new DataSource<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(null, false, value, false));

		public static DataSource<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this DefaultedStateValidator<sbyte> defaultedValidator, sbyte value)
			=> new DataSource<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(null, false, value, true));

		public static DataSource<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this DefaultedStateValidator<sbyte> defaultedValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<DefaultedStateValidator<short>, RangeValidator_Int16, short> LessThan(this DefaultedStateValidator<short> defaultedValidator, short value)
			=> new DataSource<DefaultedStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(value, false, null, false));

		public static DataSource<DefaultedStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this DefaultedStateValidator<short> defaultedValidator, short value)
			=> new DataSource<DefaultedStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(value, true, null, false));

		public static DataSource<DefaultedStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this DefaultedStateValidator<short> defaultedValidator, short value)
			=> new DataSource<DefaultedStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(null, false, value, false));

		public static DataSource<DefaultedStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this DefaultedStateValidator<short> defaultedValidator, short value)
			=> new DataSource<DefaultedStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(null, false, value, true));

		public static DataSource<DefaultedStateValidator<short>, RangeValidator_Int16, short> InRange(this DefaultedStateValidator<short> defaultedValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<DefaultedStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this DefaultedStateValidator<ushort> defaultedValidator, ushort value)
			=> new DataSource<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(value, false, null, false));

		public static DataSource<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this DefaultedStateValidator<ushort> defaultedValidator, ushort value)
			=> new DataSource<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(value, true, null, false));

		public static DataSource<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this DefaultedStateValidator<ushort> defaultedValidator, ushort value)
			=> new DataSource<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(null, false, value, false));

		public static DataSource<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this DefaultedStateValidator<ushort> defaultedValidator, ushort value)
			=> new DataSource<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(null, false, value, true));

		public static DataSource<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this DefaultedStateValidator<ushort> defaultedValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<DefaultedStateValidator<int>, RangeValidator_Int32, int> LessThan(this DefaultedStateValidator<int> defaultedValidator, int value)
			=> new DataSource<DefaultedStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(value, false, null, false));

		public static DataSource<DefaultedStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this DefaultedStateValidator<int> defaultedValidator, int value)
			=> new DataSource<DefaultedStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(value, true, null, false));

		public static DataSource<DefaultedStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this DefaultedStateValidator<int> defaultedValidator, int value)
			=> new DataSource<DefaultedStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(null, false, value, false));

		public static DataSource<DefaultedStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this DefaultedStateValidator<int> defaultedValidator, int value)
			=> new DataSource<DefaultedStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(null, false, value, true));

		public static DataSource<DefaultedStateValidator<int>, RangeValidator_Int32, int> InRange(this DefaultedStateValidator<int> defaultedValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<DefaultedStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this DefaultedStateValidator<uint> defaultedValidator, uint value)
			=> new DataSource<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(value, false, null, false));

		public static DataSource<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this DefaultedStateValidator<uint> defaultedValidator, uint value)
			=> new DataSource<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(value, true, null, false));

		public static DataSource<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this DefaultedStateValidator<uint> defaultedValidator, uint value)
			=> new DataSource<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(null, false, value, false));

		public static DataSource<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this DefaultedStateValidator<uint> defaultedValidator, uint value)
			=> new DataSource<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(null, false, value, true));

		public static DataSource<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this DefaultedStateValidator<uint> defaultedValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<DefaultedStateValidator<long>, RangeValidator_Int64, long> LessThan(this DefaultedStateValidator<long> defaultedValidator, long value)
			=> new DataSource<DefaultedStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(value, false, null, false));

		public static DataSource<DefaultedStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this DefaultedStateValidator<long> defaultedValidator, long value)
			=> new DataSource<DefaultedStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(value, true, null, false));

		public static DataSource<DefaultedStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this DefaultedStateValidator<long> defaultedValidator, long value)
			=> new DataSource<DefaultedStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(null, false, value, false));

		public static DataSource<DefaultedStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this DefaultedStateValidator<long> defaultedValidator, long value)
			=> new DataSource<DefaultedStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(null, false, value, true));

		public static DataSource<DefaultedStateValidator<long>, RangeValidator_Int64, long> InRange(this DefaultedStateValidator<long> defaultedValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<DefaultedStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this DefaultedStateValidator<ulong> defaultedValidator, ulong value)
			=> new DataSource<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(value, false, null, false));

		public static DataSource<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this DefaultedStateValidator<ulong> defaultedValidator, ulong value)
			=> new DataSource<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(value, true, null, false));

		public static DataSource<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this DefaultedStateValidator<ulong> defaultedValidator, ulong value)
			=> new DataSource<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(null, false, value, false));

		public static DataSource<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this DefaultedStateValidator<ulong> defaultedValidator, ulong value)
			=> new DataSource<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(null, false, value, true));

		public static DataSource<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this DefaultedStateValidator<ulong> defaultedValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<DefaultedStateValidator<float>, RangeValidator_Single, float> LessThan(this DefaultedStateValidator<float> defaultedValidator, float value)
			=> new DataSource<DefaultedStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(value, false, null, false));

		public static DataSource<DefaultedStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this DefaultedStateValidator<float> defaultedValidator, float value)
			=> new DataSource<DefaultedStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(value, true, null, false));

		public static DataSource<DefaultedStateValidator<float>, RangeValidator_Single, float> GreaterThan(this DefaultedStateValidator<float> defaultedValidator, float value)
			=> new DataSource<DefaultedStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(null, false, value, false));

		public static DataSource<DefaultedStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this DefaultedStateValidator<float> defaultedValidator, float value)
			=> new DataSource<DefaultedStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(null, false, value, true));

		public static DataSource<DefaultedStateValidator<float>, RangeValidator_Single, float> InRange(this DefaultedStateValidator<float> defaultedValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<DefaultedStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<DefaultedStateValidator<double>, RangeValidator_Double, double> LessThan(this DefaultedStateValidator<double> defaultedValidator, double value)
			=> new DataSource<DefaultedStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(value, false, null, false));

		public static DataSource<DefaultedStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this DefaultedStateValidator<double> defaultedValidator, double value)
			=> new DataSource<DefaultedStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(value, true, null, false));

		public static DataSource<DefaultedStateValidator<double>, RangeValidator_Double, double> GreaterThan(this DefaultedStateValidator<double> defaultedValidator, double value)
			=> new DataSource<DefaultedStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(null, false, value, false));

		public static DataSource<DefaultedStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this DefaultedStateValidator<double> defaultedValidator, double value)
			=> new DataSource<DefaultedStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(null, false, value, true));

		public static DataSource<DefaultedStateValidator<double>, RangeValidator_Double, double> InRange(this DefaultedStateValidator<double> defaultedValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<DefaultedStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this DefaultedStateValidator<decimal> defaultedValidator, decimal value)
			=> new DataSource<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(value, false, null, false));

		public static DataSource<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this DefaultedStateValidator<decimal> defaultedValidator, decimal value)
			=> new DataSource<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(value, true, null, false));

		public static DataSource<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this DefaultedStateValidator<decimal> defaultedValidator, decimal value)
			=> new DataSource<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(null, false, value, false));

		public static DataSource<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this DefaultedStateValidator<decimal> defaultedValidator, decimal value)
			=> new DataSource<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(null, false, value, true));

		public static DataSource<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this DefaultedStateValidator<decimal> defaultedValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}
	}
}