using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedStateValidatorExtensions
	{
		public static DataSourceStandard<DefaultedStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this DefaultedStateValidator<TValue> stateValidator, string description, Func<TValue, bool> validator)
			=> stateValidator.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> Precision(this DefaultedStateValidator<decimal> stateValidator, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> stateValidator.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, TValue> Equals<TValue>(this DefaultedStateValidator<TValue> stateValidator, TValue value)
			=> stateValidator.Add(new EqualsValidator<TValue>(value));

		public static DataSourceStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedStateValidator<TValue> stateValidator, params TValue[] options)
			=> stateValidator.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedStateValidator<TValue> stateValidator, ISet<TValue> options)
			=> stateValidator.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DefaultedStateValidator<string>, StringLengthValidator, string> Length(this DefaultedStateValidator<string> stateValidator, int? minimumDecimalPlaces = null, int? maximumDecimalPlaces = null)
			=> stateValidator.Add(new StringLengthValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<DefaultedStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this DefaultedStateValidator<string> stateValidator)
			=> stateValidator.Add(new EqualsValidator<string>(String.Empty));

		public static DataSourceStandard<DefaultedStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this DefaultedStateValidator<Guid> stateValidator)
			=> stateValidator.Add(new EqualsValidator<Guid>(Guid.Empty));

		public static DataSourceStandard<DefaultedStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this DefaultedStateValidator<byte> stateValidator)
			=> stateValidator.Add(new EqualsValidator<byte>(0));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this DefaultedStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this DefaultedStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this DefaultedStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this DefaultedStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> InRange(this DefaultedStateValidator<byte> stateValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Byte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this DefaultedStateValidator<sbyte> stateValidator)
			=> stateValidator.Add(new EqualsValidator<sbyte>(0));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this DefaultedStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this DefaultedStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this DefaultedStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this DefaultedStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this DefaultedStateValidator<sbyte> stateValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_SByte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<short>, EqualsValidator<short>, short> NotZero(this DefaultedStateValidator<short> stateValidator)
			=> stateValidator.Add(new EqualsValidator<short>(0));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short> LessThan(this DefaultedStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this DefaultedStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this DefaultedStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this DefaultedStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short> InRange(this DefaultedStateValidator<short> stateValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int16(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this DefaultedStateValidator<ushort> stateValidator)
			=> stateValidator.Add(new EqualsValidator<ushort>(0));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this DefaultedStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this DefaultedStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this DefaultedStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this DefaultedStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this DefaultedStateValidator<ushort> stateValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt16(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<int>, EqualsValidator<int>, int> NotZero(this DefaultedStateValidator<int> stateValidator)
			=> stateValidator.Add(new EqualsValidator<int>(0));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int> LessThan(this DefaultedStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this DefaultedStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this DefaultedStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this DefaultedStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int> InRange(this DefaultedStateValidator<int> stateValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int32(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this DefaultedStateValidator<uint> stateValidator)
			=> stateValidator.Add(new EqualsValidator<uint>(0));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this DefaultedStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this DefaultedStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this DefaultedStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this DefaultedStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this DefaultedStateValidator<uint> stateValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt32(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<long>, EqualsValidator<long>, long> NotZero(this DefaultedStateValidator<long> stateValidator)
			=> stateValidator.Add(new EqualsValidator<long>(0));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long> LessThan(this DefaultedStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this DefaultedStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this DefaultedStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this DefaultedStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long> InRange(this DefaultedStateValidator<long> stateValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int64(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this DefaultedStateValidator<ulong> stateValidator)
			=> stateValidator.Add(new EqualsValidator<ulong>(0));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this DefaultedStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this DefaultedStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this DefaultedStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this DefaultedStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this DefaultedStateValidator<ulong> stateValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt64(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<float>, EqualsValidator<float>, float> NotZero(this DefaultedStateValidator<float> stateValidator)
			=> stateValidator.Add(new EqualsValidator<float>(0));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float> LessThan(this DefaultedStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this DefaultedStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float> GreaterThan(this DefaultedStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this DefaultedStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float> InRange(this DefaultedStateValidator<float> stateValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Single(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<double>, EqualsValidator<double>, double> NotZero(this DefaultedStateValidator<double> stateValidator)
			=> stateValidator.Add(new EqualsValidator<double>(0));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double> LessThan(this DefaultedStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this DefaultedStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double> GreaterThan(this DefaultedStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this DefaultedStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double> InRange(this DefaultedStateValidator<double> stateValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Double(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this DefaultedStateValidator<decimal> stateValidator)
			=> stateValidator.Add(new EqualsValidator<decimal>(0));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this DefaultedStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this DefaultedStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this DefaultedStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this DefaultedStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this DefaultedStateValidator<decimal> stateValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Decimal(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this DefaultedStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this DefaultedStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this DefaultedStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this DefaultedStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this DefaultedStateValidator<DateTime> stateValidator, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_DateTime(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

	}
}