using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalNullableStateValidatorExtensions
	{
		public static InvertedNullableDataSource<OptionalNullableStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this OptionalNullableStateValidator<TValue> optionalValidator, Func<OptionalNullableStateValidator<TValue>, NullableDataSource<OptionalNullableStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(optionalValidator).Invert();

		public static NullableDataSource<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this OptionalNullableStateValidator<TValue> optionalValidator, params TValue[] options)
			=> new NullableDataSource<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>(optionalValidator, new InSetValidator<TValue>(options));

		public static NullableDataSource<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this OptionalNullableStateValidator<TValue> optionalValidator, ISet<TValue> options)
			=> new NullableDataSource<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>(optionalValidator, new InSetValidator<TValue>(options));

		public static NullableDataSource<OptionalNullableStateValidator<string>, StringLengthValidator, string> Length(this OptionalNullableStateValidator<string> optionalValidator, int? minimumLength = null, int? maximumLength = null)
			=> new NullableDataSource<OptionalNullableStateValidator<string>, StringLengthValidator, string>(optionalValidator, new StringLengthValidator(minimumLength, maximumLength));

		public static NullableDataSource<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this OptionalNullableStateValidator<byte> optionalValidator, byte value)
			=> new NullableDataSource<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte>(optionalValidator, new RangeValidator_Byte(value, false, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this OptionalNullableStateValidator<byte> optionalValidator, byte value)
			=> new NullableDataSource<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte>(optionalValidator, new RangeValidator_Byte(value, true, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this OptionalNullableStateValidator<byte> optionalValidator, byte value)
			=> new NullableDataSource<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte>(optionalValidator, new RangeValidator_Byte(null, false, value, false));

		public static NullableDataSource<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this OptionalNullableStateValidator<byte> optionalValidator, byte value)
			=> new NullableDataSource<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte>(optionalValidator, new RangeValidator_Byte(null, false, value, true));

		public static NullableDataSource<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> InRange(this OptionalNullableStateValidator<byte> optionalValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte>(optionalValidator, new RangeValidator_Byte(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this OptionalNullableStateValidator<sbyte> optionalValidator, sbyte value)
			=> new NullableDataSource<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(optionalValidator, new RangeValidator_SByte(value, false, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this OptionalNullableStateValidator<sbyte> optionalValidator, sbyte value)
			=> new NullableDataSource<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(optionalValidator, new RangeValidator_SByte(value, true, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this OptionalNullableStateValidator<sbyte> optionalValidator, sbyte value)
			=> new NullableDataSource<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(optionalValidator, new RangeValidator_SByte(null, false, value, false));

		public static NullableDataSource<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this OptionalNullableStateValidator<sbyte> optionalValidator, sbyte value)
			=> new NullableDataSource<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(optionalValidator, new RangeValidator_SByte(null, false, value, true));

		public static NullableDataSource<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this OptionalNullableStateValidator<sbyte> optionalValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(optionalValidator, new RangeValidator_SByte(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> LessThan(this OptionalNullableStateValidator<short> optionalValidator, short value)
			=> new NullableDataSource<OptionalNullableStateValidator<short>, RangeValidator_Int16, short>(optionalValidator, new RangeValidator_Int16(value, false, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this OptionalNullableStateValidator<short> optionalValidator, short value)
			=> new NullableDataSource<OptionalNullableStateValidator<short>, RangeValidator_Int16, short>(optionalValidator, new RangeValidator_Int16(value, true, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this OptionalNullableStateValidator<short> optionalValidator, short value)
			=> new NullableDataSource<OptionalNullableStateValidator<short>, RangeValidator_Int16, short>(optionalValidator, new RangeValidator_Int16(null, false, value, false));

		public static NullableDataSource<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this OptionalNullableStateValidator<short> optionalValidator, short value)
			=> new NullableDataSource<OptionalNullableStateValidator<short>, RangeValidator_Int16, short>(optionalValidator, new RangeValidator_Int16(null, false, value, true));

		public static NullableDataSource<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> InRange(this OptionalNullableStateValidator<short> optionalValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalNullableStateValidator<short>, RangeValidator_Int16, short>(optionalValidator, new RangeValidator_Int16(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this OptionalNullableStateValidator<ushort> optionalValidator, ushort value)
			=> new NullableDataSource<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(optionalValidator, new RangeValidator_UInt16(value, false, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this OptionalNullableStateValidator<ushort> optionalValidator, ushort value)
			=> new NullableDataSource<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(optionalValidator, new RangeValidator_UInt16(value, true, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this OptionalNullableStateValidator<ushort> optionalValidator, ushort value)
			=> new NullableDataSource<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(optionalValidator, new RangeValidator_UInt16(null, false, value, false));

		public static NullableDataSource<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this OptionalNullableStateValidator<ushort> optionalValidator, ushort value)
			=> new NullableDataSource<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(optionalValidator, new RangeValidator_UInt16(null, false, value, true));

		public static NullableDataSource<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this OptionalNullableStateValidator<ushort> optionalValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(optionalValidator, new RangeValidator_UInt16(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> LessThan(this OptionalNullableStateValidator<int> optionalValidator, int value)
			=> new NullableDataSource<OptionalNullableStateValidator<int>, RangeValidator_Int32, int>(optionalValidator, new RangeValidator_Int32(value, false, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this OptionalNullableStateValidator<int> optionalValidator, int value)
			=> new NullableDataSource<OptionalNullableStateValidator<int>, RangeValidator_Int32, int>(optionalValidator, new RangeValidator_Int32(value, true, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this OptionalNullableStateValidator<int> optionalValidator, int value)
			=> new NullableDataSource<OptionalNullableStateValidator<int>, RangeValidator_Int32, int>(optionalValidator, new RangeValidator_Int32(null, false, value, false));

		public static NullableDataSource<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this OptionalNullableStateValidator<int> optionalValidator, int value)
			=> new NullableDataSource<OptionalNullableStateValidator<int>, RangeValidator_Int32, int>(optionalValidator, new RangeValidator_Int32(null, false, value, true));

		public static NullableDataSource<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> InRange(this OptionalNullableStateValidator<int> optionalValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalNullableStateValidator<int>, RangeValidator_Int32, int>(optionalValidator, new RangeValidator_Int32(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this OptionalNullableStateValidator<uint> optionalValidator, uint value)
			=> new NullableDataSource<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint>(optionalValidator, new RangeValidator_UInt32(value, false, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this OptionalNullableStateValidator<uint> optionalValidator, uint value)
			=> new NullableDataSource<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint>(optionalValidator, new RangeValidator_UInt32(value, true, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this OptionalNullableStateValidator<uint> optionalValidator, uint value)
			=> new NullableDataSource<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint>(optionalValidator, new RangeValidator_UInt32(null, false, value, false));

		public static NullableDataSource<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this OptionalNullableStateValidator<uint> optionalValidator, uint value)
			=> new NullableDataSource<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint>(optionalValidator, new RangeValidator_UInt32(null, false, value, true));

		public static NullableDataSource<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this OptionalNullableStateValidator<uint> optionalValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint>(optionalValidator, new RangeValidator_UInt32(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> LessThan(this OptionalNullableStateValidator<long> optionalValidator, long value)
			=> new NullableDataSource<OptionalNullableStateValidator<long>, RangeValidator_Int64, long>(optionalValidator, new RangeValidator_Int64(value, false, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this OptionalNullableStateValidator<long> optionalValidator, long value)
			=> new NullableDataSource<OptionalNullableStateValidator<long>, RangeValidator_Int64, long>(optionalValidator, new RangeValidator_Int64(value, true, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this OptionalNullableStateValidator<long> optionalValidator, long value)
			=> new NullableDataSource<OptionalNullableStateValidator<long>, RangeValidator_Int64, long>(optionalValidator, new RangeValidator_Int64(null, false, value, false));

		public static NullableDataSource<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this OptionalNullableStateValidator<long> optionalValidator, long value)
			=> new NullableDataSource<OptionalNullableStateValidator<long>, RangeValidator_Int64, long>(optionalValidator, new RangeValidator_Int64(null, false, value, true));

		public static NullableDataSource<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> InRange(this OptionalNullableStateValidator<long> optionalValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalNullableStateValidator<long>, RangeValidator_Int64, long>(optionalValidator, new RangeValidator_Int64(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this OptionalNullableStateValidator<ulong> optionalValidator, ulong value)
			=> new NullableDataSource<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(optionalValidator, new RangeValidator_UInt64(value, false, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this OptionalNullableStateValidator<ulong> optionalValidator, ulong value)
			=> new NullableDataSource<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(optionalValidator, new RangeValidator_UInt64(value, true, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this OptionalNullableStateValidator<ulong> optionalValidator, ulong value)
			=> new NullableDataSource<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(optionalValidator, new RangeValidator_UInt64(null, false, value, false));

		public static NullableDataSource<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this OptionalNullableStateValidator<ulong> optionalValidator, ulong value)
			=> new NullableDataSource<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(optionalValidator, new RangeValidator_UInt64(null, false, value, true));

		public static NullableDataSource<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this OptionalNullableStateValidator<ulong> optionalValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(optionalValidator, new RangeValidator_UInt64(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalNullableStateValidator<float>, RangeValidator_Single, float> LessThan(this OptionalNullableStateValidator<float> optionalValidator, float value)
			=> new NullableDataSource<OptionalNullableStateValidator<float>, RangeValidator_Single, float>(optionalValidator, new RangeValidator_Single(value, false, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this OptionalNullableStateValidator<float> optionalValidator, float value)
			=> new NullableDataSource<OptionalNullableStateValidator<float>, RangeValidator_Single, float>(optionalValidator, new RangeValidator_Single(value, true, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<float>, RangeValidator_Single, float> GreaterThan(this OptionalNullableStateValidator<float> optionalValidator, float value)
			=> new NullableDataSource<OptionalNullableStateValidator<float>, RangeValidator_Single, float>(optionalValidator, new RangeValidator_Single(null, false, value, false));

		public static NullableDataSource<OptionalNullableStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this OptionalNullableStateValidator<float> optionalValidator, float value)
			=> new NullableDataSource<OptionalNullableStateValidator<float>, RangeValidator_Single, float>(optionalValidator, new RangeValidator_Single(null, false, value, true));

		public static NullableDataSource<OptionalNullableStateValidator<float>, RangeValidator_Single, float> InRange(this OptionalNullableStateValidator<float> optionalValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalNullableStateValidator<float>, RangeValidator_Single, float>(optionalValidator, new RangeValidator_Single(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalNullableStateValidator<double>, RangeValidator_Double, double> LessThan(this OptionalNullableStateValidator<double> optionalValidator, double value)
			=> new NullableDataSource<OptionalNullableStateValidator<double>, RangeValidator_Double, double>(optionalValidator, new RangeValidator_Double(value, false, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this OptionalNullableStateValidator<double> optionalValidator, double value)
			=> new NullableDataSource<OptionalNullableStateValidator<double>, RangeValidator_Double, double>(optionalValidator, new RangeValidator_Double(value, true, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<double>, RangeValidator_Double, double> GreaterThan(this OptionalNullableStateValidator<double> optionalValidator, double value)
			=> new NullableDataSource<OptionalNullableStateValidator<double>, RangeValidator_Double, double>(optionalValidator, new RangeValidator_Double(null, false, value, false));

		public static NullableDataSource<OptionalNullableStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this OptionalNullableStateValidator<double> optionalValidator, double value)
			=> new NullableDataSource<OptionalNullableStateValidator<double>, RangeValidator_Double, double>(optionalValidator, new RangeValidator_Double(null, false, value, true));

		public static NullableDataSource<OptionalNullableStateValidator<double>, RangeValidator_Double, double> InRange(this OptionalNullableStateValidator<double> optionalValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalNullableStateValidator<double>, RangeValidator_Double, double>(optionalValidator, new RangeValidator_Double(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this OptionalNullableStateValidator<decimal> optionalValidator, decimal value)
			=> new NullableDataSource<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(optionalValidator, new RangeValidator_Decimal(value, false, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this OptionalNullableStateValidator<decimal> optionalValidator, decimal value)
			=> new NullableDataSource<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(optionalValidator, new RangeValidator_Decimal(value, true, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this OptionalNullableStateValidator<decimal> optionalValidator, decimal value)
			=> new NullableDataSource<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(optionalValidator, new RangeValidator_Decimal(null, false, value, false));

		public static NullableDataSource<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this OptionalNullableStateValidator<decimal> optionalValidator, decimal value)
			=> new NullableDataSource<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(optionalValidator, new RangeValidator_Decimal(null, false, value, true));

		public static NullableDataSource<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this OptionalNullableStateValidator<decimal> optionalValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(optionalValidator, new RangeValidator_Decimal(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this OptionalNullableStateValidator<DateTime> optionalValidator, DateTime value)
			=> new NullableDataSource<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(optionalValidator, new RangeValidator_DateTime(value, false, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this OptionalNullableStateValidator<DateTime> optionalValidator, DateTime value)
			=> new NullableDataSource<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(optionalValidator, new RangeValidator_DateTime(value, true, null, false));

		public static NullableDataSource<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this OptionalNullableStateValidator<DateTime> optionalValidator, DateTime value)
			=> new NullableDataSource<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(optionalValidator, new RangeValidator_DateTime(null, false, value, false));

		public static NullableDataSource<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this OptionalNullableStateValidator<DateTime> optionalValidator, DateTime value)
			=> new NullableDataSource<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(optionalValidator, new RangeValidator_DateTime(null, false, value, true));

		public static NullableDataSource<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this OptionalNullableStateValidator<DateTime> optionalValidator, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(optionalValidator, new RangeValidator_DateTime(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}
	}
}
