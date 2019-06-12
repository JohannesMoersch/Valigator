using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredNullableStateValidatorExtensions
	{
		public static NullableDataSourceInverted<RequiredNullableStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this RequiredNullableStateValidator<TValue> source, Func<RequiredNullableStateValidator<TValue>, NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this RequiredNullableStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> EqualTo<TValue>(this RequiredNullableStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this RequiredNullableStateValidator<string> source)
			=> source.Add(new EqualsValidator<string>(String.Empty));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this RequiredNullableStateValidator<Guid> source)
			=> source.Add(new EqualsValidator<Guid>(Guid.Empty));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this RequiredNullableStateValidator<byte> source)
			=> source.Add(new EqualsValidator<byte>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this RequiredNullableStateValidator<sbyte> source)
			=> source.Add(new EqualsValidator<sbyte>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<short>, EqualsValidator<short>, short> NotZero(this RequiredNullableStateValidator<short> source)
			=> source.Add(new EqualsValidator<short>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this RequiredNullableStateValidator<ushort> source)
			=> source.Add(new EqualsValidator<ushort>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<int>, EqualsValidator<int>, int> NotZero(this RequiredNullableStateValidator<int> source)
			=> source.Add(new EqualsValidator<int>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this RequiredNullableStateValidator<uint> source)
			=> source.Add(new EqualsValidator<uint>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<long>, EqualsValidator<long>, long> NotZero(this RequiredNullableStateValidator<long> source)
			=> source.Add(new EqualsValidator<long>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this RequiredNullableStateValidator<ulong> source)
			=> source.Add(new EqualsValidator<ulong>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<float>, EqualsValidator<float>, float> NotZero(this RequiredNullableStateValidator<float> source)
			=> source.Add(new EqualsValidator<float>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<double>, EqualsValidator<double>, double> NotZero(this RequiredNullableStateValidator<double> source)
			=> source.Add(new EqualsValidator<double>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this RequiredNullableStateValidator<decimal> source)
			=> source.Add(new EqualsValidator<decimal>(0));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredNullableStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredNullableStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> Precision(this RequiredNullableStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this RequiredNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this RequiredNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this RequiredNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this RequiredNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> InRange(this RequiredNullableStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this RequiredNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this RequiredNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this RequiredNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this RequiredNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this RequiredNullableStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this RequiredNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this RequiredNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> LessThan(this RequiredNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this RequiredNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> InRange(this RequiredNullableStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this RequiredNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this RequiredNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this RequiredNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this RequiredNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this RequiredNullableStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this RequiredNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this RequiredNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> LessThan(this RequiredNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this RequiredNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> InRange(this RequiredNullableStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this RequiredNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this RequiredNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this RequiredNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this RequiredNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this RequiredNullableStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this RequiredNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this RequiredNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> LessThan(this RequiredNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this RequiredNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> InRange(this RequiredNullableStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this RequiredNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this RequiredNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this RequiredNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this RequiredNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this RequiredNullableStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, float> GreaterThan(this RequiredNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this RequiredNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, float> LessThan(this RequiredNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this RequiredNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, float> InRange(this RequiredNullableStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, double> GreaterThan(this RequiredNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this RequiredNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, double> LessThan(this RequiredNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this RequiredNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, double> InRange(this RequiredNullableStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this RequiredNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this RequiredNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this RequiredNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this RequiredNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this RequiredNullableStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this RequiredNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this RequiredNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this RequiredNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this RequiredNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this RequiredNullableStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<string>, StringLengthValidator, string> Length(this RequiredNullableStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<TValue>, EqualsValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<TValue>, EqualsValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceInverted<RequiredNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceInverted<RequiredNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceInverted<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceInverted<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThan(this NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThan(this NullableDataSourceInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThan(this NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThan(this NullableDataSourceInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> InRange(this NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> InRange(this NullableDataSourceInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, decimal>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, short>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, int>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, long>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, CustomValidator<float>, float> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, CustomValidator<float>, float> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<float>, RangeValidator_Single, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<float>, RangeValidator_Single, TValueValidator, float> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, float> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, float>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, TValueValidator, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<float>, RangeValidator_Single, TValueValidator, float> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<float>, RangeValidator_Single, float> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<float>, RangeValidator_Single, float>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<float>, RangeValidator_Single, TValueValidator, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, CustomValidator<double>, double> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, CustomValidator<double>, double> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<double>, RangeValidator_Double, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<double>, RangeValidator_Double, TValueValidator, double> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, double> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, double>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, TValueValidator, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<double>, RangeValidator_Double, TValueValidator, double> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<double>, RangeValidator_Double, double> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<double>, RangeValidator_Double, double>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<double>, RangeValidator_Double, TValueValidator, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> Precision(this NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> Precision(this NullableDataSourceInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, decimal>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, CustomValidator<DateTime>, DateTime> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, CustomValidator<DateTime>, DateTime> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<string>, StringLengthValidator, CustomValidator<string>, string> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<string>, StringLengthValidator, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<string>, StringLengthValidator, CustomValidator<string>, string> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<string>, StringLengthValidator, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<string>, StringLengthValidator, TValueValidator, string> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<string>, StringLengthValidator, string> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<string>, StringLengthValidator, string>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<string>, StringLengthValidator, TValueValidator, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<string>, StringLengthValidator, TValueValidator, string> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<string>, StringLengthValidator, string> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<string>, StringLengthValidator, string>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<string>, StringLengthValidator, TValueValidator, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}