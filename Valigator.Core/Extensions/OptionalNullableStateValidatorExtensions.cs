using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class OptionalNullableStateValidatorExtensions
	{
		public static MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, TValue> Map<TSource, TValue>(this OptionalNullableStateValidator<TSource> source, Func<TSource, TValue> mapper)
			=> new MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, TValue>(source, mapper);

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this OptionalNullableStateValidator<TSource> source, Func<OptionalNullableStateValidator<TSource>, NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, TValue> source, Func<MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, TValue>, NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, CustomValidator<TValue>, TValue, TValue> Assert<TValue>(this OptionalNullableStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, EqualsValidator<TValue>, TValue, TValue> EqualTo<TValue>(this OptionalNullableStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> EqualTo<TSource, TValue>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<string>, EqualsValidator<string>, string, string> NotEmpty(this OptionalNullableStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<string>, TSource, string> NotEmpty<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<Guid>, EqualsValidator<Guid>, Guid, Guid> NotEmpty(this OptionalNullableStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<Guid>, TSource, Guid> NotEmpty<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<byte>, EqualsValidator<byte>, byte, byte> NotZero(this OptionalNullableStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<byte>, TSource, byte> NotZero<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte, sbyte> NotZero(this OptionalNullableStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<sbyte>, TSource, sbyte> NotZero<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<short>, EqualsValidator<short>, short, short> NotZero(this OptionalNullableStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<short>, TSource, short> NotZero<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<ushort>, EqualsValidator<ushort>, ushort, ushort> NotZero(this OptionalNullableStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<ushort>, TSource, ushort> NotZero<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<int>, EqualsValidator<int>, int, int> NotZero(this OptionalNullableStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<int>, TSource, int> NotZero<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<uint>, EqualsValidator<uint>, uint, uint> NotZero(this OptionalNullableStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<uint>, TSource, uint> NotZero<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<long>, EqualsValidator<long>, long, long> NotZero(this OptionalNullableStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<long>, TSource, long> NotZero<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<ulong>, EqualsValidator<ulong>, ulong, ulong> NotZero(this OptionalNullableStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<ulong>, TSource, ulong> NotZero<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<float>, EqualsValidator<float>, float, float> NotZero(this OptionalNullableStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<float>, TSource, float> NotZero<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<double>, EqualsValidator<double>, double, double> NotZero(this OptionalNullableStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<double>, TSource, double> NotZero<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<decimal>, EqualsValidator<decimal>, decimal, decimal> NotZero(this OptionalNullableStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<decimal>, TSource, decimal> NotZero<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue, TValue> InSet<TValue>(this OptionalNullableStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> InSet<TSource, TValue>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TValue>, InSetValidator<TValue>, TValue, TValue> InSet<TValue>(this OptionalNullableStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> InSet<TSource, TValue>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, MultipleOfValidator_Byte, byte, byte> MultipleOf(this OptionalNullableStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> MultipleOf<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte, sbyte> MultipleOf(this OptionalNullableStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> MultipleOf<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, MultipleOfValidator_Int16, short, short> MultipleOf(this OptionalNullableStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> MultipleOf<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, MultipleOfValidator_UInt16, ushort, ushort> MultipleOf(this OptionalNullableStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> MultipleOf<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, MultipleOfValidator_Int32, int, int> MultipleOf(this OptionalNullableStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> MultipleOf<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, MultipleOfValidator_UInt32, uint, uint> MultipleOf(this OptionalNullableStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> MultipleOf<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, MultipleOfValidator_Int64, long, long> MultipleOf(this OptionalNullableStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> MultipleOf<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, MultipleOfValidator_UInt64, ulong, ulong> MultipleOf(this OptionalNullableStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> MultipleOf<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, PrecisionValidator, decimal, decimal> Precision(this OptionalNullableStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> Precision<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte, byte> GreaterThan(this OptionalNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> GreaterThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte, byte> GreaterThanOrEqualTo(this OptionalNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte, byte> LessThan(this OptionalNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> LessThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte, byte> LessThanOrEqualTo(this OptionalNullableStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<byte>, RangeValidator_Byte, byte, byte> InRange(this OptionalNullableStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> InRange<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> GreaterThan(this OptionalNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> GreaterThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> GreaterThanOrEqualTo(this OptionalNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> LessThan(this OptionalNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> LessThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> LessThanOrEqualTo(this OptionalNullableStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> InRange(this OptionalNullableStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> InRange<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short, short> GreaterThan(this OptionalNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> GreaterThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short, short> GreaterThanOrEqualTo(this OptionalNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short, short> LessThan(this OptionalNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> LessThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short, short> LessThanOrEqualTo(this OptionalNullableStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<short>, RangeValidator_Int16, short, short> InRange(this OptionalNullableStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> InRange<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> GreaterThan(this OptionalNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> GreaterThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> GreaterThanOrEqualTo(this OptionalNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> LessThan(this OptionalNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> LessThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> LessThanOrEqualTo(this OptionalNullableStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> InRange(this OptionalNullableStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> InRange<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int, int> GreaterThan(this OptionalNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> GreaterThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int, int> GreaterThanOrEqualTo(this OptionalNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int, int> LessThan(this OptionalNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> LessThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int, int> LessThanOrEqualTo(this OptionalNullableStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<int>, RangeValidator_Int32, int, int> InRange(this OptionalNullableStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> InRange<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint, uint> GreaterThan(this OptionalNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> GreaterThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint, uint> GreaterThanOrEqualTo(this OptionalNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint, uint> LessThan(this OptionalNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> LessThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint, uint> LessThanOrEqualTo(this OptionalNullableStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<uint>, RangeValidator_UInt32, uint, uint> InRange(this OptionalNullableStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> InRange<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long, long> GreaterThan(this OptionalNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> GreaterThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long, long> GreaterThanOrEqualTo(this OptionalNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long, long> LessThan(this OptionalNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> LessThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long, long> LessThanOrEqualTo(this OptionalNullableStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<long>, RangeValidator_Int64, long, long> InRange(this OptionalNullableStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> InRange<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> GreaterThan(this OptionalNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> GreaterThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> GreaterThanOrEqualTo(this OptionalNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> LessThan(this OptionalNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> LessThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> LessThanOrEqualTo(this OptionalNullableStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> InRange(this OptionalNullableStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> InRange<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float, float> GreaterThan(this OptionalNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> GreaterThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float, float> GreaterThanOrEqualTo(this OptionalNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float, float> LessThan(this OptionalNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> LessThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float, float> LessThanOrEqualTo(this OptionalNullableStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<float>, RangeValidator_Single, float, float> InRange(this OptionalNullableStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> InRange<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double, double> GreaterThan(this OptionalNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> GreaterThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double, double> GreaterThanOrEqualTo(this OptionalNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double, double> LessThan(this OptionalNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> LessThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double, double> LessThanOrEqualTo(this OptionalNullableStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<double>, RangeValidator_Double, double, double> InRange(this OptionalNullableStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> InRange<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> GreaterThan(this OptionalNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> GreaterThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> GreaterThanOrEqualTo(this OptionalNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> LessThan(this OptionalNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> LessThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> LessThanOrEqualTo(this OptionalNullableStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> InRange(this OptionalNullableStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> InRange<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> GreaterThan(this OptionalNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> GreaterThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> GreaterThanOrEqualTo(this OptionalNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> GreaterThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> LessThan(this OptionalNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> LessThan<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> LessThanOrEqualTo(this OptionalNullableStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> LessThanOrEqualTo<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> InRange(this OptionalNullableStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> InRange<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<string>, StringLengthValidator, string, string> Length(this OptionalNullableStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, StringLengthValidator, TSource, string> Length<TSource>(this MappedNullableDataSource<OptionalNullableStateValidator<TSource>, TSource, string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, EqualsValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, EqualsValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, InSetValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, InSetValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> InRange<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> InRange<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> InRange<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> InRange<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> InRange<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> InRange<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> InRange<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> InRange<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> InRange<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> InRange<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> InRange<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> InRange<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> InRange<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> InRange<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> InRange<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> InRange<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThan<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThan<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThanOrEqualTo<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThanOrEqualTo<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> InRange<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> InRange<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, TSource, decimal>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TSource, byte>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TSource, short>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TSource, int>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TSource, uint>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TSource, long>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> MultipleOf<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> MultipleOf<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Single, CustomValidator<float>, TSource, float> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Single, CustomValidator<float>, TSource, float> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TSource, float>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TSource, float> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TSource, float>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Double, CustomValidator<double>, TSource, double> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Double, CustomValidator<double>, TSource, double> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TSource, double>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TSource, double> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TSource, double>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> Precision<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> Precision<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static NullableDataSourceStandardStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, NullableDataSourceStandardStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, NullableDataSourceInvertedStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, NullableDataSourceStandardInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceInvertedInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, NullableDataSourceInvertedInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, CustomValidator<DateTime>, TSource, DateTime> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, CustomValidator<DateTime>, TSource, DateTime> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, StringLengthValidator, CustomValidator<string>, TSource, string> Assert<TSource>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, StringLengthValidator, TSource, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, StringLengthValidator, CustomValidator<string>, TSource, string> Assert<TSource>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, StringLengthValidator, TSource, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static NullableDataSourceStandardInverted<OptionalNullableStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string> Not<TSource, TValueValidator>(this NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, StringLengthValidator, TSource, string> source, Func<NullableDataSourceStandard<OptionalNullableStateValidator<TSource>, StringLengthValidator, TSource, string>, NullableDataSourceStandardStandard<OptionalNullableStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static NullableDataSourceInvertedInverted<OptionalNullableStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string> Not<TSource, TValueValidator>(this NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, StringLengthValidator, TSource, string> source, Func<NullableDataSourceInverted<OptionalNullableStateValidator<TSource>, StringLengthValidator, TSource, string>, NullableDataSourceInvertedStandard<OptionalNullableStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}