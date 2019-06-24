using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class DefaultedStateValidatorExtensions
	{
		public static MappedDataSource<DefaultedStateValidator<TSource>, TSource, TValue> Map<TSource, TValue>(this DefaultedStateValidator<TSource> source, Func<TSource, TValue> mapper)
			=> new MappedDataSource<DefaultedStateValidator<TSource>, TSource, TValue>(source, mapper);

		public static DataSourceInverted<DefaultedStateValidator<TSource>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this DefaultedStateValidator<TSource> source, Func<DefaultedStateValidator<TSource>, DataSourceStandard<DefaultedStateValidator<TSource>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<DefaultedStateValidator<TSource>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, TValue> source, Func<MappedDataSource<DefaultedStateValidator<TSource>, TSource, TValue>, DataSourceStandard<DefaultedStateValidator<TSource>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<DefaultedStateValidator<TValue>, CustomValidator<TValue>, TValue, TValue> Assert<TValue>(this DefaultedStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<DefaultedStateValidator<TValue>, EqualsValidator<TValue>, TValue, TValue> EqualTo<TValue>(this DefaultedStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> EqualTo<TSource, TValue>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceInverted<DefaultedStateValidator<string>, EqualsValidator<string>, string, string> NotEmpty(this DefaultedStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<string>, TSource, string> NotEmpty<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<DefaultedStateValidator<Guid>, EqualsValidator<Guid>, Guid, Guid> NotEmpty(this DefaultedStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<Guid>, TSource, Guid> NotEmpty<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<DefaultedStateValidator<byte>, EqualsValidator<byte>, byte, byte> NotZero(this DefaultedStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<byte>, TSource, byte> NotZero<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<DefaultedStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte, sbyte> NotZero(this DefaultedStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<sbyte>, TSource, sbyte> NotZero<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<DefaultedStateValidator<short>, EqualsValidator<short>, short, short> NotZero(this DefaultedStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<short>, TSource, short> NotZero<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<DefaultedStateValidator<ushort>, EqualsValidator<ushort>, ushort, ushort> NotZero(this DefaultedStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<ushort>, TSource, ushort> NotZero<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<DefaultedStateValidator<int>, EqualsValidator<int>, int, int> NotZero(this DefaultedStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<int>, TSource, int> NotZero<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<DefaultedStateValidator<uint>, EqualsValidator<uint>, uint, uint> NotZero(this DefaultedStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<uint>, TSource, uint> NotZero<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<DefaultedStateValidator<long>, EqualsValidator<long>, long, long> NotZero(this DefaultedStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<long>, TSource, long> NotZero<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<DefaultedStateValidator<ulong>, EqualsValidator<ulong>, ulong, ulong> NotZero(this DefaultedStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<ulong>, TSource, ulong> NotZero<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<DefaultedStateValidator<float>, EqualsValidator<float>, float, float> NotZero(this DefaultedStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<float>, TSource, float> NotZero<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<DefaultedStateValidator<double>, EqualsValidator<double>, double, double> NotZero(this DefaultedStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<double>, TSource, double> NotZero<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<DefaultedStateValidator<decimal>, EqualsValidator<decimal>, decimal, decimal> NotZero(this DefaultedStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<decimal>, TSource, decimal> NotZero<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue, TValue> InSet<TValue>(this DefaultedStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> InSet<TSource, TValue>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DefaultedStateValidator<TValue>, InSetValidator<TValue>, TValue, TValue> InSet<TValue>(this DefaultedStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> InSet<TSource, TValue>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DefaultedStateValidator<byte>, MultipleOfValidator_Byte, byte, byte> MultipleOf(this DefaultedStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> MultipleOf<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte, sbyte> MultipleOf(this DefaultedStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> MultipleOf<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<DefaultedStateValidator<short>, MultipleOfValidator_Int16, short, short> MultipleOf(this DefaultedStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> MultipleOf<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, MultipleOfValidator_UInt16, ushort, ushort> MultipleOf(this DefaultedStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> MultipleOf<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<DefaultedStateValidator<int>, MultipleOfValidator_Int32, int, int> MultipleOf(this DefaultedStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> MultipleOf<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<DefaultedStateValidator<uint>, MultipleOfValidator_UInt32, uint, uint> MultipleOf(this DefaultedStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> MultipleOf<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<DefaultedStateValidator<long>, MultipleOfValidator_Int64, long, long> MultipleOf(this DefaultedStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> MultipleOf<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, MultipleOfValidator_UInt64, ulong, ulong> MultipleOf(this DefaultedStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> MultipleOf<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, PrecisionValidator, decimal, decimal> Precision(this DefaultedStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> Precision<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte, byte> GreaterThan(this DefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, TSource, byte> GreaterThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte, byte> GreaterThanOrEqualTo(this DefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, TSource, byte> GreaterThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte, byte> LessThan(this DefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, TSource, byte> LessThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte, byte> LessThanOrEqualTo(this DefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, TSource, byte> LessThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<byte>, RangeValidator_Byte, byte, byte> InRange(this DefaultedStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, TSource, byte> InRange<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> GreaterThan(this DefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> GreaterThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> GreaterThanOrEqualTo(this DefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> GreaterThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> LessThan(this DefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> LessThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> LessThanOrEqualTo(this DefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> LessThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> InRange(this DefaultedStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> InRange<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short, short> GreaterThan(this DefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, TSource, short> GreaterThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short, short> GreaterThanOrEqualTo(this DefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, TSource, short> GreaterThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short, short> LessThan(this DefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, TSource, short> LessThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short, short> LessThanOrEqualTo(this DefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, TSource, short> LessThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<short>, RangeValidator_Int16, short, short> InRange(this DefaultedStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, TSource, short> InRange<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> GreaterThan(this DefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> GreaterThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> GreaterThanOrEqualTo(this DefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> GreaterThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> LessThan(this DefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> LessThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> LessThanOrEqualTo(this DefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> LessThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> InRange(this DefaultedStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> InRange<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int, int> GreaterThan(this DefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, TSource, int> GreaterThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int, int> GreaterThanOrEqualTo(this DefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, TSource, int> GreaterThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int, int> LessThan(this DefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, TSource, int> LessThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int, int> LessThanOrEqualTo(this DefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, TSource, int> LessThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<int>, RangeValidator_Int32, int, int> InRange(this DefaultedStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, TSource, int> InRange<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint, uint> GreaterThan(this DefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> GreaterThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint, uint> GreaterThanOrEqualTo(this DefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> GreaterThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint, uint> LessThan(this DefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> LessThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint, uint> LessThanOrEqualTo(this DefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> LessThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<uint>, RangeValidator_UInt32, uint, uint> InRange(this DefaultedStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> InRange<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long, long> GreaterThan(this DefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, TSource, long> GreaterThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long, long> GreaterThanOrEqualTo(this DefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, TSource, long> GreaterThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long, long> LessThan(this DefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, TSource, long> LessThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long, long> LessThanOrEqualTo(this DefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, TSource, long> LessThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<long>, RangeValidator_Int64, long, long> InRange(this DefaultedStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, TSource, long> InRange<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> GreaterThan(this DefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> GreaterThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> GreaterThanOrEqualTo(this DefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> GreaterThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> LessThan(this DefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> LessThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> LessThanOrEqualTo(this DefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> LessThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> InRange(this DefaultedStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> InRange<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float, float> GreaterThan(this DefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Single, TSource, float> GreaterThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float, float> GreaterThanOrEqualTo(this DefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Single, TSource, float> GreaterThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float, float> LessThan(this DefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Single, TSource, float> LessThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float, float> LessThanOrEqualTo(this DefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Single, TSource, float> LessThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<float>, RangeValidator_Single, float, float> InRange(this DefaultedStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Single, TSource, float> InRange<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double, double> GreaterThan(this DefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Double, TSource, double> GreaterThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double, double> GreaterThanOrEqualTo(this DefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Double, TSource, double> GreaterThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double, double> LessThan(this DefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Double, TSource, double> LessThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double, double> LessThanOrEqualTo(this DefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Double, TSource, double> LessThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<double>, RangeValidator_Double, double, double> InRange(this DefaultedStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Double, TSource, double> InRange<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> GreaterThan(this DefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> GreaterThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> GreaterThanOrEqualTo(this DefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> GreaterThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> LessThan(this DefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> LessThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> LessThanOrEqualTo(this DefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> LessThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> InRange(this DefaultedStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> InRange<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> GreaterThan(this DefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> GreaterThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> GreaterThanOrEqualTo(this DefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> GreaterThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> LessThan(this DefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> LessThan<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> LessThanOrEqualTo(this DefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> LessThanOrEqualTo<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<DefaultedStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> InRange(this DefaultedStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> InRange<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DefaultedStateValidator<string>, StringLengthValidator, string, string> Length(this DefaultedStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandard<DefaultedStateValidator<TSource>, StringLengthValidator, TSource, string> Length<TSource>(this MappedDataSource<DefaultedStateValidator<TSource>, TSource, string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, EqualsValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this DataSourceStandard<DefaultedStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, EqualsValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this DataSourceStandard<DefaultedStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, InSetValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this DataSourceStandard<DefaultedStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, InSetValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this DataSourceInverted<DefaultedStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this DataSourceStandard<DefaultedStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this DataSourceInverted<DefaultedStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> InRange<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> InRange<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> InRange<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> InRange<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> InRange<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> InRange<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> InRange<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> InRange<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> InRange<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> InRange<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> InRange<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> InRange<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> InRange<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> InRange<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> InRange<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> InRange<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThan<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThan<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThanOrEqualTo<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThanOrEqualTo<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> InRange<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> InRange<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, PrecisionValidator, TSource, decimal>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> MultipleOf<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> MultipleOf<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, TSource, byte>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, TSource, byte>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> MultipleOf<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> MultipleOf<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> MultipleOf<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> MultipleOf<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, TSource, short>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, TSource, short>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> MultipleOf<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> MultipleOf<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> MultipleOf<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> MultipleOf<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, TSource, int>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, TSource, int>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> MultipleOf<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> MultipleOf<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TSource, uint>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TSource, uint>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> MultipleOf<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> MultipleOf<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, TSource, long>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, TSource, long>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> MultipleOf<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> MultipleOf<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Single, CustomValidator<float>, TSource, float> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Single, TSource, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Single, CustomValidator<float>, TSource, float> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Single, TSource, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Single, TSource, float> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Single, TSource, float>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Single, TSource, float> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Single, TSource, float>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Double, CustomValidator<double>, TSource, double> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Double, TSource, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Double, CustomValidator<double>, TSource, double> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Double, TSource, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Double, TSource, double> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Double, TSource, double>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Double, TSource, double> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Double, TSource, double>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> Precision<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> Precision<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, DataSourceStandardStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, DataSourceInvertedStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, DataSourceStandardInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, DataSourceInvertedInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_DateTime, CustomValidator<DateTime>, TSource, DateTime> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_DateTime, CustomValidator<DateTime>, TSource, DateTime> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DefaultedStateValidator<TSource>, StringLengthValidator, CustomValidator<string>, TSource, string> Assert<TSource>(this DataSourceStandard<DefaultedStateValidator<TSource>, StringLengthValidator, TSource, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceInvertedStandard<DefaultedStateValidator<TSource>, StringLengthValidator, CustomValidator<string>, TSource, string> Assert<TSource>(this DataSourceInverted<DefaultedStateValidator<TSource>, StringLengthValidator, TSource, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceStandardInverted<DefaultedStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string> Not<TSource, TValueValidator>(this DataSourceStandard<DefaultedStateValidator<TSource>, StringLengthValidator, TSource, string> source, Func<DataSourceStandard<DefaultedStateValidator<TSource>, StringLengthValidator, TSource, string>, DataSourceStandardStandard<DefaultedStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DefaultedStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string> Not<TSource, TValueValidator>(this DataSourceInverted<DefaultedStateValidator<TSource>, StringLengthValidator, TSource, string> source, Func<DataSourceInverted<DefaultedStateValidator<TSource>, StringLengthValidator, TSource, string>, DataSourceInvertedStandard<DefaultedStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}