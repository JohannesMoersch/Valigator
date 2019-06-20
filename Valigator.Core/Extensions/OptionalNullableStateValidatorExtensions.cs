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

		public static NullableDataSourceInverted<OptionalNullableStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this OptionalNullableStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this OptionalNullableStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this OptionalNullableStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this OptionalNullableStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<short>, EqualsValidator<short>, short> NotZero(this OptionalNullableStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this OptionalNullableStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<int>, EqualsValidator<int>, int> NotZero(this OptionalNullableStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this OptionalNullableStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<long>, EqualsValidator<long>, long> NotZero(this OptionalNullableStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this OptionalNullableStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<float>, EqualsValidator<float>, float> NotZero(this OptionalNullableStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<double>, EqualsValidator<double>, double> NotZero(this OptionalNullableStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this OptionalNullableStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this OptionalNullableStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this OptionalNullableStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> MultipleOf(this OptionalNullableStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> MultipleOf(this OptionalNullableStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> MultipleOf(this OptionalNullableStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> MultipleOf(this OptionalNullableStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> MultipleOf(this OptionalNullableStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> MultipleOf(this OptionalNullableStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> MultipleOf(this OptionalNullableStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> MultipleOf(this OptionalNullableStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

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

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThan(this NullableDataSourceStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThan(this NullableDataSourceInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThan(this NullableDataSourceStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThan(this NullableDataSourceInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> InRange(this NullableDataSourceStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> InRange(this NullableDataSourceInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThan(this NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThan(this NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThan(this NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThan(this NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> InRange(this NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> InRange(this NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThan(this NullableDataSourceStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThan(this NullableDataSourceInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThan(this NullableDataSourceStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThan(this NullableDataSourceInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> InRange(this NullableDataSourceStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> InRange(this NullableDataSourceInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThan(this NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThan(this NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThan(this NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThan(this NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> InRange(this NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> InRange(this NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThan(this NullableDataSourceStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThan(this NullableDataSourceInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThan(this NullableDataSourceStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThan(this NullableDataSourceInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> InRange(this NullableDataSourceStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> InRange(this NullableDataSourceInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThan(this NullableDataSourceStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThan(this NullableDataSourceInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThan(this NullableDataSourceStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThan(this NullableDataSourceInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> InRange(this NullableDataSourceStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> InRange(this NullableDataSourceInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThan(this NullableDataSourceStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThan(this NullableDataSourceInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThan(this NullableDataSourceStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThan(this NullableDataSourceInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> InRange(this NullableDataSourceStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> InRange(this NullableDataSourceInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThan(this NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThan(this NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThan(this NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThan(this NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> InRange(this NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> InRange(this NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

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

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> MultipleOf(this NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> MultipleOf(this NullableDataSourceInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> MultipleOf(this NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> MultipleOf(this NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> MultipleOf(this NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> MultipleOf(this NullableDataSourceInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, short> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, short>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> MultipleOf(this NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> MultipleOf(this NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> MultipleOf(this NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> MultipleOf(this NullableDataSourceInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, int> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, int>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> MultipleOf(this NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> MultipleOf(this NullableDataSourceInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> MultipleOf(this NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> MultipleOf(this NullableDataSourceInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, long> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, long>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> MultipleOf(this NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> MultipleOf(this NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

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