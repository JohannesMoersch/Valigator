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

		public class Test : ModelDefinition<Test>
		{
			public IModelValidatorSet<Test, int[]> One => Data.Collection<int>().Required();
		}
	}
}
