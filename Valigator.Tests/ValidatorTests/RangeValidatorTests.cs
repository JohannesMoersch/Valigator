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
		[Fact]
		public void NoMinimumOrMaxiumSet()
			=> Assert.Throws<ArgumentException>(() => new RangeValidator_Byte(null, null, null, null));

		[Fact]
		public void LessThanAndLessThanOrEqualToSet()
			=> Assert.Throws<ArgumentException>(() => new RangeValidator_Byte(0, 0, null, null));

		[Fact]
		public void GreaterThanAndGreaterThanOrEqualToSet()
			=> Assert.Throws<ArgumentException>(() => new RangeValidator_Byte(null, null, 0, 0));
	}
}
