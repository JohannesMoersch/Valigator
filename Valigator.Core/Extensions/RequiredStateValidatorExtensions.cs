using System;
using System.Collections.Generic;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueValidators;

namespace Valigator
{
	public static class RequiredStateValidatorExtensions
	{
		public static MappedDataSource<RequiredStateValidator<TSource>, TSource, TValue> Map<TSource, TValue>(this RequiredStateValidator<TSource> source, Func<TSource, TValue> mapper)
			=> new MappedDataSource<RequiredStateValidator<TSource>, TSource, TValue>(source, mapper);

		public static DataSourceInverted<RequiredStateValidator<TSource>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this RequiredStateValidator<TSource> source, Func<RequiredStateValidator<TSource>, DataSourceStandard<RequiredStateValidator<TSource>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceInverted<RequiredStateValidator<TSource>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, TValue> source, Func<MappedDataSource<RequiredStateValidator<TSource>, TSource, TValue>, DataSourceStandard<RequiredStateValidator<TSource>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertOne();

		public static DataSourceStandard<RequiredStateValidator<TValue>, CustomValidator<TValue>, TValue, TValue> Assert<TValue>(this RequiredStateValidator<TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<RequiredStateValidator<TSource>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandard<RequiredStateValidator<TValue>, EqualsValidator<TValue>, TValue, TValue> EqualTo<TValue>(this RequiredStateValidator<TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceStandard<RequiredStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> EqualTo<TSource, TValue>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, TValue> source, TValue value)
			=> source.Add(new EqualsValidator<TValue>(value));

		public static DataSourceInverted<RequiredStateValidator<string>, EqualsValidator<string>, string, string> NotEmpty(this RequiredStateValidator<string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<string>, TSource, string> NotEmpty<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, string> source)
			=> source.Not(s => s.Add(new EqualsValidator<string>(String.Empty)));

		public static DataSourceInverted<RequiredStateValidator<Guid>, EqualsValidator<Guid>, Guid, Guid> NotEmpty(this RequiredStateValidator<Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<Guid>, TSource, Guid> NotEmpty<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, Guid> source)
			=> source.Not(s => s.Add(new EqualsValidator<Guid>(Guid.Empty)));

		public static DataSourceInverted<RequiredStateValidator<byte>, EqualsValidator<byte>, byte, byte> NotZero(this RequiredStateValidator<byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<byte>, TSource, byte> NotZero<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, byte> source)
			=> source.Not(s => s.Add(new EqualsValidator<byte>(0)));

		public static DataSourceInverted<RequiredStateValidator<sbyte>, EqualsValidator<sbyte>, sbyte, sbyte> NotZero(this RequiredStateValidator<sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<sbyte>, TSource, sbyte> NotZero<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, sbyte> source)
			=> source.Not(s => s.Add(new EqualsValidator<sbyte>(0)));

		public static DataSourceInverted<RequiredStateValidator<short>, EqualsValidator<short>, short, short> NotZero(this RequiredStateValidator<short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<short>, TSource, short> NotZero<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, short> source)
			=> source.Not(s => s.Add(new EqualsValidator<short>(0)));

		public static DataSourceInverted<RequiredStateValidator<ushort>, EqualsValidator<ushort>, ushort, ushort> NotZero(this RequiredStateValidator<ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<ushort>, TSource, ushort> NotZero<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, ushort> source)
			=> source.Not(s => s.Add(new EqualsValidator<ushort>(0)));

		public static DataSourceInverted<RequiredStateValidator<int>, EqualsValidator<int>, int, int> NotZero(this RequiredStateValidator<int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<int>, TSource, int> NotZero<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, int> source)
			=> source.Not(s => s.Add(new EqualsValidator<int>(0)));

		public static DataSourceInverted<RequiredStateValidator<uint>, EqualsValidator<uint>, uint, uint> NotZero(this RequiredStateValidator<uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<uint>, TSource, uint> NotZero<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, uint> source)
			=> source.Not(s => s.Add(new EqualsValidator<uint>(0)));

		public static DataSourceInverted<RequiredStateValidator<long>, EqualsValidator<long>, long, long> NotZero(this RequiredStateValidator<long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<long>, TSource, long> NotZero<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, long> source)
			=> source.Not(s => s.Add(new EqualsValidator<long>(0)));

		public static DataSourceInverted<RequiredStateValidator<ulong>, EqualsValidator<ulong>, ulong, ulong> NotZero(this RequiredStateValidator<ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<ulong>, TSource, ulong> NotZero<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, ulong> source)
			=> source.Not(s => s.Add(new EqualsValidator<ulong>(0)));

		public static DataSourceInverted<RequiredStateValidator<float>, EqualsValidator<float>, float, float> NotZero(this RequiredStateValidator<float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<float>, TSource, float> NotZero<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, float> source)
			=> source.Not(s => s.Add(new EqualsValidator<float>(0)));

		public static DataSourceInverted<RequiredStateValidator<double>, EqualsValidator<double>, double, double> NotZero(this RequiredStateValidator<double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<double>, TSource, double> NotZero<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, double> source)
			=> source.Not(s => s.Add(new EqualsValidator<double>(0)));

		public static DataSourceInverted<RequiredStateValidator<decimal>, EqualsValidator<decimal>, decimal, decimal> NotZero(this RequiredStateValidator<decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<decimal>, TSource, decimal> NotZero<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, decimal> source)
			=> source.Not(s => s.Add(new EqualsValidator<decimal>(0)));

		public static DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue, TValue> InSet<TValue>(this RequiredStateValidator<TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<RequiredStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> InSet<TSource, TValue>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, TValue> source, params TValue[] options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<RequiredStateValidator<TValue>, InSetValidator<TValue>, TValue, TValue> InSet<TValue>(this RequiredStateValidator<TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<RequiredStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> InSet<TSource, TValue>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, TValue> source, ISet<TValue> options)
			=> source.Add(new InSetValidator<TValue>(options));

		public static DataSourceStandard<RequiredStateValidator<byte>, MultipleOfValidator_Byte, byte, byte> MultipleOf(this RequiredStateValidator<byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> MultipleOf<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, MultipleOfValidator_SByte, sbyte, sbyte> MultipleOf(this RequiredStateValidator<sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> MultipleOf<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandard<RequiredStateValidator<short>, MultipleOfValidator_Int16, short, short> MultipleOf(this RequiredStateValidator<short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> MultipleOf<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandard<RequiredStateValidator<ushort>, MultipleOfValidator_UInt16, ushort, ushort> MultipleOf(this RequiredStateValidator<ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> MultipleOf<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandard<RequiredStateValidator<int>, MultipleOfValidator_Int32, int, int> MultipleOf(this RequiredStateValidator<int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> MultipleOf<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandard<RequiredStateValidator<uint>, MultipleOfValidator_UInt32, uint, uint> MultipleOf(this RequiredStateValidator<uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> MultipleOf<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandard<RequiredStateValidator<long>, MultipleOfValidator_Int64, long, long> MultipleOf(this RequiredStateValidator<long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> MultipleOf<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandard<RequiredStateValidator<ulong>, MultipleOfValidator_UInt64, ulong, ulong> MultipleOf(this RequiredStateValidator<ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> MultipleOf<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandard<RequiredStateValidator<decimal>, PrecisionValidator, decimal, decimal> Precision(this RequiredStateValidator<decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> Precision<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte, byte> GreaterThan(this RequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, TSource, byte> GreaterThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte, byte> GreaterThanOrEqualTo(this RequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, TSource, byte> GreaterThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte, byte> LessThan(this RequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, TSource, byte> LessThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte, byte> LessThanOrEqualTo(this RequiredStateValidator<byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, TSource, byte> LessThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<byte>, RangeValidator_Byte, byte, byte> InRange(this RequiredStateValidator<byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, TSource, byte> InRange<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> GreaterThan(this RequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> GreaterThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> GreaterThanOrEqualTo(this RequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> GreaterThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> LessThan(this RequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> LessThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> LessThanOrEqualTo(this RequiredStateValidator<sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> LessThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<sbyte>, RangeValidator_SByte, sbyte, sbyte> InRange(this RequiredStateValidator<sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> InRange<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short, short> GreaterThan(this RequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, TSource, short> GreaterThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short, short> GreaterThanOrEqualTo(this RequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, TSource, short> GreaterThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short, short> LessThan(this RequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, TSource, short> LessThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short, short> LessThanOrEqualTo(this RequiredStateValidator<short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, TSource, short> LessThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<short>, RangeValidator_Int16, short, short> InRange(this RequiredStateValidator<short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, TSource, short> InRange<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> GreaterThan(this RequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> GreaterThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> GreaterThanOrEqualTo(this RequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> GreaterThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> LessThan(this RequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> LessThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> LessThanOrEqualTo(this RequiredStateValidator<ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> LessThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<ushort>, RangeValidator_UInt16, ushort, ushort> InRange(this RequiredStateValidator<ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> InRange<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int, int> GreaterThan(this RequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, TSource, int> GreaterThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int, int> GreaterThanOrEqualTo(this RequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, TSource, int> GreaterThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int, int> LessThan(this RequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, TSource, int> LessThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int, int> LessThanOrEqualTo(this RequiredStateValidator<int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, TSource, int> LessThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<int>, RangeValidator_Int32, int, int> InRange(this RequiredStateValidator<int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, TSource, int> InRange<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint, uint> GreaterThan(this RequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> GreaterThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint, uint> GreaterThanOrEqualTo(this RequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> GreaterThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint, uint> LessThan(this RequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> LessThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint, uint> LessThanOrEqualTo(this RequiredStateValidator<uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> LessThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<uint>, RangeValidator_UInt32, uint, uint> InRange(this RequiredStateValidator<uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> InRange<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long, long> GreaterThan(this RequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, TSource, long> GreaterThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long, long> GreaterThanOrEqualTo(this RequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, TSource, long> GreaterThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long, long> LessThan(this RequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, TSource, long> LessThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long, long> LessThanOrEqualTo(this RequiredStateValidator<long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, TSource, long> LessThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<long>, RangeValidator_Int64, long, long> InRange(this RequiredStateValidator<long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, TSource, long> InRange<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> GreaterThan(this RequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> GreaterThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> GreaterThanOrEqualTo(this RequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> GreaterThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> LessThan(this RequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> LessThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> LessThanOrEqualTo(this RequiredStateValidator<ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> LessThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<ulong>, RangeValidator_UInt64, ulong, ulong> InRange(this RequiredStateValidator<ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> InRange<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float, float> GreaterThan(this RequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Single, TSource, float> GreaterThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float, float> GreaterThanOrEqualTo(this RequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Single, TSource, float> GreaterThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float, float> LessThan(this RequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Single, TSource, float> LessThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float, float> LessThanOrEqualTo(this RequiredStateValidator<float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Single, TSource, float> LessThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, float> source, float value)
			=> source.Add(new RangeValidator_Single(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<float>, RangeValidator_Single, float, float> InRange(this RequiredStateValidator<float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Single, TSource, float> InRange<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, float> source, float? greaterThan = null, float? greaterThanOrEqualTo = null, float? lessThan = null, float? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Single(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double, double> GreaterThan(this RequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Double, TSource, double> GreaterThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double, double> GreaterThanOrEqualTo(this RequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Double, TSource, double> GreaterThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double, double> LessThan(this RequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Double, TSource, double> LessThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double, double> LessThanOrEqualTo(this RequiredStateValidator<double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Double, TSource, double> LessThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, double> source, double value)
			=> source.Add(new RangeValidator_Double(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<double>, RangeValidator_Double, double, double> InRange(this RequiredStateValidator<double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Double, TSource, double> InRange<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, double> source, double? greaterThan = null, double? greaterThanOrEqualTo = null, double? lessThan = null, double? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Double(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> GreaterThan(this RequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> GreaterThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> GreaterThanOrEqualTo(this RequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> GreaterThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> LessThan(this RequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> LessThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> LessThanOrEqualTo(this RequiredStateValidator<decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> LessThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<decimal>, RangeValidator_Decimal, decimal, decimal> InRange(this RequiredStateValidator<decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> InRange<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> GreaterThan(this RequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> GreaterThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(value, null, null, null));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> GreaterThanOrEqualTo(this RequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> GreaterThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, value, null, null));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> LessThan(this RequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> LessThan<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, value, null));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> LessThanOrEqualTo(this RequiredStateValidator<DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> LessThanOrEqualTo<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, DateTime> source, DateTime value)
			=> source.Add(new RangeValidator_DateTime(null, null, null, value));

		public static DataSourceStandard<RequiredStateValidator<DateTime>, RangeValidator_DateTime, DateTime, DateTime> InRange(this RequiredStateValidator<DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> InRange<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, DateTime> source, DateTime? greaterThan = null, DateTime? greaterThanOrEqualTo = null, DateTime? lessThan = null, DateTime? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_DateTime(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandard<RequiredStateValidator<string>, StringLengthValidator, string, string> Length(this RequiredStateValidator<string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandard<RequiredStateValidator<TSource>, StringLengthValidator, TSource, string> Length<TSource>(this MappedDataSource<RequiredStateValidator<TSource>, TSource, string> source, int? minimumLength = null, int? maximumLength = null)
			=> source.Add(new StringLengthValidator(minimumLength, maximumLength));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, EqualsValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this DataSourceStandard<RequiredStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, EqualsValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this DataSourceStandard<RequiredStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue>, DataSourceStandardStandard<RequiredStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, EqualsValidator<TValue>, TSource, TValue>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, EqualsValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, InSetValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this DataSourceStandard<RequiredStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, InSetValidator<TValue>, CustomValidator<TValue>, TSource, TValue> Assert<TSource, TValue>(this DataSourceInverted<RequiredStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, string description, Func<TValue, bool> validator)
			=> source.Add(new CustomValidator<TValue>(description, validator));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this DataSourceStandard<RequiredStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue>, DataSourceStandardStandard<RequiredStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue> Not<TSource, TValueValidator, TValue>(this DataSourceInverted<RequiredStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, InSetValidator<TValue>, TSource, TValue>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, InSetValidator<TValue>, TValueValidator, TSource, TValue>> validatorFactory)
			where TValueValidator : IValueValidator<TValue>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> LessThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte value)
			=> source.Add(new RangeValidator_Byte(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> InRange<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> InRange<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, byte? greaterThan = null, byte? greaterThanOrEqualTo = null, byte? lessThan = null, byte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Byte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte>, DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TSource, byte>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TSource, byte>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Byte, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> LessThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte value)
			=> source.Add(new RangeValidator_SByte(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> InRange<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> InRange<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, sbyte? greaterThan = null, sbyte? greaterThanOrEqualTo = null, sbyte? lessThan = null, sbyte? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_SByte(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte>, DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TSource, sbyte>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TSource, sbyte>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_SByte, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> LessThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short value)
			=> source.Add(new RangeValidator_Int16(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> InRange<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> InRange<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, short? greaterThan = null, short? greaterThanOrEqualTo = null, short? lessThan = null, short? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short>, DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TSource, short>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TSource, short>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int16, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> LessThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort value)
			=> source.Add(new RangeValidator_UInt16(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> InRange<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> InRange<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, ushort? greaterThan = null, ushort? greaterThanOrEqualTo = null, ushort? lessThan = null, ushort? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt16(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort>, DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TSource, ushort>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TSource, ushort>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt16, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> LessThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int value)
			=> source.Add(new RangeValidator_Int32(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> InRange<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> InRange<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, int? greaterThan = null, int? greaterThanOrEqualTo = null, int? lessThan = null, int? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int>, DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TSource, int>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TSource, int>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int32, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> LessThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint value)
			=> source.Add(new RangeValidator_UInt32(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> InRange<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> InRange<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, uint? greaterThan = null, uint? greaterThanOrEqualTo = null, uint? lessThan = null, uint? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt32(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint>, DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TSource, uint>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TSource, uint>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt32, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> LessThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long value)
			=> source.Add(new RangeValidator_Int64(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> InRange<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> InRange<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, long? greaterThan = null, long? greaterThanOrEqualTo = null, long? lessThan = null, long? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Int64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long>, DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TSource, long>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TSource, long>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_Int64, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> LessThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong value)
			=> source.Add(new RangeValidator_UInt64(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> InRange<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> InRange<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, ulong? greaterThan = null, ulong? greaterThanOrEqualTo = null, ulong? lessThan = null, ulong? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_UInt64(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong>, DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TSource, ulong>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TSource, ulong>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, MultipleOfValidator_UInt64, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(value, null, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> GreaterThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, value, null, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThan<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThan<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, value, null));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThanOrEqualTo<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> LessThanOrEqualTo<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal value)
			=> source.Add(new RangeValidator_Decimal(null, null, null, value));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> InRange<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> InRange<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, decimal? greaterThan = null, decimal? greaterThanOrEqualTo = null, decimal? lessThan = null, decimal? lessThanOrEqualTo = null)
			=> source.Add(new RangeValidator_Decimal(greaterThan, greaterThanOrEqualTo, lessThan, lessThanOrEqualTo));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal>, DataSourceStandardStandard<RequiredStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, PrecisionValidator, TSource, decimal>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TSource, decimal>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, PrecisionValidator, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> MultipleOf<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> MultipleOf<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, byte divisor)
			=> source.Add(new MultipleOfValidator_Byte(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, TSource, byte>, DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, TSource, byte> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, TSource, byte>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, CustomValidator<byte>, TSource, byte> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, string description, Func<byte, bool> validator)
			=> source.Add(new CustomValidator<byte>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TSource, byte>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Byte, MultipleOfValidator_Byte, TValueValidator, TSource, byte>> validatorFactory)
			where TValueValidator : IValueValidator<byte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> MultipleOf<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> MultipleOf<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, sbyte divisor)
			=> source.Add(new MultipleOfValidator_SByte(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte>, DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, TSource, sbyte>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, CustomValidator<sbyte>, TSource, sbyte> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, string description, Func<sbyte, bool> validator)
			=> source.Add(new CustomValidator<sbyte>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TSource, sbyte>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_SByte, MultipleOfValidator_SByte, TValueValidator, TSource, sbyte>> validatorFactory)
			where TValueValidator : IValueValidator<sbyte>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> MultipleOf<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> MultipleOf<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, short divisor)
			=> source.Add(new MultipleOfValidator_Int16(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, TSource, short>, DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, TSource, short> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, TSource, short>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, CustomValidator<short>, TSource, short> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, string description, Func<short, bool> validator)
			=> source.Add(new CustomValidator<short>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TSource, short>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int16, MultipleOfValidator_Int16, TValueValidator, TSource, short>> validatorFactory)
			where TValueValidator : IValueValidator<short>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> MultipleOf<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> MultipleOf<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, ushort divisor)
			=> source.Add(new MultipleOfValidator_UInt16(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort>, DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, TSource, ushort>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, CustomValidator<ushort>, TSource, ushort> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, string description, Func<ushort, bool> validator)
			=> source.Add(new CustomValidator<ushort>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TSource, ushort>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt16, MultipleOfValidator_UInt16, TValueValidator, TSource, ushort>> validatorFactory)
			where TValueValidator : IValueValidator<ushort>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> MultipleOf<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> MultipleOf<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, int divisor)
			=> source.Add(new MultipleOfValidator_Int32(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, TSource, int>, DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, TSource, int> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, TSource, int>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, CustomValidator<int>, TSource, int> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, string description, Func<int, bool> validator)
			=> source.Add(new CustomValidator<int>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TSource, int>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int32, MultipleOfValidator_Int32, TValueValidator, TSource, int>> validatorFactory)
			where TValueValidator : IValueValidator<int>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> MultipleOf<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> MultipleOf<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, uint divisor)
			=> source.Add(new MultipleOfValidator_UInt32(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, TSource, uint>, DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, TSource, uint> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, TSource, uint>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, CustomValidator<uint>, TSource, uint> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, string description, Func<uint, bool> validator)
			=> source.Add(new CustomValidator<uint>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TSource, uint>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt32, MultipleOfValidator_UInt32, TValueValidator, TSource, uint>> validatorFactory)
			where TValueValidator : IValueValidator<uint>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> MultipleOf<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> MultipleOf<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, long divisor)
			=> source.Add(new MultipleOfValidator_Int64(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, TSource, long>, DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, TSource, long> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, TSource, long>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, CustomValidator<long>, TSource, long> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, string description, Func<long, bool> validator)
			=> source.Add(new CustomValidator<long>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TSource, long>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Int64, MultipleOfValidator_Int64, TValueValidator, TSource, long>> validatorFactory)
			where TValueValidator : IValueValidator<long>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> MultipleOf<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> MultipleOf<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, ulong divisor)
			=> source.Add(new MultipleOfValidator_UInt64(divisor));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong>, DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, TSource, ulong>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, CustomValidator<ulong>, TSource, ulong> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, string description, Func<ulong, bool> validator)
			=> source.Add(new CustomValidator<ulong>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TSource, ulong>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_UInt64, MultipleOfValidator_UInt64, TValueValidator, TSource, ulong>> validatorFactory)
			where TValueValidator : IValueValidator<ulong>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Single, CustomValidator<float>, TSource, float> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Single, TSource, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Single, CustomValidator<float>, TSource, float> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Single, TSource, float> source, string description, Func<float, bool> validator)
			=> source.Add(new CustomValidator<float>(description, validator));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Single, TSource, float> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Single, TSource, float>, DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Single, TSource, float> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Single, TSource, float>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Single, TValueValidator, TSource, float>> validatorFactory)
			where TValueValidator : IValueValidator<float>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Double, CustomValidator<double>, TSource, double> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Double, TSource, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Double, CustomValidator<double>, TSource, double> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Double, TSource, double> source, string description, Func<double, bool> validator)
			=> source.Add(new CustomValidator<double>(description, validator));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Double, TSource, double> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Double, TSource, double>, DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Double, TSource, double> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Double, TSource, double>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Double, TValueValidator, TSource, double>> validatorFactory)
			where TValueValidator : IValueValidator<double>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> Precision<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> Precision<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, decimal? minimumDecimalPlaces = null, decimal? maximumDecimalPlaces = null)
			=> source.Add(new PrecisionValidator(minimumDecimalPlaces, maximumDecimalPlaces));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal>, DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, TSource, decimal>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, CustomValidator<decimal>, TSource, decimal> Assert<TSource>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, string description, Func<decimal, bool> validator)
			=> source.Add(new CustomValidator<decimal>(description, validator));

		public static DataSourceStandardStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, DataSourceStandardStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, DataSourceInvertedStandardStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, DataSourceStandardInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceInvertedInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal> Not<TSource, TValueValidator>(this DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal> source, Func<DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TSource, decimal>, DataSourceInvertedInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_Decimal, PrecisionValidator, TValueValidator, TSource, decimal>> validatorFactory)
			where TValueValidator : IValueValidator<decimal>
			=> validatorFactory.Invoke(source).InvertThree();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_DateTime, CustomValidator<DateTime>, TSource, DateTime> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_DateTime, CustomValidator<DateTime>, TSource, DateTime> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, string description, Func<DateTime, bool> validator)
			=> source.Add(new CustomValidator<DateTime>(description, validator));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime>, DataSourceStandardStandard<RequiredStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, RangeValidator_DateTime, TSource, DateTime>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, RangeValidator_DateTime, TValueValidator, TSource, DateTime>> validatorFactory)
			where TValueValidator : IValueValidator<DateTime>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceStandardStandard<RequiredStateValidator<TSource>, StringLengthValidator, CustomValidator<string>, TSource, string> Assert<TSource>(this DataSourceStandard<RequiredStateValidator<TSource>, StringLengthValidator, TSource, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceInvertedStandard<RequiredStateValidator<TSource>, StringLengthValidator, CustomValidator<string>, TSource, string> Assert<TSource>(this DataSourceInverted<RequiredStateValidator<TSource>, StringLengthValidator, TSource, string> source, string description, Func<string, bool> validator)
			=> source.Add(new CustomValidator<string>(description, validator));

		public static DataSourceStandardInverted<RequiredStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string> Not<TSource, TValueValidator>(this DataSourceStandard<RequiredStateValidator<TSource>, StringLengthValidator, TSource, string> source, Func<DataSourceStandard<RequiredStateValidator<TSource>, StringLengthValidator, TSource, string>, DataSourceStandardStandard<RequiredStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();

		public static DataSourceInvertedInverted<RequiredStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string> Not<TSource, TValueValidator>(this DataSourceInverted<RequiredStateValidator<TSource>, StringLengthValidator, TSource, string> source, Func<DataSourceInverted<RequiredStateValidator<TSource>, StringLengthValidator, TSource, string>, DataSourceInvertedStandard<RequiredStateValidator<TSource>, StringLengthValidator, TValueValidator, TSource, string>> validatorFactory)
			where TValueValidator : IValueValidator<string>
			=> validatorFactory.Invoke(source).InvertTwo();
	}
}