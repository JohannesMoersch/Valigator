using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Valigator.Tests
{
	public interface ITest
	{
		Data<int> Stuff { get; }
	}

	public class Test : ITest
	{
		public Test(int stuff)
			=> Stuff = Stuff.WithValue(stuff);

		public Data<int> Stuff { get; private set; } = Data.Required<int>();
	}

	public class TestWrapper
	{
		public Data<ITest> Value { get; set; } = Data.Required<ITest>();
	}

	public class InterfaceTests
	{
		[Fact]
		public void Test()
		{
			var wrapper = new TestWrapper();

			wrapper.Value = wrapper.Value.WithValue(new Test(10));

			Model
				.Verify(wrapper)
				.AssertSuccess();
		}
	}
}
