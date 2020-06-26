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
	public static class NullableOptionalStateValidatorExtensions
	{
		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TValue, TValue>, Optional<Option<TValue>>, TValue, TValueValidator> Not<TValue, TValueValidator>(this NullableOptionalStateValidator<TValue> source, Func<NullableOptionalStateValidator<TValue>, DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TValue, TValue>, Optional<Option<TValue>>, TValue, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue> source, Func<DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue>, DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TValue, TValue>, Optional<Option<TValue>>, TValue, CustomValidator<TValue>> Assert<TValue>(this NullableOptionalStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TValue, TValue>, Optional<Option<TValue>>, TValue, EqualsValidator<TValue>> EqualTo<TValue>(this NullableOptionalStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, EqualsValidator<TValue>> EqualTo<TSource, TValue>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, string, string>, Optional<Option<string>>, string, EqualsValidator<string>> NotEmpty(this NullableOptionalStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string, EqualsValidator<string>> NotEmpty<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<Guid>, Guid, Guid>, Optional<Option<Guid>>, Guid, EqualsValidator<Guid>> NotEmpty(this NullableOptionalStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<Guid>, TSource, Guid>, Optional<Option<Guid>>, Guid, EqualsValidator<Guid>> NotEmpty<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<Guid>, TSource, Guid>, Optional<Option<Guid>>, Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, byte, byte>, Optional<Option<byte>>, byte, EqualsValidator<byte>> NotZero(this NullableOptionalStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, EqualsValidator<byte>> NotZero<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, sbyte, sbyte>, Optional<Option<sbyte>>, sbyte, EqualsValidator<sbyte>> NotZero(this NullableOptionalStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, EqualsValidator<sbyte>> NotZero<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, short, short>, Optional<Option<short>>, short, EqualsValidator<short>> NotZero(this NullableOptionalStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, EqualsValidator<short>> NotZero<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, ushort, ushort>, Optional<Option<ushort>>, ushort, EqualsValidator<ushort>> NotZero(this NullableOptionalStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, EqualsValidator<ushort>> NotZero<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, int, int>, Optional<Option<int>>, int, EqualsValidator<int>> NotZero(this NullableOptionalStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, EqualsValidator<int>> NotZero<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, uint, uint>, Optional<Option<uint>>, uint, EqualsValidator<uint>> NotZero(this NullableOptionalStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, EqualsValidator<uint>> NotZero<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, long, long>, Optional<Option<long>>, long, EqualsValidator<long>> NotZero(this NullableOptionalStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, EqualsValidator<long>> NotZero<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, ulong, ulong>, Optional<Option<ulong>>, ulong, EqualsValidator<ulong>> NotZero(this NullableOptionalStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, EqualsValidator<ulong>> NotZero<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, float, float>, Optional<Option<float>>, float, EqualsValidator<float>> NotZero(this NullableOptionalStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, EqualsValidator<float>> NotZero<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, double, double>, Optional<Option<double>>, double, EqualsValidator<double>> NotZero(this NullableOptionalStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, EqualsValidator<double>> NotZero<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, decimal, decimal>, Optional<Option<decimal>>, decimal, EqualsValidator<decimal>> NotZero(this NullableOptionalStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, EqualsValidator<decimal>> NotZero<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TValue, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>> InSet<TValue>(this NullableOptionalStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>> InSet<TSource, TValue>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TValue, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>> InSet<TValue>(this NullableOptionalStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>> InSet<TSource, TValue>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, byte, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> MultipleOf(this NullableOptionalStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, sbyte, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> MultipleOf(this NullableOptionalStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, short, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> MultipleOf(this NullableOptionalStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, ushort, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> MultipleOf(this NullableOptionalStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, int, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> MultipleOf(this NullableOptionalStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, uint, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> MultipleOf(this NullableOptionalStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, long, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> MultipleOf(this NullableOptionalStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, ulong, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> MultipleOf(this NullableOptionalStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, decimal, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> Precision(this NullableOptionalStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> Precision<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, byte, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> GreaterThan(this NullableOptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, byte, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> GreaterThanOrEqualTo(this NullableOptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, byte, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> LessThan(this NullableOptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> LessThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, byte, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> LessThanOrEqualTo(this NullableOptionalStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, byte, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> InRange(this NullableOptionalStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> InRange<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, sbyte, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> GreaterThan(this NullableOptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> GreaterThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, sbyte, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> GreaterThanOrEqualTo(this NullableOptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, sbyte, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> LessThan(this NullableOptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> LessThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, sbyte, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> LessThanOrEqualTo(this NullableOptionalStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, sbyte, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> InRange(this NullableOptionalStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> InRange<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, short, short>, Optional<Option<short>>, short, RangeValidator_Int16> GreaterThan(this NullableOptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16> GreaterThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, short, short>, Optional<Option<short>>, short, RangeValidator_Int16> GreaterThanOrEqualTo(this NullableOptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, short, short>, Optional<Option<short>>, short, RangeValidator_Int16> LessThan(this NullableOptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16> LessThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, short, short>, Optional<Option<short>>, short, RangeValidator_Int16> LessThanOrEqualTo(this NullableOptionalStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, short, short>, Optional<Option<short>>, short, RangeValidator_Int16> InRange(this NullableOptionalStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16> InRange<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, ushort, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> GreaterThan(this NullableOptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> GreaterThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, ushort, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> GreaterThanOrEqualTo(this NullableOptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, ushort, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> LessThan(this NullableOptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> LessThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, ushort, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> LessThanOrEqualTo(this NullableOptionalStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, ushort, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> InRange(this NullableOptionalStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> InRange<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, int, int>, Optional<Option<int>>, int, RangeValidator_Int32> GreaterThan(this NullableOptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32> GreaterThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, int, int>, Optional<Option<int>>, int, RangeValidator_Int32> GreaterThanOrEqualTo(this NullableOptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, int, int>, Optional<Option<int>>, int, RangeValidator_Int32> LessThan(this NullableOptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32> LessThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, int, int>, Optional<Option<int>>, int, RangeValidator_Int32> LessThanOrEqualTo(this NullableOptionalStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, int, int>, Optional<Option<int>>, int, RangeValidator_Int32> InRange(this NullableOptionalStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32> InRange<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, uint, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> GreaterThan(this NullableOptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> GreaterThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, uint, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> GreaterThanOrEqualTo(this NullableOptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, uint, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> LessThan(this NullableOptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> LessThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, uint, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> LessThanOrEqualTo(this NullableOptionalStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, uint, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> InRange(this NullableOptionalStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> InRange<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, long, long>, Optional<Option<long>>, long, RangeValidator_Int64> GreaterThan(this NullableOptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64> GreaterThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, long, long>, Optional<Option<long>>, long, RangeValidator_Int64> GreaterThanOrEqualTo(this NullableOptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, long, long>, Optional<Option<long>>, long, RangeValidator_Int64> LessThan(this NullableOptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64> LessThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, long, long>, Optional<Option<long>>, long, RangeValidator_Int64> LessThanOrEqualTo(this NullableOptionalStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, long, long>, Optional<Option<long>>, long, RangeValidator_Int64> InRange(this NullableOptionalStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64> InRange<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, ulong, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> GreaterThan(this NullableOptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> GreaterThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, ulong, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> GreaterThanOrEqualTo(this NullableOptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, ulong, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> LessThan(this NullableOptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> LessThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, ulong, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> LessThanOrEqualTo(this NullableOptionalStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, ulong, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> InRange(this NullableOptionalStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> InRange<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, float, float>, Optional<Option<float>>, float, RangeValidator_Single> GreaterThan(this NullableOptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single> GreaterThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, float, float>, Optional<Option<float>>, float, RangeValidator_Single> GreaterThanOrEqualTo(this NullableOptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, float, float>, Optional<Option<float>>, float, RangeValidator_Single> LessThan(this NullableOptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single> LessThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, float, float>, Optional<Option<float>>, float, RangeValidator_Single> LessThanOrEqualTo(this NullableOptionalStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single> LessThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, float, float>, Optional<Option<float>>, float, RangeValidator_Single> InRange(this NullableOptionalStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single> InRange<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, double, double>, Optional<Option<double>>, double, RangeValidator_Double> GreaterThan(this NullableOptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double> GreaterThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, double, double>, Optional<Option<double>>, double, RangeValidator_Double> GreaterThanOrEqualTo(this NullableOptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, double, double>, Optional<Option<double>>, double, RangeValidator_Double> LessThan(this NullableOptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double> LessThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, double, double>, Optional<Option<double>>, double, RangeValidator_Double> LessThanOrEqualTo(this NullableOptionalStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double> LessThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, double, double>, Optional<Option<double>>, double, RangeValidator_Double> InRange(this NullableOptionalStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double> InRange<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, decimal, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> GreaterThan(this NullableOptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> GreaterThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, decimal, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> GreaterThanOrEqualTo(this NullableOptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, decimal, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> LessThan(this NullableOptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> LessThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, decimal, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> LessThanOrEqualTo(this NullableOptionalStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, decimal, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> InRange(this NullableOptionalStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> InRange<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, DateTime, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime> GreaterThan(this NullableOptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime> GreaterThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, DateTime, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime> GreaterThanOrEqualTo(this NullableOptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime> GreaterThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, DateTime, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime> LessThan(this NullableOptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime> LessThan<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, DateTime, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime> LessThanOrEqualTo(this NullableOptionalStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime> LessThanOrEqualTo<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, DateTime, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime> InRange(this NullableOptionalStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime> InRange<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, string, string>, Optional<Option<string>>, string, StringLengthValidator> Length(this NullableOptionalStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string, StringLengthValidator> Length<TSource>(this DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, EqualsValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, EqualsValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, EqualsValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, EqualsValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, EqualsValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, EqualsValidator<TValue>> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, EqualsValidator<TValue>>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, EqualsValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, EqualsValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, EqualsValidator<TValue>> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, EqualsValidator<TValue>>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, EqualsValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>, CustomValidator<TValue>> Assert<TSource, TValue>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>, TValueValidator> Not<TSource, TValue, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue, InSetValidator<TValue>, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> InRange<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> InRange<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> InRange<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> InRange<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> InRange<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> InRange<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> InRange<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> InRange<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> InRange<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> InRange<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> InRange<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> InRange<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> InRange<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> InRange<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> InRange<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> InRange<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThan<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThan<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> LessThanOrEqualTo<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> InRange<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> InRange<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, PrecisionValidator, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> MultipleOf<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<byte>, TSource, byte>, Optional<Option<byte>>, byte, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> MultipleOf<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<sbyte>, TSource, sbyte>, Optional<Option<sbyte>>, sbyte, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16> MultipleOf<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<short>, TSource, short>, Optional<Option<short>>, short, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> MultipleOf<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ushort>, TSource, ushort>, Optional<Option<ushort>>, ushort, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32> MultipleOf<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<int>, TSource, int>, Optional<Option<int>>, int, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> MultipleOf<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<uint>, TSource, uint>, Optional<Option<uint>>, uint, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64> MultipleOf<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<long>, TSource, long>, Optional<Option<long>>, long, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> MultipleOf<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<ulong>, TSource, ulong>, Optional<Option<ulong>>, ulong, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single, CustomValidator<float>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single, CustomValidator<float>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<float>, TSource, float>, Optional<Option<float>>, float, RangeValidator_Single, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double, CustomValidator<double>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double, CustomValidator<double>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<double>, TSource, double>, Optional<Option<double>>, double, RangeValidator_Double, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, CustomValidator<decimal>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator> Precision<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator> Precision<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>> Assert<TSource>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceStandardStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceInvertedStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceStandardInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator> source, Func<DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator>, DataSourceInvertedInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<decimal>, TSource, decimal>, Optional<Option<decimal>>, decimal, RangeValidator_Decimal, PrecisionValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime, CustomValidator<DateTime>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime, CustomValidator<DateTime>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<DateTime>, TSource, DateTime>, Optional<Option<DateTime>>, DateTime, RangeValidator_DateTime, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string, StringLengthValidator, CustomValidator<string>> Assert<TSource>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string, StringLengthValidator> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string, StringLengthValidator, CustomValidator<string>> Assert<TSource>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string, StringLengthValidator> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceStandardInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string, StringLengthValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string, StringLengthValidator> source, Func<DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string, StringLengthValidator>, DataSourceStandardStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string, StringLengthValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string, StringLengthValidator, TValueValidator> Not<TSource, TValueValidator>(this DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string, StringLengthValidator> source, Func<DataSourceInverted<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string, StringLengthValidator>, DataSourceInvertedStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<string>, TSource, string>, Optional<Option<string>>, string, StringLengthValidator, TValueValidator>> validatorFactory)
			where TValueValidator : struct, IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}