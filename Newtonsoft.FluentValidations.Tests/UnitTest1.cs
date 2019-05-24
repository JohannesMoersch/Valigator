using System;
using Newtonsoft.FluentValidation;
using Xunit;

namespace Newtonsoft.FluentValidations.Tests
{
	public class TestModel
	{
		public Data<int?> One { get; set; } = Data.Required<int>().Nullable();
	}

	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			var model = new TestModel()
			{
				One = 12
			};

			int stuff = model.One;
		}
	}
}
