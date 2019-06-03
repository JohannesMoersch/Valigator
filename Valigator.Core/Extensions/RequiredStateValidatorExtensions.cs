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
		public static DataSourceInverted<RequiredStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this RequiredStateValidator<TValue> requiredValidator, Func<RequiredStateValidator<TValue>, DataSourceStandard<RequiredStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(requiredValidator).Invert();

		public static DataSourceStandard<RequiredStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this RequiredStateValidator<TValue> requiredValidator, string description, Func<TValue, bool> validator)
			=> new DataSourceStandard<RequiredStateValidator<TValue>, CustomValidator<TValue>, TValue>(requiredValidator, new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal> Precision(this RequiredStateValidator<decimal> requiredValidator, decimal? minimumDecimalPlaces, decimal? maximumDecimalPlaces)
			=> new DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal>(requiredValidator, new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValue> Equals<TValue>(this RequiredStateValidator<TValue> requiredValidator, TValue value)
			=> new DataSourceStandard<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValue>(requiredValidator, new EqualsValidator<TValue>(value));

		public static DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredStateValidator<TValue> requiredValidator, params TValue[] options)
			=> new DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue>(requiredValidator, new InSetValidator<TValue>(options));

		public static DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredStateValidator<TValue> requiredValidator, ISet<TValue> options)
			=> new DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue>(requiredValidator, new InSetValidator<TValue>(options));

		public static DataSourceStandard<RequiredStateValidator<string>, StringLengthValidator, string> Length(this RequiredStateValidator<string> requiredValidator, int? minimumLength = null, int? maximumLength = null)
			=> new DataSourceStandard<RequiredStateValidator<string>, StringLengthValidator, string>(requiredValidator, new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceInverted<RequiredStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this RequiredStateValidator<string> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<string>, EqualsValidator<string>, string>(requiredValidator, new EqualsValidator<string>(String.Empty));

		public static DataSourceInverted<RequiredStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this RequiredStateValidator<Guid> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<Guid>, EqualsValidator<Guid>, Guid>(requiredValidator, new EqualsValidator<Guid>(Guid.Empty));

		public static DataSourceInverted<RequiredStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this RequiredStateValidator<byte> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<byte>, EqualsValidator<byte>, byte>(requiredValidator, new EqualsValidator<byte>(0));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(value, false, null, false));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(value, true, null, false));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(null, false, value, false));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this RequiredStateValidator<byte> requiredValidator, byte value)
			=> new DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(null, false, value, true));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> InRange(this RequiredStateValidator<byte> requiredValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte>(requiredValidator, new RangeValidator_Byte(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSourceInverted<RequiredStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this RequiredStateValidator<sbyte> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte>(requiredValidator, new EqualsValidator<sbyte>(0));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this RequiredStateValidator<sbyte> requiredValidator, sbyte value)
			=> new DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(value, false, null, false));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this RequiredStateValidator<sbyte> requiredValidator, sbyte value)
			=> new DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(value, true, null, false));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this RequiredStateValidator<sbyte> requiredValidator, sbyte value)
			=> new DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(null, false, value, false));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this RequiredStateValidator<sbyte> requiredValidator, sbyte value)
			=> new DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(null, false, value, true));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this RequiredStateValidator<sbyte> requiredValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte>(requiredValidator, new RangeValidator_SByte(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSourceInverted<RequiredStateValidator<short>, EqualsValidator<short>, short> NotZero(this RequiredStateValidator<short> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<short>, EqualsValidator<short>, short>(requiredValidator, new EqualsValidator<short>(0));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> LessThan(this RequiredStateValidator<short> requiredValidator, short value)
			=> new DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(value, false, null, false));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this RequiredStateValidator<short> requiredValidator, short value)
			=> new DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(value, true, null, false));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this RequiredStateValidator<short> requiredValidator, short value)
			=> new DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(null, false, value, false));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this RequiredStateValidator<short> requiredValidator, short value)
			=> new DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(null, false, value, true));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> InRange(this RequiredStateValidator<short> requiredValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short>(requiredValidator, new RangeValidator_Int16(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSourceInverted<RequiredStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this RequiredStateValidator<ushort> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<ushort>, EqualsValidator<ushort>, ushort>(requiredValidator, new EqualsValidator<ushort>(0));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this RequiredStateValidator<ushort> requiredValidator, ushort value)
			=> new DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(value, false, null, false));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this RequiredStateValidator<ushort> requiredValidator, ushort value)
			=> new DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(value, true, null, false));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this RequiredStateValidator<ushort> requiredValidator, ushort value)
			=> new DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(null, false, value, false));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this RequiredStateValidator<ushort> requiredValidator, ushort value)
			=> new DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(null, false, value, true));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this RequiredStateValidator<ushort> requiredValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort>(requiredValidator, new RangeValidator_UInt16(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSourceInverted<RequiredStateValidator<int>, EqualsValidator<int>, int> NotZero(this RequiredStateValidator<int> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<int>, EqualsValidator<int>, int>(requiredValidator, new EqualsValidator<int>(0));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> LessThan(this RequiredStateValidator<int> requiredValidator, int value)
			=> new DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(value, false, null, false));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this RequiredStateValidator<int> requiredValidator, int value)
			=> new DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(value, true, null, false));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this RequiredStateValidator<int> requiredValidator, int value)
			=> new DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(null, false, value, false));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this RequiredStateValidator<int> requiredValidator, int value)
			=> new DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(null, false, value, true));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> InRange(this RequiredStateValidator<int> requiredValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int>(requiredValidator, new RangeValidator_Int32(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSourceInverted<RequiredStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this RequiredStateValidator<uint> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<uint>, EqualsValidator<uint>, uint>(requiredValidator, new EqualsValidator<uint>(0));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this RequiredStateValidator<uint> requiredValidator, uint value)
			=> new DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(value, false, null, false));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this RequiredStateValidator<uint> requiredValidator, uint value)
			=> new DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(value, true, null, false));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this RequiredStateValidator<uint> requiredValidator, uint value)
			=> new DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(null, false, value, false));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this RequiredStateValidator<uint> requiredValidator, uint value)
			=> new DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(null, false, value, true));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this RequiredStateValidator<uint> requiredValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint>(requiredValidator, new RangeValidator_UInt32(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSourceInverted<RequiredStateValidator<long>, EqualsValidator<long>, long> NotZero(this RequiredStateValidator<long> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<long>, EqualsValidator<long>, long>(requiredValidator, new EqualsValidator<long>(0));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> LessThan(this RequiredStateValidator<long> requiredValidator, long value)
			=> new DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(value, false, null, false));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this RequiredStateValidator<long> requiredValidator, long value)
			=> new DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(value, true, null, false));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this RequiredStateValidator<long> requiredValidator, long value)
			=> new DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(null, false, value, false));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this RequiredStateValidator<long> requiredValidator, long value)
			=> new DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(null, false, value, true));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> InRange(this RequiredStateValidator<long> requiredValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long>(requiredValidator, new RangeValidator_Int64(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSourceInverted<RequiredStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this RequiredStateValidator<ulong> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<ulong>, EqualsValidator<ulong>, ulong>(requiredValidator, new EqualsValidator<ulong>(0));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this RequiredStateValidator<ulong> requiredValidator, ulong value)
			=> new DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(value, false, null, false));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this RequiredStateValidator<ulong> requiredValidator, ulong value)
			=> new DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(value, true, null, false));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this RequiredStateValidator<ulong> requiredValidator, ulong value)
			=> new DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(null, false, value, false));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this RequiredStateValidator<ulong> requiredValidator, ulong value)
			=> new DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(null, false, value, true));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this RequiredStateValidator<ulong> requiredValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong>(requiredValidator, new RangeValidator_UInt64(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSourceInverted<RequiredStateValidator<float>, EqualsValidator<float>, float> NotZero(this RequiredStateValidator<float> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<float>, EqualsValidator<float>, float>(requiredValidator, new EqualsValidator<float>(0));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> LessThan(this RequiredStateValidator<float> requiredValidator, float value)
			=> new DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(value, false, null, false));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this RequiredStateValidator<float> requiredValidator, float value)
			=> new DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(value, true, null, false));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> GreaterThan(this RequiredStateValidator<float> requiredValidator, float value)
			=> new DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(null, false, value, false));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this RequiredStateValidator<float> requiredValidator, float value)
			=> new DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(null, false, value, true));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> InRange(this RequiredStateValidator<float> requiredValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float>(requiredValidator, new RangeValidator_Single(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSourceInverted<RequiredStateValidator<double>, EqualsValidator<double>, double> NotZero(this RequiredStateValidator<double> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<double>, EqualsValidator<double>, double>(requiredValidator, new EqualsValidator<double>(0));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> LessThan(this RequiredStateValidator<double> requiredValidator, double value)
			=> new DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(value, false, null, false));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this RequiredStateValidator<double> requiredValidator, double value)
			=> new DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(value, true, null, false));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> GreaterThan(this RequiredStateValidator<double> requiredValidator, double value)
			=> new DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(null, false, value, false));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this RequiredStateValidator<double> requiredValidator, double value)
			=> new DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(null, false, value, true));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> InRange(this RequiredStateValidator<double> requiredValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double>(requiredValidator, new RangeValidator_Double(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSourceInverted<RequiredStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this RequiredStateValidator<decimal> requiredValidator)
			=> new DataSourceInverted<RequiredStateValidator<decimal>, EqualsValidator<decimal>, decimal>(requiredValidator, new EqualsValidator<decimal>(0));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this RequiredStateValidator<decimal> requiredValidator, decimal value)
			=> new DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(value, false, null, false));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this RequiredStateValidator<decimal> requiredValidator, decimal value)
			=> new DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(value, true, null, false));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this RequiredStateValidator<decimal> requiredValidator, decimal value)
			=> new DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(null, false, value, false));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this RequiredStateValidator<decimal> requiredValidator, decimal value)
			=> new DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(null, false, value, true));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this RequiredStateValidator<decimal> requiredValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal>(requiredValidator, new RangeValidator_Decimal(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this RequiredStateValidator<DateTime> requiredValidator, DateTime value)
			=> new DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(requiredValidator, new RangeValidator_DateTime(value, false, null, false));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this RequiredStateValidator<DateTime> requiredValidator, DateTime value)
			=> new DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(requiredValidator, new RangeValidator_DateTime(value, true, null, false));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this RequiredStateValidator<DateTime> requiredValidator, DateTime value)
			=> new DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(requiredValidator, new RangeValidator_DateTime(null, false, value, false));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this RequiredStateValidator<DateTime> requiredValidator, DateTime value)
			=> new DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(requiredValidator, new RangeValidator_DateTime(null, false, value, true));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this RequiredStateValidator<DateTime> requiredValidator, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null)
		{
			if (lessThan.HasValue && lessThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(lessThan), $"{nameof(lessThan)} and {nameof(lessThanOrEqualTo)} cannot both be specified.");

			if (greaterThan.HasValue && greaterThanOrEqualTo.HasValue)
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"{nameof(greaterThan)} and {nameof(greaterThanOrEqualTo)} cannot both be specified.");

			if ((lessThan ?? lessThanOrEqualTo) <= (greaterThan ?? greaterThanOrEqualTo))
				throw new ArgumentOutOfRangeException(nameof(greaterThan), $"Specified range must include more than one possible value.");

			return new DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime>(requiredValidator, new RangeValidator_DateTime(lessThan ?? lessThanOrEqualTo, lessThanOrEqualTo.HasValue, greaterThan ?? greaterThanOrEqualTo, greaterThanOrEqualTo.HasValue));
		}
	}
}
