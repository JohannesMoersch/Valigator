using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalStateValidatorExtensions
	{
		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this OptionalStateValidator<TValue> stateValidator, string description, Func<TValue, bool> validator)
			=> stateValidator.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, PrecisionValidator, decimal> Precision(this OptionalStateValidator<decimal> stateValidator, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> stateValidator.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, EqualsValidator<TValue>, TValue> Equals<TValue>(this OptionalStateValidator<TValue> stateValidator, TValue value)
			=> stateValidator.Add(new EqualsValidator<TValue>(value));

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this OptionalStateValidator<TValue> stateValidator, params TValue[] options)
			=> stateValidator.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this OptionalStateValidator<TValue> stateValidator, ISet<TValue> options)
			=> stateValidator.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalStateValidator<string>, StringLengthValidator, string> Length(this OptionalStateValidator<string> stateValidator, int? minimumDecimalPlaces = null, int? maximumDecimalPlaces = null)
			=> stateValidator.Add(new StringLengthValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<OptionalStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this OptionalStateValidator<string> stateValidator)
			=> stateValidator.Add(new EqualsValidator<string>(String.Empty));

		public static NullableDataSourceStandard<OptionalStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this OptionalStateValidator<Guid> stateValidator)
			=> stateValidator.Add(new EqualsValidator<Guid>(Guid.Empty));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this OptionalStateValidator<byte> stateValidator)
			=> stateValidator.Add(new EqualsValidator<byte>(0));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this OptionalStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this OptionalStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this OptionalStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this OptionalStateValidator<byte> stateValidator, byte value)
			=> stateValidator.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte> InRange(this OptionalStateValidator<byte> stateValidator, byte? lessThan = null, byte? lessThanOrEqualTo = null, byte? greaterThan = null, byte? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Byte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this OptionalStateValidator<sbyte> stateValidator)
			=> stateValidator.Add(new EqualsValidator<sbyte>(0));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this OptionalStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this OptionalStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this OptionalStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this OptionalStateValidator<sbyte> stateValidator, sbyte value)
			=> stateValidator.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this OptionalStateValidator<sbyte> stateValidator, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_SByte(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, EqualsValidator<short>, short> NotZero(this OptionalStateValidator<short> stateValidator)
			=> stateValidator.Add(new EqualsValidator<short>(0));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short> LessThan(this OptionalStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this OptionalStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this OptionalStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this OptionalStateValidator<short> stateValidator, short value)
			=> stateValidator.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short> InRange(this OptionalStateValidator<short> stateValidator, short? lessThan = null, short? lessThanOrEqualTo = null, short? greaterThan = null, short? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int16(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this OptionalStateValidator<ushort> stateValidator)
			=> stateValidator.Add(new EqualsValidator<ushort>(0));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this OptionalStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this OptionalStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this OptionalStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this OptionalStateValidator<ushort> stateValidator, ushort value)
			=> stateValidator.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this OptionalStateValidator<ushort> stateValidator, ushort? lessThan = null, ushort? lessThanOrEqualTo = null, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt16(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, EqualsValidator<int>, int> NotZero(this OptionalStateValidator<int> stateValidator)
			=> stateValidator.Add(new EqualsValidator<int>(0));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int> LessThan(this OptionalStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this OptionalStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this OptionalStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this OptionalStateValidator<int> stateValidator, int value)
			=> stateValidator.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int> InRange(this OptionalStateValidator<int> stateValidator, int? lessThan = null, int? lessThanOrEqualTo = null, int? greaterThan = null, int? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int32(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this OptionalStateValidator<uint> stateValidator)
			=> stateValidator.Add(new EqualsValidator<uint>(0));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this OptionalStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this OptionalStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this OptionalStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this OptionalStateValidator<uint> stateValidator, uint value)
			=> stateValidator.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this OptionalStateValidator<uint> stateValidator, uint? lessThan = null, uint? lessThanOrEqualTo = null, uint? greaterThan = null, uint? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt32(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, EqualsValidator<long>, long> NotZero(this OptionalStateValidator<long> stateValidator)
			=> stateValidator.Add(new EqualsValidator<long>(0));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long> LessThan(this OptionalStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this OptionalStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this OptionalStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this OptionalStateValidator<long> stateValidator, long value)
			=> stateValidator.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long> InRange(this OptionalStateValidator<long> stateValidator, long? lessThan = null, long? lessThanOrEqualTo = null, long? greaterThan = null, long? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Int64(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this OptionalStateValidator<ulong> stateValidator)
			=> stateValidator.Add(new EqualsValidator<ulong>(0));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this OptionalStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this OptionalStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this OptionalStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this OptionalStateValidator<ulong> stateValidator, ulong value)
			=> stateValidator.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this OptionalStateValidator<ulong> stateValidator, ulong? lessThan = null, ulong? lessThanOrEqualTo = null, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_UInt64(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, EqualsValidator<float>, float> NotZero(this OptionalStateValidator<float> stateValidator)
			=> stateValidator.Add(new EqualsValidator<float>(0));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float> LessThan(this OptionalStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this OptionalStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float> GreaterThan(this OptionalStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this OptionalStateValidator<float> stateValidator, float value)
			=> stateValidator.Add(new RangeValidator_Single(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float> InRange(this OptionalStateValidator<float> stateValidator, float? lessThan = null, float? lessThanOrEqualTo = null, float? greaterThan = null, float? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Single(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, EqualsValidator<double>, double> NotZero(this OptionalStateValidator<double> stateValidator)
			=> stateValidator.Add(new EqualsValidator<double>(0));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double> LessThan(this OptionalStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this OptionalStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double> GreaterThan(this OptionalStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this OptionalStateValidator<double> stateValidator, double value)
			=> stateValidator.Add(new RangeValidator_Double(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double> InRange(this OptionalStateValidator<double> stateValidator, double? lessThan = null, double? lessThanOrEqualTo = null, double? greaterThan = null, double? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Double(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this OptionalStateValidator<decimal> stateValidator)
			=> stateValidator.Add(new EqualsValidator<decimal>(0));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this OptionalStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this OptionalStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this OptionalStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this OptionalStateValidator<decimal> stateValidator, decimal value)
			=> stateValidator.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this OptionalStateValidator<decimal> stateValidator, decimal? lessThan = null, decimal? lessThanOrEqualTo = null, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_Decimal(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this OptionalStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this OptionalStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this OptionalStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this OptionalStateValidator<DateTime> stateValidator, DateTime value)
			=> stateValidator.Add(new RangeValidator_DateTime(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this OptionalStateValidator<DateTime> stateValidator, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null)
			=> stateValidator.Add(new RangeValidator_DateTime(lessThan, lessThanOrEqualTo, greaterThan, greaterThanOrEqualTo));

	}
}