using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedNullableStateValidatorExtensions
	{
		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this DefaultedNullableStateValidator<TValue> stateValidator, string description, Func<TValue, bool> validator)
			=> stateValidator.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> Precision(this DefaultedNullableStateValidator<decimal> stateValidator, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> stateValidator.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> Equals<TValue>(this DefaultedNullableStateValidator<TValue> stateValidator, TValue value)
			=> stateValidator.Add(new EqualsValidator<TValue>(value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedNullableStateValidator<TValue> stateValidator, params TValue[] options)
			=> stateValidator.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedNullableStateValidator<TValue> stateValidator, ISet<TValue> options)
			=> stateValidator.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<string>, StringLengthValidator, string> Length(this DefaultedNullableStateValidator<string> stateValidator, int? minimumDecimalPlaces = null, int? maximumDecimalPlaces = null)
			=> stateValidator.Add(new StringLengthValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this DefaultedNullableStateValidator<string> stateValidator)
			=> stateValidator.Add(new EqualsValidator<string>(String.Empty));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this DefaultedNullableStateValidator<Guid> stateValidator)
			=> stateValidator.Add(new EqualsValidator<Guid>(Guid.Empty));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this DefaultedNullableStateValidator<byte> stateValidator)
			=> stateValidator.Add(new EqualsValidator<byte>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this DefaultedNullableStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this DefaultedNullableStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this DefaultedNullableStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> InRange(this DefaultedNullableStateValidator<byte> stateValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Byte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this DefaultedNullableStateValidator<sbyte> stateValidator)
			=> stateValidator.Add(new EqualsValidator<sbyte>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this DefaultedNullableStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this DefaultedNullableStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this DefaultedNullableStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this DefaultedNullableStateValidator<sbyte> stateValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_SByte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, EqualsValidator<short>, short> NotZero(this DefaultedNullableStateValidator<short> stateValidator)
			=> stateValidator.Add(new EqualsValidator<short>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> LessThan(this DefaultedNullableStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this DefaultedNullableStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this DefaultedNullableStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> InRange(this DefaultedNullableStateValidator<short> stateValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int16(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this DefaultedNullableStateValidator<ushort> stateValidator)
			=> stateValidator.Add(new EqualsValidator<ushort>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this DefaultedNullableStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this DefaultedNullableStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this DefaultedNullableStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this DefaultedNullableStateValidator<ushort> stateValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt16(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, EqualsValidator<int>, int> NotZero(this DefaultedNullableStateValidator<int> stateValidator)
			=> stateValidator.Add(new EqualsValidator<int>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> LessThan(this DefaultedNullableStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this DefaultedNullableStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this DefaultedNullableStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> InRange(this DefaultedNullableStateValidator<int> stateValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int32(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this DefaultedNullableStateValidator<uint> stateValidator)
			=> stateValidator.Add(new EqualsValidator<uint>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this DefaultedNullableStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this DefaultedNullableStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this DefaultedNullableStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this DefaultedNullableStateValidator<uint> stateValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt32(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, EqualsValidator<long>, long> NotZero(this DefaultedNullableStateValidator<long> stateValidator)
			=> stateValidator.Add(new EqualsValidator<long>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> LessThan(this DefaultedNullableStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this DefaultedNullableStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this DefaultedNullableStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> InRange(this DefaultedNullableStateValidator<long> stateValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int64(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this DefaultedNullableStateValidator<ulong> stateValidator)
			=> stateValidator.Add(new EqualsValidator<ulong>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this DefaultedNullableStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this DefaultedNullableStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this DefaultedNullableStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this DefaultedNullableStateValidator<ulong> stateValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt64(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, EqualsValidator<float>, float> NotZero(this DefaultedNullableStateValidator<float> stateValidator)
			=> stateValidator.Add(new EqualsValidator<float>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> LessThan(this DefaultedNullableStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this DefaultedNullableStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> GreaterThan(this DefaultedNullableStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> InRange(this DefaultedNullableStateValidator<float> stateValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Single(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, EqualsValidator<double>, double> NotZero(this DefaultedNullableStateValidator<double> stateValidator)
			=> stateValidator.Add(new EqualsValidator<double>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> LessThan(this DefaultedNullableStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this DefaultedNullableStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> GreaterThan(this DefaultedNullableStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> InRange(this DefaultedNullableStateValidator<double> stateValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Double(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this DefaultedNullableStateValidator<decimal> stateValidator)
			=> stateValidator.Add(new EqualsValidator<decimal>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this DefaultedNullableStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this DefaultedNullableStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this DefaultedNullableStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this DefaultedNullableStateValidator<decimal> stateValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Decimal(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this DefaultedNullableStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this DefaultedNullableStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this DefaultedNullableStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this DefaultedNullableStateValidator<DateTime> stateValidator, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_DateTime(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

	}
}