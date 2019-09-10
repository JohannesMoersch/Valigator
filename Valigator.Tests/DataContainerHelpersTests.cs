using Xunit;
using FluentAssertions;
using System.Linq;

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

			var second3 = new SecondNestedTestClass();
			second3.Int = second3.Int.WithValue(201);

			var second4 = new SecondNestedTestClass();
			second4.Int = second4.Int.WithValue(201);

			nested1.SecondNestedTestClass = nested1.SecondNestedTestClass.WithValue(second1);
			nested1.SecondNestedCollection = nested1.SecondNestedCollection.WithValue(new[] { second2 });

			nested2.SecondNestedTestClass = nested2.SecondNestedTestClass.WithValue(second3);
			nested2.SecondNestedCollection = nested2.SecondNestedCollection.WithValue(new[] { second4 });

			var sut = new TestClass();
			sut.NestedTestClass = sut.NestedTestClass.WithValue(nested1);
			sut.NestedTestCollection = sut.NestedTestCollection.WithValue(new[] { nested2 });

			var result = Model.Verify(sut);
			result.AssertSuccess();
		}

		[Theory]
		[InlineData(1, 101)]
		[InlineData(101, 1)]
		[InlineData(1, 1)]
		public void ShouldFailBecauseNestedClassNotValid(int value1, int value2)
		{
			var nested1 = new NestedTestClass();
			nested1.Int = nested1.Int.WithValue(value1);

			var nested2 = new NestedTestClass();
			nested2.Int = nested2.Int.WithValue(value2);

			var second1 = new SecondNestedTestClass();
			second1.Int = second1.Int.WithValue(201);

			var second2 = new SecondNestedTestClass();
			second2.Int = second2.Int.WithValue(201);

			var second3 = new SecondNestedTestClass();
			second3.Int = second3.Int.WithValue(201);

			var second4 = new SecondNestedTestClass();
			second4.Int = second4.Int.WithValue(201);

			nested1.SecondNestedTestClass = nested1.SecondNestedTestClass.WithValue(second1);
			nested1.SecondNestedCollection = nested1.SecondNestedCollection.WithValue(new[] { second2 });

			nested2.SecondNestedTestClass = nested2.SecondNestedTestClass.WithValue(second3);
			nested2.SecondNestedCollection = nested2.SecondNestedCollection.WithValue(new[] { second4 });

			var sut = new TestClass();
			sut.NestedTestClass = sut.NestedTestClass.WithValue(nested1);
			sut.NestedTestCollection = sut.NestedTestCollection.WithValue(new[] { nested2 });

			var result = Model.Verify(sut);
			var failures = result.AssertFailure();
			var paths = failures.Select(f => f.Path.ToString());

			if (value1 < 101)
				paths.Should().Contain($"{nameof(TestClass.NestedTestClass)}.{nameof(SecondNestedTestClass.Int)}");

			if (value2 < 101)
				paths.Should().Contain($"{nameof(TestClass.NestedTestCollection)}[0].{nameof(SecondNestedTestClass.Int)}");
		}

		[Theory]
		[InlineData(2, 201, 201, 201)]
		[InlineData(201, 2, 201, 201)]
		[InlineData(201, 201, 2, 201)]
		[InlineData(201, 201, 201, 2)]
		[InlineData(2, 2, 201, 201)]
		[InlineData(2, 201, 2, 201)]
		[InlineData(2, 201, 201, 2)]
		[InlineData(201, 2, 2, 201)]
		[InlineData(201, 2, 201, 2)]
		[InlineData(201, 201, 2, 2)]
		[InlineData(2, 2, 2, 201)]
		[InlineData(2, 2, 201, 2)]
		[InlineData(201, 2, 2, 2)]
		[InlineData(2, 2, 2, 2)]
		public void ShouldFailBecauseSecondNestedClassInvalid(int value1, int value2, int value3, int value4)
		{
			var nested1 = new NestedTestClass();
			nested1.Int = nested1.Int.WithValue(101);

			var nested2 = new NestedTestClass();
			nested2.Int = nested2.Int.WithValue(101);

			var second1 = new SecondNestedTestClass();
			second1.Int = second1.Int.WithValue(value1);

			var second2 = new SecondNestedTestClass();
			second2.Int = second2.Int.WithValue(value2);

			var second3 = new SecondNestedTestClass();
			second3.Int = second3.Int.WithValue(value3);

			var second4 = new SecondNestedTestClass();
			second4.Int = second4.Int.WithValue(value4);

			nested1.SecondNestedTestClass = nested1.SecondNestedTestClass.WithValue(second1);
			nested1.SecondNestedCollection = nested1.SecondNestedCollection.WithValue(new[] { second2 });

			nested2.SecondNestedTestClass = nested2.SecondNestedTestClass.WithValue(second3);
			nested2.SecondNestedCollection = nested2.SecondNestedCollection.WithValue(new[] { second4 });

			var sut = new TestClass();
			sut.NestedTestClass = sut.NestedTestClass.WithValue(nested1);
			sut.NestedTestCollection = sut.NestedTestCollection.WithValue(new[] { nested2 });

			var result = Model.Verify(sut);
			var failures = result.AssertFailure();
			var paths = failures.Select(f => f.Path.ToString());

			if (value1 < 101)
				paths.Should().Contain($"{nameof(TestClass.NestedTestClass)}.{nameof(NestedTestClass.SecondNestedTestClass)}.{nameof(SecondNestedTestClass.Int)}");

			if (value2 < 101)
				paths.Should().Contain($"{nameof(TestClass.NestedTestClass)}.{nameof(NestedTestClass.SecondNestedCollection)}[0].{nameof(SecondNestedTestClass.Int)}");

			if (value3 < 101)
				paths.Should().Contain($"{nameof(TestClass.NestedTestCollection)}[0].{nameof(NestedTestClass.SecondNestedTestClass)}.{nameof(SecondNestedTestClass.Int)}");

			if (value4 < 101)
				paths.Should().Contain($"{nameof(TestClass.NestedTestCollection)}[0].{nameof(NestedTestClass.SecondNestedCollection)}[0].{nameof(SecondNestedTestClass.Int)}");
		}

		[Theory]
		[InlineData(false, true)]
		[InlineData(true, false)]
		[InlineData(false, false)]
		public void ShouldFailBecauseCollectionsAreNotAssigned(bool b1, bool b2)
		{
			var nested1 = new NestedTestClass();
			nested1.Int = nested1.Int.WithValue(101);

			var nested2 = new NestedTestClass();
			nested2.Int = nested2.Int.WithValue(101);

			var second1 = new SecondNestedTestClass();
			second1.Int = second1.Int.WithValue(201);

			var second2 = new SecondNestedTestClass();
			second2.Int = second2.Int.WithValue(201);

			var second3 = new SecondNestedTestClass();
			second3.Int = second3.Int.WithValue(201);

			var second4 = new SecondNestedTestClass();
			second4.Int = second4.Int.WithValue(201);

			nested1.SecondNestedTestClass = nested1.SecondNestedTestClass.WithValue(second1);
			if (b1)
				nested1.SecondNestedCollection = nested1.SecondNestedCollection.WithValue(new[] { second2 });

			nested2.SecondNestedTestClass = nested2.SecondNestedTestClass.WithValue(second3);
			if (b2)
				nested2.SecondNestedCollection = nested2.SecondNestedCollection.WithValue(new[] { second4 });

			var sut = new TestClass();
			sut.NestedTestClass = sut.NestedTestClass.WithValue(nested1);
			if (b2)
				sut.NestedTestCollection = sut.NestedTestCollection.WithValue(new[] { nested2 });

			var result = Model.Verify(sut);
			var failures = result.AssertFailure();
			var paths = failures.Select(f => f.Path.ToString());

			if (!b1)
				paths.Should().Contain($"{nameof(TestClass.NestedTestClass)}.{nameof(NestedTestClass.SecondNestedCollection)}");

			if (!b2)
				paths.Should().Contain($"{nameof(TestClass.NestedTestCollection)}");
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
