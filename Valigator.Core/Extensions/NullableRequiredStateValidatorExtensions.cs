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
	public static class NullableRequiredStateValidatorExtensions
	{
		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, TValueValidator> Not<TValue, TValueValidator>(this NullableRequiredStateValidator<TValue> source, Func<NullableRequiredStateValidator<TValue>, DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> source, Func<DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue>, DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, CustomValidator<TValue>> Assert<TValue>(this NullableRequiredStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, CustomValidator<TValue>> Assert<TValue>(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> EqualTo<TValue>(this NullableRequiredStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> EqualTo<TValue>(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<string>, string, string>, Option<string>, string, EqualsValidator<string>> NotEmpty(this NullableRequiredStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<string>, string, string>, Option<string>, string, EqualsValidator<string>> NotEmpty(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<string>, string, string>, Option<string>, string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<Guid>, Guid, Guid>, Option<Guid>, Guid, EqualsValidator<Guid>> NotEmpty(this NullableRequiredStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<Guid>, Guid, Guid>, Option<Guid>, Guid, EqualsValidator<Guid>> NotEmpty(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<Guid>, Guid, Guid>, Option<Guid>, Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte, EqualsValidator<byte>> NotZero(this NullableRequiredStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte, EqualsValidator<byte>> NotZero(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, EqualsValidator<sbyte>> NotZero(this NullableRequiredStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, EqualsValidator<sbyte>> NotZero(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short, EqualsValidator<short>> NotZero(this NullableRequiredStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short, EqualsValidator<short>> NotZero(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, EqualsValidator<ushort>> NotZero(this NullableRequiredStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, EqualsValidator<ushort>> NotZero(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, EqualsValidator<int>> NotZero(this NullableRequiredStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, EqualsValidator<int>> NotZero(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint, EqualsValidator<uint>> NotZero(this NullableRequiredStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint, EqualsValidator<uint>> NotZero(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long, EqualsValidator<long>> NotZero(this NullableRequiredStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long, EqualsValidator<long>> NotZero(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, EqualsValidator<ulong>> NotZero(this NullableRequiredStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, EqualsValidator<ulong>> NotZero(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float, EqualsValidator<float>> NotZero(this NullableRequiredStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float, EqualsValidator<float>> NotZero(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double, EqualsValidator<double>> NotZero(this NullableRequiredStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double, EqualsValidator<double>> NotZero(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, EqualsValidator<decimal>> NotZero(this NullableRequiredStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, EqualsValidator<decimal>> NotZero(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> InSet<TValue>(this NullableRequiredStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> InSet<TValue>(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> InSet<TValue>(this NullableRequiredStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> InSet<TValue>(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte, MultipleOfValidator_Byte> MultipleOf(this NullableRequiredStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte, MultipleOfValidator_Byte> MultipleOf(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> MultipleOf(this NullableRequiredStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> MultipleOf(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short, MultipleOfValidator_Int16> MultipleOf(this NullableRequiredStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short, MultipleOfValidator_Int16> MultipleOf(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> MultipleOf(this NullableRequiredStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> MultipleOf(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, MultipleOfValidator_Int32> MultipleOf(this NullableRequiredStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, MultipleOfValidator_Int32> MultipleOf(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> MultipleOf(this NullableRequiredStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> MultipleOf(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long, MultipleOfValidator_Int64> MultipleOf(this NullableRequiredStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long, MultipleOfValidator_Int64> MultipleOf(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> MultipleOf(this NullableRequiredStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> MultipleOf(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, PrecisionValidator> Precision(this NullableRequiredStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, PrecisionValidator> Precision(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> GreaterThan(this NullableRequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> GreaterThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> GreaterThanOrEqualTo(this NullableRequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> LessThan(this NullableRequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> LessThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> LessThanOrEqualTo(this NullableRequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> InRange(this NullableRequiredStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> InRange(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, byte, byte>, Option<byte>, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> GreaterThan(this NullableRequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> GreaterThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> GreaterThanOrEqualTo(this NullableRequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> LessThan(this NullableRequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> LessThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> LessThanOrEqualTo(this NullableRequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> InRange(this NullableRequiredStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> InRange(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> GreaterThan(this NullableRequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> GreaterThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> GreaterThanOrEqualTo(this NullableRequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> LessThan(this NullableRequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> LessThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> LessThanOrEqualTo(this NullableRequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> InRange(this NullableRequiredStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> InRange(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<short>, short, short>, Option<short>, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> GreaterThan(this NullableRequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> GreaterThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> GreaterThanOrEqualTo(this NullableRequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> LessThan(this NullableRequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> LessThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> LessThanOrEqualTo(this NullableRequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> InRange(this NullableRequiredStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> InRange(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> GreaterThan(this NullableRequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> GreaterThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> GreaterThanOrEqualTo(this NullableRequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> LessThan(this NullableRequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> LessThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> LessThanOrEqualTo(this NullableRequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> InRange(this NullableRequiredStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> InRange(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<int>, int, int>, Option<int>, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> GreaterThan(this NullableRequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> GreaterThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> GreaterThanOrEqualTo(this NullableRequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> LessThan(this NullableRequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> LessThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> LessThanOrEqualTo(this NullableRequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> InRange(this NullableRequiredStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> InRange(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, uint, uint>, Option<uint>, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> GreaterThan(this NullableRequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> GreaterThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> GreaterThanOrEqualTo(this NullableRequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> LessThan(this NullableRequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> LessThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> LessThanOrEqualTo(this NullableRequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> InRange(this NullableRequiredStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> InRange(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<long>, long, long>, Option<long>, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> GreaterThan(this NullableRequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> GreaterThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> GreaterThanOrEqualTo(this NullableRequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> LessThan(this NullableRequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> LessThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> LessThanOrEqualTo(this NullableRequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> InRange(this NullableRequiredStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> InRange(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> GreaterThan(this NullableRequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> GreaterThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> GreaterThanOrEqualTo(this NullableRequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> LessThan(this NullableRequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> LessThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> LessThanOrEqualTo(this NullableRequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> InRange(this NullableRequiredStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> InRange(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<float>, float, float>, Option<float>, float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> GreaterThan(this NullableRequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> GreaterThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> GreaterThanOrEqualTo(this NullableRequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> LessThan(this NullableRequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> LessThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> LessThanOrEqualTo(this NullableRequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> InRange(this NullableRequiredStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> InRange(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<double>, double, double>, Option<double>, double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> GreaterThan(this NullableRequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> GreaterThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> GreaterThanOrEqualTo(this NullableRequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> LessThan(this NullableRequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> LessThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> LessThanOrEqualTo(this NullableRequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> InRange(this NullableRequiredStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> InRange(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> GreaterThan(this NullableRequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> GreaterThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> GreaterThanOrEqualTo(this NullableRequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> LessThan(this NullableRequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> LessThan(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> LessThanOrEqualTo(this NullableRequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> InRange(this NullableRequiredStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> InRange(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<string>, string, string>, Option<string>, string, StringLengthValidator> Length(this NullableRequiredStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<string>, string, string>, Option<string>, string, StringLengthValidator> Length(this DataSource<NullableDataContainerFactory<NullableRequiredStateValidator<string>, string, string>, Option<string>, string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, CustomValidator<float>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, CustomValidator<float>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, CustomValidator<double>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, CustomValidator<double>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> Precision<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> Precision<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceStandardStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, CustomValidator<DateTime>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, CustomValidator<DateTime>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, CustomValidator<string>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, CustomValidator<string>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<NullableRequiredStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator> source, Func<DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator>, DataSourceStandardStandard<NullableDataContainerFactory<NullableRequiredStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<NullableRequiredStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator> source, Func<DataSourceInverted<NullableDataContainerFactory<NullableRequiredStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator>, DataSourceInvertedStandard<NullableDataContainerFactory<NullableRequiredStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}