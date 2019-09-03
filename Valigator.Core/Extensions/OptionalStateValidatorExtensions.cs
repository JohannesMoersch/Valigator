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
	public static class OptionalStateValidatorExtensions
	{
		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, TValueValidator> Not<TValue, TValueValidator>(this OptionalStateValidator<TValue> source, Func<OptionalStateValidator<TValue>, DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSource<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> source, Func<DataSource<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue>, DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, CustomValidator<TValue>> Assert<TValue>(this OptionalStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, CustomValidator<TValue>> Assert<TValue>(this DataSource<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> EqualTo<TValue>(this OptionalStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> EqualTo<TValue>(this DataSource<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<string>, string, string>, Option<string>, string, EqualsValidator<string>> NotEmpty(this OptionalStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<string>, string, string>, Option<string>, string, EqualsValidator<string>> NotEmpty(this DataSource<NullableDataContainerFactory<OptionalStateValidator<string>, string, string>, Option<string>, string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<Guid>, Guid, Guid>, Option<Guid>, Guid, EqualsValidator<Guid>> NotEmpty(this OptionalStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<Guid>, Guid, Guid>, Option<Guid>, Guid, EqualsValidator<Guid>> NotEmpty(this DataSource<NullableDataContainerFactory<OptionalStateValidator<Guid>, Guid, Guid>, Option<Guid>, Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte, EqualsValidator<byte>> NotZero(this OptionalStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte, EqualsValidator<byte>> NotZero(this DataSource<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, EqualsValidator<sbyte>> NotZero(this OptionalStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, EqualsValidator<sbyte>> NotZero(this DataSource<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short, EqualsValidator<short>> NotZero(this OptionalStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short, EqualsValidator<short>> NotZero(this DataSource<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, EqualsValidator<ushort>> NotZero(this OptionalStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, EqualsValidator<ushort>> NotZero(this DataSource<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int, EqualsValidator<int>> NotZero(this OptionalStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int, EqualsValidator<int>> NotZero(this DataSource<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint, EqualsValidator<uint>> NotZero(this OptionalStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint, EqualsValidator<uint>> NotZero(this DataSource<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long, EqualsValidator<long>> NotZero(this OptionalStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long, EqualsValidator<long>> NotZero(this DataSource<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, EqualsValidator<ulong>> NotZero(this OptionalStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, EqualsValidator<ulong>> NotZero(this DataSource<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float, EqualsValidator<float>> NotZero(this OptionalStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float, EqualsValidator<float>> NotZero(this DataSource<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double, EqualsValidator<double>> NotZero(this OptionalStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double, EqualsValidator<double>> NotZero(this DataSource<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, EqualsValidator<decimal>> NotZero(this OptionalStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, EqualsValidator<decimal>> NotZero(this DataSource<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> InSet<TValue>(this OptionalStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> InSet<TValue>(this DataSource<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> InSet<TValue>(this OptionalStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> InSet<TValue>(this DataSource<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte, MultipleOfValidator_Byte> MultipleOf(this OptionalStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte, MultipleOfValidator_Byte> MultipleOf(this DataSource<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> MultipleOf(this OptionalStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> MultipleOf(this DataSource<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short, MultipleOfValidator_Int16> MultipleOf(this OptionalStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short, MultipleOfValidator_Int16> MultipleOf(this DataSource<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> MultipleOf(this OptionalStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> MultipleOf(this DataSource<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int, MultipleOfValidator_Int32> MultipleOf(this OptionalStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int, MultipleOfValidator_Int32> MultipleOf(this DataSource<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> MultipleOf(this OptionalStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> MultipleOf(this DataSource<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long, MultipleOfValidator_Int64> MultipleOf(this OptionalStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long, MultipleOfValidator_Int64> MultipleOf(this DataSource<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> MultipleOf(this OptionalStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> MultipleOf(this DataSource<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, PrecisionValidator> Precision(this OptionalStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, PrecisionValidator> Precision(this DataSource<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> GreaterThan(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> GreaterThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> GreaterThanOrEqualTo(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> LessThan(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> LessThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> LessThanOrEqualTo(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> InRange(this OptionalStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte, RangeValidator_Byte> InRange(this DataSource<NullableDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Option<byte>, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> GreaterThan(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> GreaterThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> GreaterThanOrEqualTo(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> LessThan(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> LessThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> LessThanOrEqualTo(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> InRange(this OptionalStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> InRange(this DataSource<NullableDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Option<sbyte>, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> GreaterThan(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> GreaterThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> GreaterThanOrEqualTo(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> LessThan(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> LessThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> LessThanOrEqualTo(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> InRange(this OptionalStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short, RangeValidator_Int16> InRange(this DataSource<NullableDataContainerFactory<OptionalStateValidator<short>, short, short>, Option<short>, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> GreaterThan(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> GreaterThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> GreaterThanOrEqualTo(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> LessThan(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> LessThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> LessThanOrEqualTo(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> InRange(this OptionalStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> InRange(this DataSource<NullableDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Option<ushort>, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> GreaterThan(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> GreaterThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> GreaterThanOrEqualTo(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> LessThan(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> LessThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> LessThanOrEqualTo(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> InRange(this OptionalStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int, RangeValidator_Int32> InRange(this DataSource<NullableDataContainerFactory<OptionalStateValidator<int>, int, int>, Option<int>, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> GreaterThan(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> GreaterThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> GreaterThanOrEqualTo(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> LessThan(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> LessThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> LessThanOrEqualTo(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> InRange(this OptionalStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint, RangeValidator_UInt32> InRange(this DataSource<NullableDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Option<uint>, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> GreaterThan(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> GreaterThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> GreaterThanOrEqualTo(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> LessThan(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> LessThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> LessThanOrEqualTo(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> InRange(this OptionalStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long, RangeValidator_Int64> InRange(this DataSource<NullableDataContainerFactory<OptionalStateValidator<long>, long, long>, Option<long>, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> GreaterThan(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> GreaterThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> GreaterThanOrEqualTo(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> LessThan(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> LessThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> LessThanOrEqualTo(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> InRange(this OptionalStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> InRange(this DataSource<NullableDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Option<ulong>, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> GreaterThan(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> GreaterThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> GreaterThanOrEqualTo(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> LessThan(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> LessThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> LessThanOrEqualTo(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> InRange(this OptionalStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float, RangeValidator_Single> InRange(this DataSource<NullableDataContainerFactory<OptionalStateValidator<float>, float, float>, Option<float>, float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> GreaterThan(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> GreaterThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> GreaterThanOrEqualTo(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> LessThan(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> LessThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> LessThanOrEqualTo(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> InRange(this OptionalStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double, RangeValidator_Double> InRange(this DataSource<NullableDataContainerFactory<OptionalStateValidator<double>, double, double>, Option<double>, double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> GreaterThan(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> GreaterThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> GreaterThanOrEqualTo(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> LessThan(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> LessThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> LessThanOrEqualTo(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> InRange(this OptionalStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> InRange(this DataSource<NullableDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Option<decimal>, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> GreaterThan(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> GreaterThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> GreaterThanOrEqualTo(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> GreaterThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> LessThan(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> LessThan(this DataSource<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> LessThanOrEqualTo(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> LessThanOrEqualTo(this DataSource<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> InRange(this OptionalStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> InRange(this DataSource<NullableDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Option<DateTime>, DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<string>, string, string>, Option<string>, string, StringLengthValidator> Length(this OptionalStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<string>, string, string>, Option<string>, string, StringLengthValidator> Length(this DataSource<NullableDataContainerFactory<OptionalStateValidator<string>, string, string>, Option<string>, string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, EqualsValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue, InSetValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThan<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThan<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> InRange<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> InRange<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Option<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Option<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Option<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Option<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Option<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Option<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Option<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Option<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, CustomValidator<float>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, CustomValidator<float>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Option<float>, float, RangeValidator_Single, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, CustomValidator<double>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, CustomValidator<double>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Option<double>, double, RangeValidator_Double, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> Precision<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> Precision<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceStandardStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceInvertedStandardStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceStandardInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceInvertedInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Option<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, CustomValidator<DateTime>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, CustomValidator<DateTime>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Option<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, CustomValidator<string>> Assert<TSource>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, CustomValidator<string>> Assert<TSource>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceStandardInverted<NullableDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator> source, Func<DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator>, DataSourceStandardStandard<NullableDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<NullableDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator> source, Func<DataSourceInverted<NullableDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator>, DataSourceInvertedStandard<NullableDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Option<string>, string, StringLengthValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}