using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Valigator.Core.ValueValidators;
using Xunit;

namespace Valigator.Tests.ValidatorTests
{
	public class UniqueValidatorTests
	{
		[Fact]
		public void EmptyArray()
			=> new UniqueValidator<int, int>()
				.IsValid(Array.Empty<int>())
				.Should()
				.BeTrue();

		[Fact]
		public void NoDuplicates()
			=> new UniqueValidator<int, int>()
				.IsValid(new[] { 1, 2, 3 })
				.Should()
				.BeTrue();

		[Fact]
		public void OneDuplicate()
			=> new UniqueValidator<int, int>()
				.IsValid(new[] { 1, 2, 3, 2 })
				.Should()
				.BeFalse();

		[Fact]
		public void TwoDuplicates()
			=> new UniqueValidator<int, int>()
				.IsValid(new[] { 1, 2, 3, 2, 1 })
				.Should()
				.BeFalse();
	}
}
