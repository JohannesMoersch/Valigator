using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredNullableStateValidatorExtensions
	{
		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this RequiredNullableStateValidator<TValue> stateValidator, string description, Func<TValue, bool> validator)
			=> stateValidator.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> Precision(this RequiredNullableStateValidator<decimal> stateValidator, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> stateValidator.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> Equals<TValue>(this RequiredNullableStateValidator<TValue> stateValidator, TValue value)
			=> stateValidator.Add(new EqualsValidator<TValue>(value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredNullableStateValidator<TValue> stateValidator, params TValue[] options)
			=> stateValidator.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredNullableStateValidator<TValue> stateValidator, ISet<TValue> options)
			=> stateValidator.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<string>, StringLengthValidator, string> Length(this RequiredNullableStateValidator<string> stateValidator, int? minimumDecimalPlaces = null, int? maximumDecimalPlaces = null)
			=> stateValidator.Add(new StringLengthValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this RequiredNullableStateValidator<string> stateValidator)
			=> stateValidator.Add(new EqualsValidator<string>(String.Empty));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this RequiredNullableStateValidator<Guid> stateValidator)
			=> stateValidator.Add(new EqualsValidator<Guid>(Guid.Empty));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this RequiredNullableStateValidator<byte> stateValidator)
			=> stateValidator.Add(new EqualsValidator<byte>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this RequiredNullableStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this RequiredNullableStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this RequiredNullableStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this RequiredNullableStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> InRange(this RequiredNullableStateValidator<byte> stateValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Byte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this RequiredNullableStateValidator<sbyte> stateValidator)
			=> stateValidator.Add(new EqualsValidator<sbyte>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this RequiredNullableStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this RequiredNullableStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this RequiredNullableStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this RequiredNullableStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this RequiredNullableStateValidator<sbyte> stateValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_SByte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<short>, EqualsValidator<short>, short> NotZero(this RequiredNullableStateValidator<short> stateValidator)
			=> stateValidator.Add(new EqualsValidator<short>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> LessThan(this RequiredNullableStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this RequiredNullableStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this RequiredNullableStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this RequiredNullableStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> InRange(this RequiredNullableStateValidator<short> stateValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int16(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this RequiredNullableStateValidator<ushort> stateValidator)
			=> stateValidator.Add(new EqualsValidator<ushort>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this RequiredNullableStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this RequiredNullableStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this RequiredNullableStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this RequiredNullableStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this RequiredNullableStateValidator<ushort> stateValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt16(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<int>, EqualsValidator<int>, int> NotZero(this RequiredNullableStateValidator<int> stateValidator)
			=> stateValidator.Add(new EqualsValidator<int>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> LessThan(this RequiredNullableStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this RequiredNullableStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this RequiredNullableStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this RequiredNullableStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> InRange(this RequiredNullableStateValidator<int> stateValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int32(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this RequiredNullableStateValidator<uint> stateValidator)
			=> stateValidator.Add(new EqualsValidator<uint>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this RequiredNullableStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this RequiredNullableStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this RequiredNullableStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this RequiredNullableStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this RequiredNullableStateValidator<uint> stateValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt32(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<long>, EqualsValidator<long>, long> NotZero(this RequiredNullableStateValidator<long> stateValidator)
			=> stateValidator.Add(new EqualsValidator<long>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> LessThan(this RequiredNullableStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this RequiredNullableStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this RequiredNullableStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this RequiredNullableStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> InRange(this RequiredNullableStateValidator<long> stateValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int64(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this RequiredNullableStateValidator<ulong> stateValidator)
			=> stateValidator.Add(new EqualsValidator<ulong>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this RequiredNullableStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this RequiredNullableStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this RequiredNullableStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this RequiredNullableStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this RequiredNullableStateValidator<ulong> stateValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt64(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<float>, EqualsValidator<float>, float> NotZero(this RequiredNullableStateValidator<float> stateValidator)
			=> stateValidator.Add(new EqualsValidator<float>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, float> LessThan(this RequiredNullableStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this RequiredNullableStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, float> GreaterThan(this RequiredNullableStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this RequiredNullableStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, float> InRange(this RequiredNullableStateValidator<float> stateValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Single(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<double>, EqualsValidator<double>, double> NotZero(this RequiredNullableStateValidator<double> stateValidator)
			=> stateValidator.Add(new EqualsValidator<double>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, double> LessThan(this RequiredNullableStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this RequiredNullableStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, double> GreaterThan(this RequiredNullableStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this RequiredNullableStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, double> InRange(this RequiredNullableStateValidator<double> stateValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Double(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this RequiredNullableStateValidator<decimal> stateValidator)
			=> stateValidator.Add(new EqualsValidator<decimal>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this RequiredNullableStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this RequiredNullableStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this RequiredNullableStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this RequiredNullableStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this RequiredNullableStateValidator<decimal> stateValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Decimal(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this RequiredNullableStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this RequiredNullableStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this RequiredNullableStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this RequiredNullableStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this RequiredNullableStateValidator<DateTime> stateValidator, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_DateTime(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

	}
}