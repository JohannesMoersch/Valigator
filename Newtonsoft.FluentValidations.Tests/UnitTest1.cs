using System;
using Functional;
using Newtonsoft.FluentValidation;
using Xunit;

namespace Newtonsoft.FluentValidations.Tests
{
	public class TestModel
	{
		public Data<Option<int>> One { get; set; } = Data.Required<int>().Nullable().NotDefault();

		public Data<string> Two { get; set; } = Data.Required<string>();
	}

	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			var model = new TestModel()
			{
				One = Option.Some(12)
			};

			Option<int> stuff = model.One;
		}
	}
}
