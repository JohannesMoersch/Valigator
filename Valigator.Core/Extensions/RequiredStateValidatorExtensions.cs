// NOTE: GENERATED FILE //
using Functional;
using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.DataContainers.Factories;
using Valigator.Core.DataSources;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredStateValidatorExtensions
	{
		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<TValue>, TValue, TValue>, TValue, TValue, TValueValidator> Not<TValue, TValueValidator>(this RequiredStateValidator<TValue> source, Func<RequiredStateValidator<TValue>, DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TValue, TValue>, TValue, TValue, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSource<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue> source, Func<DataSource<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue>, DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TValue, TValue>, TValue, TValue, CustomValidator<TValue>> Assert<TValue>(this RequiredStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSource<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TValue, TValue>, TValue, TValue, EqualsValidator<TValue>> EqualTo<TValue>(this RequiredStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>> EqualTo<TSource, TValue>(this DataSource<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<string>, string, string>, string, string, EqualsValidator<string>> NotEmpty(this RequiredStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string, EqualsValidator<string>> NotEmpty<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<Guid>, Guid, Guid>, Guid, Guid, EqualsValidator<Guid>> NotEmpty(this RequiredStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<Guid>, TSource, Guid>, Guid, Guid, EqualsValidator<Guid>> NotEmpty<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<Guid>, TSource, Guid>, Guid, Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<byte>, byte, byte>, byte, byte, EqualsValidator<byte>> NotZero(this RequiredStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, EqualsValidator<byte>> NotZero<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, EqualsValidator<sbyte>> NotZero(this RequiredStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, EqualsValidator<sbyte>> NotZero<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<short>, short, short>, short, short, EqualsValidator<short>> NotZero(this RequiredStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, EqualsValidator<short>> NotZero<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<ushort>, ushort, ushort>, ushort, ushort, EqualsValidator<ushort>> NotZero(this RequiredStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, EqualsValidator<ushort>> NotZero<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, EqualsValidator<int>> NotZero(this RequiredStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, EqualsValidator<int>> NotZero<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<uint>, uint, uint>, uint, uint, EqualsValidator<uint>> NotZero(this RequiredStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, EqualsValidator<uint>> NotZero<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<long>, long, long>, long, long, EqualsValidator<long>> NotZero(this RequiredStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, EqualsValidator<long>> NotZero<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<ulong>, ulong, ulong>, ulong, ulong, EqualsValidator<ulong>> NotZero(this RequiredStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, EqualsValidator<ulong>> NotZero<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<float>, float, float>, float, float, EqualsValidator<float>> NotZero(this RequiredStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, EqualsValidator<float>> NotZero<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<double>, double, double>, double, double, EqualsValidator<double>> NotZero(this RequiredStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, EqualsValidator<double>> NotZero<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<decimal>, decimal, decimal>, decimal, decimal, EqualsValidator<decimal>> NotZero(this RequiredStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, EqualsValidator<decimal>> NotZero<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TValue, TValue>, TValue, TValue, InSetValidator<TValue>> InSet<TValue>(this RequiredStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>> InSet<TSource, TValue>(this DataSource<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TValue, TValue>, TValue, TValue, InSetValidator<TValue>> InSet<TValue>(this RequiredStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>> InSet<TSource, TValue>(this DataSource<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, byte, byte>, byte, byte, MultipleOfValidator_Byte> MultipleOf(this RequiredStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> MultipleOf(this RequiredStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, short, short>, short, short, MultipleOfValidator_Int16> MultipleOf(this RequiredStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, ushort, ushort>, ushort, ushort, MultipleOfValidator_UInt16> MultipleOf(this RequiredStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, MultipleOfValidator_Int32> MultipleOf(this RequiredStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, uint, uint>, uint, uint, MultipleOfValidator_UInt32> MultipleOf(this RequiredStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, long, long>, long, long, MultipleOfValidator_Int64> MultipleOf(this RequiredStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, ulong, ulong>, ulong, ulong, MultipleOfValidator_UInt64> MultipleOf(this RequiredStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, decimal, decimal>, decimal, decimal, PrecisionValidator> Precision(this RequiredStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> Precision<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> GreaterThan(this RequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> GreaterThanOrEqualTo(this RequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> LessThan(this RequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> LessThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> LessThanOrEqualTo(this RequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> InRange(this RequiredStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> InRange<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> GreaterThan(this RequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> GreaterThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> GreaterThanOrEqualTo(this RequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> LessThan(this RequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> LessThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> LessThanOrEqualTo(this RequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> InRange(this RequiredStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> InRange<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, short, short>, short, short, RangeValidator_Int16> GreaterThan(this RequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> GreaterThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, short, short>, short, short, RangeValidator_Int16> GreaterThanOrEqualTo(this RequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, short, short>, short, short, RangeValidator_Int16> LessThan(this RequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> LessThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, short, short>, short, short, RangeValidator_Int16> LessThanOrEqualTo(this RequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, short, short>, short, short, RangeValidator_Int16> InRange(this RequiredStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> InRange<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> GreaterThan(this RequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> GreaterThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> GreaterThanOrEqualTo(this RequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> LessThan(this RequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> LessThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> LessThanOrEqualTo(this RequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> InRange(this RequiredStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> InRange<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, RangeValidator_Int32> GreaterThan(this RequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> GreaterThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, RangeValidator_Int32> GreaterThanOrEqualTo(this RequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, RangeValidator_Int32> LessThan(this RequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> LessThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, RangeValidator_Int32> LessThanOrEqualTo(this RequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, int, int>, int, int, RangeValidator_Int32> InRange(this RequiredStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> InRange<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> GreaterThan(this RequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> GreaterThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> GreaterThanOrEqualTo(this RequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> LessThan(this RequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> LessThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> LessThanOrEqualTo(this RequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> InRange(this RequiredStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> InRange<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, long, long>, long, long, RangeValidator_Int64> GreaterThan(this RequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> GreaterThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, long, long>, long, long, RangeValidator_Int64> GreaterThanOrEqualTo(this RequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, long, long>, long, long, RangeValidator_Int64> LessThan(this RequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> LessThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, long, long>, long, long, RangeValidator_Int64> LessThanOrEqualTo(this RequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, long, long>, long, long, RangeValidator_Int64> InRange(this RequiredStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> InRange<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> GreaterThan(this RequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> GreaterThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> GreaterThanOrEqualTo(this RequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> LessThan(this RequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> LessThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> LessThanOrEqualTo(this RequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> InRange(this RequiredStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> InRange<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<float>, float, float>, float, float, RangeValidator_Single> GreaterThan(this RequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single> GreaterThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<float>, float, float>, float, float, RangeValidator_Single> GreaterThanOrEqualTo(this RequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single> GreaterThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<float>, float, float>, float, float, RangeValidator_Single> LessThan(this RequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single> LessThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<float>, float, float>, float, float, RangeValidator_Single> LessThanOrEqualTo(this RequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single> LessThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<float>, float, float>, float, float, RangeValidator_Single> InRange(this RequiredStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single> InRange<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<double>, double, double>, double, double, RangeValidator_Double> GreaterThan(this RequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double> GreaterThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<double>, double, double>, double, double, RangeValidator_Double> GreaterThanOrEqualTo(this RequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double> GreaterThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<double>, double, double>, double, double, RangeValidator_Double> LessThan(this RequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double> LessThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<double>, double, double>, double, double, RangeValidator_Double> LessThanOrEqualTo(this RequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double> LessThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<double>, double, double>, double, double, RangeValidator_Double> InRange(this RequiredStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double> InRange<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> GreaterThan(this RequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> GreaterThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> GreaterThanOrEqualTo(this RequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> LessThan(this RequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> LessThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> LessThanOrEqualTo(this RequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> InRange(this RequiredStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> InRange<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> GreaterThan(this RequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime> GreaterThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> GreaterThanOrEqualTo(this RequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime> GreaterThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> LessThan(this RequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime> LessThan<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> LessThanOrEqualTo(this RequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime> LessThanOrEqualTo<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> InRange(this RequiredStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime> InRange<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<string>, string, string>, string, string, StringLengthValidator> Length(this RequiredStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandard<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string, StringLengthValidator> Length<TSource>(this DataSource<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> InRange<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> InRange<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> InRange<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> InRange<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> InRange<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> InRange<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> InRange<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> InRange<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> InRange<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> InRange<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> InRange<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> InRange<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> InRange<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> InRange<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> InRange<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> InRange<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> InRange<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> InRange<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single, CustomValidator<float>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single, CustomValidator<float>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<float>, TSource, float>, float, float, RangeValidator_Single, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double, CustomValidator<double>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double, CustomValidator<double>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<double>, TSource, double>, double, double, RangeValidator_Double, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> Precision<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> Precision<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceStandardStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceInvertedStandardStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceStandardInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceInvertedInvertedStandard<DataContainerFactory<RequiredStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime, CustomValidator<DateTime>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime, CustomValidator<DateTime>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string, StringLengthValidator, CustomValidator<string>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string, StringLengthValidator> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string, StringLengthValidator, CustomValidator<string>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string, StringLengthValidator> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceStandardInverted<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string, StringLengthValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string, StringLengthValidator> source, Func<DataSourceStandard<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string, StringLengthValidator>, DataSourceStandardStandard<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string, StringLengthValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string, StringLengthValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string, StringLengthValidator> source, Func<DataSourceInverted<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string, StringLengthValidator>, DataSourceInvertedStandard<DataContainerFactory<RequiredStateValidator<string>, TSource, string>, string, string, StringLengthValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}