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
	public static class DefaultedStateValidatorExtensions
	{
		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue, TValueValidator> Not<TValue, TValueValidator>(this DefaultedStateValidator<TValue> source, Func<DefaultedStateValidator<TValue>, DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSource<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue> source, Func<DataSource<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue>, DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue, CustomValidator<TValue>> Assert<TValue>(this DefaultedStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue, CustomValidator<TValue>> Assert<TValue>(this DataSource<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue, EqualsValidator<TValue>> EqualTo<TValue>(this DefaultedStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue, EqualsValidator<TValue>> EqualTo<TValue>(this DataSource<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<string>, string, string>, string, string, EqualsValidator<string>> NotEmpty(this DefaultedStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<string>, string, string>, string, string, EqualsValidator<string>> NotEmpty(this DataSource<DataContainerFactory<DefaultedStateValidator<string>, string, string>, string, string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<Guid>, Guid, Guid>, Guid, Guid, EqualsValidator<Guid>> NotEmpty(this DefaultedStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<Guid>, Guid, Guid>, Guid, Guid, EqualsValidator<Guid>> NotEmpty(this DataSource<DataContainerFactory<DefaultedStateValidator<Guid>, Guid, Guid>, Guid, Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte, EqualsValidator<byte>> NotZero(this DefaultedStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte, EqualsValidator<byte>> NotZero(this DataSource<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, EqualsValidator<sbyte>> NotZero(this DefaultedStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, EqualsValidator<sbyte>> NotZero(this DataSource<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short, EqualsValidator<short>> NotZero(this DefaultedStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short, EqualsValidator<short>> NotZero(this DataSource<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort, EqualsValidator<ushort>> NotZero(this DefaultedStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort, EqualsValidator<ushort>> NotZero(this DataSource<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int, EqualsValidator<int>> NotZero(this DefaultedStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int, EqualsValidator<int>> NotZero(this DataSource<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint, EqualsValidator<uint>> NotZero(this DefaultedStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint, EqualsValidator<uint>> NotZero(this DataSource<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long, EqualsValidator<long>> NotZero(this DefaultedStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long, EqualsValidator<long>> NotZero(this DataSource<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong, EqualsValidator<ulong>> NotZero(this DefaultedStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong, EqualsValidator<ulong>> NotZero(this DataSource<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float, EqualsValidator<float>> NotZero(this DefaultedStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float, EqualsValidator<float>> NotZero(this DataSource<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double, EqualsValidator<double>> NotZero(this DefaultedStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double, EqualsValidator<double>> NotZero(this DataSource<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal, EqualsValidator<decimal>> NotZero(this DefaultedStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceInverted<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal, EqualsValidator<decimal>> NotZero(this DataSource<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue, InSetValidator<TValue>> InSet<TValue>(this DefaultedStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue, InSetValidator<TValue>> InSet<TValue>(this DataSource<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue, InSetValidator<TValue>> InSet<TValue>(this DefaultedStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue, InSetValidator<TValue>> InSet<TValue>(this DataSource<DataContainerFactory<DefaultedStateValidator<TValue>, TValue, TValue>, TValue, TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte, MultipleOfValidator_Byte> MultipleOf(this DefaultedStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte, MultipleOfValidator_Byte> MultipleOf(this DataSource<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> MultipleOf(this DefaultedStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> MultipleOf(this DataSource<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short, MultipleOfValidator_Int16> MultipleOf(this DefaultedStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short, MultipleOfValidator_Int16> MultipleOf(this DataSource<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort, MultipleOfValidator_UInt16> MultipleOf(this DefaultedStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort, MultipleOfValidator_UInt16> MultipleOf(this DataSource<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int, MultipleOfValidator_Int32> MultipleOf(this DefaultedStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int, MultipleOfValidator_Int32> MultipleOf(this DataSource<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint, MultipleOfValidator_UInt32> MultipleOf(this DefaultedStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint, MultipleOfValidator_UInt32> MultipleOf(this DataSource<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long, MultipleOfValidator_Int64> MultipleOf(this DefaultedStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long, MultipleOfValidator_Int64> MultipleOf(this DataSource<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong, MultipleOfValidator_UInt64> MultipleOf(this DefaultedStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong, MultipleOfValidator_UInt64> MultipleOf(this DataSource<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal, PrecisionValidator> Precision(this DefaultedStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal, PrecisionValidator> Precision(this DataSource<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> GreaterThan(this DefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> GreaterThan(this DataSource<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> GreaterThanOrEqualTo(this DefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> GreaterThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> LessThan(this DefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> LessThan(this DataSource<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> LessThanOrEqualTo(this DefaultedStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> LessThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> InRange(this DefaultedStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte, RangeValidator_Byte> InRange(this DataSource<DataContainerFactory<DefaultedStateValidator<byte>, byte, byte>, byte, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> GreaterThan(this DefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> GreaterThan(this DataSource<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> GreaterThanOrEqualTo(this DefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> GreaterThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> LessThan(this DefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> LessThan(this DataSource<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> LessThanOrEqualTo(this DefaultedStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> LessThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> InRange(this DefaultedStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte, RangeValidator_SByte> InRange(this DataSource<DataContainerFactory<DefaultedStateValidator<sbyte>, sbyte, sbyte>, sbyte, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short, RangeValidator_Int16> GreaterThan(this DefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short, RangeValidator_Int16> GreaterThan(this DataSource<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short, RangeValidator_Int16> GreaterThanOrEqualTo(this DefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short, RangeValidator_Int16> GreaterThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short, RangeValidator_Int16> LessThan(this DefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short, RangeValidator_Int16> LessThan(this DataSource<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short, RangeValidator_Int16> LessThanOrEqualTo(this DefaultedStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short, RangeValidator_Int16> LessThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short, RangeValidator_Int16> InRange(this DefaultedStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short, RangeValidator_Int16> InRange(this DataSource<DataContainerFactory<DefaultedStateValidator<short>, short, short>, short, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> GreaterThan(this DefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> GreaterThan(this DataSource<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> GreaterThanOrEqualTo(this DefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> GreaterThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> LessThan(this DefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> LessThan(this DataSource<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> LessThanOrEqualTo(this DefaultedStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> LessThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> InRange(this DefaultedStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort, RangeValidator_UInt16> InRange(this DataSource<DataContainerFactory<DefaultedStateValidator<ushort>, ushort, ushort>, ushort, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int, RangeValidator_Int32> GreaterThan(this DefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int, RangeValidator_Int32> GreaterThan(this DataSource<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int, RangeValidator_Int32> GreaterThanOrEqualTo(this DefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int, RangeValidator_Int32> GreaterThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int, RangeValidator_Int32> LessThan(this DefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int, RangeValidator_Int32> LessThan(this DataSource<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int, RangeValidator_Int32> LessThanOrEqualTo(this DefaultedStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int, RangeValidator_Int32> LessThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int, RangeValidator_Int32> InRange(this DefaultedStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int, RangeValidator_Int32> InRange(this DataSource<DataContainerFactory<DefaultedStateValidator<int>, int, int>, int, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> GreaterThan(this DefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> GreaterThan(this DataSource<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> GreaterThanOrEqualTo(this DefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> GreaterThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> LessThan(this DefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> LessThan(this DataSource<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> LessThanOrEqualTo(this DefaultedStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> LessThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> InRange(this DefaultedStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint, RangeValidator_UInt32> InRange(this DataSource<DataContainerFactory<DefaultedStateValidator<uint>, uint, uint>, uint, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long, RangeValidator_Int64> GreaterThan(this DefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long, RangeValidator_Int64> GreaterThan(this DataSource<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long, RangeValidator_Int64> GreaterThanOrEqualTo(this DefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long, RangeValidator_Int64> GreaterThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long, RangeValidator_Int64> LessThan(this DefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long, RangeValidator_Int64> LessThan(this DataSource<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long, RangeValidator_Int64> LessThanOrEqualTo(this DefaultedStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long, RangeValidator_Int64> LessThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long, RangeValidator_Int64> InRange(this DefaultedStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long, RangeValidator_Int64> InRange(this DataSource<DataContainerFactory<DefaultedStateValidator<long>, long, long>, long, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> GreaterThan(this DefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> GreaterThan(this DataSource<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> GreaterThanOrEqualTo(this DefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> GreaterThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> LessThan(this DefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> LessThan(this DataSource<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> LessThanOrEqualTo(this DefaultedStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> LessThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> InRange(this DefaultedStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong, RangeValidator_UInt64> InRange(this DataSource<DataContainerFactory<DefaultedStateValidator<ulong>, ulong, ulong>, ulong, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float, RangeValidator_Single> GreaterThan(this DefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float, RangeValidator_Single> GreaterThan(this DataSource<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float, RangeValidator_Single> GreaterThanOrEqualTo(this DefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float, RangeValidator_Single> GreaterThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float, RangeValidator_Single> LessThan(this DefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float, RangeValidator_Single> LessThan(this DataSource<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float, RangeValidator_Single> LessThanOrEqualTo(this DefaultedStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float, RangeValidator_Single> LessThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float, RangeValidator_Single> InRange(this DefaultedStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float, RangeValidator_Single> InRange(this DataSource<DataContainerFactory<DefaultedStateValidator<float>, float, float>, float, float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double, RangeValidator_Double> GreaterThan(this DefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double, RangeValidator_Double> GreaterThan(this DataSource<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double, RangeValidator_Double> GreaterThanOrEqualTo(this DefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double, RangeValidator_Double> GreaterThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double, RangeValidator_Double> LessThan(this DefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double, RangeValidator_Double> LessThan(this DataSource<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double, RangeValidator_Double> LessThanOrEqualTo(this DefaultedStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double, RangeValidator_Double> LessThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double, RangeValidator_Double> InRange(this DefaultedStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double, RangeValidator_Double> InRange(this DataSource<DataContainerFactory<DefaultedStateValidator<double>, double, double>, double, double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> GreaterThan(this DefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> GreaterThan(this DataSource<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> GreaterThanOrEqualTo(this DefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> GreaterThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> LessThan(this DefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> LessThan(this DataSource<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> LessThanOrEqualTo(this DefaultedStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> LessThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> InRange(this DefaultedStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal, RangeValidator_Decimal> InRange(this DataSource<DataContainerFactory<DefaultedStateValidator<decimal>, decimal, decimal>, decimal, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> GreaterThan(this DefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> GreaterThan(this DataSource<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> GreaterThanOrEqualTo(this DefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> GreaterThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> LessThan(this DefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> LessThan(this DataSource<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> LessThanOrEqualTo(this DefaultedStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> LessThanOrEqualTo(this DataSource<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> InRange(this DefaultedStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime, RangeValidator_DateTime> InRange(this DataSource<DataContainerFactory<DefaultedStateValidator<DateTime>, DateTime, DateTime>, DateTime, DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<string>, string, string>, string, string, StringLengthValidator> Length(this DefaultedStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandard<DataContainerFactory<DefaultedStateValidator<string>, string, string>, string, string, StringLengthValidator> Length(this DataSource<DataContainerFactory<DefaultedStateValidator<string>, string, string>, string, string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, EqualsValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<TValue>, TSource, TValue>, TValue, TValue, InSetValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> InRange<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> InRange<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> InRange<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> InRange<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> InRange<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> InRange<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> InRange<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> InRange<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> InRange<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> InRange<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> InRange<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> InRange<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> InRange<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> InRange<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> InRange<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> InRange<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> LessThan<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> LessThan<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> InRange<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> InRange<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<byte>, TSource, byte>, byte, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<sbyte>, TSource, sbyte>, sbyte, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<short>, TSource, short>, short, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<ushort>, TSource, ushort>, ushort, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<int>, TSource, int>, int, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<uint>, TSource, uint>, uint, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<long>, TSource, long>, long, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<ulong>, TSource, ulong>, ulong, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<float>, TSource, float>, float, float, RangeValidator_Single, CustomValidator<float>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<float>, TSource, float>, float, float, RangeValidator_Single> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<float>, TSource, float>, float, float, RangeValidator_Single, CustomValidator<float>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<float>, TSource, float>, float, float, RangeValidator_Single> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<float>, TSource, float>, float, float, RangeValidator_Single, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<float>, TSource, float>, float, float, RangeValidator_Single> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<float>, TSource, float>, float, float, RangeValidator_Single>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<float>, TSource, float>, float, float, RangeValidator_Single, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<float>, TSource, float>, float, float, RangeValidator_Single, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<float>, TSource, float>, float, float, RangeValidator_Single> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<float>, TSource, float>, float, float, RangeValidator_Single>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<float>, TSource, float>, float, float, RangeValidator_Single, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<double>, TSource, double>, double, double, RangeValidator_Double, CustomValidator<double>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<double>, TSource, double>, double, double, RangeValidator_Double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<double>, TSource, double>, double, double, RangeValidator_Double, CustomValidator<double>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<double>, TSource, double>, double, double, RangeValidator_Double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<double>, TSource, double>, double, double, RangeValidator_Double, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<double>, TSource, double>, double, double, RangeValidator_Double> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<double>, TSource, double>, double, double, RangeValidator_Double>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<double>, TSource, double>, double, double, RangeValidator_Double, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<double>, TSource, double>, double, double, RangeValidator_Double, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<double>, TSource, double>, double, double, RangeValidator_Double> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<double>, TSource, double>, double, double, RangeValidator_Double>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<double>, TSource, double>, double, double, RangeValidator_Double, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> Precision<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> Precision<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceStandardStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceInvertedStandardStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceStandardInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceInvertedInvertedStandard<DataContainerFactory<DefaultedStateValidator<decimal>, TSource, decimal>, decimal, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime, CustomValidator<DateTime>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime, CustomValidator<DateTime>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<DateTime>, TSource, DateTime>, DateTime, DateTime, RangeValidator_DateTime, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<string>, TSource, string>, string, string, StringLengthValidator, CustomValidator<string>> Assert<TSource>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<string>, TSource, string>, string, string, StringLengthValidator> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<string>, TSource, string>, string, string, StringLengthValidator, CustomValidator<string>> Assert<TSource>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<string>, TSource, string>, string, string, StringLengthValidator> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceStandardInverted<DataContainerFactory<DefaultedStateValidator<string>, TSource, string>, string, string, StringLengthValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<DataContainerFactory<DefaultedStateValidator<string>, TSource, string>, string, string, StringLengthValidator> source, Func<DataSourceStandard<DataContainerFactory<DefaultedStateValidator<string>, TSource, string>, string, string, StringLengthValidator>, DataSourceStandardStandard<DataContainerFactory<DefaultedStateValidator<string>, TSource, string>, string, string, StringLengthValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<DataContainerFactory<DefaultedStateValidator<string>, TSource, string>, string, string, StringLengthValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<DataContainerFactory<DefaultedStateValidator<string>, TSource, string>, string, string, StringLengthValidator> source, Func<DataSourceInverted<DataContainerFactory<DefaultedStateValidator<string>, TSource, string>, string, string, StringLengthValidator>, DataSourceInvertedStandard<DataContainerFactory<DefaultedStateValidator<string>, TSource, string>, string, string, StringLengthValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}