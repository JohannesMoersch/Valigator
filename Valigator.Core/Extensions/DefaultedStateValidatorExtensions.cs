using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedStateValidatorExtensions
	{
		public static RangeValidator_Byte<DefaultedStateValidator<byte>> LessThan(this DefaultedStateValidator<byte> requiredValidator, byte value)
			=> new RangeValidator_Byte<DefaultedStateValidator<byte>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Byte<DefaultedStateValidator<byte>> LessThanOrEqualTo(this DefaultedStateValidator<byte> requiredValidator, byte value)
			=> new RangeValidator_Byte<DefaultedStateValidator<byte>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Byte<DefaultedStateValidator<byte>> GreaterThan(this DefaultedStateValidator<byte> requiredValidator, byte value)
			=> new RangeValidator_Byte<DefaultedStateValidator<byte>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Byte<DefaultedStateValidator<byte>> GreaterThanOrEqualTo(this DefaultedStateValidator<byte> requiredValidator, byte value)
			=> new RangeValidator_Byte<DefaultedStateValidator<byte>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Byte<DefaultedStateValidator<byte>> InRange(this DefaultedStateValidator<byte> requiredValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_Byte<DefaultedStateValidator<byte>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_SByte<DefaultedStateValidator<sbyte>> LessThan(this DefaultedStateValidator<sbyte> requiredValidator, sbyte value)
			=> new RangeValidator_SByte<DefaultedStateValidator<sbyte>>(requiredValidator, value, false, null, false);

		public static RangeValidator_SByte<DefaultedStateValidator<sbyte>> LessThanOrEqualTo(this DefaultedStateValidator<sbyte> requiredValidator, sbyte value)
			=> new RangeValidator_SByte<DefaultedStateValidator<sbyte>>(requiredValidator, value, true, null, false);

		public static RangeValidator_SByte<DefaultedStateValidator<sbyte>> GreaterThan(this DefaultedStateValidator<sbyte> requiredValidator, sbyte value)
			=> new RangeValidator_SByte<DefaultedStateValidator<sbyte>>(requiredValidator, null, false, value, false);

		public static RangeValidator_SByte<DefaultedStateValidator<sbyte>> GreaterThanOrEqualTo(this DefaultedStateValidator<sbyte> requiredValidator, sbyte value)
			=> new RangeValidator_SByte<DefaultedStateValidator<sbyte>>(requiredValidator, null, false, value, true);

		public static RangeValidator_SByte<DefaultedStateValidator<sbyte>> InRange(this DefaultedStateValidator<sbyte> requiredValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_SByte<DefaultedStateValidator<sbyte>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Int16<DefaultedStateValidator<short>> LessThan(this DefaultedStateValidator<short> requiredValidator, short value)
			=> new RangeValidator_Int16<DefaultedStateValidator<short>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Int16<DefaultedStateValidator<short>> LessThanOrEqualTo(this DefaultedStateValidator<short> requiredValidator, short value)
			=> new RangeValidator_Int16<DefaultedStateValidator<short>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Int16<DefaultedStateValidator<short>> GreaterThan(this DefaultedStateValidator<short> requiredValidator, short value)
			=> new RangeValidator_Int16<DefaultedStateValidator<short>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Int16<DefaultedStateValidator<short>> GreaterThanOrEqualTo(this DefaultedStateValidator<short> requiredValidator, short value)
			=> new RangeValidator_Int16<DefaultedStateValidator<short>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Int16<DefaultedStateValidator<short>> InRange(this DefaultedStateValidator<short> requiredValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_Int16<DefaultedStateValidator<short>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_UInt16<DefaultedStateValidator<ushort>> LessThan(this DefaultedStateValidator<ushort> requiredValidator, ushort value)
			=> new RangeValidator_UInt16<DefaultedStateValidator<ushort>>(requiredValidator, value, false, null, false);

		public static RangeValidator_UInt16<DefaultedStateValidator<ushort>> LessThanOrEqualTo(this DefaultedStateValidator<ushort> requiredValidator, ushort value)
			=> new RangeValidator_UInt16<DefaultedStateValidator<ushort>>(requiredValidator, value, true, null, false);

		public static RangeValidator_UInt16<DefaultedStateValidator<ushort>> GreaterThan(this DefaultedStateValidator<ushort> requiredValidator, ushort value)
			=> new RangeValidator_UInt16<DefaultedStateValidator<ushort>>(requiredValidator, null, false, value, false);

		public static RangeValidator_UInt16<DefaultedStateValidator<ushort>> GreaterThanOrEqualTo(this DefaultedStateValidator<ushort> requiredValidator, ushort value)
			=> new RangeValidator_UInt16<DefaultedStateValidator<ushort>>(requiredValidator, null, false, value, true);

		public static RangeValidator_UInt16<DefaultedStateValidator<ushort>> InRange(this DefaultedStateValidator<ushort> requiredValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_UInt16<DefaultedStateValidator<ushort>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Int32<DefaultedStateValidator<int>> LessThan(this DefaultedStateValidator<int> requiredValidator, int value)
			=> new RangeValidator_Int32<DefaultedStateValidator<int>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Int32<DefaultedStateValidator<int>> LessThanOrEqualTo(this DefaultedStateValidator<int> requiredValidator, int value)
			=> new RangeValidator_Int32<DefaultedStateValidator<int>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Int32<DefaultedStateValidator<int>> GreaterThan(this DefaultedStateValidator<int> requiredValidator, int value)
			=> new RangeValidator_Int32<DefaultedStateValidator<int>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Int32<DefaultedStateValidator<int>> GreaterThanOrEqualTo(this DefaultedStateValidator<int> requiredValidator, int value)
			=> new RangeValidator_Int32<DefaultedStateValidator<int>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Int32<DefaultedStateValidator<int>> InRange(this DefaultedStateValidator<int> requiredValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_Int32<DefaultedStateValidator<int>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_UInt32<DefaultedStateValidator<uint>> LessThan(this DefaultedStateValidator<uint> requiredValidator, uint value)
			=> new RangeValidator_UInt32<DefaultedStateValidator<uint>>(requiredValidator, value, false, null, false);

		public static RangeValidator_UInt32<DefaultedStateValidator<uint>> LessThanOrEqualTo(this DefaultedStateValidator<uint> requiredValidator, uint value)
			=> new RangeValidator_UInt32<DefaultedStateValidator<uint>>(requiredValidator, value, true, null, false);

		public static RangeValidator_UInt32<DefaultedStateValidator<uint>> GreaterThan(this DefaultedStateValidator<uint> requiredValidator, uint value)
			=> new RangeValidator_UInt32<DefaultedStateValidator<uint>>(requiredValidator, null, false, value, false);

		public static RangeValidator_UInt32<DefaultedStateValidator<uint>> GreaterThanOrEqualTo(this DefaultedStateValidator<uint> requiredValidator, uint value)
			=> new RangeValidator_UInt32<DefaultedStateValidator<uint>>(requiredValidator, null, false, value, true);

		public static RangeValidator_UInt32<DefaultedStateValidator<uint>> InRange(this DefaultedStateValidator<uint> requiredValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_UInt32<DefaultedStateValidator<uint>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Int64<DefaultedStateValidator<long>> LessThan(this DefaultedStateValidator<long> requiredValidator, long value)
			=> new RangeValidator_Int64<DefaultedStateValidator<long>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Int64<DefaultedStateValidator<long>> LessThanOrEqualTo(this DefaultedStateValidator<long> requiredValidator, long value)
			=> new RangeValidator_Int64<DefaultedStateValidator<long>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Int64<DefaultedStateValidator<long>> GreaterThan(this DefaultedStateValidator<long> requiredValidator, long value)
			=> new RangeValidator_Int64<DefaultedStateValidator<long>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Int64<DefaultedStateValidator<long>> GreaterThanOrEqualTo(this DefaultedStateValidator<long> requiredValidator, long value)
			=> new RangeValidator_Int64<DefaultedStateValidator<long>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Int64<DefaultedStateValidator<long>> InRange(this DefaultedStateValidator<long> requiredValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_Int64<DefaultedStateValidator<long>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_UInt64<DefaultedStateValidator<ulong>> LessThan(this DefaultedStateValidator<ulong> requiredValidator, ulong value)
			=> new RangeValidator_UInt64<DefaultedStateValidator<ulong>>(requiredValidator, value, false, null, false);

		public static RangeValidator_UInt64<DefaultedStateValidator<ulong>> LessThanOrEqualTo(this DefaultedStateValidator<ulong> requiredValidator, ulong value)
			=> new RangeValidator_UInt64<DefaultedStateValidator<ulong>>(requiredValidator, value, true, null, false);

		public static RangeValidator_UInt64<DefaultedStateValidator<ulong>> GreaterThan(this DefaultedStateValidator<ulong> requiredValidator, ulong value)
			=> new RangeValidator_UInt64<DefaultedStateValidator<ulong>>(requiredValidator, null, false, value, false);

		public static RangeValidator_UInt64<DefaultedStateValidator<ulong>> GreaterThanOrEqualTo(this DefaultedStateValidator<ulong> requiredValidator, ulong value)
			=> new RangeValidator_UInt64<DefaultedStateValidator<ulong>>(requiredValidator, null, false, value, true);

		public static RangeValidator_UInt64<DefaultedStateValidator<ulong>> InRange(this DefaultedStateValidator<ulong> requiredValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_UInt64<DefaultedStateValidator<ulong>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Single<DefaultedStateValidator<float>> LessThan(this DefaultedStateValidator<float> requiredValidator, float value)
			=> new RangeValidator_Single<DefaultedStateValidator<float>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Single<DefaultedStateValidator<float>> LessThanOrEqualTo(this DefaultedStateValidator<float> requiredValidator, float value)
			=> new RangeValidator_Single<DefaultedStateValidator<float>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Single<DefaultedStateValidator<float>> GreaterThan(this DefaultedStateValidator<float> requiredValidator, float value)
			=> new RangeValidator_Single<DefaultedStateValidator<float>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Single<DefaultedStateValidator<float>> GreaterThanOrEqualTo(this DefaultedStateValidator<float> requiredValidator, float value)
			=> new RangeValidator_Single<DefaultedStateValidator<float>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Single<DefaultedStateValidator<float>> InRange(this DefaultedStateValidator<float> requiredValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_Single<DefaultedStateValidator<float>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Double<DefaultedStateValidator<double>> LessThan(this DefaultedStateValidator<double> requiredValidator, double value)
			=> new RangeValidator_Double<DefaultedStateValidator<double>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Double<DefaultedStateValidator<double>> LessThanOrEqualTo(this DefaultedStateValidator<double> requiredValidator, double value)
			=> new RangeValidator_Double<DefaultedStateValidator<double>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Double<DefaultedStateValidator<double>> GreaterThan(this DefaultedStateValidator<double> requiredValidator, double value)
			=> new RangeValidator_Double<DefaultedStateValidator<double>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Double<DefaultedStateValidator<double>> GreaterThanOrEqualTo(this DefaultedStateValidator<double> requiredValidator, double value)
			=> new RangeValidator_Double<DefaultedStateValidator<double>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Double<DefaultedStateValidator<double>> InRange(this DefaultedStateValidator<double> requiredValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_Double<DefaultedStateValidator<double>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}

		public static RangeValidator_Decimal<DefaultedStateValidator<decimal>> LessThan(this DefaultedStateValidator<decimal> requiredValidator, decimal value)
			=> new RangeValidator_Decimal<DefaultedStateValidator<decimal>>(requiredValidator, value, false, null, false);

		public static RangeValidator_Decimal<DefaultedStateValidator<decimal>> LessThanOrEqualTo(this DefaultedStateValidator<decimal> requiredValidator, decimal value)
			=> new RangeValidator_Decimal<DefaultedStateValidator<decimal>>(requiredValidator, value, true, null, false);

		public static RangeValidator_Decimal<DefaultedStateValidator<decimal>> GreaterThan(this DefaultedStateValidator<decimal> requiredValidator, decimal value)
			=> new RangeValidator_Decimal<DefaultedStateValidator<decimal>>(requiredValidator, null, false, value, false);

		public static RangeValidator_Decimal<DefaultedStateValidator<decimal>> GreaterThanOrEqualTo(this DefaultedStateValidator<decimal> requiredValidator, decimal value)
			=> new RangeValidator_Decimal<DefaultedStateValidator<decimal>>(requiredValidator, null, false, value, true);

		public static RangeValidator_Decimal<DefaultedStateValidator<decimal>> InRange(this DefaultedStateValidator<decimal> requiredValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) >= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new RangeValidator_Decimal<DefaultedStateValidator<decimal>>(requiredValidator, lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue);
		}
	}
}
