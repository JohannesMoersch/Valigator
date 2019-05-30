using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredStateValidatorExtensions
	{
		public static DataSource<RequiredStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new DataSource<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(value, false, null, false));

		public static DataSource<RequiredStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new DataSource<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(value, true, null, false));

		public static DataSource<RequiredStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new DataSource<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(null, false, value, false));

		public static DataSource<RequiredStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new DataSource<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(null, false, value, true));

		public static DataSource<RequiredStateValidator<byte>, RangeValidator_Byte, byte> InRange(this RequiredStateValidator<byte> requiredValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this RequiredStateValidator<sbyte> requiredValidator, sbyte value)
			=> new DataSource<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(value, false, null, false));

		public static DataSource<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this RequiredStateValidator<sbyte> requiredValidator, sbyte value)
			=> new DataSource<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(value, true, null, false));

		public static DataSource<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this RequiredStateValidator<sbyte> requiredValidator, sbyte value)
			=> new DataSource<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(null, false, value, false));

		public static DataSource<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this RequiredStateValidator<sbyte> requiredValidator, sbyte value)
			=> new DataSource<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(null, false, value, true));

		public static DataSource<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this RequiredStateValidator<sbyte> requiredValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<RequiredStateValidator<short>, RangeValidator_Int16, short> LessThan(this RequiredStateValidator<short> requiredValidator, short value)
			=> new DataSource<RequiredStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(value, false, null, false));

		public static DataSource<RequiredStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this RequiredStateValidator<short> requiredValidator, short value)
			=> new DataSource<RequiredStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(value, true, null, false));

		public static DataSource<RequiredStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this RequiredStateValidator<short> requiredValidator, short value)
			=> new DataSource<RequiredStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(null, false, value, false));

		public static DataSource<RequiredStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this RequiredStateValidator<short> requiredValidator, short value)
			=> new DataSource<RequiredStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(null, false, value, true));

		public static DataSource<RequiredStateValidator<short>, RangeValidator_Int16, short> InRange(this RequiredStateValidator<short> requiredValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<RequiredStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this RequiredStateValidator<ushort> requiredValidator, ushort value)
			=> new DataSource<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(value, false, null, false));

		public static DataSource<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this RequiredStateValidator<ushort> requiredValidator, ushort value)
			=> new DataSource<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(value, true, null, false));

		public static DataSource<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this RequiredStateValidator<ushort> requiredValidator, ushort value)
			=> new DataSource<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(null, false, value, false));

		public static DataSource<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this RequiredStateValidator<ushort> requiredValidator, ushort value)
			=> new DataSource<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(null, false, value, true));

		public static DataSource<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this RequiredStateValidator<ushort> requiredValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<RequiredStateValidator<int>, RangeValidator_Int32, int> LessThan(this RequiredStateValidator<int> requiredValidator, int value)
			=> new DataSource<RequiredStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(value, false, null, false));

		public static DataSource<RequiredStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this RequiredStateValidator<int> requiredValidator, int value)
			=> new DataSource<RequiredStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(value, true, null, false));

		public static DataSource<RequiredStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this RequiredStateValidator<int> requiredValidator, int value)
			=> new DataSource<RequiredStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(null, false, value, false));

		public static DataSource<RequiredStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this RequiredStateValidator<int> requiredValidator, int value)
			=> new DataSource<RequiredStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(null, false, value, true));

		public static DataSource<RequiredStateValidator<int>, RangeValidator_Int32, int> InRange(this RequiredStateValidator<int> requiredValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<RequiredStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this RequiredStateValidator<uint> requiredValidator, uint value)
			=> new DataSource<RequiredStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(value, false, null, false));

		public static DataSource<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this RequiredStateValidator<uint> requiredValidator, uint value)
			=> new DataSource<RequiredStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(value, true, null, false));

		public static DataSource<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this RequiredStateValidator<uint> requiredValidator, uint value)
			=> new DataSource<RequiredStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(null, false, value, false));

		public static DataSource<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this RequiredStateValidator<uint> requiredValidator, uint value)
			=> new DataSource<RequiredStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(null, false, value, true));

		public static DataSource<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this RequiredStateValidator<uint> requiredValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<RequiredStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<RequiredStateValidator<long>, RangeValidator_Int64, long> LessThan(this RequiredStateValidator<long> requiredValidator, long value)
			=> new DataSource<RequiredStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(value, false, null, false));

		public static DataSource<RequiredStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this RequiredStateValidator<long> requiredValidator, long value)
			=> new DataSource<RequiredStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(value, true, null, false));

		public static DataSource<RequiredStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this RequiredStateValidator<long> requiredValidator, long value)
			=> new DataSource<RequiredStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(null, false, value, false));

		public static DataSource<RequiredStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this RequiredStateValidator<long> requiredValidator, long value)
			=> new DataSource<RequiredStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(null, false, value, true));

		public static DataSource<RequiredStateValidator<long>, RangeValidator_Int64, long> InRange(this RequiredStateValidator<long> requiredValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<RequiredStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this RequiredStateValidator<ulong> requiredValidator, ulong value)
			=> new DataSource<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(value, false, null, false));

		public static DataSource<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this RequiredStateValidator<ulong> requiredValidator, ulong value)
			=> new DataSource<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(value, true, null, false));

		public static DataSource<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this RequiredStateValidator<ulong> requiredValidator, ulong value)
			=> new DataSource<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(null, false, value, false));

		public static DataSource<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this RequiredStateValidator<ulong> requiredValidator, ulong value)
			=> new DataSource<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(null, false, value, true));

		public static DataSource<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this RequiredStateValidator<ulong> requiredValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<RequiredStateValidator<float>, RangeValidator_Single, float> LessThan(this RequiredStateValidator<float> requiredValidator, float value)
			=> new DataSource<RequiredStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(value, false, null, false));

		public static DataSource<RequiredStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this RequiredStateValidator<float> requiredValidator, float value)
			=> new DataSource<RequiredStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(value, true, null, false));

		public static DataSource<RequiredStateValidator<float>, RangeValidator_Single, float> GreaterThan(this RequiredStateValidator<float> requiredValidator, float value)
			=> new DataSource<RequiredStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(null, false, value, false));

		public static DataSource<RequiredStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this RequiredStateValidator<float> requiredValidator, float value)
			=> new DataSource<RequiredStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(null, false, value, true));

		public static DataSource<RequiredStateValidator<float>, RangeValidator_Single, float> InRange(this RequiredStateValidator<float> requiredValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<RequiredStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<RequiredStateValidator<double>, RangeValidator_Double, double> LessThan(this RequiredStateValidator<double> requiredValidator, double value)
			=> new DataSource<RequiredStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(value, false, null, false));

		public static DataSource<RequiredStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this RequiredStateValidator<double> requiredValidator, double value)
			=> new DataSource<RequiredStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(value, true, null, false));

		public static DataSource<RequiredStateValidator<double>, RangeValidator_Double, double> GreaterThan(this RequiredStateValidator<double> requiredValidator, double value)
			=> new DataSource<RequiredStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(null, false, value, false));

		public static DataSource<RequiredStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this RequiredStateValidator<double> requiredValidator, double value)
			=> new DataSource<RequiredStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(null, false, value, true));

		public static DataSource<RequiredStateValidator<double>, RangeValidator_Double, double> InRange(this RequiredStateValidator<double> requiredValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<RequiredStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSource<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this RequiredStateValidator<decimal> requiredValidator, decimal value)
			=> new DataSource<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(value, false, null, false));

		public static DataSource<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this RequiredStateValidator<decimal> requiredValidator, decimal value)
			=> new DataSource<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(value, true, null, false));

		public static DataSource<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this RequiredStateValidator<decimal> requiredValidator, decimal value)
			=> new DataSource<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(null, false, value, false));

		public static DataSource<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this RequiredStateValidator<decimal> requiredValidator, decimal value)
			=> new DataSource<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(null, false, value, true));

		public static DataSource<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this RequiredStateValidator<decimal> requiredValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSource<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}
	}
}
