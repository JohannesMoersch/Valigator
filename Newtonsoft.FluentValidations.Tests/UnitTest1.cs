using System;
using FluentAssertions;
using Functional;
using Newtonsoft.FluentValidation;
using Xunit;

namespace Newtonsoft.FluentValidations.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			Data<int> data = Data.Required<int>();

			data.Verify(null).AssureFailure();
		}

		[Fact]
		public void Test2()
		{
			Data<int> data = Data.Required<int>();

			data.WithValue(10).Verify(null).AssureSuccess().Value.Should().Be(10);
		}
	}
}
