using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedNullableStateValidatorExtensions
	{
		public static InvertedNullableDataSource<DefaultedNullableStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this DefaultedNullableStateValidator<TValue> defaultedValidator, Func<DefaultedNullableStateValidator<TValue>, NullableDataSource<DefaultedNullableStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(defaultedValidator).Invert();

		public static NullableDataSource<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedNullableStateValidator<TValue> defaultedValidator, TValue[] options)
			=> new NullableDataSource<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>(defaultedValidator, new InSetValidator<TValue>(options));

		public static NullableDataSource<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedNullableStateValidator<TValue> defaultedValidator, ISet<TValue> options)
			=> new NullableDataSource<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>(defaultedValidator, new InSetValidator<TValue>(options));

		public static NullableDataSource<DefaultedNullableStateValidator<string>, StringLengthValidator, string> Length(this DefaultedNullableStateValidator<string> defaultedValidator, int? minimumLength = null, int? maximumLength = null) 
			=> new NullableDataSource<DefaultedNullableStateValidator<string>, StringLengthValidator, string>(defaultedValidator, new StringLengthValidator(minimumLength, maximumLength));

		public static NullableDataSource<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this DefaultedNullableStateValidator<byte> defaultedValidator, byte value)
			=> new NullableDataSource<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(value, false, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this DefaultedNullableStateValidator<byte> defaultedValidator, byte value)
			=> new NullableDataSource<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(value, true, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this DefaultedNullableStateValidator<byte> defaultedValidator, byte value)
			=> new NullableDataSource<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(null, false, value, false));

		public static NullableDataSource<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<byte> defaultedValidator, byte value)
			=> new NullableDataSource<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(null, false, value, true));

		public static NullableDataSource<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> InRange(this DefaultedNullableStateValidator<byte> defaultedValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte>(defaultedValidator, new RangeValidator_Byte(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this DefaultedNullableStateValidator<sbyte> defaultedValidator, sbyte value)
			=> new NullableDataSource<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(value, false, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this DefaultedNullableStateValidator<sbyte> defaultedValidator, sbyte value)
			=> new NullableDataSource<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(value, true, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this DefaultedNullableStateValidator<sbyte> defaultedValidator, sbyte value)
			=> new NullableDataSource<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(null, false, value, false));

		public static NullableDataSource<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<sbyte> defaultedValidator, sbyte value)
			=> new NullableDataSource<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(null, false, value, true));

		public static NullableDataSource<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this DefaultedNullableStateValidator<sbyte> defaultedValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>(defaultedValidator, new RangeValidator_SByte(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> LessThan(this DefaultedNullableStateValidator<short> defaultedValidator, short value)
			=> new NullableDataSource<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(value, false, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this DefaultedNullableStateValidator<short> defaultedValidator, short value)
			=> new NullableDataSource<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(value, true, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this DefaultedNullableStateValidator<short> defaultedValidator, short value)
			=> new NullableDataSource<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(null, false, value, false));

		public static NullableDataSource<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<short> defaultedValidator, short value)
			=> new NullableDataSource<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(null, false, value, true));

		public static NullableDataSource<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> InRange(this DefaultedNullableStateValidator<short> defaultedValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short>(defaultedValidator, new RangeValidator_Int16(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this DefaultedNullableStateValidator<ushort> defaultedValidator, ushort value)
			=> new NullableDataSource<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(value, false, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this DefaultedNullableStateValidator<ushort> defaultedValidator, ushort value)
			=> new NullableDataSource<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(value, true, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this DefaultedNullableStateValidator<ushort> defaultedValidator, ushort value)
			=> new NullableDataSource<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(null, false, value, false));

		public static NullableDataSource<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<ushort> defaultedValidator, ushort value)
			=> new NullableDataSource<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(null, false, value, true));

		public static NullableDataSource<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this DefaultedNullableStateValidator<ushort> defaultedValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>(defaultedValidator, new RangeValidator_UInt16(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> LessThan(this DefaultedNullableStateValidator<int> defaultedValidator, int value)
			=> new NullableDataSource<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(value, false, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this DefaultedNullableStateValidator<int> defaultedValidator, int value)
			=> new NullableDataSource<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(value, true, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this DefaultedNullableStateValidator<int> defaultedValidator, int value)
			=> new NullableDataSource<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(null, false, value, false));

		public static NullableDataSource<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<int> defaultedValidator, int value)
			=> new NullableDataSource<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(null, false, value, true));

		public static NullableDataSource<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> InRange(this DefaultedNullableStateValidator<int> defaultedValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int>(defaultedValidator, new RangeValidator_Int32(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this DefaultedNullableStateValidator<uint> defaultedValidator, uint value)
			=> new NullableDataSource<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(value, false, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this DefaultedNullableStateValidator<uint> defaultedValidator, uint value)
			=> new NullableDataSource<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(value, true, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this DefaultedNullableStateValidator<uint> defaultedValidator, uint value)
			=> new NullableDataSource<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(null, false, value, false));

		public static NullableDataSource<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<uint> defaultedValidator, uint value)
			=> new NullableDataSource<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(null, false, value, true));

		public static NullableDataSource<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this DefaultedNullableStateValidator<uint> defaultedValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint>(defaultedValidator, new RangeValidator_UInt32(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> LessThan(this DefaultedNullableStateValidator<long> defaultedValidator, long value)
			=> new NullableDataSource<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(value, false, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this DefaultedNullableStateValidator<long> defaultedValidator, long value)
			=> new NullableDataSource<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(value, true, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this DefaultedNullableStateValidator<long> defaultedValidator, long value)
			=> new NullableDataSource<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(null, false, value, false));

		public static NullableDataSource<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<long> defaultedValidator, long value)
			=> new NullableDataSource<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(null, false, value, true));

		public static NullableDataSource<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> InRange(this DefaultedNullableStateValidator<long> defaultedValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long>(defaultedValidator, new RangeValidator_Int64(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this DefaultedNullableStateValidator<ulong> defaultedValidator, ulong value)
			=> new NullableDataSource<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(value, false, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this DefaultedNullableStateValidator<ulong> defaultedValidator, ulong value)
			=> new NullableDataSource<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(value, true, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this DefaultedNullableStateValidator<ulong> defaultedValidator, ulong value)
			=> new NullableDataSource<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(null, false, value, false));

		public static NullableDataSource<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<ulong> defaultedValidator, ulong value)
			=> new NullableDataSource<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(null, false, value, true));

		public static NullableDataSource<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this DefaultedNullableStateValidator<ulong> defaultedValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>(defaultedValidator, new RangeValidator_UInt64(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> LessThan(this DefaultedNullableStateValidator<float> defaultedValidator, float value)
			=> new NullableDataSource<DefaultedNullableStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(value, false, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this DefaultedNullableStateValidator<float> defaultedValidator, float value)
			=> new NullableDataSource<DefaultedNullableStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(value, true, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> GreaterThan(this DefaultedNullableStateValidator<float> defaultedValidator, float value)
			=> new NullableDataSource<DefaultedNullableStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(null, false, value, false));

		public static NullableDataSource<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<float> defaultedValidator, float value)
			=> new NullableDataSource<DefaultedNullableStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(null, false, value, true));

		public static NullableDataSource<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> InRange(this DefaultedNullableStateValidator<float> defaultedValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<DefaultedNullableStateValidator<float>, RangeValidator_Single, float>(defaultedValidator, new RangeValidator_Single(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> LessThan(this DefaultedNullableStateValidator<double> defaultedValidator, double value)
			=> new NullableDataSource<DefaultedNullableStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(value, false, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this DefaultedNullableStateValidator<double> defaultedValidator, double value)
			=> new NullableDataSource<DefaultedNullableStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(value, true, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> GreaterThan(this DefaultedNullableStateValidator<double> defaultedValidator, double value)
			=> new NullableDataSource<DefaultedNullableStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(null, false, value, false));

		public static NullableDataSource<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<double> defaultedValidator, double value)
			=> new NullableDataSource<DefaultedNullableStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(null, false, value, true));

		public static NullableDataSource<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> InRange(this DefaultedNullableStateValidator<double> defaultedValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<DefaultedNullableStateValidator<double>, RangeValidator_Double, double>(defaultedValidator, new RangeValidator_Double(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this DefaultedNullableStateValidator<decimal> defaultedValidator, decimal value)
			=> new NullableDataSource<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(value, false, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this DefaultedNullableStateValidator<decimal> defaultedValidator, decimal value)
			=> new NullableDataSource<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(value, true, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this DefaultedNullableStateValidator<decimal> defaultedValidator, decimal value)
			=> new NullableDataSource<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(null, false, value, false));

		public static NullableDataSource<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<decimal> defaultedValidator, decimal value)
			=> new NullableDataSource<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(null, false, value, true));

		public static NullableDataSource<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this DefaultedNullableStateValidator<decimal> defaultedValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>(defaultedValidator, new RangeValidator_Decimal(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static NullableDataSource<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this DefaultedNullableStateValidator<DateTime> defaultedValidator, DateTime value)
			=> new NullableDataSource<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(defaultedValidator, new RangeValidator_DateTime(value, false, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this DefaultedNullableStateValidator<DateTime> defaultedValidator, DateTime value)
			=> new NullableDataSource<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(defaultedValidator, new RangeValidator_DateTime(value, true, null, false));

		public static NullableDataSource<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this DefaultedNullableStateValidator<DateTime> defaultedValidator, DateTime value)
			=> new NullableDataSource<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(defaultedValidator, new RangeValidator_DateTime(null, false, value, false));

		public static NullableDataSource<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<DateTime> defaultedValidator, DateTime value)
			=> new NullableDataSource<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(defaultedValidator, new RangeValidator_DateTime(null, false, value, true));

		public static NullableDataSource<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this DefaultedNullableStateValidator<DateTime> defaultedValidator, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new NullableDataSource<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(defaultedValidator, new RangeValidator_DateTime(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}
	}
}
