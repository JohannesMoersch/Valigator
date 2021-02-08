using System;
using Xunit;

namespace Valigator.Models.Generator.Tests
{
	public class UnitTest1
	{
		public class TestModel
		{
			public class TestModelDefinition : ModelDefinition<TestModel>
			{
				//public Property<int> A { get; } = Data.Value<int>().Defaulted(5);

				//public Property<IReadOnlyList<int>> B { get; } = Data.Collection<int>().Required();
			}
		}

		[Fact]
		public void Test1()
		{

		}
	}
}
