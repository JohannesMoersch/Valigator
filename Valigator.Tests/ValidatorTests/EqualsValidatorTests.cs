using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Valigator.Core.ValueValidators;
using Xunit;

namespace Valigator.Tests.ValidatorTests
{
	public class EqualsValidatorTests
	{
		[Fact]
		public void ValueTypeEquals()
			=> new EqualsValidator<int>(10)
				.IsValid(10)
				.Should()
				.BeTrue();

		[Fact]
		public void ValueTypeNotEquals()
			=> new EqualsValidator<int>(10)
				.IsValid(20)
				.Should()
				.BeFalse();

		[Fact]
		public void ObjectTypeEquals()
			=> new EqualsValidator<string>("abc")
				.IsValid("abc")
				.Should()
				.BeTrue();

		[Fact]
		public void ObjectTypeNotEquals()
			=> new EqualsValidator<string>("abc")
				.IsValid("123")
				.Should()
				.BeFalse();
	}
}
