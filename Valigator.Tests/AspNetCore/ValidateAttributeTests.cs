using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Valigator.AspNetCore;
using Valigator.Tests.Common;
using Xunit;

namespace Valigator.Tests.AspNetCore
{

	public class ValidateAttributeTests
	{
		public class TestValidateAttribute : ValidateAttribute, IValidateType<int>
		{
			public Data<int> GetData()
				=> Data.Required<int>().InRange(greaterThan: -5, lessThan: 10);
		}

		[Fact]
		public void Test()
			=> new TestValidateAttribute()
				.Verify(0)
				.AssertSuccess();

		[Fact]
		public void Test2()
			=> Assert.Throws<ValidateAttributeDoesNotSupportTypeException>(() => new TestValidateAttribute().Verify(1.0f));

		[Fact]
		public void Test3()
		{
			var descriptor = new TestValidateAttribute()
				.GetDescriptor(typeof(int));
		}
	}
}
