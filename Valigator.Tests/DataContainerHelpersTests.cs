using Xunit;
using FluentAssertions;

namespace Valigator.Tests
{
	public class DataContainerHelpersTests
	{
		[Fact]
		public void ShouldSucceedBecauseEverythingIsValid()
		{
			var nested1 = new NestedTestClass();
			nested1.Int = nested1.Int.WithValue(101); 
			
			var nested2 = new NestedTestClass();
			nested2.Int = nested2.Int.WithValue(101);

			var second1 = new SecondNestedTestClass();
			second1.Int = second1.Int.WithValue(201);

			var second2 = new SecondNestedTestClass();
			second2.Int = second2.Int.WithValue(201);
			
			nested1.SecondNestedTestClass = nested1.SecondNestedTestClass.WithValue(second1);
			nested1.SecondNestedCollection = nested1.SecondNestedCollection.WithValue(new[] { second2 });

			var sut = new TestClass();
			sut.NestedTestClass = sut.NestedTestClass.WithValue(nested1);
			sut.NestedTestCollection = sut.NestedTestCollection.WithValue(new[] { nested2 });

			var result = Model.Verify(sut);
			result.AssertSuccess();
		}

		[Fact]
		public void ShouldFailBecauseNestedClassNotValid()
		{
			var nested1 = new NestedTestClass();
			nested1.Int = nested1.Int.WithValue(1);

			var nested2 = new NestedTestClass();
			nested2.Int = nested2.Int.WithValue(101);

			var second1 = new SecondNestedTestClass();
			second1.Int = second1.Int.WithValue(201);

			var second2 = new SecondNestedTestClass();
			second2.Int = second2.Int.WithValue(201);

			nested1.SecondNestedTestClass = nested1.SecondNestedTestClass.WithValue(second1);
			nested1.SecondNestedCollection = nested1.SecondNestedCollection.WithValue(new[] { second2 });

			var sut = new TestClass();
			sut.NestedTestClass = sut.NestedTestClass.WithValue(nested1);
			sut.NestedTestCollection = sut.NestedTestCollection.WithValue(new[] { nested2 });

			var failures = Model.Verify(sut).AssertFailure();
		}

		[Fact]
		public void ShouldFailBecauseNestedCollectionNotValid()
		{
			var nested1 = new NestedTestClass();
			nested1.Int = nested1.Int.WithValue(101);

			var nested2 = new NestedTestClass();
			nested2.Int = nested2.Int.WithValue(1);

			var second1 = new SecondNestedTestClass();
			second1.Int = second1.Int.WithValue(201);

			var second2 = new SecondNestedTestClass();
			second2.Int = second2.Int.WithValue(201);

			nested1.SecondNestedTestClass = nested1.SecondNestedTestClass.WithValue(second1);
			nested1.SecondNestedCollection = nested1.SecondNestedCollection.WithValue(new[] { second2 });

			var sut = new TestClass();
			sut.NestedTestClass = sut.NestedTestClass.WithValue(nested1);
			sut.NestedTestCollection = sut.NestedTestCollection.WithValue(new[] { nested2 });

			var failures = Model.Verify(sut).AssertFailure();
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
