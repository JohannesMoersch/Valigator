using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Valigator.Core.ValueValidators;
using Xunit;

namespace Valigator.Tests.ValidatorTests
{
	public class MultipleOfValidatorTests
	{
		public class ByteTests
		{
			[Fact]
			public void ZeroThrowsException()
					=> Assert.Throws<ArgumentException>(() => new MultipleOfValidator_Byte(0));

			[Fact]
			public void IsPositiveMultiple()
				=> new MultipleOfValidator_Byte(7)
						.IsValid((byte)21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNotMultiple()
				=> new MultipleOfValidator_Byte(7)
						.IsValid((byte)19)
						.Should()
						.BeFalse();
		}

		public class SByteTests
		{
			[Fact]
			public void ZeroThrowsException()
					=> Assert.Throws<ArgumentException>(() => new MultipleOfValidator_SByte(0));

			[Fact]
			public void IsPositiveMultipleOfPositive()
				=> new MultipleOfValidator_SByte(7)
						.IsValid((sbyte)21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNegativeMultipleOfPositive()
				=> new MultipleOfValidator_SByte(7)
						.IsValid((sbyte)-21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsPositiveMultipleOfNegative()
				=> new MultipleOfValidator_SByte(-7)
						.IsValid((sbyte)21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNegativeMultipleOfNegative()
				=> new MultipleOfValidator_SByte(-7)
						.IsValid((sbyte)-21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNotMultiple()
				=> new MultipleOfValidator_SByte(7)
						.IsValid((sbyte)19)
						.Should()
						.BeFalse();
		}

		public class Int16Tests
		{
			[Fact]
			public void ZeroThrowsException()
					=> Assert.Throws<ArgumentException>(() => new MultipleOfValidator_Int16(0));

			[Fact]
			public void IsPositiveMultipleOfPositive()
				=> new MultipleOfValidator_Int16(7)
						.IsValid((short)21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNegativeMultipleOfPositive()
				=> new MultipleOfValidator_Int16(7)
						.IsValid((short)-21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsPositiveMultipleOfNegative()
				=> new MultipleOfValidator_Int16(-7)
						.IsValid((short)21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNegativeMultipleOfNegative()
				=> new MultipleOfValidator_Int16(-7)
						.IsValid((short)-21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNotMultiple()
				=> new MultipleOfValidator_Int16(7)
						.IsValid((short)19)
						.Should()
						.BeFalse();
		}

		public class UInt16Tests
		{
			[Fact]
			public void ZeroThrowsException()
					=> Assert.Throws<ArgumentException>(() => new MultipleOfValidator_UInt16(0));

			[Fact]
			public void IsPositiveMultiple()
				=> new MultipleOfValidator_UInt16(7)
						.IsValid((ushort)21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNotMultiple()
				=> new MultipleOfValidator_UInt16(7)
						.IsValid((ushort)19)
						.Should()
						.BeFalse();
		}

		public class Int32Tests
		{
			[Fact]
			public void ZeroThrowsException()
					=> Assert.Throws<ArgumentException>(() => new MultipleOfValidator_Int32(0));

			[Fact]
			public void IsPositiveMultipleOfPositive()
				=> new MultipleOfValidator_Int32(7)
						.IsValid((int)21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNegativeMultipleOfPositive()
				=> new MultipleOfValidator_Int32(7)
						.IsValid((int)-21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsPositiveMultipleOfNegative()
				=> new MultipleOfValidator_Int32(-7)
						.IsValid((int)21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNegativeMultipleOfNegative()
				=> new MultipleOfValidator_Int32(-7)
						.IsValid((int)-21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNotMultiple()
				=> new MultipleOfValidator_Int32(7)
						.IsValid((int)19)
						.Should()
						.BeFalse();
		}

		public class UInt32Tests
		{
			[Fact]
			public void ZeroThrowsException()
					=> Assert.Throws<ArgumentException>(() => new MultipleOfValidator_UInt32(0));

			[Fact]
			public void IsPositiveMultiple()
				=> new MultipleOfValidator_UInt32(7)
						.IsValid((uint)21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNotMultiple()
				=> new MultipleOfValidator_UInt32(7)
						.IsValid((uint)19)
						.Should()
						.BeFalse();
		}

		public class Int64Tests
		{
			[Fact]
			public void ZeroThrowsException()
					=> Assert.Throws<ArgumentException>(() => new MultipleOfValidator_Int64(0));

			[Fact]
			public void IsPositiveMultipleOfPositive()
				=> new MultipleOfValidator_Int64(7)
						.IsValid((long)21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNegativeMultipleOfPositive()
				=> new MultipleOfValidator_Int64(7)
						.IsValid((long)-21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsPositiveMultipleOfNegative()
				=> new MultipleOfValidator_Int64(-7)
						.IsValid((long)21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNegativeMultipleOfNegative()
				=> new MultipleOfValidator_Int64(-7)
						.IsValid((long)-21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNotMultiple()
				=> new MultipleOfValidator_Int64(7)
						.IsValid((long)19)
						.Should()
						.BeFalse();
		}

		public class UInt64Tests
		{
			[Fact]
			public void ZeroThrowsException()
					=> Assert.Throws<ArgumentException>(() => new MultipleOfValidator_UInt64(0));

			[Fact]
			public void IsPositiveMultiple()
				=> new MultipleOfValidator_UInt64(7)
						.IsValid((ulong)21)
						.Should()
						.BeTrue();

			[Fact]
			public void IsNotMultiple()
				=> new MultipleOfValidator_UInt64(7)
						.IsValid((ulong)19)
						.Should()
						.BeFalse();
		}
	}
}
