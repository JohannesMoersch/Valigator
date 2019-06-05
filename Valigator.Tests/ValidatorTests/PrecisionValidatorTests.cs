using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Valigator.Core.ValueValidators;
using Xunit;

namespace Valigator.Tests.ValidatorTests
{
	public class PrecisionValidatorTests
	{
		[Fact]
		public void NoMinimumOrMaxiumSet()
			=> Assert.Throws<ArgumentException>(() => new PrecisionValidator(null, null));

		[Fact]
		public void MinimumBelowZero()
			=> Assert.Throws<ArgumentException>(() => new PrecisionValidator(-1, null));

		[Fact]
		public void MaximumBelowOne()
			=> Assert.Throws<ArgumentException>(() => new PrecisionValidator(null, 0));

		[Fact]
		public void MaximumBelowMinimum()
			=> Assert.Throws<ArgumentException>(() => new PrecisionValidator(10, 5));

		[Fact]
		public void MinimumOnlyBelowMinimum()
			=> new PrecisionValidator(2, null)
				.IsValid(0.0m)
				.Should()
				.BeFalse();

		[Fact]
		public void MinimumOnlyAtMinimum()
			=> new PrecisionValidator(2, null)
				.IsValid(0.00m)
				.Should()
				.BeTrue();

		[Fact]
		public void MinimumOnlyAboveMinimum()
			=> new PrecisionValidator(2, null)
				.IsValid(0.000m)
				.Should()
				.BeTrue();

		[Fact]
		public void MaximumOnlyBelowMaximum()
			=> new PrecisionValidator(null, 5)
				.IsValid(0.0000m)
				.Should()
				.BeTrue();

		[Fact]
		public void MaximumOnlyAtMaximum()
			=> new PrecisionValidator(null, 5)
				.IsValid(0.00000m)
				.Should()
				.BeTrue();

		[Fact]
		public void MaximumOnlyAboveMaximum()
			=> new PrecisionValidator(null, 5)
				.IsValid(0.000000m)
				.Should()
				.BeFalse();

		[Fact]
		public void MinimumAndMaximumBelowMinimum()
			=> new PrecisionValidator(2, 5)
				.IsValid(0.0m)
				.Should()
				.BeFalse();

		[Fact]
		public void MinimumAndMaximumAtMinimum()
			=> new PrecisionValidator(2, 5)
				.IsValid(0.00m)
				.Should()
				.BeTrue();

		[Fact]
		public void MinimumAndMaximumAtMaximum()
			=> new PrecisionValidator(2, 5)
				.IsValid(0.00000m)
				.Should()
				.BeTrue();

		[Fact]
		public void MinimumAndMaximumAboveMaximum()
			=> new PrecisionValidator(2, 5)
				.IsValid(0.000000m)
				.Should()
				.BeFalse();
	}
}
