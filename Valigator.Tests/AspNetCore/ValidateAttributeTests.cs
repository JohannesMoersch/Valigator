using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace Valigator.Tests.AspNetCore
{
	public class ValidateAttributeTests
	{
		public class TestValidateAttribute : ValidateAttribute, ValidateAttribute.IValidateType<int>
		{
			public Data<int> GetData()
				=> Data.Required<int>().InRange(greaterThan: -5, lessThan: 10);
		}

		[Fact]
		public void Test()
			=> new TestValidateAttribute()
				.Verify(typeof(int), 0)
				.AssertSuccess();
	}
}
