using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredStateValidatorExtensions
	{
		public static DataSourceInverted<RequiredStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this RequiredStateValidator<TValue> source, Func<RequiredStateValidator<TValue>, DataSourceStandard<RequiredStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<RequiredStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this RequiredStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValue> EqualTo<TValue>(this RequiredStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceInverted<RequiredStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this RequiredStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<RequiredStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this RequiredStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<RequiredStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this RequiredStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<RequiredStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this RequiredStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<RequiredStateValidator<short>, EqualsValidator<short>, short> NotZero(this RequiredStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<RequiredStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this RequiredStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<RequiredStateValidator<int>, EqualsValidator<int>, int> NotZero(this RequiredStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<RequiredStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this RequiredStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<RequiredStateValidator<long>, EqualsValidator<long>, long> NotZero(this RequiredStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<RequiredStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this RequiredStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<RequiredStateValidator<float>, EqualsValidator<float>, float> NotZero(this RequiredStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<RequiredStateValidator<double>, EqualsValidator<double>, double> NotZero(this RequiredStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<RequiredStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this RequiredStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> MultipleOf(this RequiredStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> MultipleOf(this RequiredStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> MultipleOf(this RequiredStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> MultipleOf(this RequiredStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> MultipleOf(this RequiredStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> MultipleOf(this RequiredStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> MultipleOf(this RequiredStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> MultipleOf(this RequiredStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal> Precision(this RequiredStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this RequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this RequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this RequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this RequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> InRange(this RequiredStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this RequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this RequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this RequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this RequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this RequiredStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this RequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this RequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> LessThan(this RequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this RequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> InRange(this RequiredStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this RequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this RequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this RequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this RequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this RequiredStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this RequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this RequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> LessThan(this RequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this RequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> InRange(this RequiredStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this RequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this RequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this RequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this RequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this RequiredStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this RequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this RequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> LessThan(this RequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this RequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> InRange(this RequiredStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this RequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this RequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this RequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this RequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this RequiredStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> GreaterThan(this RequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this RequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> LessThan(this RequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this RequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> InRange(this RequiredStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> GreaterThan(this RequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this RequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> LessThan(this RequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this RequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> InRange(this RequiredStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this RequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this RequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this RequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this RequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this RequiredStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this RequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this RequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this RequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this RequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this RequiredStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<string>, StringLengthValidator, string> Length(this RequiredStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandardStandard<RequiredStateValidator<TValue>, EqualsValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this DataSourceStandard<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TValue>, EqualsValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this DataSourceInverted<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this DataSourceStandard<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, Func<DataSourceStandard<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValue>, DataSourceStandardStandard<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this DataSourceInverted<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, Func<DataSourceInverted<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValue>, DataSourceInvertedStandard<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this DataSourceInverted<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue> source, Func<DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue>, DataSourceStandardStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this DataSourceInverted<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue> source, Func<DataSourceInverted<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue>, DataSourceInvertedStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this DataSourceStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this DataSourceInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThan(this DataSourceStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThan(this DataSourceInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThan(this DataSourceStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThan(this DataSourceInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> InRange(this DataSourceStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> InRange(this DataSourceInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> source, Func<DataSourceStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte>, DataSourceStandardStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte> source, Func<DataSourceInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte>, DataSourceInvertedStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this DataSourceStandardStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this DataSourceInvertedStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this DataSourceStandardInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this DataSourceInvertedInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<DataSourceStandardStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, DataSourceStandardStandardStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<DataSourceInvertedStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, DataSourceInvertedStandardStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<DataSourceStandardInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, DataSourceStandardInvertedStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<DataSourceInvertedInverted<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, DataSourceInvertedInvertedStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this DataSourceStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this DataSourceInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThan(this DataSourceStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThan(this DataSourceInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThan(this DataSourceStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThan(this DataSourceInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> InRange(this DataSourceStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> InRange(this DataSourceInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, Func<DataSourceStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte>, DataSourceStandardStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, Func<DataSourceInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte>, DataSourceInvertedStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this DataSourceStandardStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this DataSourceInvertedStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this DataSourceStandardInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this DataSourceInvertedInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<DataSourceStandardStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, DataSourceStandardStandardStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<DataSourceInvertedStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, DataSourceInvertedStandardStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<DataSourceStandardInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, DataSourceStandardInvertedStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<DataSourceInvertedInverted<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, DataSourceInvertedInvertedStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this DataSourceStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this DataSourceInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThan(this DataSourceStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThan(this DataSourceInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThan(this DataSourceStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThan(this DataSourceInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> InRange(this DataSourceStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> InRange(this DataSourceInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> source, Func<DataSourceStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, short>, DataSourceStandardStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, short> source, Func<DataSourceInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, short>, DataSourceInvertedStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this DataSourceStandardStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this DataSourceInvertedStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this DataSourceStandardInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this DataSourceInvertedInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<DataSourceStandardStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, DataSourceStandardStandardStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<DataSourceInvertedStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, DataSourceInvertedStandardStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<DataSourceStandardInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, DataSourceStandardInvertedStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<DataSourceInvertedInverted<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, DataSourceInvertedInvertedStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this DataSourceStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this DataSourceInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThan(this DataSourceStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThan(this DataSourceInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThan(this DataSourceStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThan(this DataSourceInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> InRange(this DataSourceStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> InRange(this DataSourceInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, Func<DataSourceStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort>, DataSourceStandardStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, Func<DataSourceInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort>, DataSourceInvertedStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this DataSourceStandardStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this DataSourceInvertedStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this DataSourceStandardInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this DataSourceInvertedInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<DataSourceStandardStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, DataSourceStandardStandardStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<DataSourceInvertedStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, DataSourceInvertedStandardStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<DataSourceStandardInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, DataSourceStandardInvertedStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<DataSourceInvertedInverted<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, DataSourceInvertedInvertedStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this DataSourceStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this DataSourceInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThan(this DataSourceStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThan(this DataSourceInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThan(this DataSourceStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThan(this DataSourceInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> InRange(this DataSourceStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> InRange(this DataSourceInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> source, Func<DataSourceStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, int>, DataSourceStandardStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, int> source, Func<DataSourceInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, int>, DataSourceInvertedStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this DataSourceStandardStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this DataSourceInvertedStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this DataSourceStandardInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this DataSourceInvertedInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<DataSourceStandardStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, DataSourceStandardStandardStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<DataSourceInvertedStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, DataSourceInvertedStandardStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<DataSourceStandardInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, DataSourceStandardInvertedStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<DataSourceInvertedInverted<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, DataSourceInvertedInvertedStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this DataSourceStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this DataSourceInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThan(this DataSourceStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThan(this DataSourceInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThan(this DataSourceStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThan(this DataSourceInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> InRange(this DataSourceStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> InRange(this DataSourceInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, Func<DataSourceStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint>, DataSourceStandardStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, Func<DataSourceInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint>, DataSourceInvertedStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this DataSourceStandardStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this DataSourceInvertedStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this DataSourceStandardInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this DataSourceInvertedInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<DataSourceStandardStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, DataSourceStandardStandardStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<DataSourceInvertedStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, DataSourceInvertedStandardStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<DataSourceStandardInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, DataSourceStandardInvertedStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<DataSourceInvertedInverted<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, DataSourceInvertedInvertedStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this DataSourceStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this DataSourceInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThan(this DataSourceStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThan(this DataSourceInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThan(this DataSourceStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThan(this DataSourceInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> InRange(this DataSourceStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> InRange(this DataSourceInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> source, Func<DataSourceStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, long>, DataSourceStandardStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, long> source, Func<DataSourceInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, long>, DataSourceInvertedStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this DataSourceStandardStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this DataSourceInvertedStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this DataSourceStandardInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this DataSourceInvertedInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<DataSourceStandardStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, DataSourceStandardStandardStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<DataSourceInvertedStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, DataSourceInvertedStandardStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<DataSourceStandardInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, DataSourceStandardInvertedStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<DataSourceInvertedInverted<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, DataSourceInvertedInvertedStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this DataSourceStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this DataSourceInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThan(this DataSourceStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThan(this DataSourceInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThan(this DataSourceStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThan(this DataSourceInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> InRange(this DataSourceStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> InRange(this DataSourceInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, Func<DataSourceStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong>, DataSourceStandardStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, Func<DataSourceInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong>, DataSourceInvertedStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this DataSourceStandardStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this DataSourceInvertedStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this DataSourceStandardInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this DataSourceInvertedInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<DataSourceStandardStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, DataSourceStandardStandardStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<DataSourceInvertedStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, DataSourceInvertedStandardStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<DataSourceStandardInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, DataSourceStandardInvertedStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<DataSourceInvertedInverted<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, DataSourceInvertedInvertedStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<decimal>, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<decimal>, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this DataSourceInverted<RequiredStateValidator<decimal>, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThan(this DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThan(this DataSourceInverted<RequiredStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThan(this DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThan(this DataSourceInverted<RequiredStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this DataSourceInverted<RequiredStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> InRange(this DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> InRange(this DataSourceInverted<RequiredStateValidator<decimal>, PrecisionValidator, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal> source, Func<DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal>, DataSourceStandardStandard<RequiredStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<decimal>, PrecisionValidator, decimal> source, Func<DataSourceInverted<RequiredStateValidator<decimal>, PrecisionValidator, decimal>, DataSourceInvertedStandard<RequiredStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this DataSourceStandardStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this DataSourceInvertedStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this DataSourceStandardInverted<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this DataSourceInvertedInverted<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<DataSourceStandardStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, DataSourceStandardStandardStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<DataSourceInvertedStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, DataSourceInvertedStandardStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<DataSourceStandardInverted<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, DataSourceStandardInvertedStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<DataSourceInvertedInverted<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, DataSourceInvertedInvertedStandard<RequiredStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<byte>, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<byte>, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this DataSourceInverted<RequiredStateValidator<byte>, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> MultipleOf(this DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> MultipleOf(this DataSourceInverted<RequiredStateValidator<byte>, RangeValidator_Byte, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte> source, Func<DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte>, DataSourceStandardStandard<RequiredStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<byte>, RangeValidator_Byte, byte> source, Func<DataSourceInverted<RequiredStateValidator<byte>, RangeValidator_Byte, byte>, DataSourceInvertedStandard<RequiredStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this DataSourceStandardStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this DataSourceInvertedStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this DataSourceStandardInverted<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this DataSourceInvertedInverted<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<DataSourceStandardStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, DataSourceStandardStandardStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<DataSourceInvertedStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, DataSourceInvertedStandardStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<DataSourceStandardInverted<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, DataSourceStandardInvertedStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<DataSourceInvertedInverted<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, DataSourceInvertedInvertedStandard<RequiredStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this DataSourceInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> MultipleOf(this DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> MultipleOf(this DataSourceInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte>, DataSourceStandardStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<DataSourceInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte>, DataSourceInvertedStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this DataSourceStandardStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this DataSourceInvertedStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this DataSourceStandardInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this DataSourceInvertedInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<DataSourceStandardStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, DataSourceStandardStandardStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<DataSourceInvertedStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, DataSourceInvertedStandardStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<DataSourceStandardInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, DataSourceStandardInvertedStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<DataSourceInvertedInverted<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, DataSourceInvertedInvertedStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this DataSourceInverted<RequiredStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> MultipleOf(this DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> MultipleOf(this DataSourceInverted<RequiredStateValidator<short>, RangeValidator_Int16, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short> source, Func<DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short>, DataSourceStandardStandard<RequiredStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<short>, RangeValidator_Int16, short> source, Func<DataSourceInverted<RequiredStateValidator<short>, RangeValidator_Int16, short>, DataSourceInvertedStandard<RequiredStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this DataSourceStandardStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this DataSourceInvertedStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this DataSourceStandardInverted<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this DataSourceInvertedInverted<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<DataSourceStandardStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, DataSourceStandardStandardStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<DataSourceInvertedStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, DataSourceInvertedStandardStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<DataSourceStandardInverted<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, DataSourceStandardInvertedStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<DataSourceInvertedInverted<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, DataSourceInvertedInvertedStandard<RequiredStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this DataSourceInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> MultipleOf(this DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> MultipleOf(this DataSourceInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort>, DataSourceStandardStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<DataSourceInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort>, DataSourceInvertedStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this DataSourceStandardStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this DataSourceInvertedStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this DataSourceStandardInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this DataSourceInvertedInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<DataSourceStandardStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, DataSourceStandardStandardStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<DataSourceInvertedStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, DataSourceInvertedStandardStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<DataSourceStandardInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, DataSourceStandardInvertedStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<DataSourceInvertedInverted<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, DataSourceInvertedInvertedStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this DataSourceInverted<RequiredStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> MultipleOf(this DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> MultipleOf(this DataSourceInverted<RequiredStateValidator<int>, RangeValidator_Int32, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int> source, Func<DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int>, DataSourceStandardStandard<RequiredStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<int>, RangeValidator_Int32, int> source, Func<DataSourceInverted<RequiredStateValidator<int>, RangeValidator_Int32, int>, DataSourceInvertedStandard<RequiredStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this DataSourceStandardStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this DataSourceInvertedStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this DataSourceStandardInverted<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this DataSourceInvertedInverted<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<DataSourceStandardStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, DataSourceStandardStandardStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<DataSourceInvertedStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, DataSourceInvertedStandardStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<DataSourceStandardInverted<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, DataSourceStandardInvertedStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<DataSourceInvertedInverted<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, DataSourceInvertedInvertedStandard<RequiredStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this DataSourceInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> MultipleOf(this DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> MultipleOf(this DataSourceInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint>, DataSourceStandardStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<DataSourceInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, uint>, DataSourceInvertedStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this DataSourceStandardStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this DataSourceInvertedStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this DataSourceStandardInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this DataSourceInvertedInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<DataSourceStandardStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, DataSourceStandardStandardStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<DataSourceInvertedStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, DataSourceInvertedStandardStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<DataSourceStandardInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, DataSourceStandardInvertedStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<DataSourceInvertedInverted<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, DataSourceInvertedInvertedStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this DataSourceInverted<RequiredStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> MultipleOf(this DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> MultipleOf(this DataSourceInverted<RequiredStateValidator<long>, RangeValidator_Int64, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long> source, Func<DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long>, DataSourceStandardStandard<RequiredStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<long>, RangeValidator_Int64, long> source, Func<DataSourceInverted<RequiredStateValidator<long>, RangeValidator_Int64, long>, DataSourceInvertedStandard<RequiredStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this DataSourceStandardStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this DataSourceInvertedStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this DataSourceStandardInverted<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this DataSourceInvertedInverted<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<DataSourceStandardStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, DataSourceStandardStandardStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<DataSourceInvertedStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, DataSourceInvertedStandardStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<DataSourceStandardInverted<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, DataSourceStandardInvertedStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<DataSourceInvertedInverted<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, DataSourceInvertedInvertedStandard<RequiredStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this DataSourceInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> MultipleOf(this DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> MultipleOf(this DataSourceInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong>, DataSourceStandardStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<DataSourceInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong>, DataSourceInvertedStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this DataSourceStandardStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this DataSourceInvertedStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this DataSourceStandardInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this DataSourceInvertedInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<DataSourceStandardStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, DataSourceStandardStandardStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<DataSourceInvertedStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, DataSourceInvertedStandardStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<DataSourceStandardInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, DataSourceStandardInvertedStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<DataSourceInvertedInverted<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, DataSourceInvertedInvertedStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<float>, RangeValidator_Single, CustomValidator<float>, float> Assert(this DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<float>, RangeValidator_Single, CustomValidator<float>, float> Assert(this DataSourceInverted<RequiredStateValidator<float>, RangeValidator_Single, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceStandardInverted<RequiredStateValidator<float>, RangeValidator_Single, TValueValidator, float> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float> source, Func<DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float>, DataSourceStandardStandard<RequiredStateValidator<float>, RangeValidator_Single, TValueValidator, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<float>, RangeValidator_Single, TValueValidator, float> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<float>, RangeValidator_Single, float> source, Func<DataSourceInverted<RequiredStateValidator<float>, RangeValidator_Single, float>, DataSourceInvertedStandard<RequiredStateValidator<float>, RangeValidator_Single, TValueValidator, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<RequiredStateValidator<double>, RangeValidator_Double, CustomValidator<double>, double> Assert(this DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<double>, RangeValidator_Double, CustomValidator<double>, double> Assert(this DataSourceInverted<RequiredStateValidator<double>, RangeValidator_Double, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceStandardInverted<RequiredStateValidator<double>, RangeValidator_Double, TValueValidator, double> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double> source, Func<DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double>, DataSourceStandardStandard<RequiredStateValidator<double>, RangeValidator_Double, TValueValidator, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<double>, RangeValidator_Double, TValueValidator, double> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<double>, RangeValidator_Double, double> source, Func<DataSourceInverted<RequiredStateValidator<double>, RangeValidator_Double, double>, DataSourceInvertedStandard<RequiredStateValidator<double>, RangeValidator_Double, TValueValidator, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this DataSourceInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> Precision(this DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceInvertedStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> Precision(this DataSourceInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandardInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> source, Func<DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal>, DataSourceStandardStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal> source, Func<DataSourceInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal>, DataSourceInvertedStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this DataSourceStandardStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this DataSourceInvertedStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this DataSourceStandardInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this DataSourceInvertedInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<DataSourceStandardStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, DataSourceStandardStandardStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<DataSourceInvertedStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, DataSourceInvertedStandardStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<DataSourceStandardInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, DataSourceStandardInvertedStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<DataSourceInvertedInverted<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, DataSourceInvertedInvertedStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, CustomValidator<DateTime>, DateTime> Assert(this DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, CustomValidator<DateTime>, DateTime> Assert(this DataSourceInverted<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceStandardInverted<RequiredStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, Func<DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime>, DataSourceStandardStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, Func<DataSourceInverted<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime>, DataSourceInvertedStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<RequiredStateValidator<string>, StringLengthValidator, CustomValidator<string>, string> Assert(this DataSourceStandard<RequiredStateValidator<string>, StringLengthValidator, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<string>, StringLengthValidator, CustomValidator<string>, string> Assert(this DataSourceInverted<RequiredStateValidator<string>, StringLengthValidator, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceStandardInverted<RequiredStateValidator<string>, StringLengthValidator, TValueValidator, string> Not<TValueValidator>(this DataSourceStandard<RequiredStateValidator<string>, StringLengthValidator, string> source, Func<DataSourceStandard<RequiredStateValidator<string>, StringLengthValidator, string>, DataSourceStandardStandard<RequiredStateValidator<string>, StringLengthValidator, TValueValidator, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<string>, StringLengthValidator, TValueValidator, string> Not<TValueValidator>(this DataSourceInverted<RequiredStateValidator<string>, StringLengthValidator, string> source, Func<DataSourceInverted<RequiredStateValidator<string>, StringLengthValidator, string>, DataSourceInvertedStandard<RequiredStateValidator<string>, StringLengthValidator, TValueValidator, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}