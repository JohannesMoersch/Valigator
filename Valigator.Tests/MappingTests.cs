using FluentAssertions;
using Functional;
using Valigator.Core;
using Xunit;

namespace Valigator.Tests
{
	public class MappingTests
	{
		public class Required
		{
			[Fact]
			public void MapWithErrorAndDefaultShouldNotBeValidBecauseFailureResult()
				=> Data.Required<int>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int))), -1).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void MapWithErrorAndDefaultShouldBeValidBecauseSuccessResult()
				=> Data.Required<(int Item1, int Item2)>().Map(x => Result.Success<int, ValidationError>(50), -1).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void MapWithErrorAndDefaultShouldBeNotBeValidDespiteDefaultIsValid()
				=> Data.Required<(int Item1, int Item2)>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof((int, int)), typeof(int))), 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Invalid);
		}

		public class RequiredNullable
		{
			[Fact]
			public void MapWithErrorAndDefaultShouldNotBeValidBecauseFailureResult()
			=> Data.Required<int>().Nullable().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int))), -1).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void MapWithErrorAndDefaultShouldBeValidBecauseSuccessResult()
				=> Data.Required<(int Item1, int Item2)>().Nullable().Map(x => Result.Success<int, ValidationError>(50), -1).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void MapWithErrorAndDefaultShouldBeNotBeValidDespiteDefaultIsValid()
				=> Data.Required<(int Item1, int Item2)>().Nullable().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof((int, int)), typeof(int))), 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Invalid);
		}

		public class Optional
		{
			[Fact]
			public void MapWithErrorAndDefaultShouldNotBeValidBecauseFailureResult()
			=> Data.Optional<int>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int))), -1).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void MapWithErrorAndDefaultShouldBeValidBecauseSuccessResult()
				=> Data.Optional<(int Item1, int Item2)>().Map(x => Result.Success<int, ValidationError>(50), -1).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void MapWithErrorAndDefaultShouldBeNotBeValidDespiteDefaultIsValid()
				=> Data.Optional<(int Item1, int Item2)>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof((int, int)), typeof(int))), 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Invalid);
		}

		public class OptionalNullable
		{
			[Fact]
			public void MapWithErrorAndDefaultShouldNotBeValidBecauseFailureResult()
			=> Data.Optional<int>().Nullable().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int))), -1).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void MapWithErrorAndDefaultShouldBeValidBecauseSuccessResult()
				=> Data.Optional<(int Item1, int Item2)>().Nullable().Map(x => Result.Success<int, ValidationError>(50), -1).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void MapWithErrorAndDefaultShouldBeNotBeValidDespiteDefaultIsValid()
				=> Data.Optional<(int Item1, int Item2)>().Nullable().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof((int, int)), typeof(int))), 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Invalid);
		}

		public class Defaulted
		{
			[Fact]
			public void MapWithErrorAndDefaultShouldNotBeValidBecauseFailureResult()
			=> Data.Defaulted<int>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int))), -1).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void MapWithErrorAndDefaultShouldBeValidBecauseSuccessResult()
				=> Data.Defaulted<(int Item1, int Item2)>().Map(x => Result.Success<int, ValidationError>(50), -1).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void MapWithErrorAndDefaultShouldBeNotBeValidDespiteDefaultIsValid()
				=> Data.Defaulted<(int Item1, int Item2)>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof((int, int)), typeof(int))), 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Invalid);
		}

		public class DefaultedNullable
		{
			[Fact]
			public void MapWithErrorAndDefaultShouldNotBeValidBecauseFailureResult()
			=> Data.Defaulted<int>().Nullable().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int))), -1).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void MapWithErrorAndDefaultShouldBeValidBecauseSuccessResult()
				=> Data.Defaulted<(int Item1, int Item2)>().Nullable().Map(x => Result.Success<int, ValidationError>(50), -1).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void MapWithErrorAndDefaultShouldBeNotBeValidDespiteDefaultIsValid()
				=> Data.Defaulted<(int Item1, int Item2)>().Nullable().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof((int, int)), typeof(int))), 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Invalid);
		}
	}
}
