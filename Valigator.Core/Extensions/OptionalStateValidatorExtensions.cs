using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalStateValidatorExtensions
	{
		public static NullableDataSourceInverted<OptionalStateValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this OptionalStateValidator<TValue> source, Func<OptionalStateValidator<TValue>, NullableDataSourceStandard<OptionalStateValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this OptionalStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, EqualsValidator<TValue>, TValue> EqualTo<TValue>(this OptionalStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static NullableDataSourceInverted<OptionalStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this OptionalStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static NullableDataSourceInverted<OptionalStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this OptionalStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static NullableDataSourceInverted<OptionalStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this OptionalStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this OptionalStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<short>, EqualsValidator<short>, short> NotZero(this OptionalStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this OptionalStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<int>, EqualsValidator<int>, int> NotZero(this OptionalStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this OptionalStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<long>, EqualsValidator<long>, long> NotZero(this OptionalStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this OptionalStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<float>, EqualsValidator<float>, float> NotZero(this OptionalStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<double>, EqualsValidator<double>, double> NotZero(this OptionalStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static NullableDataSourceInverted<OptionalStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this OptionalStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this OptionalStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this OptionalStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> MultipleOf(this OptionalStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> MultipleOf(this OptionalStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> MultipleOf(this OptionalStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> MultipleOf(this OptionalStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> MultipleOf(this OptionalStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> MultipleOf(this OptionalStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> MultipleOf(this OptionalStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> MultipleOf(this OptionalStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, PrecisionValidator, decimal> Precision(this OptionalStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte> GreaterThan(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte> LessThan(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte> LessThanOrEqualTo(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte> InRange(this OptionalStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThan(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThan(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> InRange(this OptionalStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short> GreaterThan(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short> GreaterThanOrEqualTo(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short> LessThan(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short> LessThanOrEqualTo(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short> InRange(this OptionalStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThan(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThan(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> InRange(this OptionalStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int> GreaterThan(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int> GreaterThanOrEqualTo(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int> LessThan(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int> LessThanOrEqualTo(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int> InRange(this OptionalStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThan(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> LessThan(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> LessThanOrEqualTo(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> InRange(this OptionalStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long> GreaterThan(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long> GreaterThanOrEqualTo(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long> LessThan(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long> LessThanOrEqualTo(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long> InRange(this OptionalStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThan(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThan(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> InRange(this OptionalStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float> GreaterThan(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float> GreaterThanOrEqualTo(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float> LessThan(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float> LessThanOrEqualTo(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float> InRange(this OptionalStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double> GreaterThan(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double> GreaterThanOrEqualTo(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double> LessThan(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double> LessThanOrEqualTo(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double> InRange(this OptionalStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThan(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThan(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> InRange(this OptionalStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThan(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> GreaterThanOrEqualTo(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThan(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> LessThanOrEqualTo(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> InRange(this OptionalStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalStateValidator<string>, StringLengthValidator, string> Length(this OptionalStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TValue>, EqualsValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceStandard<OptionalStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TValue>, EqualsValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceInverted<OptionalStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceStandard<OptionalStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, Func<NullableDataSourceStandard<OptionalStateValidator<TValue>, EqualsValidator<TValue>, TValue>, NullableDataSourceStandardStandard<OptionalStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceInverted<OptionalStateValidator<TValue>, EqualsValidator<TValue>, TValue> source, Func<NullableDataSourceInverted<OptionalStateValidator<TValue>, EqualsValidator<TValue>, TValue>, NullableDataSourceInvertedStandard<OptionalStateValidator<TValue>, EqualsValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<TValue>, InSetValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceStandard<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<TValue>, InSetValidator<TValue>, CustomValidator<TValue>, TValue> Assert<TValue>(this NullableDataSourceInverted<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceStandard<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValue> source, Func<NullableDataSourceStandard<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValue>, NullableDataSourceStandardStandard<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue> Not<TValueValidator, TValue>(this NullableDataSourceInverted<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValue> source, Func<NullableDataSourceInverted<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValue>, NullableDataSourceInvertedStandard<OptionalStateValidator<TValue>, InSetValidator<TValue>, TValueValidator, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThan(this NullableDataSourceStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThan(this NullableDataSourceInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThan(this NullableDataSourceStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThan(this NullableDataSourceInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> InRange(this NullableDataSourceStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> InRange(this NullableDataSourceInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte>, NullableDataSourceStandardStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, byte>, NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThan(this NullableDataSourceStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThan(this NullableDataSourceInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThan(this NullableDataSourceStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThan(this NullableDataSourceInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> InRange(this NullableDataSourceStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> InRange(this NullableDataSourceInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte>, NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte>, NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThan(this NullableDataSourceStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThan(this NullableDataSourceInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThan(this NullableDataSourceStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThan(this NullableDataSourceInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> InRange(this NullableDataSourceStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> InRange(this NullableDataSourceInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, short>, NullableDataSourceStandardStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, short>, NullableDataSourceInvertedStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThan(this NullableDataSourceStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThan(this NullableDataSourceInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThan(this NullableDataSourceStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThan(this NullableDataSourceInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> InRange(this NullableDataSourceStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> InRange(this NullableDataSourceInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort>, NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, ushort>, NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThan(this NullableDataSourceStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThan(this NullableDataSourceInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThan(this NullableDataSourceStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThan(this NullableDataSourceInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> InRange(this NullableDataSourceStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> InRange(this NullableDataSourceInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, int>, NullableDataSourceStandardStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, int>, NullableDataSourceInvertedStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThan(this NullableDataSourceStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThan(this NullableDataSourceInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThan(this NullableDataSourceStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThan(this NullableDataSourceInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> InRange(this NullableDataSourceStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> InRange(this NullableDataSourceInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint>, NullableDataSourceStandardStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, uint>, NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThan(this NullableDataSourceStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThan(this NullableDataSourceInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThan(this NullableDataSourceStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThan(this NullableDataSourceInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> InRange(this NullableDataSourceStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> InRange(this NullableDataSourceInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, long>, NullableDataSourceStandardStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, long>, NullableDataSourceInvertedStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThan(this NullableDataSourceStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThan(this NullableDataSourceInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThan(this NullableDataSourceStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThan(this NullableDataSourceInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> InRange(this NullableDataSourceStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> InRange(this NullableDataSourceInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong>, NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, ulong>, NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandard<OptionalStateValidator<decimal>, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInverted<OptionalStateValidator<decimal>, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThan(this NullableDataSourceStandard<OptionalStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThan(this NullableDataSourceInverted<OptionalStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThan(this NullableDataSourceStandard<OptionalStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThan(this NullableDataSourceInverted<OptionalStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalStateValidator<decimal>, PrecisionValidator, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> InRange(this NullableDataSourceStandard<OptionalStateValidator<decimal>, PrecisionValidator, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> InRange(this NullableDataSourceInverted<OptionalStateValidator<decimal>, PrecisionValidator, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<decimal>, PrecisionValidator, decimal> source, Func<NullableDataSourceStandard<OptionalStateValidator<decimal>, PrecisionValidator, decimal>, NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<decimal>, PrecisionValidator, decimal> source, Func<NullableDataSourceInverted<OptionalStateValidator<decimal>, PrecisionValidator, decimal>, NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, decimal>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<decimal>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<byte>, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInverted<OptionalStateValidator<byte>, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> MultipleOf(this NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> MultipleOf(this NullableDataSourceInverted<OptionalStateValidator<byte>, RangeValidator_Byte, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandard<OptionalStateValidator<byte>, RangeValidator_Byte, byte>, NullableDataSourceStandardStandard<OptionalStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<byte>, RangeValidator_Byte, byte> source, Func<NullableDataSourceInverted<OptionalStateValidator<byte>, RangeValidator_Byte, byte>, NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> MultipleOf(this NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> MultipleOf(this NullableDataSourceInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte>, NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInverted<OptionalStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> MultipleOf(this NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> MultipleOf(this NullableDataSourceInverted<OptionalStateValidator<short>, RangeValidator_Int16, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short> source, Func<NullableDataSourceStandard<OptionalStateValidator<short>, RangeValidator_Int16, short>, NullableDataSourceStandardStandard<OptionalStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<short>, RangeValidator_Int16, short> source, Func<NullableDataSourceInverted<OptionalStateValidator<short>, RangeValidator_Int16, short>, NullableDataSourceInvertedStandard<OptionalStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> MultipleOf(this NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> MultipleOf(this NullableDataSourceInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort>, NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInverted<OptionalStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> MultipleOf(this NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> MultipleOf(this NullableDataSourceInverted<OptionalStateValidator<int>, RangeValidator_Int32, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int> source, Func<NullableDataSourceStandard<OptionalStateValidator<int>, RangeValidator_Int32, int>, NullableDataSourceStandardStandard<OptionalStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<int>, RangeValidator_Int32, int> source, Func<NullableDataSourceInverted<OptionalStateValidator<int>, RangeValidator_Int32, int>, NullableDataSourceInvertedStandard<OptionalStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> MultipleOf(this NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> MultipleOf(this NullableDataSourceInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, uint>, NullableDataSourceStandardStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, uint>, NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInverted<OptionalStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> MultipleOf(this NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> MultipleOf(this NullableDataSourceInverted<OptionalStateValidator<long>, RangeValidator_Int64, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long> source, Func<NullableDataSourceStandard<OptionalStateValidator<long>, RangeValidator_Int64, long>, NullableDataSourceStandardStandard<OptionalStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<long>, RangeValidator_Int64, long> source, Func<NullableDataSourceInverted<OptionalStateValidator<long>, RangeValidator_Int64, long>, NullableDataSourceInvertedStandard<OptionalStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> MultipleOf(this NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> MultipleOf(this NullableDataSourceInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong>, NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<float>, RangeValidator_Single, CustomValidator<float>, float> Assert(this NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<float>, RangeValidator_Single, CustomValidator<float>, float> Assert(this NullableDataSourceInverted<OptionalStateValidator<float>, RangeValidator_Single, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<float>, RangeValidator_Single, TValueValidator, float> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float> source, Func<NullableDataSourceStandard<OptionalStateValidator<float>, RangeValidator_Single, float>, NullableDataSourceStandardStandard<OptionalStateValidator<float>, RangeValidator_Single, TValueValidator, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<float>, RangeValidator_Single, TValueValidator, float> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<float>, RangeValidator_Single, float> source, Func<NullableDataSourceInverted<OptionalStateValidator<float>, RangeValidator_Single, float>, NullableDataSourceInvertedStandard<OptionalStateValidator<float>, RangeValidator_Single, TValueValidator, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<double>, RangeValidator_Double, CustomValidator<double>, double> Assert(this NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<double>, RangeValidator_Double, CustomValidator<double>, double> Assert(this NullableDataSourceInverted<OptionalStateValidator<double>, RangeValidator_Double, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<double>, RangeValidator_Double, TValueValidator, double> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double> source, Func<NullableDataSourceStandard<OptionalStateValidator<double>, RangeValidator_Double, double>, NullableDataSourceStandardStandard<OptionalStateValidator<double>, RangeValidator_Double, TValueValidator, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<double>, RangeValidator_Double, TValueValidator, double> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<double>, RangeValidator_Double, double> source, Func<NullableDataSourceInverted<OptionalStateValidator<double>, RangeValidator_Double, double>, NullableDataSourceInvertedStandard<OptionalStateValidator<double>, RangeValidator_Double, TValueValidator, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> Precision(this NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> Precision(this NullableDataSourceInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal>, NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal> source, Func<NullableDataSourceInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, decimal>, NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceStandardInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, decimal> Assert(this NullableDataSourceInvertedInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceStandardStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceStandardStandardStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceInvertedStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceInvertedStandardStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceStandardInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceStandardInvertedStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal> source, Func<NullableDataSourceInvertedInverted<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, decimal>, NullableDataSourceInvertedInvertedStandard<OptionalStateValidator<decimal>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, CustomValidator<DateTime>, DateTime> Assert(this NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, CustomValidator<DateTime>, DateTime> Assert(this NullableDataSourceInverted<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, Func<NullableDataSourceStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime>, NullableDataSourceStandardStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime> source, Func<NullableDataSourceInverted<OptionalStateValidator<DateTime>, RangeValidator_DateTime, DateTime>, NullableDataSourceInvertedStandard<OptionalStateValidator<DateTime>, RangeValidator_DateTime, TValueValidator, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalStateValidator<string>, StringLengthValidator, CustomValidator<string>, string> Assert(this NullableDataSourceStandard<OptionalStateValidator<string>, StringLengthValidator, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalStateValidator<string>, StringLengthValidator, CustomValidator<string>, string> Assert(this NullableDataSourceInverted<OptionalStateValidator<string>, StringLengthValidator, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalStateValidator<string>, StringLengthValidator, TValueValidator, string> Not<TValueValidator>(this NullableDataSourceStandard<OptionalStateValidator<string>, StringLengthValidator, string> source, Func<NullableDataSourceStandard<OptionalStateValidator<string>, StringLengthValidator, string>, NullableDataSourceStandardStandard<OptionalStateValidator<string>, StringLengthValidator, TValueValidator, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalStateValidator<string>, StringLengthValidator, TValueValidator, string> Not<TValueValidator>(this NullableDataSourceInverted<OptionalStateValidator<string>, StringLengthValidator, string> source, Func<NullableDataSourceInverted<OptionalStateValidator<string>, StringLengthValidator, string>, NullableDataSourceInvertedStandard<OptionalStateValidator<string>, StringLengthValidator, TValueValidator, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}