using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalStateValidatorExtensions
	{
		public static NullableDataSource<OptionalStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this OptionalStateValidator<byte> defaultedValidator, byte value)
			=> new NullableDataSource<OptionalStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(value, false, null, false));

		public static NullableDataSource<OptionalStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this OptionalStateValidator<byte> defaultedValidator, byte value)
			=> new NullableDataSource<OptionalStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(value, true, null, false));

		public static NullableDataSource<OptionalStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this OptionalStateValidator<byte> defaultedValidator, byte value)
			=> new NullableDataSource<OptionalStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(null, false, value, false));

		public static NullableDataSource<OptionalStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this OptionalStateValidator<byte> defaultedValidator, byte value)
			=> new NullableDataSource<OptionalStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(null, false, value, true));

		public static NullableDataSource<OptionalStateValidator<byte>, RangeValidator_Byte, byte> InRange(this OptionalStateValidator<byte> defaultedValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this OptionalStateValidator<sbyte> defaultedValidator, sbyte value)
			=> new NullableDataSource<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(value, false, null, false));

		public static NullableDataSource<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this OptionalStateValidator<sbyte> defaultedValidator, sbyte value)
			=> new NullableDataSource<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(value, true, null, false));

		public static NullableDataSource<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this OptionalStateValidator<sbyte> defaultedValidator, sbyte value)
			=> new NullableDataSource<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(null, false, value, false));

		public static NullableDataSource<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this OptionalStateValidator<sbyte> defaultedValidator, sbyte value)
			=> new NullableDataSource<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(null, false, value, true));

		public static NullableDataSource<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this OptionalStateValidator<sbyte> defaultedValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalStateValidator<short>, RangeValidator_Int16, short> LessThan(this OptionalStateValidator<short> defaultedValidator, short value)
			=> new NullableDataSource<OptionalStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(value, false, null, false));

		public static NullableDataSource<OptionalStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this OptionalStateValidator<short> defaultedValidator, short value)
			=> new NullableDataSource<OptionalStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(value, true, null, false));

		public static NullableDataSource<OptionalStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this OptionalStateValidator<short> defaultedValidator, short value)
			=> new NullableDataSource<OptionalStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(null, false, value, false));

		public static NullableDataSource<OptionalStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this OptionalStateValidator<short> defaultedValidator, short value)
			=> new NullableDataSource<OptionalStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(null, false, value, true));

		public static NullableDataSource<OptionalStateValidator<short>, RangeValidator_Int16, short> InRange(this OptionalStateValidator<short> defaultedValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this OptionalStateValidator<ushort> defaultedValidator, ushort value)
			=> new NullableDataSource<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(value, false, null, false));

		public static NullableDataSource<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this OptionalStateValidator<ushort> defaultedValidator, ushort value)
			=> new NullableDataSource<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(value, true, null, false));

		public static NullableDataSource<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this OptionalStateValidator<ushort> defaultedValidator, ushort value)
			=> new NullableDataSource<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(null, false, value, false));

		public static NullableDataSource<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this OptionalStateValidator<ushort> defaultedValidator, ushort value)
			=> new NullableDataSource<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(null, false, value, true));

		public static NullableDataSource<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this OptionalStateValidator<ushort> defaultedValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalStateValidator<int>, RangeValidator_Int32, int> LessThan(this OptionalStateValidator<int> defaultedValidator, int value)
			=> new NullableDataSource<OptionalStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(value, false, null, false));

		public static NullableDataSource<OptionalStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this OptionalStateValidator<int> defaultedValidator, int value)
			=> new NullableDataSource<OptionalStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(value, true, null, false));

		public static NullableDataSource<OptionalStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this OptionalStateValidator<int> defaultedValidator, int value)
			=> new NullableDataSource<OptionalStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(null, false, value, false));

		public static NullableDataSource<OptionalStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this OptionalStateValidator<int> defaultedValidator, int value)
			=> new NullableDataSource<OptionalStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(null, false, value, true));

		public static NullableDataSource<OptionalStateValidator<int>, RangeValidator_Int32, int> InRange(this OptionalStateValidator<int> defaultedValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this OptionalStateValidator<uint> defaultedValidator, uint value)
			=> new NullableDataSource<OptionalStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(value, false, null, false));

		public static NullableDataSource<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this OptionalStateValidator<uint> defaultedValidator, uint value)
			=> new NullableDataSource<OptionalStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(value, true, null, false));

		public static NullableDataSource<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this OptionalStateValidator<uint> defaultedValidator, uint value)
			=> new NullableDataSource<OptionalStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(null, false, value, false));

		public static NullableDataSource<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this OptionalStateValidator<uint> defaultedValidator, uint value)
			=> new NullableDataSource<OptionalStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(null, false, value, true));

		public static NullableDataSource<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this OptionalStateValidator<uint> defaultedValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalStateValidator<long>, RangeValidator_Int64, long> LessThan(this OptionalStateValidator<long> defaultedValidator, long value)
			=> new NullableDataSource<OptionalStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(value, false, null, false));

		public static NullableDataSource<OptionalStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this OptionalStateValidator<long> defaultedValidator, long value)
			=> new NullableDataSource<OptionalStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(value, true, null, false));

		public static NullableDataSource<OptionalStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this OptionalStateValidator<long> defaultedValidator, long value)
			=> new NullableDataSource<OptionalStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(null, false, value, false));

		public static NullableDataSource<OptionalStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this OptionalStateValidator<long> defaultedValidator, long value)
			=> new NullableDataSource<OptionalStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(null, false, value, true));

		public static NullableDataSource<OptionalStateValidator<long>, RangeValidator_Int64, long> InRange(this OptionalStateValidator<long> defaultedValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this OptionalStateValidator<ulong> defaultedValidator, ulong value)
			=> new NullableDataSource<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(value, false, null, false));

		public static NullableDataSource<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this OptionalStateValidator<ulong> defaultedValidator, ulong value)
			=> new NullableDataSource<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(value, true, null, false));

		public static NullableDataSource<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this OptionalStateValidator<ulong> defaultedValidator, ulong value)
			=> new NullableDataSource<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(null, false, value, false));

		public static NullableDataSource<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this OptionalStateValidator<ulong> defaultedValidator, ulong value)
			=> new NullableDataSource<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(null, false, value, true));

		public static NullableDataSource<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this OptionalStateValidator<ulong> defaultedValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalStateValidator<float>, RangeValidator_Single, float> LessThan(this OptionalStateValidator<float> defaultedValidator, float value)
			=> new NullableDataSource<OptionalStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(value, false, null, false));

		public static NullableDataSource<OptionalStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this OptionalStateValidator<float> defaultedValidator, float value)
			=> new NullableDataSource<OptionalStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(value, true, null, false));

		public static NullableDataSource<OptionalStateValidator<float>, RangeValidator_Single, float> GreaterThan(this OptionalStateValidator<float> defaultedValidator, float value)
			=> new NullableDataSource<OptionalStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(null, false, value, false));

		public static NullableDataSource<OptionalStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this OptionalStateValidator<float> defaultedValidator, float value)
			=> new NullableDataSource<OptionalStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(null, false, value, true));

		public static NullableDataSource<OptionalStateValidator<float>, RangeValidator_Single, float> InRange(this OptionalStateValidator<float> defaultedValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalStateValidator<double>, RangeValidator_Double, double> LessThan(this OptionalStateValidator<double> defaultedValidator, double value)
			=> new NullableDataSource<OptionalStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(value, false, null, false));

		public static NullableDataSource<OptionalStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this OptionalStateValidator<double> defaultedValidator, double value)
			=> new NullableDataSource<OptionalStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(value, true, null, false));

		public static NullableDataSource<OptionalStateValidator<double>, RangeValidator_Double, double> GreaterThan(this OptionalStateValidator<double> defaultedValidator, double value)
			=> new NullableDataSource<OptionalStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(null, false, value, false));

		public static NullableDataSource<OptionalStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this OptionalStateValidator<double> defaultedValidator, double value)
			=> new NullableDataSource<OptionalStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(null, false, value, true));

		public static NullableDataSource<OptionalStateValidator<double>, RangeValidator_Double, double> InRange(this OptionalStateValidator<double> defaultedValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this OptionalStateValidator<decimal> defaultedValidator, decimal value)
			=> new NullableDataSource<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(value, false, null, false));

		public static NullableDataSource<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this OptionalStateValidator<decimal> defaultedValidator, decimal value)
			=> new NullableDataSource<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(value, true, null, false));

		public static NullableDataSource<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this OptionalStateValidator<decimal> defaultedValidator, decimal value)
			=> new NullableDataSource<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(null, false, value, false));

		public static NullableDataSource<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this OptionalStateValidator<decimal> defaultedValidator, decimal value)
			=> new NullableDataSource<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(null, false, value, true));

		public static NullableDataSource<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this OptionalStateValidator<decimal> defaultedValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this OptionalStateValidator<DateTime> defaultedValidator, DateTime value)
			=> new NullableDataSource<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(defaultedValidator, new RangeValidator_DateTime(value, false, null, false));

		public static NullableDataSource<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this OptionalStateValidator<DateTime> defaultedValidator, DateTime value)
			=> new NullableDataSource<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(defaultedValidator, new RangeValidator_DateTime(value, true, null, false));

		public static NullableDataSource<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this OptionalStateValidator<DateTime> defaultedValidator, DateTime value)
			=> new NullableDataSource<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(defaultedValidator, new RangeValidator_DateTime(null, false, value, false));

		public static NullableDataSource<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this OptionalStateValidator<DateTime> defaultedValidator, DateTime value)
			=> new NullableDataSource<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(defaultedValidator, new RangeValidator_DateTime(null, false, value, true));

		public static NullableDataSource<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this OptionalStateValidator<DateTime> defaultedValidator, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(defaultedValidator, new RangeValidator_DateTime(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}
	}
}
