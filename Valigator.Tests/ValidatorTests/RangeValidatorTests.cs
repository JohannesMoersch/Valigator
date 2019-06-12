using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Valigator.Core.ValueValidators;
using Xunit;

namespace Valigator.Tests.ValidatorTests
{
	public class RangeValidatorTests
	{
		public class ByteTests
		{
			[Theory]
			[InlineData(false, false, false, false)]
			[InlineData(true, true, false, false)]
			[InlineData(false, false, true, true)]
			[InlineData(true, true, true, true)]
			[InlineData(false, true, false, true)]
			[InlineData(false, true, true, false)]
			[InlineData(true, false, false, true)]
			[InlineData(true, false, true, false)]
			public void InvalidParameters(bool lessThan, bool lessThanOrEqualTo, bool greaterThan, bool greaterThanOrEqualTo)
				=> Assert.Throws<ArgumentException>(() => new RangeValidator_Byte(lessThan ? (byte?)0 : null, lessThanOrEqualTo ? (byte?)0 : null, greaterThan ? (byte?)0 : null, greaterThanOrEqualTo ? (byte?)0 : null));

			[Fact]
			public void BelowLessThanValue()
				=> new RangeValidator_Byte(null, null, 10, null)
					.IsValid((byte)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanValue()
				=> new RangeValidator_Byte(null, null, 10, null)
					.IsValid((byte)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveLessThanValue()
				=> new RangeValidator_Byte(null, null, 10, null)
					.IsValid((byte)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowLessThanOrEqualToValue()
				=> new RangeValidator_Byte(null, null, null, 10)
					.IsValid((byte)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanOrEqualToValue()
				=> new RangeValidator_Byte(null, null, null, 10)
					.IsValid((byte)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveLessThanOrEqualToValue()
				=> new RangeValidator_Byte(null, null, null, 10)
					.IsValid((byte)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowGreaterThanValue()
				=> new RangeValidator_Byte(10, null, null, null)
					.IsValid((byte)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanValue()
				=> new RangeValidator_Byte(10, null, null, null)
					.IsValid((byte)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveGreaterThanValue()
				=> new RangeValidator_Byte(10, null, null, null)
					.IsValid((byte)11)
					.Should()
					.BeTrue();

			[Fact]
			public void BelowGreaterThanOrEqualToValue()
				=> new RangeValidator_Byte(null, 10, null, null)
					.IsValid((byte)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanOrEqualToValue()
				=> new RangeValidator_Byte(null, 10, null, null)
					.IsValid((byte)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveGreaterThanOrEqualToValue()
				=> new RangeValidator_Byte(null, 10, null, null)
					.IsValid((byte)11)
					.Should()
					.BeTrue();
		}

		public class SByteTests
		{
			[Theory]
			[InlineData(false, false, false, false)]
			[InlineData(true, true, false, false)]
			[InlineData(false, false, true, true)]
			[InlineData(true, true, true, true)]
			[InlineData(false, true, false, true)]
			[InlineData(false, true, true, false)]
			[InlineData(true, false, false, true)]
			[InlineData(true, false, true, false)]
			public void InvalidParameters(bool lessThan, bool lessThanOrEqualTo, bool greaterThan, bool greaterThanOrEqualTo)
				=> Assert.Throws<ArgumentException>(() => new RangeValidator_SByte(lessThan ? (sbyte?)0 : null, lessThanOrEqualTo ? (sbyte?)0 : null, greaterThan ? (sbyte?)0 : null, greaterThanOrEqualTo ? (sbyte?)0 : null));

			[Fact]
			public void BelowLessThanValue()
				=> new RangeValidator_SByte(null, null, 10, null)
					.IsValid((sbyte)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanValue()
				=> new RangeValidator_SByte(null, null, 10, null)
					.IsValid((sbyte)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveLessThanValue()
				=> new RangeValidator_SByte(null, null, 10, null)
					.IsValid((sbyte)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowLessThanOrEqualToValue()
				=> new RangeValidator_SByte(null, null, null, 10)
					.IsValid((sbyte)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanOrEqualToValue()
				=> new RangeValidator_SByte(null, null, null, 10)
					.IsValid((sbyte)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveLessThanOrEqualToValue()
				=> new RangeValidator_SByte(null, null, null, 10)
					.IsValid((sbyte)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowGreaterThanValue()
				=> new RangeValidator_SByte(10, null, null, null)
					.IsValid((sbyte)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanValue()
				=> new RangeValidator_SByte(10, null, null, null)
					.IsValid((sbyte)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveGreaterThanValue()
				=> new RangeValidator_SByte(10, null, null, null)
					.IsValid((sbyte)11)
					.Should()
					.BeTrue();

			[Fact]
			public void BelowGreaterThanOrEqualToValue()
				=> new RangeValidator_SByte(null, 10, null, null)
					.IsValid((sbyte)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanOrEqualToValue()
				=> new RangeValidator_SByte(null, 10, null, null)
					.IsValid((sbyte)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveGreaterThanOrEqualToValue()
				=> new RangeValidator_SByte(null, 10, null, null)
					.IsValid((sbyte)11)
					.Should()
					.BeTrue();
		}

		public class Int16Tests
		{
			[Theory]
			[InlineData(false, false, false, false)]
			[InlineData(true, true, false, false)]
			[InlineData(false, false, true, true)]
			[InlineData(true, true, true, true)]
			[InlineData(false, true, false, true)]
			[InlineData(false, true, true, false)]
			[InlineData(true, false, false, true)]
			[InlineData(true, false, true, false)]
			public void InvalidParameters(bool lessThan, bool lessThanOrEqualTo, bool greaterThan, bool greaterThanOrEqualTo)
				=> Assert.Throws<ArgumentException>(() => new RangeValidator_Int16(lessThan ? (short?)0 : null, lessThanOrEqualTo ? (short?)0 : null, greaterThan ? (short?)0 : null, greaterThanOrEqualTo ? (short?)0 : null));

			[Fact]
			public void BelowLessThanValue()
				=> new RangeValidator_Int16(null, null, 10, null)
					.IsValid((short)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanValue()
				=> new RangeValidator_Int16(null, null, 10, null)
					.IsValid((short)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveLessThanValue()
				=> new RangeValidator_Int16(null, null, 10, null)
					.IsValid((short)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowLessThanOrEqualToValue()
				=> new RangeValidator_Int16(null, null, null, 10)
					.IsValid((short)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanOrEqualToValue()
				=> new RangeValidator_Int16(null, null, null, 10)
					.IsValid((short)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveLessThanOrEqualToValue()
				=> new RangeValidator_Int16(null, null, null, 10)
					.IsValid((short)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowGreaterThanValue()
				=> new RangeValidator_Int16(10, null, null, null)
					.IsValid((short)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanValue()
				=> new RangeValidator_Int16(10, null, null, null)
					.IsValid((short)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveGreaterThanValue()
				=> new RangeValidator_Int16(10, null, null, null)
					.IsValid((short)11)
					.Should()
					.BeTrue();

			[Fact]
			public void BelowGreaterThanOrEqualToValue()
				=> new RangeValidator_Int16(null, 10, null, null)
					.IsValid((short)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanOrEqualToValue()
				=> new RangeValidator_Int16(null, 10, null, null)
					.IsValid((short)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveGreaterThanOrEqualToValue()
				=> new RangeValidator_Int16(null, 10, null, null)
					.IsValid((short)11)
					.Should()
					.BeTrue();
		}

		public class UInt16Tests
		{
			[Theory]
			[InlineData(false, false, false, false)]
			[InlineData(true, true, false, false)]
			[InlineData(false, false, true, true)]
			[InlineData(true, true, true, true)]
			[InlineData(false, true, false, true)]
			[InlineData(false, true, true, false)]
			[InlineData(true, false, false, true)]
			[InlineData(true, false, true, false)]
			public void InvalidParameters(bool lessThan, bool lessThanOrEqualTo, bool greaterThan, bool greaterThanOrEqualTo)
				=> Assert.Throws<ArgumentException>(() => new RangeValidator_UInt16(lessThan ? (ushort?)0 : null, lessThanOrEqualTo ? (ushort?)0 : null, greaterThan ? (ushort?)0 : null, greaterThanOrEqualTo ? (ushort?)0 : null));

			[Fact]
			public void BelowLessThanValue()
				=> new RangeValidator_UInt16(null, null, 10, null)
					.IsValid((ushort)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanValue()
				=> new RangeValidator_UInt16(null, null, 10, null)
					.IsValid((ushort)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveLessThanValue()
				=> new RangeValidator_UInt16(null, null, 10, null)
					.IsValid((ushort)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowLessThanOrEqualToValue()
				=> new RangeValidator_UInt16(null, null, null, 10)
					.IsValid((ushort)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanOrEqualToValue()
				=> new RangeValidator_UInt16(null, null, null, 10)
					.IsValid((ushort)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveLessThanOrEqualToValue()
				=> new RangeValidator_UInt16(null, null, null, 10)
					.IsValid((ushort)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowGreaterThanValue()
				=> new RangeValidator_UInt16(10, null, null, null)
					.IsValid((ushort)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanValue()
				=> new RangeValidator_UInt16(10, null, null, null)
					.IsValid((ushort)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveGreaterThanValue()
				=> new RangeValidator_UInt16(10, null, null, null)
					.IsValid((ushort)11)
					.Should()
					.BeTrue();

			[Fact]
			public void BelowGreaterThanOrEqualToValue()
				=> new RangeValidator_UInt16(null, 10, null, null)
					.IsValid((ushort)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanOrEqualToValue()
				=> new RangeValidator_UInt16(null, 10, null, null)
					.IsValid((ushort)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveGreaterThanOrEqualToValue()
				=> new RangeValidator_UInt16(null, 10, null, null)
					.IsValid((ushort)11)
					.Should()
					.BeTrue();
		}

		public class Int32Tests
		{
			[Theory]
			[InlineData(false, false, false, false)]
			[InlineData(true, true, false, false)]
			[InlineData(false, false, true, true)]
			[InlineData(true, true, true, true)]
			[InlineData(false, true, false, true)]
			[InlineData(false, true, true, false)]
			[InlineData(true, false, false, true)]
			[InlineData(true, false, true, false)]
			public void InvalidParameters(bool lessThan, bool lessThanOrEqualTo, bool greaterThan, bool greaterThanOrEqualTo)
				=> Assert.Throws<ArgumentException>(() => new RangeValidator_Int32(lessThan ? (int?)0 : null, lessThanOrEqualTo ? (int?)0 : null, greaterThan ? (int?)0 : null, greaterThanOrEqualTo ? (int?)0 : null));

			[Fact]
			public void BelowLessThanValue()
				=> new RangeValidator_Int32(null, null, 10, null)
					.IsValid((int)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanValue()
				=> new RangeValidator_Int32(null, null, 10, null)
					.IsValid((int)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveLessThanValue()
				=> new RangeValidator_Int32(null, null, 10, null)
					.IsValid((int)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowLessThanOrEqualToValue()
				=> new RangeValidator_Int32(null, null, null, 10)
					.IsValid((int)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanOrEqualToValue()
				=> new RangeValidator_Int32(null, null, null, 10)
					.IsValid((int)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveLessThanOrEqualToValue()
				=> new RangeValidator_Int32(null, null, null, 10)
					.IsValid((int)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowGreaterThanValue()
				=> new RangeValidator_Int32(10, null, null, null)
					.IsValid((int)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanValue()
				=> new RangeValidator_Int32(10, null, null, null)
					.IsValid((int)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveGreaterThanValue()
				=> new RangeValidator_Int32(10, null, null, null)
					.IsValid((int)11)
					.Should()
					.BeTrue();

			[Fact]
			public void BelowGreaterThanOrEqualToValue()
				=> new RangeValidator_Int32(null, 10, null, null)
					.IsValid((int)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanOrEqualToValue()
				=> new RangeValidator_Int32(null, 10, null, null)
					.IsValid((int)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveGreaterThanOrEqualToValue()
				=> new RangeValidator_Int32(null, 10, null, null)
					.IsValid((int)11)
					.Should()
					.BeTrue();
		}

		public class UInt32Tests
		{
			[Theory]
			[InlineData(false, false, false, false)]
			[InlineData(true, true, false, false)]
			[InlineData(false, false, true, true)]
			[InlineData(true, true, true, true)]
			[InlineData(false, true, false, true)]
			[InlineData(false, true, true, false)]
			[InlineData(true, false, false, true)]
			[InlineData(true, false, true, false)]
			public void InvalidParameters(bool lessThan, bool lessThanOrEqualTo, bool greaterThan, bool greaterThanOrEqualTo)
				=> Assert.Throws<ArgumentException>(() => new RangeValidator_UInt32(lessThan ? (uint?)0 : null, lessThanOrEqualTo ? (uint?)0 : null, greaterThan ? (uint?)0 : null, greaterThanOrEqualTo ? (uint?)0 : null));

			[Fact]
			public void BelowLessThanValue()
				=> new RangeValidator_UInt32(null, null, 10, null)
					.IsValid((uint)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanValue()
				=> new RangeValidator_UInt32(null, null, 10, null)
					.IsValid((uint)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveLessThanValue()
				=> new RangeValidator_UInt32(null, null, 10, null)
					.IsValid((uint)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowLessThanOrEqualToValue()
				=> new RangeValidator_UInt32(null, null, null, 10)
					.IsValid((uint)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanOrEqualToValue()
				=> new RangeValidator_UInt32(null, null, null, 10)
					.IsValid((uint)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveLessThanOrEqualToValue()
				=> new RangeValidator_UInt32(null, null, null, 10)
					.IsValid((uint)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowGreaterThanValue()
				=> new RangeValidator_UInt32(10, null, null, null)
					.IsValid((uint)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanValue()
				=> new RangeValidator_UInt32(10, null, null, null)
					.IsValid((uint)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveGreaterThanValue()
				=> new RangeValidator_UInt32(10, null, null, null)
					.IsValid((uint)11)
					.Should()
					.BeTrue();

			[Fact]
			public void BelowGreaterThanOrEqualToValue()
				=> new RangeValidator_UInt32(null, 10, null, null)
					.IsValid((uint)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanOrEqualToValue()
				=> new RangeValidator_UInt32(null, 10, null, null)
					.IsValid((uint)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveGreaterThanOrEqualToValue()
				=> new RangeValidator_UInt32(null, 10, null, null)
					.IsValid((uint)11)
					.Should()
					.BeTrue();
		}

		public class Int64Tests
		{
			[Theory]
			[InlineData(false, false, false, false)]
			[InlineData(true, true, false, false)]
			[InlineData(false, false, true, true)]
			[InlineData(true, true, true, true)]
			[InlineData(false, true, false, true)]
			[InlineData(false, true, true, false)]
			[InlineData(true, false, false, true)]
			[InlineData(true, false, true, false)]
			public void InvalidParameters(bool lessThan, bool lessThanOrEqualTo, bool greaterThan, bool greaterThanOrEqualTo)
				=> Assert.Throws<ArgumentException>(() => new RangeValidator_Int64(lessThan ? (long?)0 : null, lessThanOrEqualTo ? (long?)0 : null, greaterThan ? (long?)0 : null, greaterThanOrEqualTo ? (long?)0 : null));

			[Fact]
			public void BelowLessThanValue()
				=> new RangeValidator_Int64(null, null, 10, null)
					.IsValid((long)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanValue()
				=> new RangeValidator_Int64(null, null, 10, null)
					.IsValid((long)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveLessThanValue()
				=> new RangeValidator_Int64(null, null, 10, null)
					.IsValid((long)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowLessThanOrEqualToValue()
				=> new RangeValidator_Int64(null, null, null, 10)
					.IsValid((long)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanOrEqualToValue()
				=> new RangeValidator_Int64(null, null, null, 10)
					.IsValid((long)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveLessThanOrEqualToValue()
				=> new RangeValidator_Int64(null, null, null, 10)
					.IsValid((long)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowGreaterThanValue()
				=> new RangeValidator_Int64(10, null, null, null)
					.IsValid((long)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanValue()
				=> new RangeValidator_Int64(10, null, null, null)
					.IsValid((long)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveGreaterThanValue()
				=> new RangeValidator_Int64(10, null, null, null)
					.IsValid((long)11)
					.Should()
					.BeTrue();

			[Fact]
			public void BelowGreaterThanOrEqualToValue()
				=> new RangeValidator_Int64(null, 10, null, null)
					.IsValid((long)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanOrEqualToValue()
				=> new RangeValidator_Int64(null, 10, null, null)
					.IsValid((long)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveGreaterThanOrEqualToValue()
				=> new RangeValidator_Int64(null, 10, null, null)
					.IsValid((long)11)
					.Should()
					.BeTrue();
		}

		public class UInt64Tests
		{
			[Theory]
			[InlineData(false, false, false, false)]
			[InlineData(true, true, false, false)]
			[InlineData(false, false, true, true)]
			[InlineData(true, true, true, true)]
			[InlineData(false, true, false, true)]
			[InlineData(false, true, true, false)]
			[InlineData(true, false, false, true)]
			[InlineData(true, false, true, false)]
			public void InvalidParameters(bool lessThan, bool lessThanOrEqualTo, bool greaterThan, bool greaterThanOrEqualTo)
				=> Assert.Throws<ArgumentException>(() => new RangeValidator_UInt64(lessThan ? (ulong?)0 : null, lessThanOrEqualTo ? (ulong?)0 : null, greaterThan ? (ulong?)0 : null, greaterThanOrEqualTo ? (ulong?)0 : null));

			[Fact]
			public void BelowLessThanValue()
				=> new RangeValidator_UInt64(null, null, 10, null)
					.IsValid((ulong)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanValue()
				=> new RangeValidator_UInt64(null, null, 10, null)
					.IsValid((ulong)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveLessThanValue()
				=> new RangeValidator_UInt64(null, null, 10, null)
					.IsValid((ulong)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowLessThanOrEqualToValue()
				=> new RangeValidator_UInt64(null, null, null, 10)
					.IsValid((ulong)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanOrEqualToValue()
				=> new RangeValidator_UInt64(null, null, null, 10)
					.IsValid((ulong)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveLessThanOrEqualToValue()
				=> new RangeValidator_UInt64(null, null, null, 10)
					.IsValid((ulong)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowGreaterThanValue()
				=> new RangeValidator_UInt64(10, null, null, null)
					.IsValid((ulong)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanValue()
				=> new RangeValidator_UInt64(10, null, null, null)
					.IsValid((ulong)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveGreaterThanValue()
				=> new RangeValidator_UInt64(10, null, null, null)
					.IsValid((ulong)11)
					.Should()
					.BeTrue();

			[Fact]
			public void BelowGreaterThanOrEqualToValue()
				=> new RangeValidator_UInt64(null, 10, null, null)
					.IsValid((ulong)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanOrEqualToValue()
				=> new RangeValidator_UInt64(null, 10, null, null)
					.IsValid((ulong)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveGreaterThanOrEqualToValue()
				=> new RangeValidator_UInt64(null, 10, null, null)
					.IsValid((ulong)11)
					.Should()
					.BeTrue();
		}

		public class SingleTests
		{
			[Theory]
			[InlineData(false, false, false, false)]
			[InlineData(true, true, false, false)]
			[InlineData(false, false, true, true)]
			[InlineData(true, true, true, true)]
			[InlineData(false, true, false, true)]
			[InlineData(false, true, true, false)]
			[InlineData(true, false, false, true)]
			[InlineData(true, false, true, false)]
			public void InvalidParameters(bool lessThan, bool lessThanOrEqualTo, bool greaterThan, bool greaterThanOrEqualTo)
				=> Assert.Throws<ArgumentException>(() => new RangeValidator_Single(lessThan ? (float?)0 : null, lessThanOrEqualTo ? (float?)0 : null, greaterThan ? (float?)0 : null, greaterThanOrEqualTo ? (float?)0 : null));

			[Fact]
			public void BelowLessThanValue()
				=> new RangeValidator_Single(null, null, 10, null)
					.IsValid((float)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanValue()
				=> new RangeValidator_Single(null, null, 10, null)
					.IsValid((float)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveLessThanValue()
				=> new RangeValidator_Single(null, null, 10, null)
					.IsValid((float)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowLessThanOrEqualToValue()
				=> new RangeValidator_Single(null, null, null, 10)
					.IsValid((float)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanOrEqualToValue()
				=> new RangeValidator_Single(null, null, null, 10)
					.IsValid((float)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveLessThanOrEqualToValue()
				=> new RangeValidator_Single(null, null, null, 10)
					.IsValid((float)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowGreaterThanValue()
				=> new RangeValidator_Single(10, null, null, null)
					.IsValid((float)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanValue()
				=> new RangeValidator_Single(10, null, null, null)
					.IsValid((float)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveGreaterThanValue()
				=> new RangeValidator_Single(10, null, null, null)
					.IsValid((float)11)
					.Should()
					.BeTrue();

			[Fact]
			public void BelowGreaterThanOrEqualToValue()
				=> new RangeValidator_Single(null, 10, null, null)
					.IsValid((float)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanOrEqualToValue()
				=> new RangeValidator_Single(null, 10, null, null)
					.IsValid((float)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveGreaterThanOrEqualToValue()
				=> new RangeValidator_Single(null, 10, null, null)
					.IsValid((float)11)
					.Should()
					.BeTrue();
		}

		public class DoubleTests
		{
			[Theory]
			[InlineData(false, false, false, false)]
			[InlineData(true, true, false, false)]
			[InlineData(false, false, true, true)]
			[InlineData(true, true, true, true)]
			[InlineData(false, true, false, true)]
			[InlineData(false, true, true, false)]
			[InlineData(true, false, false, true)]
			[InlineData(true, false, true, false)]
			public void InvalidParameters(bool lessThan, bool lessThanOrEqualTo, bool greaterThan, bool greaterThanOrEqualTo)
				=> Assert.Throws<ArgumentException>(() => new RangeValidator_Double(lessThan ? (double?)0 : null, lessThanOrEqualTo ? (double?)0 : null, greaterThan ? (double?)0 : null, greaterThanOrEqualTo ? (double?)0 : null));

			[Fact]
			public void BelowLessThanValue()
				=> new RangeValidator_Double(null, null, 10, null)
					.IsValid((double)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanValue()
				=> new RangeValidator_Double(null, null, 10, null)
					.IsValid((double)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveLessThanValue()
				=> new RangeValidator_Double(null, null, 10, null)
					.IsValid((double)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowLessThanOrEqualToValue()
				=> new RangeValidator_Double(null, null, null, 10)
					.IsValid((double)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanOrEqualToValue()
				=> new RangeValidator_Double(null, null, null, 10)
					.IsValid((double)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveLessThanOrEqualToValue()
				=> new RangeValidator_Double(null, null, null, 10)
					.IsValid((double)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowGreaterThanValue()
				=> new RangeValidator_Double(10, null, null, null)
					.IsValid((double)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanValue()
				=> new RangeValidator_Double(10, null, null, null)
					.IsValid((double)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveGreaterThanValue()
				=> new RangeValidator_Double(10, null, null, null)
					.IsValid((double)11)
					.Should()
					.BeTrue();

			[Fact]
			public void BelowGreaterThanOrEqualToValue()
				=> new RangeValidator_Double(null, 10, null, null)
					.IsValid((double)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanOrEqualToValue()
				=> new RangeValidator_Double(null, 10, null, null)
					.IsValid((double)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveGreaterThanOrEqualToValue()
				=> new RangeValidator_Double(null, 10, null, null)
					.IsValid((double)11)
					.Should()
					.BeTrue();
		}

		public class DecimalTests
		{
			[Theory]
			[InlineData(false, false, false, false)]
			[InlineData(true, true, false, false)]
			[InlineData(false, false, true, true)]
			[InlineData(true, true, true, true)]
			[InlineData(false, true, false, true)]
			[InlineData(false, true, true, false)]
			[InlineData(true, false, false, true)]
			[InlineData(true, false, true, false)]
			public void InvalidParameters(bool lessThan, bool lessThanOrEqualTo, bool greaterThan, bool greaterThanOrEqualTo)
				=> Assert.Throws<ArgumentException>(() => new RangeValidator_Decimal(lessThan ? (decimal?)0 : null, lessThanOrEqualTo ? (decimal?)0 : null, greaterThan ? (decimal?)0 : null, greaterThanOrEqualTo ? (decimal?)0 : null));

			[Fact]
			public void BelowLessThanValue()
				=> new RangeValidator_Decimal(null, null, 10, null)
					.IsValid((decimal)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanValue()
				=> new RangeValidator_Decimal(null, null, 10, null)
					.IsValid((decimal)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveLessThanValue()
				=> new RangeValidator_Decimal(null, null, 10, null)
					.IsValid((decimal)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowLessThanOrEqualToValue()
				=> new RangeValidator_Decimal(null, null, null, 10)
					.IsValid((decimal)9)
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanOrEqualToValue()
				=> new RangeValidator_Decimal(null, null, null, 10)
					.IsValid((decimal)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveLessThanOrEqualToValue()
				=> new RangeValidator_Decimal(null, null, null, 10)
					.IsValid((decimal)11)
					.Should()
					.BeFalse();

			[Fact]
			public void BelowGreaterThanValue()
				=> new RangeValidator_Decimal(10, null, null, null)
					.IsValid((decimal)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanValue()
				=> new RangeValidator_Decimal(10, null, null, null)
					.IsValid((decimal)10)
					.Should()
					.BeFalse();

			[Fact]
			public void AboveGreaterThanValue()
				=> new RangeValidator_Decimal(10, null, null, null)
					.IsValid((decimal)11)
					.Should()
					.BeTrue();

			[Fact]
			public void BelowGreaterThanOrEqualToValue()
				=> new RangeValidator_Decimal(null, 10, null, null)
					.IsValid((decimal)9)
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanOrEqualToValue()
				=> new RangeValidator_Decimal(null, 10, null, null)
					.IsValid((decimal)10)
					.Should()
					.BeTrue();

			[Fact]
			public void AboveGreaterThanOrEqualToValue()
				=> new RangeValidator_Decimal(null, 10, null, null)
					.IsValid((decimal)11)
					.Should()
					.BeTrue();
		}

		public class DateTimeTests
		{
			[Theory]
			[InlineData(false, false, false, false)]
			[InlineData(true, true, false, false)]
			[InlineData(false, false, true, true)]
			[InlineData(true, true, true, true)]
			[InlineData(false, true, false, true)]
			[InlineData(false, true, true, false)]
			[InlineData(true, false, false, true)]
			[InlineData(true, false, true, false)]
			public void InvalidParameters(bool lessThan, bool lessThanOrEqualTo, bool greaterThan, bool greaterThanOrEqualTo)
				=> Assert.Throws<ArgumentException>(() => new RangeValidator_DateTime(lessThan ? new DateTime(2000, 1, 1, 12, 0, 0) : default(DateTime?), lessThanOrEqualTo ? new DateTime(2000, 1, 1, 12, 0, 0) : default(DateTime?), greaterThan ? new DateTime(2000, 1, 1, 12, 0, 0) : default(DateTime?), greaterThanOrEqualTo ? new DateTime(2000, 1, 1, 12, 0, 0) : default(DateTime?)));

			[Fact]
			public void BelowLessThanValue()
				=> new RangeValidator_DateTime(null, null, new DateTime(2000, 1, 1, 12, 0, 0), null)
					.IsValid(new DateTime(1999, 1, 1, 12, 0, 0))
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanValue()
				=> new RangeValidator_DateTime(null, null, new DateTime(2000, 1, 1, 12, 0, 0), null)
					.IsValid(new DateTime(2000, 1, 1, 12, 0, 0))
					.Should()
					.BeFalse();

			[Fact]
			public void AboveLessThanValue()
				=> new RangeValidator_DateTime(null, null, new DateTime(2000, 1, 1, 12, 0, 0), null)
					.IsValid(new DateTime(2010, 1, 1, 12, 0, 0))
					.Should()
					.BeFalse();

			[Fact]
			public void BelowLessThanOrEqualToValue()
				=> new RangeValidator_DateTime(null, null, null, new DateTime(2000, 1, 1, 12, 0, 0))
					.IsValid(new DateTime(1999, 1, 1, 12, 0, 0))
					.Should()
					.BeTrue();

			[Fact]
			public void EqualsLessThanOrEqualToValue()
				=> new RangeValidator_DateTime(null, null, null, new DateTime(2000, 1, 1, 12, 0, 0))
					.IsValid(new DateTime(2000, 1, 1, 12, 0, 0))
					.Should()
					.BeTrue();

			[Fact]
			public void AboveLessThanOrEqualToValue()
				=> new RangeValidator_DateTime(null, null, null, new DateTime(2000, 1, 1, 12, 0, 0))
					.IsValid(new DateTime(2010, 1, 1, 12, 0, 0))
					.Should()
					.BeFalse();

			[Fact]
			public void BelowGreaterThanValue()
				=> new RangeValidator_DateTime(new DateTime(2000, 1, 1, 12, 0, 0), null, null, null)
					.IsValid(new DateTime(1999, 1, 1, 12, 0, 0))
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanValue()
				=> new RangeValidator_DateTime(new DateTime(2000, 1, 1, 12, 0, 0), null, null, null)
					.IsValid(new DateTime(2000, 1, 1, 12, 0, 0))
					.Should()
					.BeFalse();

			[Fact]
			public void AboveGreaterThanValue()
				=> new RangeValidator_DateTime(new DateTime(2000, 1, 1, 12, 0, 0), null, null, null)
					.IsValid(new DateTime(2010, 1, 1, 12, 0, 0))
					.Should()
					.BeTrue();

			[Fact]
			public void BelowGreaterThanOrEqualToValue()
				=> new RangeValidator_DateTime(null, new DateTime(2000, 1, 1, 12, 0, 0), null, null)
					.IsValid(new DateTime(1999, 1, 1, 12, 0, 0))
					.Should()
					.BeFalse();

			[Fact]
			public void EqualsGreaterThanOrEqualToValue()
				=> new RangeValidator_DateTime(null, new DateTime(2000, 1, 1, 12, 0, 0), null, null)
					.IsValid(new DateTime(2000, 1, 1, 12, 0, 0))
					.Should()
					.BeTrue();

			[Fact]
			public void AboveGreaterThanOrEqualToValue()
				=> new RangeValidator_DateTime(null, new DateTime(2000, 1, 1, 12, 0, 0), null, null)
					.IsValid(new DateTime(2010, 1, 1, 12, 0, 0))
					.Should()
					.BeTrue();
		}
	}
}
