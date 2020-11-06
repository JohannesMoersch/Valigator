using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Valigator.Core.ValueValidators;
using Valigator.Tests.Common;
using Xunit;

namespace Valigator.Tests.ValidatorTests
{
	public class StringLengthValidatorTests
	{
		[Fact]
		public void NoMinimumOrMaxiumSet()
			=> Assert.Throws<ArgumentException>(() => new StringLengthValidator(null, null));

		[Fact]
		public void MinimumBelowZero()
			=> Assert.Throws<ArgumentException>(() => new StringLengthValidator(-1, null));

		[Fact]
		public void MaximumBelowOne()
			=> Assert.Throws<ArgumentException>(() => new StringLengthValidator(null, 0));

		[Fact]
		public void MaximumBelowMinimum()
			=> Assert.Throws<ArgumentException>(() => new StringLengthValidator(10, 5));

		[Fact]
		public void MinimumOnlyBelowMinimum()
			=> new StringLengthValidator(10, null)
				.IsValid("abcde")
				.Should()
				.BeFalse();

		[Fact]
		public void MinimumOnlyAtMinimum()
			=> new StringLengthValidator(10, null)
				.IsValid("abcdefghij")
				.Should()
				.BeTrue();

		[Fact]
		public void MinimumOnlyAboveMinimum()
			=> new StringLengthValidator(10, null)
				.IsValid("abcdefghijklmno")
				.Should()
				.BeTrue();

		[Fact]
		public void MaximumOnlyBelowMaximum()
			=> new StringLengthValidator(null, 10)
				.IsValid("abcde")
				.Should()
				.BeTrue();

		[Fact]
		public void MaximumOnlyAtMaximum()
			=> new StringLengthValidator(null, 10)
				.IsValid("abcdefghij")
				.Should()
				.BeTrue();

		[Fact]
		public void MaximumOnlyAboveMaximum()
			=> new StringLengthValidator(null, 10)
				.IsValid("abcdefghijklmno")
				.Should()
				.BeFalse();

		[Fact]
		public void MinimumAndMaximumBelowMinimum()
			=> new StringLengthValidator(5, 10)
				.IsValid("abcd")
				.Should()
				.BeFalse();

		[Fact]
		public void MinimumAndMaximumAtMinimum()
			=> new StringLengthValidator(5, 10)
				.IsValid("abcde")
				.Should()
				.BeTrue();

		[Fact]
		public void MinimumAndMaximumAtMaximum()
			=> new StringLengthValidator(5, 10)
				.IsValid("abcdefghij")
				.Should()
				.BeTrue();

		[Fact]
		public void MinimumAndMaximumAboveMaximum()
			=> new StringLengthValidator(5, 10)
				.IsValid("abcdefghijk")
				.Should()
				.BeFalse();
	}
}
