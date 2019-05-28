using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredStateValidatorExtensions
	{
		public static RangeValidator_Byte<RequiredStateValidator<byte>> LessThan(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new RangeValidator_Byte<RequiredStateValidator<byte>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Byte<RequiredStateValidator<byte>> LessThanOrEqualTo(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new RangeValidator_Byte<RequiredStateValidator<byte>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Byte<RequiredStateValidator<byte>> GreaterThan(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new RangeValidator_Byte<RequiredStateValidator<byte>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Byte<RequiredStateValidator<byte>> GreaterThanOrEqualTo(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new RangeValidator_Byte<RequiredStateValidator<byte>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Byte<RequiredStateValidator<byte>> InRange(this RequiredStateValidator<byte> requiredValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_Byte<RequiredStateValidator<byte>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_SByte<RequiredStateValidator<sbyte>> LessThan(this RequiredStateValidator<sbyte> requiredValidator, sbyte value)
			=> new RangeValidator_SByte<RequiredStateValidator<sbyte>>(requiredValidator, value, false, null, false);

		public static RangeValidator_SByte<RequiredStateValidator<sbyte>> LessThanOrEqualTo(this RequiredStateValidator<sbyte> requiredValidator, sbyte value)
			=> new RangeValidator_SByte<RequiredStateValidator<sbyte>>(requiredValidator, value, true, null, false);

		public static RangeValidator_SByte<RequiredStateValidator<sbyte>> GreaterThan(this RequiredStateValidator<sbyte> requiredValidator, sbyte value)
			=> new RangeValidator_SByte<RequiredStateValidator<sbyte>>(requiredValidator, null, false, value, false);

		public static RangeValidator_SByte<RequiredStateValidator<sbyte>> GreaterThanOrEqualTo(this RequiredStateValidator<sbyte> requiredValidator, sbyte value)
			=> new RangeValidator_SByte<RequiredStateValidator<sbyte>>(requiredValidator, null, false, value, true);

		public static RangeValidator_SByte<RequiredStateValidator<sbyte>> InRange(this RequiredStateValidator<sbyte> requiredValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_SByte<RequiredStateValidator<sbyte>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Int16<RequiredStateValidator<short>> LessThan(this RequiredStateValidator<short> requiredValidator, short value)
			=> new RangeValidator_Int16<RequiredStateValidator<short>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Int16<RequiredStateValidator<short>> LessThanOrEqualTo(this RequiredStateValidator<short> requiredValidator, short value)
			=> new RangeValidator_Int16<RequiredStateValidator<short>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Int16<RequiredStateValidator<short>> GreaterThan(this RequiredStateValidator<short> requiredValidator, short value)
			=> new RangeValidator_Int16<RequiredStateValidator<short>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Int16<RequiredStateValidator<short>> GreaterThanOrEqualTo(this RequiredStateValidator<short> requiredValidator, short value)
			=> new RangeValidator_Int16<RequiredStateValidator<short>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Int16<RequiredStateValidator<short>> InRange(this RequiredStateValidator<short> requiredValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_Int16<RequiredStateValidator<short>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_UInt16<RequiredStateValidator<ushort>> LessThan(this RequiredStateValidator<ushort> requiredValidator, ushort value)
			=> new RangeValidator_UInt16<RequiredStateValidator<ushort>>(requiredValidator, value, false, null, false);

		public static RangeValidator_UInt16<RequiredStateValidator<ushort>> LessThanOrEqualTo(this RequiredStateValidator<ushort> requiredValidator, ushort value)
			=> new RangeValidator_UInt16<RequiredStateValidator<ushort>>(requiredValidator, value, true, null, false);

		public static RangeValidator_UInt16<RequiredStateValidator<ushort>> GreaterThan(this RequiredStateValidator<ushort> requiredValidator, ushort value)
			=> new RangeValidator_UInt16<RequiredStateValidator<ushort>>(requiredValidator, null, false, value, false);

		public static RangeValidator_UInt16<RequiredStateValidator<ushort>> GreaterThanOrEqualTo(this RequiredStateValidator<ushort> requiredValidator, ushort value)
			=> new RangeValidator_UInt16<RequiredStateValidator<ushort>>(requiredValidator, null, false, value, true);

		public static RangeValidator_UInt16<RequiredStateValidator<ushort>> InRange(this RequiredStateValidator<ushort> requiredValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_UInt16<RequiredStateValidator<ushort>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Int32<RequiredStateValidator<int>> LessThan(this RequiredStateValidator<int> requiredValidator, int value)
			=> new RangeValidator_Int32<RequiredStateValidator<int>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Int32<RequiredStateValidator<int>> LessThanOrEqualTo(this RequiredStateValidator<int> requiredValidator, int value)
			=> new RangeValidator_Int32<RequiredStateValidator<int>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Int32<RequiredStateValidator<int>> GreaterThan(this RequiredStateValidator<int> requiredValidator, int value)
			=> new RangeValidator_Int32<RequiredStateValidator<int>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Int32<RequiredStateValidator<int>> GreaterThanOrEqualTo(this RequiredStateValidator<int> requiredValidator, int value)
			=> new RangeValidator_Int32<RequiredStateValidator<int>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Int32<RequiredStateValidator<int>> InRange(this RequiredStateValidator<int> requiredValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_Int32<RequiredStateValidator<int>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_UInt32<RequiredStateValidator<uint>> LessThan(this RequiredStateValidator<uint> requiredValidator, uint value)
			=> new RangeValidator_UInt32<RequiredStateValidator<uint>>(requiredValidator, value, false, null, false);

		public static RangeValidator_UInt32<RequiredStateValidator<uint>> LessThanOrEqualTo(this RequiredStateValidator<uint> requiredValidator, uint value)
			=> new RangeValidator_UInt32<RequiredStateValidator<uint>>(requiredValidator, value, true, null, false);

		public static RangeValidator_UInt32<RequiredStateValidator<uint>> GreaterThan(this RequiredStateValidator<uint> requiredValidator, uint value)
			=> new RangeValidator_UInt32<RequiredStateValidator<uint>>(requiredValidator, null, false, value, false);

		public static RangeValidator_UInt32<RequiredStateValidator<uint>> GreaterThanOrEqualTo(this RequiredStateValidator<uint> requiredValidator, uint value)
			=> new RangeValidator_UInt32<RequiredStateValidator<uint>>(requiredValidator, null, false, value, true);

		public static RangeValidator_UInt32<RequiredStateValidator<uint>> InRange(this RequiredStateValidator<uint> requiredValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_UInt32<RequiredStateValidator<uint>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Int64<RequiredStateValidator<long>> LessThan(this RequiredStateValidator<long> requiredValidator, long value)
			=> new RangeValidator_Int64<RequiredStateValidator<long>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Int64<RequiredStateValidator<long>> LessThanOrEqualTo(this RequiredStateValidator<long> requiredValidator, long value)
			=> new RangeValidator_Int64<RequiredStateValidator<long>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Int64<RequiredStateValidator<long>> GreaterThan(this RequiredStateValidator<long> requiredValidator, long value)
			=> new RangeValidator_Int64<RequiredStateValidator<long>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Int64<RequiredStateValidator<long>> GreaterThanOrEqualTo(this RequiredStateValidator<long> requiredValidator, long value)
			=> new RangeValidator_Int64<RequiredStateValidator<long>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Int64<RequiredStateValidator<long>> InRange(this RequiredStateValidator<long> requiredValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_Int64<RequiredStateValidator<long>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_UInt64<RequiredStateValidator<ulong>> LessThan(this RequiredStateValidator<ulong> requiredValidator, ulong value)
			=> new RangeValidator_UInt64<RequiredStateValidator<ulong>>(requiredValidator, value, false, null, false);

		public static RangeValidator_UInt64<RequiredStateValidator<ulong>> LessThanOrEqualTo(this RequiredStateValidator<ulong> requiredValidator, ulong value)
			=> new RangeValidator_UInt64<RequiredStateValidator<ulong>>(requiredValidator, value, true, null, false);

		public static RangeValidator_UInt64<RequiredStateValidator<ulong>> GreaterThan(this RequiredStateValidator<ulong> requiredValidator, ulong value)
			=> new RangeValidator_UInt64<RequiredStateValidator<ulong>>(requiredValidator, null, false, value, false);

		public static RangeValidator_UInt64<RequiredStateValidator<ulong>> GreaterThanOrEqualTo(this RequiredStateValidator<ulong> requiredValidator, ulong value)
			=> new RangeValidator_UInt64<RequiredStateValidator<ulong>>(requiredValidator, null, false, value, true);

		public static RangeValidator_UInt64<RequiredStateValidator<ulong>> InRange(this RequiredStateValidator<ulong> requiredValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_UInt64<RequiredStateValidator<ulong>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Single<RequiredStateValidator<float>> LessThan(this RequiredStateValidator<float> requiredValidator, float value)
			=> new RangeValidator_Single<RequiredStateValidator<float>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Single<RequiredStateValidator<float>> LessThanOrEqualTo(this RequiredStateValidator<float> requiredValidator, float value)
			=> new RangeValidator_Single<RequiredStateValidator<float>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Single<RequiredStateValidator<float>> GreaterThan(this RequiredStateValidator<float> requiredValidator, float value)
			=> new RangeValidator_Single<RequiredStateValidator<float>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Single<RequiredStateValidator<float>> GreaterThanOrEqualTo(this RequiredStateValidator<float> requiredValidator, float value)
			=> new RangeValidator_Single<RequiredStateValidator<float>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Single<RequiredStateValidator<float>> InRange(this RequiredStateValidator<float> requiredValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_Single<RequiredStateValidator<float>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Double<RequiredStateValidator<double>> LessThan(this RequiredStateValidator<double> requiredValidator, double value)
			=> new RangeValidator_Double<RequiredStateValidator<double>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Double<RequiredStateValidator<double>> LessThanOrEqualTo(this RequiredStateValidator<double> requiredValidator, double value)
			=> new RangeValidator_Double<RequiredStateValidator<double>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Double<RequiredStateValidator<double>> GreaterThan(this RequiredStateValidator<double> requiredValidator, double value)
			=> new RangeValidator_Double<RequiredStateValidator<double>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Double<RequiredStateValidator<double>> GreaterThanOrEqualTo(this RequiredStateValidator<double> requiredValidator, double value)
			=> new RangeValidator_Double<RequiredStateValidator<double>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Double<RequiredStateValidator<double>> InRange(this RequiredStateValidator<double> requiredValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_Double<RequiredStateValidator<double>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Decimal<RequiredStateValidator<decimal>> LessThan(this RequiredStateValidator<decimal> requiredValidator, decimal value)
			=> new RangeValidator_Decimal<RequiredStateValidator<decimal>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Decimal<RequiredStateValidator<decimal>> LessThanOrEqualTo(this RequiredStateValidator<decimal> requiredValidator, decimal value)
			=> new RangeValidator_Decimal<RequiredStateValidator<decimal>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Decimal<RequiredStateValidator<decimal>> GreaterThan(this RequiredStateValidator<decimal> requiredValidator, decimal value)
			=> new RangeValidator_Decimal<RequiredStateValidator<decimal>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Decimal<RequiredStateValidator<decimal>> GreaterThanOrEqualTo(this RequiredStateValidator<decimal> requiredValidator, decimal value)
			=> new RangeValidator_Decimal<RequiredStateValidator<decimal>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Decimal<RequiredStateValidator<decimal>> InRange(this RequiredStateValidator<decimal> requiredValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_Decimal<RequiredStateValidator<decimal>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}
	}
}
