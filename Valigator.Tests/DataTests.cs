using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Functional;
using Valigator;
using Valigator.Core;
using Xunit;

namespace Valigator.Tests
{
	public class DataTests
	{
		[Fact]
		public void ValueNotInitialized()
			=> Assert.Throws<DataNotInitializedException>(() => default(Data<int>).Value);

		[Fact]
		public void WithValueNotInitialized()
			=> Assert.Throws<DataNotInitializedException>(() => default(Data<int>).WithValue(5));

		[Fact]
		public void VerifyNotInitialized()
			=> Assert.Throws<DataNotInitializedException>(() => default(Data<int>).Verify(new object()));

		[Fact]
		public void ValueNotSetNotVerified()
			=> Assert.Throws<DataNotVerifiedException>(() => Data.Required<int>().Data.Value);

		[Fact]
		public void ValueSetNotVerified()
			=> Assert.Throws<DataNotVerifiedException>(() => Data.Required<int>().Data.WithValue(5).Value);

		[Fact]
		public void ValueSetAndVerified()
			=> Data.Required<int>().Data.WithValue(5).Verify(new object()).TryGetValue().AssertSuccess().Should().Be(5);

		[Fact]
		public void ValueAlreadySet()
			=> Assert.Throws<DataAlreadySetException>(() => Data.Required<int>().Data.WithValue(5).WithValue(5));

		[Fact]
		public void ValueAlreadyVerified()
			=> Assert.Throws<DataAlreadyVerifiedException>(() => Data.Required<int>().Data.WithValue(5).Verify(new object()).Verify(new object()));

		[Fact]
		public void ValueNotInitializedGetDataDescriptor()
			=> Assert.Throws<DataNotInitializedException>(() => default(Data<int>).DataDescriptor);

		[Fact]
		public void ValueNotSetGetDataDescriptor()
			=> Data.Required<int>().Data.DataDescriptor.Should().NotBeNull();

		[Fact]
		public void ValueSetGetDataDescriptor()
			=> Data.Required<int>().Data.WithValue(5).DataDescriptor.Should().NotBeNull();

		[Fact]
		public void ValueSetAndVerifiedGetDataDescriptor()
			=> Data.Required<int>().Data.WithValue(5).Verify(new object()).DataDescriptor.Should().NotBeNull();

		[Fact]
		public void MapWithErrorAndDefaultShouldNotBeValidBecauseFailureResult()
			=> Data.Required<int>().Map(x => Result.Failure<int, MappingError>(MappingError.Create("An error for the ages")), -1).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

		[Fact]
		public void MapWithErrorAndDefaultShouldBeValidBecauseSuccessResult()
			=> Data.Required<(int Item1, int Item2)>().Map(x => Result.Success<int, MappingError>(50), -1).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

		[Fact]
		public void MapWithErrorAndDefaultShouldBeNotBeValidDespiteDefaultIsValid()
			=> Data.Required<(int Item1, int Item2)>().Map(x => Result.Failure<int, MappingError>(MappingError.Create("An error for the ages")), 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Invalid);
	}
}
