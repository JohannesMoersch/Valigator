using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalNullableStateValidatorExtensions
	{
		public static NullableDataSourceInverted<OptionalNullableStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this OptionalNullableStateValidator<TValue> source, Func<OptionalNullableStateValidator<TValue>, NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this OptionalNullableStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> EqualTo<TValue>(this OptionalNullableStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this OptionalNullableStateValidator<string> source)
			=> source.Add(new EqualsValidator<string>(String.Empty));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this OptionalNullableStateValidator<Guid> source)
			=> source.Add(new EqualsValidator<Guid>(Guid.Empty));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this OptionalNullableStateValidator<byte> source)
			=> source.Add(new EqualsValidator<byte>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this OptionalNullableStateValidator<sbyte> source)
			=> source.Add(new EqualsValidator<sbyte>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, EqualsValidator<short>, short> NotZero(this OptionalNullableStateValidator<short> source)
			=> source.Add(new EqualsValidator<short>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this OptionalNullableStateValidator<ushort> source)
			=> source.Add(new EqualsValidator<ushort>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, EqualsValidator<int>, int> NotZero(this OptionalNullableStateValidator<int> source)
			=> source.Add(new EqualsValidator<int>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this OptionalNullableStateValidator<uint> source)
			=> source.Add(new EqualsValidator<uint>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, EqualsValidator<long>, long> NotZero(this OptionalNullableStateValidator<long> source)
			=> source.Add(new EqualsValidator<long>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this OptionalNullableStateValidator<ulong> source)
			=> source.Add(new EqualsValidator<ulong>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, EqualsValidator<float>, float> NotZero(this OptionalNullableStateValidator<float> source)
			=> source.Add(new EqualsValidator<float>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, EqualsValidator<double>, double> NotZero(this OptionalNullableStateValidator<double> source)
			=> source.Add(new EqualsValidator<double>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this OptionalNullableStateValidator<decimal> source)
			=> source.Add(new EqualsValidator<decimal>(0));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this OptionalNullableStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this OptionalNullableStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> Precision(this OptionalNullableStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this OptionalNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this OptionalNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this OptionalNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this OptionalNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> InRange(this OptionalNullableStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this OptionalNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this OptionalNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this OptionalNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this OptionalNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this OptionalNullableStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this OptionalNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this OptionalNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> LessThan(this OptionalNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this OptionalNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> InRange(this OptionalNullableStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this OptionalNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this OptionalNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this OptionalNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this OptionalNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this OptionalNullableStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this OptionalNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this OptionalNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> LessThan(this OptionalNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this OptionalNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> InRange(this OptionalNullableStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this OptionalNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this OptionalNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this OptionalNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this OptionalNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this OptionalNullableStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this OptionalNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this OptionalNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> LessThan(this OptionalNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this OptionalNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> InRange(this OptionalNullableStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this OptionalNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this OptionalNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this OptionalNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this OptionalNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this OptionalNullableStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float> GreaterThan(this OptionalNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this OptionalNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float> LessThan(this OptionalNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this OptionalNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float> InRange(this OptionalNullableStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double> GreaterThan(this OptionalNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this OptionalNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double> LessThan(this OptionalNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this OptionalNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double> InRange(this OptionalNullableStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this OptionalNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this OptionalNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this OptionalNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this OptionalNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this OptionalNullableStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this OptionalNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this OptionalNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this OptionalNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this OptionalNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this OptionalNullableStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<string>, StringLengthValidator, string> Length(this OptionalNullableStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceInverted<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceInverted<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceInverted<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceInverted<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThan(this NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThan(this NullableDataSourceInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThan(this NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThan(this NullableDataSourceInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> InRange(this NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> InRange(this NullableDataSourceInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, short>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, int>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, long>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, CustomValidator<float>, float> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, CustomValidator<float>, float> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<float>, RangeValidator_Single, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<float>, RangeValidator_Single, TValueValidator, float> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, TValueValidator, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<float>, RangeValidator_Single, TValueValidator, float> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<float>, RangeValidator_Single, float> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<float>, RangeValidator_Single, float>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, TValueValidator, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, CustomValidator<double>, double> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, CustomValidator<double>, double> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<double>, RangeValidator_Double, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<double>, RangeValidator_Double, TValueValidator, double> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, TValueValidator, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<double>, RangeValidator_Double, TValueValidator, double> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<double>, RangeValidator_Double, double> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<double>, RangeValidator_Double, double>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, TValueValidator, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> Precision(this NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> Precision(this NullableDataSourceInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, CustomValidator<DateTime>, DateTime> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, CustomValidator<DateTime>, DateTime> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<string>, StringLengthValidator, CustomValidator<string>, string> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<string>, StringLengthValidator, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<string>, StringLengthValidator, CustomValidator<string>, string> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<string>, StringLengthValidator, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<string>, StringLengthValidator, TValueValidator, string> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<string>, StringLengthValidator, string> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<string>, StringLengthValidator, string>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<string>, StringLengthValidator, TValueValidator, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<string>, StringLengthValidator, TValueValidator, string> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<string>, StringLengthValidator, string> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<string>, StringLengthValidator, string>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<string>, StringLengthValidator, TValueValidator, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}