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

		public static NullableDataSourceInverted<RequiredNullableStateValidator<string>, EqualsValidator<string>, string> NotEmpty(this RequiredNullableStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static NullableDataSourceInverted<RequiredNullableStateValidator<Guid>, EqualsValidator<Guid>, Guid> NotEmpty(this RequiredNullableStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static NullableDataSourceInverted<RequiredNullableStateValidator<byte>, EqualsValidator<byte>, byte> NotZero(this RequiredNullableStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte> NotZero(this RequiredNullableStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static NullableDataSourceInverted<RequiredNullableStateValidator<short>, EqualsValidator<short>, short> NotZero(this RequiredNullableStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, EqualsValidator<ushort>, ushort> NotZero(this RequiredNullableStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static NullableDataSourceInverted<RequiredNullableStateValidator<int>, EqualsValidator<int>, int> NotZero(this RequiredNullableStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static NullableDataSourceInverted<RequiredNullableStateValidator<uint>, EqualsValidator<uint>, uint> NotZero(this RequiredNullableStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static NullableDataSourceInverted<RequiredNullableStateValidator<long>, EqualsValidator<long>, long> NotZero(this RequiredNullableStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, EqualsValidator<ulong>, ulong> NotZero(this RequiredNullableStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static NullableDataSourceInverted<RequiredNullableStateValidator<float>, EqualsValidator<float>, float> NotZero(this RequiredNullableStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static NullableDataSourceInverted<RequiredNullableStateValidator<double>, EqualsValidator<double>, double> NotZero(this RequiredNullableStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static NullableDataSourceInverted<RequiredNullableStateValidator<decimal>, EqualsValidator<decimal>, decimal> NotZero(this RequiredNullableStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredNullableStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<TValue>, InSetValidator<TValue>, TValue> InSet<TValue>(this RequiredNullableStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> MultipleOf(this RequiredNullableStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> MultipleOf(this RequiredNullableStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> MultipleOf(this RequiredNullableStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> MultipleOf(this RequiredNullableStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> MultipleOf(this RequiredNullableStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> MultipleOf(this RequiredNullableStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> MultipleOf(this RequiredNullableStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> MultipleOf(this RequiredNullableStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

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

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThan(this NullableDataSourceStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThan(this NullableDataSourceInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> GreaterThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThan(this NullableDataSourceStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThan(this NullableDataSourceInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> LessThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> InRange(this NullableDataSourceStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> InRange(this NullableDataSourceInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, byte>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, byte>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<byte>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThan(this NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThan(this NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> GreaterThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThan(this NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThan(this NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> LessThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> InRange(this NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> InRange(this NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<sbyte>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThan(this NullableDataSourceStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThan(this NullableDataSourceInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> GreaterThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThan(this NullableDataSourceStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThan(this NullableDataSourceInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> LessThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> InRange(this NullableDataSourceStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> InRange(this NullableDataSourceInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, short>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, short>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<short>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThan(this NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThan(this NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> GreaterThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThan(this NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThan(this NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> LessThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> InRange(this NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> InRange(this NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<ushort>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThan(this NullableDataSourceStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThan(this NullableDataSourceInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> GreaterThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThan(this NullableDataSourceStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThan(this NullableDataSourceInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> LessThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> InRange(this NullableDataSourceStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> InRange(this NullableDataSourceInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, int>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, int>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<int>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThan(this NullableDataSourceStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThan(this NullableDataSourceInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> GreaterThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThan(this NullableDataSourceStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThan(this NullableDataSourceInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> LessThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> InRange(this NullableDataSourceStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> InRange(this NullableDataSourceInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, uint>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<uint>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThan(this NullableDataSourceStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThan(this NullableDataSourceInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> GreaterThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThan(this NullableDataSourceStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThan(this NullableDataSourceInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> LessThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> InRange(this NullableDataSourceStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> InRange(this NullableDataSourceInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, long>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, long>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<long>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThan(this NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThan(this NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> GreaterThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThan(this NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThan(this NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> LessThanOrEqualTo(this NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> InRange(this NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> InRange(this NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<ulong>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

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

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> MultipleOf(this NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> MultipleOf(this NullableDataSourceInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, byte>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, byte> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, byte>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<byte>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> MultipleOf(this NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> MultipleOf(this NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, sbyte> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, sbyte>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<sbyte>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> MultipleOf(this NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> MultipleOf(this NullableDataSourceInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, short>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, short> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, short>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, short> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, short>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<short>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> MultipleOf(this NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> MultipleOf(this NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, ushort>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, ushort> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, ushort>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<ushort>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> MultipleOf(this NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> MultipleOf(this NullableDataSourceInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, int>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, int> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, int>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, int> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, int>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<int>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> MultipleOf(this NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> MultipleOf(this NullableDataSourceInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, uint>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, uint> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, uint>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<uint>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> MultipleOf(this NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> MultipleOf(this NullableDataSourceInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, long>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, long> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, long>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, long> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, long>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<long>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> MultipleOf(this NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> MultipleOf(this NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceStandardInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>, NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong> source, Func<NullableDataSourceInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, ulong>, NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, ulong> Assert(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandardInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceStandardStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceStandardStandardStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceInvertedStandardStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceStandardInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceStandardInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceStandardInvertedStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong> Not<TValueValidator>(this NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong> source, Func<NullableDataSourceInvertedInverted<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, ulong>, NullableDataSourceInvertedInvertedStandard<RequiredNullableStateValidator<ulong>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

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