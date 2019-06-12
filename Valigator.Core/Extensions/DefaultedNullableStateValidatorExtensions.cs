using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedNullableStateValidatorExtensions
	{
		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this DefaultedNullableStateValidator<TValue> source, Func<DefaultedNullableStateValidator<TValue>, NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this DefaultedNullableStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> EqualTo<TValue>(this DefaultedNullableStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this DefaultedNullableStateValidator<string> source)
			=> source.Add(new EqualsValidator<string>(String.Empty));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this DefaultedNullableStateValidator<Guid> source)
			=> source.Add(new EqualsValidator<Guid>(Guid.Empty));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this DefaultedNullableStateValidator<byte> source)
			=> source.Add(new EqualsValidator<byte>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this DefaultedNullableStateValidator<sbyte> source)
			=> source.Add(new EqualsValidator<sbyte>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, EqualsValidator<short>, short> NotZero(this DefaultedNullableStateValidator<short> source)
			=> source.Add(new EqualsValidator<short>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this DefaultedNullableStateValidator<ushort> source)
			=> source.Add(new EqualsValidator<ushort>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, EqualsValidator<int>, int> NotZero(this DefaultedNullableStateValidator<int> source)
			=> source.Add(new EqualsValidator<int>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this DefaultedNullableStateValidator<uint> source)
			=> source.Add(new EqualsValidator<uint>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, EqualsValidator<long>, long> NotZero(this DefaultedNullableStateValidator<long> source)
			=> source.Add(new EqualsValidator<long>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this DefaultedNullableStateValidator<ulong> source)
			=> source.Add(new EqualsValidator<ulong>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, EqualsValidator<float>, float> NotZero(this DefaultedNullableStateValidator<float> source)
			=> source.Add(new EqualsValidator<float>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, EqualsValidator<double>, double> NotZero(this DefaultedNullableStateValidator<double> source)
			=> source.Add(new EqualsValidator<double>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this DefaultedNullableStateValidator<decimal> source)
			=> source.Add(new EqualsValidator<decimal>(0));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedNullableStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedNullableStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> Precision(this DefaultedNullableStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this DefaultedNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this DefaultedNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this DefaultedNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> InRange(this DefaultedNullableStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this DefaultedNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this DefaultedNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this DefaultedNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this DefaultedNullableStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this DefaultedNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> LessThan(this DefaultedNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this DefaultedNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> InRange(this DefaultedNullableStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this DefaultedNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this DefaultedNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this DefaultedNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this DefaultedNullableStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this DefaultedNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> LessThan(this DefaultedNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this DefaultedNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> InRange(this DefaultedNullableStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this DefaultedNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this DefaultedNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this DefaultedNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this DefaultedNullableStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this DefaultedNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> LessThan(this DefaultedNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this DefaultedNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> InRange(this DefaultedNullableStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this DefaultedNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this DefaultedNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this DefaultedNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this DefaultedNullableStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> GreaterThan(this DefaultedNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> LessThan(this DefaultedNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this DefaultedNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> InRange(this DefaultedNullableStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> GreaterThan(this DefaultedNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> LessThan(this DefaultedNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this DefaultedNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> InRange(this DefaultedNullableStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this DefaultedNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this DefaultedNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this DefaultedNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this DefaultedNullableStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this DefaultedNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this DefaultedNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this DefaultedNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this DefaultedNullableStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<string>, StringLengthValidator, string> Length(this DefaultedNullableStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> InRange(this NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> InRange(this NullableDataSourceInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, CustomValidator<float>, float> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, CustomValidator<float>, float> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<float>, RangeValidator_Single, TValueValidator, float> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, TValueValidator, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<float>, RangeValidator_Single, TValueValidator, float> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<float>, RangeValidator_Single, float> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<float>, RangeValidator_Single, float>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, TValueValidator, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, CustomValidator<double>, double> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, CustomValidator<double>, double> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<double>, RangeValidator_Double, TValueValidator, double> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, TValueValidator, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<double>, RangeValidator_Double, TValueValidator, double> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<double>, RangeValidator_Double, double> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<double>, RangeValidator_Double, double>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, TValueValidator, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> Precision(this NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> Precision(this NullableDataSourceInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, CustomValidator<DateTime>, DateTime> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, CustomValidator<DateTime>, DateTime> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<string>, StringLengthValidator, CustomValidator<string>, string> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<string>, StringLengthValidator, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<string>, StringLengthValidator, CustomValidator<string>, string> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<string>, StringLengthValidator, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<string>, StringLengthValidator, TValueValidator, string> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<string>, StringLengthValidator, string> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<string>, StringLengthValidator, string>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<string>, StringLengthValidator, TValueValidator, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<string>, StringLengthValidator, TValueValidator, string> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<string>, StringLengthValidator, string> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<string>, StringLengthValidator, string>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<string>, StringLengthValidator, TValueValidator, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}