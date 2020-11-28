using System;
using Xunit;

namespace Valigator.Models.Tests
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{

		}

		public partial class TestModel
		{
			public class Definition : ModelDefinition<TestModel>
			{
				public IModelValidatorSet<TestModel, int[]> One => Data.Collection<int>().Required();

				public IModelValidatorSet<TestModel, string> Two => Data.Value<string>().Required();
			}
		}

		public partial class TestModel
		{
		}
	}
}
