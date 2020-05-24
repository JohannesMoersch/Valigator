using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Valigator.Core.ValueValidators;
using Valigator.Tests.Common;
using Xunit;

namespace Valigator.Tests.ValidatorTests
{
	public class ItemCountValidatorTests
	{
		[Fact]
		public void NoMinimumOrMaxiumSet()
			=> Assert.Throws<ArgumentException>(() => new ItemCountValidator<int>(null, null));

		[Fact]
		public void MinimumBelowZero()
			=> Assert.Throws<ArgumentException>(() => new ItemCountValidator<int>(-1, null));

		[Fact]
		public void MaximumBelowOne()
			=> Assert.Throws<ArgumentException>(() => new ItemCountValidator<int>(null, 0));

		[Fact]
		public void MaximumBelowMinimum()
			=> Assert.Throws<ArgumentException>(() => new ItemCountValidator<int>(10, 5));

		[Fact]
		public void MinimumOnlyBelowMinimum()
			=> new ItemCountValidator<int>(10, null)
				.IsValid(new int[5])
				.Should()
				.BeFalse();

		[Fact]
		public void MinimumOnlyAtMinimum()
			=> new ItemCountValidator<int>(10, null)
				.IsValid(new int[10])
				.Should()
				.BeTrue();

		[Fact]
		public void MinimumOnlyAboveMinimum()
			=> new ItemCountValidator<int>(10, null)
				.IsValid(new int[15])
				.Should()
				.BeTrue();

		[Fact]
		public void MaximumOnlyBelowMaximum()
			=> new ItemCountValidator<int>(null, 10)
				.IsValid(new int[5])
				.Should()
				.BeTrue();

		[Fact]
		public void MaximumOnlyAtMaximum()
			=> new ItemCountValidator<int>(null, 10)
				.IsValid(new int[10])
				.Should()
				.BeTrue();

		[Fact]
		public void MaximumOnlyAboveMaximum()
			=> new ItemCountValidator<int>(null, 10)
				.IsValid(new int[15])
				.Should()
				.BeFalse();

		[Fact]
		public void MinimumAndMaximumBelowMinimum()
			=> new ItemCountValidator<int>(5, 10)
				.IsValid(new int[4])
				.Should()
				.BeFalse();

		[Fact]
		public void MinimumAndMaximumAtMinimum()
			=> new ItemCountValidator<int>(5, 10)
				.IsValid(new int[5])
				.Should()
				.BeTrue();

		[Fact]
		public void MinimumAndMaximumAtMaximum()
			=> new ItemCountValidator<int>(5, 10)
				.IsValid(new int[10])
				.Should()
				.BeTrue();

		[Fact]
		public void MinimumAndMaximumAboveMaximum()
			=> new ItemCountValidator<int>(5, 10)
				.IsValid(new int[11])
				.Should()
				.BeFalse();
	}
}
