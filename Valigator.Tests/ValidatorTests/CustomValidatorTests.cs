using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Valigator.Core.ValueValidators;
using Xunit;

namespace Valigator.Tests.ValidatorTests
{
	public class CustomValidatorTests
	{
		[Fact]
		public void CustomIsValid()
			=> new CustomValidator<int>("", i => i == 10)
				.IsValid(10)
				.Should()
				.BeTrue();

		[Fact]
		public void CustomIsNotValid()
			=> new CustomValidator<int>("", i => i != 10)
				.IsValid(10)
				.Should()
				.BeFalse();
	}
}
