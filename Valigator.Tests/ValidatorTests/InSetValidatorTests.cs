using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Valigator.Core.ValueValidators;
using Valigator.Tests.Common;
using Xunit;

namespace Valigator.Tests.ValidatorTests
{
	public class InSetValidatorTests
	{
		[Fact]
		public void InArray()
			=> new InSetValidator<int>(new[] { 1, 2, 3 })
				.IsValid(2)
				.Should()
				.BeTrue();

		[Fact]
		public void NotInArray()
			=> new InSetValidator<int>(new[] { 1, 2, 3 })
				.IsValid(5)
				.Should()
				.BeFalse();

		[Fact]
		public void InSet()
			=> new InSetValidator<int>(new HashSet<int>(new[] { 1, 2, 3 }))
				.IsValid(2)
				.Should()
				.BeTrue();

		[Fact]
		public void NotInSet()
			=> new InSetValidator<int>(new HashSet<int>(new[] { 1, 2, 3 }))
				.IsValid(5)
				.Should()
				.BeFalse();
	}
}
