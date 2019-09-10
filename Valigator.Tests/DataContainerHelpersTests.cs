using Xunit;
using FluentAssertions;

namespace Valigator.Tests
{
	public class DataContainerHelpersTests
	{
		[Fact]
		public void ShouldSucceedBecauseEverythingIsValid()
		{
			var nested = new NestedTestClass();
			var second = new SecondNestedTestClass();
			second.Int = second.Int.WithValue(201);

			nested.Int = nested.Int.WithValue(101);
			nested.SecondNestedTestClass = nested.SecondNestedTestClass.WithValue(second);
			nested.SecondNestedCollection = nested.SecondNestedCollection.WithValue(new[] { second, second });

			var sut = new TestClass();
			sut.NestedTestClass = sut.NestedTestClass.WithValue(nested);
			sut.NestedTestCollection = sut.NestedTestCollection.WithValue(new[] { nested, nested });

			Model.Verify(sut).AssertSuccess();
		}

		private class TestClass
		{
			public Data<NestedTestClass> NestedTestClass { get; set; } = Data.Required<NestedTestClass>();

			public Data<NestedTestClass[]> NestedTestCollection { get; set; } = Data.Collection<NestedTestClass>().Required();
		}

		private class NestedTestClass
		{
			public Data<int> Int { get; set; } = Data.Required<int>().GreaterThan(100);

			public Data<SecondNestedTestClass> SecondNestedTestClass { get; set; } = Data.Required<SecondNestedTestClass>();

			public Data<SecondNestedTestClass[]> SecondNestedCollection { get; set; } = Data.Collection<SecondNestedTestClass>().Required();
		}

		private class SecondNestedTestClass
		{
			public Data<int> Int { get; set; } = Data.Required<int>().GreaterThan(200);
		}
	}
}
