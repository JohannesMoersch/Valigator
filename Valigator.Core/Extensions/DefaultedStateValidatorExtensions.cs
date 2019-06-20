using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedStateValidatorExtensions
	{
		public static DataSourceInverted<DefaultedStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this DefaultedStateValidator<TValue> source, Func<DefaultedStateValidator<TValue>, DataSourceStandard<DefaultedStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<DefaultedStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this DefaultedStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, TValue> EqualTo<TValue>(this DefaultedStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceInverted<DefaultedStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this DefaultedStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<DefaultedStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this DefaultedStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<DefaultedStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this DefaultedStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<DefaultedStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this DefaultedStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<DefaultedStateValidator<short>, EqualsValidator<short>, short> NotZero(this DefaultedStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<DefaultedStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this DefaultedStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<DefaultedStateValidator<int>, EqualsValidator<int>, int> NotZero(this DefaultedStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<DefaultedStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this DefaultedStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<DefaultedStateValidator<long>, EqualsValidator<long>, long> NotZero(this DefaultedStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<DefaultedStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this DefaultedStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<DefaultedStateValidator<float>, EqualsValidator<float>, float> NotZero(this DefaultedStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<DefaultedStateValidator<double>, EqualsValidator<double>, double> NotZero(this DefaultedStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<DefaultedStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this DefaultedStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> Precision(this DefaultedStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this DefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this DefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this DefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this DefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> InRange(this DefaultedStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this DefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this DefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this DefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this DefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this DefaultedStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this DefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this DefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short> LessThan(this DefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this DefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short> InRange(this DefaultedStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this DefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this DefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this DefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this DefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this DefaultedStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this DefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this DefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int> LessThan(this DefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this DefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int> InRange(this DefaultedStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this DefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this DefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this DefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this DefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this DefaultedStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this DefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this DefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long> LessThan(this DefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this DefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long> InRange(this DefaultedStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this DefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this DefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this DefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this DefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this DefaultedStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float> GreaterThan(this DefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this DefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float> LessThan(this DefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this DefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float> InRange(this DefaultedStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double> GreaterThan(this DefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this DefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double> LessThan(this DefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this DefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double> InRange(this DefaultedStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this DefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this DefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this DefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this DefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this DefaultedStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this DefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this DefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this DefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this DefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this DefaultedStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<string>, StringLengthValidator, string> Length(this DefaultedStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandardStandard<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this DataSourceStandard<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this DataSourceInverted<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this DataSourceStandard<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, Func<DataSourceStandard<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, TValue>, DataSourceStandardStandard<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this DataSourceInverted<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, Func<DataSourceInverted<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, TValue>, DataSourceInvertedStandard<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this DataSourceStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this DataSourceInverted<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this DataSourceStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue> source, Func<DataSourceStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue>, DataSourceStandardStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this DataSourceInverted<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue> source, Func<DataSourceInverted<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue>, DataSourceInvertedStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<decimal>, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this DataSourceStandard<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<decimal>, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this DataSourceInverted<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThan(this DataSourceStandard<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThan(this DataSourceInverted<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this DataSourceStandard<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this DataSourceInverted<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThan(this DataSourceStandard<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThan(this DataSourceInverted<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this DataSourceStandard<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceInvertedStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this DataSourceInverted<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandardStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> InRange(this DataSourceStandard<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> InRange(this DataSourceInverted<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DefaultedStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this DataSourceStandard<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> source, Func<DataSourceStandard<DefaultedStateValidator<decimal>, PrecisionValidator, decimal>, DataSourceStandardStandard<DefaultedStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this DataSourceInverted<DefaultedStateValidator<decimal>, PrecisionValidator, decimal> source, Func<DataSourceInverted<DefaultedStateValidator<decimal>, PrecisionValidator, decimal>, DataSourceInvertedStandard<DefaultedStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this DataSourceStandardStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this DataSourceInvertedStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this DataSourceStandardInverted<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this DataSourceInvertedInverted<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<DataSourceStandardStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, DataSourceStandardStandardStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, DataSourceInvertedStandardStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<DataSourceStandardInverted<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, DataSourceStandardInvertedStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this DataSourceInverted<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> source, Func<DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte>, DataSourceStandardStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this DataSourceInverted<DefaultedStateValidator<byte>, RangeValidator_Byte, byte> source, Func<DataSourceInverted<DefaultedStateValidator<byte>, RangeValidator_Byte, byte>, DataSourceInvertedStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this DataSourceInverted<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte>, DataSourceStandardStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this DataSourceInverted<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<DataSourceInverted<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte>, DataSourceInvertedStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this DataSourceInverted<DefaultedStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short> source, Func<DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short>, DataSourceStandardStandard<DefaultedStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this DataSourceInverted<DefaultedStateValidator<short>, RangeValidator_Int16, short> source, Func<DataSourceInverted<DefaultedStateValidator<short>, RangeValidator_Int16, short>, DataSourceInvertedStandard<DefaultedStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this DataSourceInverted<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort>, DataSourceStandardStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this DataSourceInverted<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<DataSourceInverted<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort>, DataSourceInvertedStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this DataSourceInverted<DefaultedStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int> source, Func<DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int>, DataSourceStandardStandard<DefaultedStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this DataSourceInverted<DefaultedStateValidator<int>, RangeValidator_Int32, int> source, Func<DataSourceInverted<DefaultedStateValidator<int>, RangeValidator_Int32, int>, DataSourceInvertedStandard<DefaultedStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this DataSourceInverted<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint>, DataSourceStandardStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this DataSourceInverted<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<DataSourceInverted<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint>, DataSourceInvertedStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this DataSourceInverted<DefaultedStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long> source, Func<DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long>, DataSourceStandardStandard<DefaultedStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this DataSourceInverted<DefaultedStateValidator<long>, RangeValidator_Int64, long> source, Func<DataSourceInverted<DefaultedStateValidator<long>, RangeValidator_Int64, long>, DataSourceInvertedStandard<DefaultedStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this DataSourceInverted<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong>, DataSourceStandardStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this DataSourceInverted<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<DataSourceInverted<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong>, DataSourceInvertedStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<float>, RangeValidator_Single, CustomValidator<float>, float> Assert(this DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<float>, RangeValidator_Single, CustomValidator<float>, float> Assert(this DataSourceInverted<DefaultedStateValidator<float>, RangeValidator_Single, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<float>, RangeValidator_Single, TValueValidator, float> Not<TValueValidator>(this DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float> source, Func<DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float>, DataSourceStandardStandard<DefaultedStateValidator<float>, RangeValidator_Single, TValueValidator, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<float>, RangeValidator_Single, TValueValidator, float> Not<TValueValidator>(this DataSourceInverted<DefaultedStateValidator<float>, RangeValidator_Single, float> source, Func<DataSourceInverted<DefaultedStateValidator<float>, RangeValidator_Single, float>, DataSourceInvertedStandard<DefaultedStateValidator<float>, RangeValidator_Single, TValueValidator, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<double>, RangeValidator_Double, CustomValidator<double>, double> Assert(this DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<double>, RangeValidator_Double, CustomValidator<double>, double> Assert(this DataSourceInverted<DefaultedStateValidator<double>, RangeValidator_Double, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<double>, RangeValidator_Double, TValueValidator, double> Not<TValueValidator>(this DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double> source, Func<DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double>, DataSourceStandardStandard<DefaultedStateValidator<double>, RangeValidator_Double, TValueValidator, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<double>, RangeValidator_Double, TValueValidator, double> Not<TValueValidator>(this DataSourceInverted<DefaultedStateValidator<double>, RangeValidator_Double, double> source, Func<DataSourceInverted<DefaultedStateValidator<double>, RangeValidator_Double, double>, DataSourceInvertedStandard<DefaultedStateValidator<double>, RangeValidator_Double, TValueValidator, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this DataSourceInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> Precision(this DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceInvertedStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> Precision(this DataSourceInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandardInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> source, Func<DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal>, DataSourceStandardStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this DataSourceInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal> source, Func<DataSourceInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal>, DataSourceInvertedStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this DataSourceStandardStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this DataSourceInvertedStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this DataSourceStandardInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this DataSourceInvertedInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<DataSourceStandardStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, DataSourceStandardStandardStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, DataSourceInvertedStandardStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<DataSourceStandardInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, DataSourceStandardInvertedStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, CustomValidator<DateTime>, DateTime> Assert(this DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, CustomValidator<DateTime>, DateTime> Assert(this DataSourceInverted<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime> Not<TValueValidator>(this DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, Func<DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime>, DataSourceStandardStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime> Not<TValueValidator>(this DataSourceInverted<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, Func<DataSourceInverted<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime>, DataSourceInvertedStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<string>, StringLengthValidator, CustomValidator<string>, string> Assert(this DataSourceStandard<DefaultedStateValidator<string>, StringLengthValidator, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<string>, StringLengthValidator, CustomValidator<string>, string> Assert(this DataSourceInverted<DefaultedStateValidator<string>, StringLengthValidator, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<string>, StringLengthValidator, TValueValidator, string> Not<TValueValidator>(this DataSourceStandard<DefaultedStateValidator<string>, StringLengthValidator, string> source, Func<DataSourceStandard<DefaultedStateValidator<string>, StringLengthValidator, string>, DataSourceStandardStandard<DefaultedStateValidator<string>, StringLengthValidator, TValueValidator, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<string>, StringLengthValidator, TValueValidator, string> Not<TValueValidator>(this DataSourceInverted<DefaultedStateValidator<string>, StringLengthValidator, string> source, Func<DataSourceInverted<DefaultedStateValidator<string>, StringLengthValidator, string>, DataSourceInvertedStandard<DefaultedStateValidator<string>, StringLengthValidator, TValueValidator, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}