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
		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Optional<TValue>, TValue, TValueValidator> Not<TValue, TValueValidator>(this OptionalStateValidator<TValue> source, Func<OptionalStateValidator<TValue>, DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Optional<TValue>, TValue, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue> source, Func<DataSource<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue>, DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Optional<TValue>, TValue, CustomValidator<TValue>> Assert<TValue>(this OptionalStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Optional<TValue>, TValue, EqualsValidator<TValue>> EqualTo<TValue>(this OptionalStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, EqualsValidator<TValue>> EqualTo<TSource, TValue>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<string>, string, string>, Optional<string>, string, EqualsValidator<string>> NotEmpty(this OptionalStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string, EqualsValidator<string>> NotEmpty<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<Guid>, Guid, Guid>, Optional<Guid>, Guid, EqualsValidator<Guid>> NotEmpty(this OptionalStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<Guid>, TSource, Guid>, Optional<Guid>, Guid, EqualsValidator<Guid>> NotEmpty<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<Guid>, TSource, Guid>, Optional<Guid>, Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Optional<byte>, byte, EqualsValidator<byte>> NotZero(this OptionalStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, EqualsValidator<byte>> NotZero<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Optional<sbyte>, sbyte, EqualsValidator<sbyte>> NotZero(this OptionalStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, EqualsValidator<sbyte>> NotZero<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, short, short>, Optional<short>, short, EqualsValidator<short>> NotZero(this OptionalStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, EqualsValidator<short>> NotZero<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Optional<ushort>, ushort, EqualsValidator<ushort>> NotZero(this OptionalStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, EqualsValidator<ushort>> NotZero<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, int, int>, Optional<int>, int, EqualsValidator<int>> NotZero(this OptionalStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, EqualsValidator<int>> NotZero<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Optional<uint>, uint, EqualsValidator<uint>> NotZero(this OptionalStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, EqualsValidator<uint>> NotZero<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, long, long>, Optional<long>, long, EqualsValidator<long>> NotZero(this OptionalStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, EqualsValidator<long>> NotZero<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Optional<ulong>, ulong, EqualsValidator<ulong>> NotZero(this OptionalStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, EqualsValidator<ulong>> NotZero<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<float>, float, float>, Optional<float>, float, EqualsValidator<float>> NotZero(this OptionalStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, EqualsValidator<float>> NotZero<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<double>, double, double>, Optional<double>, double, EqualsValidator<double>> NotZero(this OptionalStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, EqualsValidator<double>> NotZero<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Optional<decimal>, decimal, EqualsValidator<decimal>> NotZero(this OptionalStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, EqualsValidator<decimal>> NotZero<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>> InSet<TValue>(this OptionalStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>> InSet<TSource, TValue>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>> InSet<TValue>(this OptionalStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>> InSet<TSource, TValue>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> MultipleOf(this OptionalStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> MultipleOf(this OptionalStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, short, short>, Optional<short>, short, MultipleOfValidator_Int16> MultipleOf(this OptionalStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> MultipleOf(this OptionalStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, int, int>, Optional<int>, int, MultipleOfValidator_Int32> MultipleOf(this OptionalStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> MultipleOf(this OptionalStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, long, long>, Optional<long>, long, MultipleOfValidator_Int64> MultipleOf(this OptionalStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> MultipleOf(this OptionalStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Optional<decimal>, decimal, PrecisionValidator> Precision(this OptionalStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> Precision<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Optional<byte>, byte, RangeValidator_Byte> GreaterThan(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Optional<byte>, byte, RangeValidator_Byte> GreaterThanOrEqualTo(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Optional<byte>, byte, RangeValidator_Byte> LessThan(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte> LessThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Optional<byte>, byte, RangeValidator_Byte> LessThanOrEqualTo(this OptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, byte, byte>, Optional<byte>, byte, RangeValidator_Byte> InRange(this OptionalStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte> InRange<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> GreaterThan(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> GreaterThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> GreaterThanOrEqualTo(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> LessThan(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> LessThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> LessThanOrEqualTo(this OptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, sbyte, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> InRange(this OptionalStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> InRange<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, short, short>, Optional<short>, short, RangeValidator_Int16> GreaterThan(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16> GreaterThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, short, short>, Optional<short>, short, RangeValidator_Int16> GreaterThanOrEqualTo(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, short, short>, Optional<short>, short, RangeValidator_Int16> LessThan(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16> LessThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, short, short>, Optional<short>, short, RangeValidator_Int16> LessThanOrEqualTo(this OptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, short, short>, Optional<short>, short, RangeValidator_Int16> InRange(this OptionalStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16> InRange<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> GreaterThan(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> GreaterThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> GreaterThanOrEqualTo(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> LessThan(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> LessThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> LessThanOrEqualTo(this OptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, ushort, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> InRange(this OptionalStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> InRange<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, int, int>, Optional<int>, int, RangeValidator_Int32> GreaterThan(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32> GreaterThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, int, int>, Optional<int>, int, RangeValidator_Int32> GreaterThanOrEqualTo(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, int, int>, Optional<int>, int, RangeValidator_Int32> LessThan(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32> LessThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, int, int>, Optional<int>, int, RangeValidator_Int32> LessThanOrEqualTo(this OptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, int, int>, Optional<int>, int, RangeValidator_Int32> InRange(this OptionalStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32> InRange<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Optional<uint>, uint, RangeValidator_UInt32> GreaterThan(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32> GreaterThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Optional<uint>, uint, RangeValidator_UInt32> GreaterThanOrEqualTo(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Optional<uint>, uint, RangeValidator_UInt32> LessThan(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32> LessThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Optional<uint>, uint, RangeValidator_UInt32> LessThanOrEqualTo(this OptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, uint, uint>, Optional<uint>, uint, RangeValidator_UInt32> InRange(this OptionalStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32> InRange<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, long, long>, Optional<long>, long, RangeValidator_Int64> GreaterThan(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64> GreaterThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, long, long>, Optional<long>, long, RangeValidator_Int64> GreaterThanOrEqualTo(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, long, long>, Optional<long>, long, RangeValidator_Int64> LessThan(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64> LessThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, long, long>, Optional<long>, long, RangeValidator_Int64> LessThanOrEqualTo(this OptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, long, long>, Optional<long>, long, RangeValidator_Int64> InRange(this OptionalStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64> InRange<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> GreaterThan(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> GreaterThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> GreaterThanOrEqualTo(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> LessThan(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> LessThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> LessThanOrEqualTo(this OptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, ulong, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> InRange(this OptionalStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> InRange<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, float, float>, Optional<float>, float, RangeValidator_Single> GreaterThan(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single> GreaterThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, float, float>, Optional<float>, float, RangeValidator_Single> GreaterThanOrEqualTo(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, float, float>, Optional<float>, float, RangeValidator_Single> LessThan(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single> LessThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, float, float>, Optional<float>, float, RangeValidator_Single> LessThanOrEqualTo(this OptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single> LessThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, float, float>, Optional<float>, float, RangeValidator_Single> InRange(this OptionalStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single> InRange<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, double, double>, Optional<double>, double, RangeValidator_Double> GreaterThan(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double> GreaterThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, double, double>, Optional<double>, double, RangeValidator_Double> GreaterThanOrEqualTo(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, double, double>, Optional<double>, double, RangeValidator_Double> LessThan(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double> LessThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, double, double>, Optional<double>, double, RangeValidator_Double> LessThanOrEqualTo(this OptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double> LessThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, double, double>, Optional<double>, double, RangeValidator_Double> InRange(this OptionalStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double> InRange<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> GreaterThan(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> GreaterThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> GreaterThanOrEqualTo(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> LessThan(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> LessThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> LessThanOrEqualTo(this OptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, decimal, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> InRange(this OptionalStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> InRange<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime> GreaterThan(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime> GreaterThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime> GreaterThanOrEqualTo(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime> LessThan(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime> LessThan<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime> LessThanOrEqualTo(this OptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime> LessThanOrEqualTo<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, DateTime, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime> InRange(this OptionalStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime> InRange<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<string>, string, string>, Optional<string>, string, StringLengthValidator> Length(this OptionalStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string, StringLengthValidator> Length<TSource>(this DataSource<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, EqualsValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, EqualsValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, EqualsValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, EqualsValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, EqualsValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, EqualsValidator<TValue>> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, EqualsValidator<TValue>>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, EqualsValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, EqualsValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, EqualsValidator<TValue>> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, EqualsValidator<TValue>>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, EqualsValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue, InSetValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> InRange<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> InRange<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> InRange<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> InRange<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> InRange<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> InRange<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> InRange<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> InRange<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> InRange<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> InRange<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> InRange<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> InRange<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> InRange<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> InRange<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> InRange<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> InRange<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThan<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThan<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> InRange<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> InRange<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<byte>, TSource, byte>, Optional<byte>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<sbyte>, TSource, sbyte>, Optional<sbyte>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<short>, TSource, short>, Optional<short>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ushort>, TSource, ushort>, Optional<ushort>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<int>, TSource, int>, Optional<int>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<uint>, TSource, uint>, Optional<uint>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<long>, TSource, long>, Optional<long>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<ulong>, TSource, ulong>, Optional<ulong>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single, CustomValidator<float>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single, CustomValidator<float>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<float>, TSource, float>, Optional<float>, float, RangeValidator_Single, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double, CustomValidator<double>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double, CustomValidator<double>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<double>, TSource, double>, Optional<double>, double, RangeValidator_Double, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> Precision<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> Precision<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceStandardStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceInvertedStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceStandardInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceInvertedInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<decimal>, TSource, decimal>, Optional<decimal>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime, CustomValidator<DateTime>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime, CustomValidator<DateTime>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<DateTime>, TSource, DateTime>, Optional<DateTime>, DateTime, RangeValidator_DateTime, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string, StringLengthValidator, CustomValidator<string>> Assert<TSource>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string, StringLengthValidator> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string, StringLengthValidator, CustomValidator<string>> Assert<TSource>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string, StringLengthValidator> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceStandardInverted<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string, StringLengthValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string, StringLengthValidator> source, Func<DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string, StringLengthValidator>, DataSourceStandardStandard<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string, StringLengthValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string, StringLengthValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string, StringLengthValidator> source, Func<DataSourceInverted<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string, StringLengthValidator>, DataSourceInvertedStandard<OptionalDataContainerFactory<OptionalStateValidator<string>, TSource, string>, Optional<string>, string, StringLengthValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}