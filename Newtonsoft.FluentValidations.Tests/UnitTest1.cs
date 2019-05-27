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

			data.Verify(new object()).AssureFailure();
		}

		[Fact]
		public void Test2()
		{
			Data<int> data = Data.Required<int>();

			data.WithValue(10).Verify(new object()).AssureSuccess().Value.Should().Be(10);
		}

		[Fact]
		public void Test3()
		{
			Data<int> data = Data.Required<int>().InRange(lessThan: 8);

			data.WithValue(10).Verify(new object()).AssureFailure();
		}

		[Fact]
		public void Test4()
		{
			Data<int> data = Data.Required<int>().InRange(lessThan: 15);

			data.WithValue(10).Verify(new object()).AssureSuccess().Value.Should().Be(10);
		}
	}
}
