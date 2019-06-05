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
			=> new RangeValidator_Byte(10, null, null, null)
				.IsValid((byte)9)
				.Should()
				.BeTrue();

		[Fact]
		public void EqualsLessThanValue()
			=> new RangeValidator_Byte(10, null, null, null)
				.IsValid((byte)10)
				.Should()
				.BeFalse();

		[Fact]
		public void AboveLessThanValue()
			=> new RangeValidator_Byte(10, null, null, null)
				.IsValid((byte)11)
				.Should()
				.BeFalse();

		[Fact]
		public void BelowLessThanOrEqualToValue()
			=> new RangeValidator_Byte(null, 10, null, null)
				.IsValid((byte)9)
				.Should()
				.BeTrue();

		[Fact]
		public void EqualsLessThanOrEqualToValue()
			=> new RangeValidator_Byte(null, 10, null, null)
				.IsValid((byte)10)
				.Should()
				.BeTrue();

		[Fact]
		public void AboveLessThanOrEqualToValue()
			=> new RangeValidator_Byte(null, 10, null, null)
				.IsValid((byte)11)
				.Should()
				.BeFalse();

		[Fact]
		public void BelowGreaterThanValue()
			=> new RangeValidator_Byte(null, null, 10, null)
				.IsValid((byte)9)
				.Should()
				.BeFalse();

		[Fact]
		public void EqualsGreaterThanValue()
			=> new RangeValidator_Byte(null, null, 10, null)
				.IsValid((byte)10)
				.Should()
				.BeFalse();

		[Fact]
		public void AboveGreaterThanValue()
			=> new RangeValidator_Byte(null, null, 10, null)
				.IsValid((byte)11)
				.Should()
				.BeTrue();

		[Fact]
		public void BelowGreaterThanOrEqualToValue()
			=> new RangeValidator_Byte(null, null, null, 10)
				.IsValid((byte)9)
				.Should()
				.BeFalse();

		[Fact]
		public void EqualsGreaterThanOrEqualToValue()
			=> new RangeValidator_Byte(null, null, null, 10)
				.IsValid((byte)10)
				.Should()
				.BeTrue();

		[Fact]
		public void AboveGreaterThanOrEqualToValue()
			=> new RangeValidator_Byte(null, null, null, 10)
				.IsValid((byte)11)
				.Should()
				.BeTrue();
	}
}
