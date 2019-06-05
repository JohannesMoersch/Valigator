using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Valigator.Core.ValueValidators;
using Xunit;

namespace Valigator.Tests.ValidatorTests
{
	public class InvertValidatorTests
	{
		[Fact]
		public void InvertTrueToFalse()
			=> new InvertValidator<CustomValidator<int>, int>(new CustomValidator<int>("", _ => true))
				.IsValid(0)
				.Should()
				.BeFalse();

		[Fact]
		public void InvertFalseToTrue()
			=> new InvertValidator<CustomValidator<int>, int>(new CustomValidator<int>("", _ => false))
				.IsValid(0)
				.Should()
				.BeTrue();
	}
}
