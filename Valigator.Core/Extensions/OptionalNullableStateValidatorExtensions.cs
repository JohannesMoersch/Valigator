using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalNullableStateValidatorExtensions
	{
		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this OptionalNullableStateValidator<TValue> stateValidator, string description, Func<TValue, bool> validator)
			=> stateValidator.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> Precision(this OptionalNullableStateValidator<decimal> stateValidator, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> stateValidator.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> Equals<TValue>(this OptionalNullableStateValidator<TValue> stateValidator, TValue value)
			=> stateValidator.Add(new EqualsValidator<TValue>(value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this OptionalNullableStateValidator<TValue> stateValidator, params TValue[] options)
			=> stateValidator.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this OptionalNullableStateValidator<TValue> stateValidator, ISet<TValue> options)
			=> stateValidator.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<string>, StringLengthValidator, string> Length(this OptionalNullableStateValidator<string> stateValidator, int? minimumDecimalPlaces = null, int? maximumDecimalPlaces = null)
			=> stateValidator.Add(new StringLengthValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this OptionalNullableStateValidator<string> stateValidator)
			=> stateValidator.Add(new EqualsValidator<string>(String.Empty));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this OptionalNullableStateValidator<Guid> stateValidator)
			=> stateValidator.Add(new EqualsValidator<Guid>(Guid.Empty));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this OptionalNullableStateValidator<byte> stateValidator)
			=> stateValidator.Add(new EqualsValidator<byte>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this OptionalNullableStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this OptionalNullableStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this OptionalNullableStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this OptionalNullableStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> InRange(this OptionalNullableStateValidator<byte> stateValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Byte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this OptionalNullableStateValidator<sbyte> stateValidator)
			=> stateValidator.Add(new EqualsValidator<sbyte>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this OptionalNullableStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this OptionalNullableStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this OptionalNullableStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this OptionalNullableStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this OptionalNullableStateValidator<sbyte> stateValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_SByte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, EqualsValidator<short>, short> NotZero(this OptionalNullableStateValidator<short> stateValidator)
			=> stateValidator.Add(new EqualsValidator<short>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> LessThan(this OptionalNullableStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this OptionalNullableStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this OptionalNullableStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this OptionalNullableStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> InRange(this OptionalNullableStateValidator<short> stateValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int16(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this OptionalNullableStateValidator<ushort> stateValidator)
			=> stateValidator.Add(new EqualsValidator<ushort>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this OptionalNullableStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this OptionalNullableStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this OptionalNullableStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this OptionalNullableStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this OptionalNullableStateValidator<ushort> stateValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt16(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, EqualsValidator<int>, int> NotZero(this OptionalNullableStateValidator<int> stateValidator)
			=> stateValidator.Add(new EqualsValidator<int>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> LessThan(this OptionalNullableStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this OptionalNullableStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this OptionalNullableStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this OptionalNullableStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> InRange(this OptionalNullableStateValidator<int> stateValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int32(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this OptionalNullableStateValidator<uint> stateValidator)
			=> stateValidator.Add(new EqualsValidator<uint>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this OptionalNullableStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this OptionalNullableStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this OptionalNullableStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this OptionalNullableStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this OptionalNullableStateValidator<uint> stateValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt32(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, EqualsValidator<long>, long> NotZero(this OptionalNullableStateValidator<long> stateValidator)
			=> stateValidator.Add(new EqualsValidator<long>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> LessThan(this OptionalNullableStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this OptionalNullableStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this OptionalNullableStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this OptionalNullableStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> InRange(this OptionalNullableStateValidator<long> stateValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int64(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this OptionalNullableStateValidator<ulong> stateValidator)
			=> stateValidator.Add(new EqualsValidator<ulong>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this OptionalNullableStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this OptionalNullableStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this OptionalNullableStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this OptionalNullableStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this OptionalNullableStateValidator<ulong> stateValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt64(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, EqualsValidator<float>, float> NotZero(this OptionalNullableStateValidator<float> stateValidator)
			=> stateValidator.Add(new EqualsValidator<float>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float> LessThan(this OptionalNullableStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this OptionalNullableStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float> GreaterThan(this OptionalNullableStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this OptionalNullableStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float> InRange(this OptionalNullableStateValidator<float> stateValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Single(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, EqualsValidator<double>, double> NotZero(this OptionalNullableStateValidator<double> stateValidator)
			=> stateValidator.Add(new EqualsValidator<double>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double> LessThan(this OptionalNullableStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this OptionalNullableStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double> GreaterThan(this OptionalNullableStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this OptionalNullableStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double> InRange(this OptionalNullableStateValidator<double> stateValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Double(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this OptionalNullableStateValidator<decimal> stateValidator)
			=> stateValidator.Add(new EqualsValidator<decimal>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this OptionalNullableStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this OptionalNullableStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this OptionalNullableStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this OptionalNullableStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this OptionalNullableStateValidator<decimal> stateValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Decimal(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this OptionalNullableStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this OptionalNullableStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this OptionalNullableStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this OptionalNullableStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this OptionalNullableStateValidator<DateTime> stateValidator, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_DateTime(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

	}
}