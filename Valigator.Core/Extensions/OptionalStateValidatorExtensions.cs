using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalStateValidatorExtensions
	{
		public static NullableDataSourceInverted<OptionalStateValidator<TSource>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this OptionalStateValidator<TSource> source, Func<OptionalStateValidator<TSource>, NullableDataSourceStandard<OptionalStateValidator<TSource>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, CustomValidator<TValue>, TValue, TValue> Assert<TValue>(this OptionalStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, EqualsValidator<TValue>, TValue, TValue> EqualTo<TValue>(this OptionalStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static NullableDataSourceInverted<OptionalStateValidator<string>, EqualsValidator<string>, string, string> NotEmpty(this OptionalStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static NullableDataSourceInverted<OptionalStateValidator<Guid>, EqualsValidator<Guid>, Guid, Guid> NotEmpty(this OptionalStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static NullableDataSourceInverted<OptionalStateValidator<byte>, EqualsValidator<byte>, byte, byte> NotZero(this OptionalStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte, sbyte> NotZero(this OptionalStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<short>, EqualsValidator<short>, short, short> NotZero(this OptionalStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<ushort>, EqualsValidator<ushort>, ushort, ushort> NotZero(this OptionalStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<int>, EqualsValidator<int>, int, int> NotZero(this OptionalStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<uint>, EqualsValidator<uint>, uint, uint> NotZero(this OptionalStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<long>, EqualsValidator<long>, long, long> NotZero(this OptionalStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<ulong>, EqualsValidator<ulong>, ulong, ulong> NotZero(this OptionalStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<float>, EqualsValidator<float>, float, float> NotZero(this OptionalStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<double>, EqualsValidator<double>, double, double> NotZero(this OptionalStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<decimal>, EqualsValidator<decimal>, decimal, decimal> NotZero(this OptionalStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValue, TValue> InSet<TValue>(this OptionalStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValue, TValue> InSet<TValue>(this OptionalStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte, byte> MultipleOf(this OptionalStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte, sbyte> MultipleOf(this OptionalStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, short, short> MultipleOf(this OptionalStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort, ushort> MultipleOf(this OptionalStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, int, int> MultipleOf(this OptionalStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint, uint> MultipleOf(this OptionalStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, long, long> MultipleOf(this OptionalStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong, ulong> MultipleOf(this OptionalStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, PrecisionValidator, decimal, decimal> Precision(this OptionalStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte, byte> GreaterThan(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte, byte> GreaterThanOrEqualTo(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte, byte> LessThan(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte, byte> LessThanOrEqualTo(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte, byte> InRange(this OptionalStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> GreaterThan(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> GreaterThanOrEqualTo(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> LessThan(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> LessThanOrEqualTo(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> InRange(this OptionalStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short, short> GreaterThan(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short, short> GreaterThanOrEqualTo(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short, short> LessThan(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short, short> LessThanOrEqualTo(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short, short> InRange(this OptionalStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> GreaterThan(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> GreaterThanOrEqualTo(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> LessThan(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> LessThanOrEqualTo(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> InRange(this OptionalStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int, int> GreaterThan(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int, int> GreaterThanOrEqualTo(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int, int> LessThan(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int, int> LessThanOrEqualTo(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int, int> InRange(this OptionalStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint, uint> GreaterThan(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint, uint> GreaterThanOrEqualTo(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint, uint> LessThan(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint, uint> LessThanOrEqualTo(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint, uint> InRange(this OptionalStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long, long> GreaterThan(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long, long> GreaterThanOrEqualTo(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long, long> LessThan(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long, long> LessThanOrEqualTo(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long, long> InRange(this OptionalStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> GreaterThan(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> GreaterThanOrEqualTo(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> LessThan(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> LessThanOrEqualTo(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> InRange(this OptionalStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float, float> GreaterThan(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float, float> GreaterThanOrEqualTo(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float, float> LessThan(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float, float> LessThanOrEqualTo(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float, float> InRange(this OptionalStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double, double> GreaterThan(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double, double> GreaterThanOrEqualTo(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double, double> LessThan(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double, double> LessThanOrEqualTo(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double, double> InRange(this OptionalStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> GreaterThan(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> GreaterThanOrEqualTo(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> LessThan(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> LessThanOrEqualTo(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> InRange(this OptionalStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> GreaterThan(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> GreaterThanOrEqualTo(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> LessThan(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> LessThanOrEqualTo(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> InRange(this OptionalStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<string>, StringLengthValidator, string, string> Length(this OptionalStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, EqualsValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, EqualsValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, InSetValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, InSetValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> InRange<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> InRange<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> InRange<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> InRange<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> InRange<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> InRange<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> InRange<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> InRange<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> InRange<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> InRange<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> InRange<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> InRange<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> InRange<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> InRange<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> InRange<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> InRange<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThan<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThan<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> InRange<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> InRange<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, PrecisionValidator, TSource, decimal>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, TSource, byte>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, TSource, byte>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, TSource, short>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, TSource, short>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, TSource, int>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, TSource, int>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, TSource, uint>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, TSource, uint>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, TSource, long>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, TSource, long>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Single, CustomValidator<float>, TSource, float> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Single, TSource, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Single, CustomValidator<float>, TSource, float> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Single, TSource, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Single, TSource, float> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Single, TSource, float>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Single, TSource, float> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Single, TSource, float>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Double, CustomValidator<double>, TSource, double> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Double, TSource, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Double, CustomValidator<double>, TSource, double> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Double, TSource, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Double, TSource, double> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Double, TSource, double>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Double, TSource, double> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Double, TSource, double>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> Precision<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> Precision<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_DateTime, CustomValidator<DateTime>, TSource, DateTime> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_DateTime, CustomValidator<DateTime>, TSource, DateTime> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, StringLengthValidator, CustomValidator<string>, TSource, string> Assert<TSource>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, StringLengthValidator, TSource, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, StringLengthValidator, CustomValidator<string>, TSource, string> Assert<TSource>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, StringLengthValidator, TSource, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<TSource>, StringLengthValidator, TSource, string> source, Func<NullableDataSourceStandard<OptionalStateValidator<TSource>, StringLengthValidator, TSource, string>, NullableDataSourceStandardStandard<OptionalStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<TSource>, StringLengthValidator, TSource, string> source, Func<NullableDataSourceInverted<OptionalStateValidator<TSource>, StringLengthValidator, TSource, string>, NullableDataSourceInvertedStandard<OptionalStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}