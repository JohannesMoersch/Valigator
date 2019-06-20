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

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this DefaultedNullableStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this DefaultedNullableStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this DefaultedNullableStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this DefaultedNullableStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<short>, EqualsValidator<short>, short> NotZero(this DefaultedNullableStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this DefaultedNullableStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<int>, EqualsValidator<int>, int> NotZero(this DefaultedNullableStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this DefaultedNullableStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<long>, EqualsValidator<long>, long> NotZero(this DefaultedNullableStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this DefaultedNullableStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<float>, EqualsValidator<float>, float> NotZero(this DefaultedNullableStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<double>, EqualsValidator<double>, double> NotZero(this DefaultedNullableStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this DefaultedNullableStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedNullableStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this DefaultedNullableStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> MultipleOf(this DefaultedNullableStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> MultipleOf(this DefaultedNullableStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> MultipleOf(this DefaultedNullableStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> MultipleOf(this DefaultedNullableStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> MultipleOf(this DefaultedNullableStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> MultipleOf(this DefaultedNullableStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> MultipleOf(this DefaultedNullableStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> MultipleOf(this DefaultedNullableStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

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

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> InRange(this NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> InRange(this NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> InRange(this NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> InRange(this NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> InRange(this NullableDataSourceStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> InRange(this NullableDataSourceInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> InRange(this NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> InRange(this NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> InRange(this NullableDataSourceStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> InRange(this NullableDataSourceInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> InRange(this NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> InRange(this NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> InRange(this NullableDataSourceStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> InRange(this NullableDataSourceInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThan(this NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThan(this NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> InRange(this NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> InRange(this NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

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

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> MultipleOf(this NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> MultipleOf(this NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> MultipleOf(this NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> MultipleOf(this NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> MultipleOf(this NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> MultipleOf(this NullableDataSourceInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> MultipleOf(this NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> MultipleOf(this NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> MultipleOf(this NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> MultipleOf(this NullableDataSourceInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> MultipleOf(this NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> MultipleOf(this NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> MultipleOf(this NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> MultipleOf(this NullableDataSourceInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> MultipleOf(this NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> MultipleOf(this NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

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