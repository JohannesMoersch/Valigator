using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedNullableStateValidatorExtensions
	{
		public static MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, TValue> Map<TSource, TValue>(this DefaultedNullableStateValidator<TSource> source, Func<TSource, TValue> mapper)
			=> new MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, TValue>(source, mapper);

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this DefaultedNullableStateValidator<TSource> source, Func<DefaultedNullableStateValidator<TSource>, NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, TValue> source, Func<MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, TValue>, NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, CustomValidator<TValue>, TValue, TValue> Assert<TValue>(this DefaultedNullableStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue, TValue> EqualTo<TValue>(this DefaultedNullableStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> EqualTo<TSource, TValue>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<string>, EqualsValidator<string>, string, string> NotEmpty(this DefaultedNullableStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<string>, TSource, string> NotEmpty<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<Guid>, EqualsValidator<Guid>, Guid, Guid> NotEmpty(this DefaultedNullableStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<Guid>, TSource, Guid> NotEmpty<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<byte>, EqualsValidator<byte>, byte, byte> NotZero(this DefaultedNullableStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<byte>, TSource, byte> NotZero<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte, sbyte> NotZero(this DefaultedNullableStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<sbyte>, TSource, sbyte> NotZero<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<short>, EqualsValidator<short>, short, short> NotZero(this DefaultedNullableStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<short>, TSource, short> NotZero<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<ushort>, EqualsValidator<ushort>, ushort, ushort> NotZero(this DefaultedNullableStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<ushort>, TSource, ushort> NotZero<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<int>, EqualsValidator<int>, int, int> NotZero(this DefaultedNullableStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<int>, TSource, int> NotZero<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<uint>, EqualsValidator<uint>, uint, uint> NotZero(this DefaultedNullableStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<uint>, TSource, uint> NotZero<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<long>, EqualsValidator<long>, long, long> NotZero(this DefaultedNullableStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<long>, TSource, long> NotZero<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<ulong>, EqualsValidator<ulong>, ulong, ulong> NotZero(this DefaultedNullableStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<ulong>, TSource, ulong> NotZero<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<float>, EqualsValidator<float>, float, float> NotZero(this DefaultedNullableStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<float>, TSource, float> NotZero<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<double>, EqualsValidator<double>, double, double> NotZero(this DefaultedNullableStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<double>, TSource, double> NotZero<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<decimal>, EqualsValidator<decimal>, decimal, decimal> NotZero(this DefaultedNullableStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<decimal>, TSource, decimal> NotZero<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue, TValue> InSet<TValue>(this DefaultedNullableStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> InSet<TSource, TValue>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TValue>, InSetValidator<TValue>, TValue, TValue> InSet<TValue>(this DefaultedNullableStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> InSet<TSource, TValue>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, MultipleOfValidator_Byte, byte, byte> MultipleOf(this DefaultedNullableStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> MultipleOf<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte, sbyte> MultipleOf(this DefaultedNullableStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> MultipleOf<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, MultipleOfValidator_Int16, short, short> MultipleOf(this DefaultedNullableStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> MultipleOf<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort, ushort> MultipleOf(this DefaultedNullableStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> MultipleOf<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, MultipleOfValidator_Int32, int, int> MultipleOf(this DefaultedNullableStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> MultipleOf<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint, uint> MultipleOf(this DefaultedNullableStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> MultipleOf<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, MultipleOfValidator_Int64, long, long> MultipleOf(this DefaultedNullableStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> MultipleOf<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong, ulong> MultipleOf(this DefaultedNullableStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> MultipleOf<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, PrecisionValidator, decimal, decimal> Precision(this DefaultedNullableStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> Precision<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte, byte> GreaterThan(this DefaultedNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> GreaterThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte, byte> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte, byte> LessThan(this DefaultedNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> LessThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte, byte> LessThanOrEqualTo(this DefaultedNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<byte>, RangeValidator_Byte, byte, byte> InRange(this DefaultedNullableStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> InRange<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> GreaterThan(this DefaultedNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> GreaterThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> LessThan(this DefaultedNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> LessThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> LessThanOrEqualTo(this DefaultedNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> InRange(this DefaultedNullableStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> InRange<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short, short> GreaterThan(this DefaultedNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> GreaterThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short, short> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short, short> LessThan(this DefaultedNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> LessThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short, short> LessThanOrEqualTo(this DefaultedNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<short>, RangeValidator_Int16, short, short> InRange(this DefaultedNullableStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> InRange<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> GreaterThan(this DefaultedNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> GreaterThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> LessThan(this DefaultedNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> LessThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> LessThanOrEqualTo(this DefaultedNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> InRange(this DefaultedNullableStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> InRange<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int, int> GreaterThan(this DefaultedNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> GreaterThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int, int> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int, int> LessThan(this DefaultedNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> LessThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int, int> LessThanOrEqualTo(this DefaultedNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<int>, RangeValidator_Int32, int, int> InRange(this DefaultedNullableStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> InRange<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint, uint> GreaterThan(this DefaultedNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> GreaterThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint, uint> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint, uint> LessThan(this DefaultedNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> LessThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint, uint> LessThanOrEqualTo(this DefaultedNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<uint>, RangeValidator_UInt32, uint, uint> InRange(this DefaultedNullableStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> InRange<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long, long> GreaterThan(this DefaultedNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> GreaterThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long, long> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long, long> LessThan(this DefaultedNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> LessThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long, long> LessThanOrEqualTo(this DefaultedNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<long>, RangeValidator_Int64, long, long> InRange(this DefaultedNullableStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> InRange<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> GreaterThan(this DefaultedNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> GreaterThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> LessThan(this DefaultedNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> LessThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> LessThanOrEqualTo(this DefaultedNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> InRange(this DefaultedNullableStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> InRange<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float, float> GreaterThan(this DefaultedNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> GreaterThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float, float> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float, float> LessThan(this DefaultedNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> LessThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float, float> LessThanOrEqualTo(this DefaultedNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<float>, RangeValidator_Single, float, float> InRange(this DefaultedNullableStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> InRange<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double, double> GreaterThan(this DefaultedNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> GreaterThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double, double> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double, double> LessThan(this DefaultedNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> LessThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double, double> LessThanOrEqualTo(this DefaultedNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<double>, RangeValidator_Double, double, double> InRange(this DefaultedNullableStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> InRange<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> GreaterThan(this DefaultedNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> GreaterThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> LessThan(this DefaultedNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> LessThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> LessThanOrEqualTo(this DefaultedNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> InRange(this DefaultedNullableStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> InRange<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> GreaterThan(this DefaultedNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> GreaterThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> GreaterThanOrEqualTo(this DefaultedNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> LessThan(this DefaultedNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> LessThan<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> LessThanOrEqualTo(this DefaultedNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> InRange(this DefaultedNullableStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> InRange<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<string>, StringLengthValidator, string, string> Length(this DefaultedNullableStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, StringLengthValidator, TSource, string> Length<TSource>(this MappedNullableDataSource<DefaultedNullableStateValidator<TSource>, TSource, string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, EqualsValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, EqualsValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, InSetValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, InSetValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> InRange<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> InRange<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> InRange<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> InRange<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> InRange<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> InRange<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> InRange<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> InRange<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> InRange<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> InRange<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> InRange<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> InRange<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> InRange<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> InRange<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> InRange<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> InRange<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThan<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThan<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> InRange<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> InRange<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> MultipleOf<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> MultipleOf<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> MultipleOf<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> MultipleOf<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> MultipleOf<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> MultipleOf<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> MultipleOf<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> MultipleOf<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> MultipleOf<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> MultipleOf<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> MultipleOf<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> MultipleOf<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> MultipleOf<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> MultipleOf<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> MultipleOf<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> MultipleOf<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, CustomValidator<float>, TSource, float> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, CustomValidator<float>, TSource, float> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TSource, float>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TSource, float>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, CustomValidator<double>, TSource, double> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, CustomValidator<double>, TSource, double> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TSource, double>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TSource, double>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> Precision<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> Precision<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, NullableDataSourceStandardStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, NullableDataSourceInvertedStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, NullableDataSourceStandardInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, NullableDataSourceInvertedInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, CustomValidator<DateTime>, TSource, DateTime> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, CustomValidator<DateTime>, TSource, DateTime> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, StringLengthValidator, CustomValidator<string>, TSource, string> Assert<TSource>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, StringLengthValidator, TSource, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, StringLengthValidator, CustomValidator<string>, TSource, string> Assert<TSource>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, StringLengthValidator, TSource, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static NullableDataSourceStandardInverted<DefaultedNullableStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string> Not<TSource, TValueValidator>(this NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, StringLengthValidator, TSource, string> source, Func<NullableDataSourceStandard<DefaultedNullableStateValidator<TSource>, StringLengthValidator, TSource, string>, NullableDataSourceStandardStandard<DefaultedNullableStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<DefaultedNullableStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string> Not<TSource, TValueValidator>(this NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, StringLengthValidator, TSource, string> source, Func<NullableDataSourceInverted<DefaultedNullableStateValidator<TSource>, StringLengthValidator, TSource, string>, NullableDataSourceInvertedStandard<DefaultedNullableStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}