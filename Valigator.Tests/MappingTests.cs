using FluentAssertions;
using Functional;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Xunit;

namespace Valigator.Tests
{
	public class MappingTests
	{
		public class Required
		{
			private static RequiredStateValidator<T> CreateData<T>() => Data.Required<T>();

			[Fact]
			public void InvalidBecauseFailureResult()
				=> CreateData<int>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int))), -1).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void InvalidBecauseFailureResultAndNoDefault()
				=> CreateData<int>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int)))).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void ValidBecauseSuccessResult()
				=> CreateData<(int Item1, int Item2)>().Map(x => Result.Success<int, ValidationError>(50), -1).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void ValidBecauseSuccessResultWhenNoDefault()
				=> CreateData<(int Item1, int Item2)>().Map(x => Result.Success<int, ValidationError>(50)).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void ValidBecauseNormal()
				=> CreateData<(int Item1, int Item2)>().Map(x => 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void InvalidDespiteDefaultIsValid()
				=> CreateData<(int Item1, int Item2)>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof((int, int)), typeof(int))), 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Invalid);
		}

		public class RequiredNullable
		{
			private static RequiredNullableStateValidator<T> CreateData<T>() => Data.Required<T>().Nullable();

			[Fact]
			public void InvalidBecauseFailureResult()
				=> CreateData<int>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int))), -1).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void InvalidBecauseFailureResultAndNoDefault()
				=> CreateData<int>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int)))).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void ValidBecauseSuccessResult()
				=> CreateData<(int Item1, int Item2)>().Map(x => Result.Success<int, ValidationError>(50), -1).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void ValidBecauseSuccessResultWhenNoDefault()
				=> CreateData<(int Item1, int Item2)>().Map(x => Result.Success<int, ValidationError>(50)).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void ValidBecauseNormal()
				=> CreateData<(int Item1, int Item2)>().Map(x => 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void InvalidDespiteDefaultIsValid()
				=> CreateData<(int Item1, int Item2)>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof((int, int)), typeof(int))), 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Invalid);
		}

		public class Optional
		{
			private static OptionalStateValidator<T> CreateData<T>() => Data.Optional<T>();

			[Fact]
			public void InvalidBecauseFailureResult()
				=> CreateData<int>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int))), -1).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void InvalidBecauseFailureResultAndNoDefault()
				=> CreateData<int>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int)))).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void ValidBecauseSuccessResult()
				=> CreateData<(int Item1, int Item2)>().Map(x => Result.Success<int, ValidationError>(50), -1).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void ValidBecauseSuccessResultWhenNoDefault()
				=> CreateData<(int Item1, int Item2)>().Map(x => Result.Success<int, ValidationError>(50)).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void ValidBecauseNormal()
				=> CreateData<(int Item1, int Item2)>().Map(x => 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void InvalidDespiteDefaultIsValid()
				=> CreateData<(int Item1, int Item2)>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof((int, int)), typeof(int))), 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Invalid);
		}

		public class OptionalNullable
		{
			private static OptionalNullableStateValidator<T> CreateData<T>() => Data.Optional<T>().Nullable();

			[Fact]
			public void InvalidBecauseFailureResult()
				=> CreateData<int>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int))), -1).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void InvalidBecauseFailureResultAndNoDefault()
				=> CreateData<int>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int)))).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void ValidBecauseSuccessResult()
				=> CreateData<(int Item1, int Item2)>().Map(x => Result.Success<int, ValidationError>(50), -1).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void ValidBecauseSuccessResultWhenNoDefault()
				=> CreateData<(int Item1, int Item2)>().Map(x => Result.Success<int, ValidationError>(50)).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void ValidBecauseNormal()
				=> CreateData<(int Item1, int Item2)>().Map(x => 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void InvalidDespiteDefaultIsValid()
				=> CreateData<(int Item1, int Item2)>().Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof((int, int)), typeof(int))), 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Invalid);
		}

		public class Defaulted
		{
			private static DefaultedStateValidator<T> CreateData<T>(T value) => Data.Defaulted<T>(value);

			[Fact]
			public void InvalidBecauseFailureResult()
				=> CreateData<int>(7).Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int))), -1).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void InvalidBecauseFailureResultAndNoDefault()
				=> CreateData<int>(7).Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int)))).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void ValidBecauseSuccessResult()
				=> CreateData<(int Item1, int Item2)>((7, 7)).Map(x => Result.Success<int, ValidationError>(50), -1).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void ValidBecauseSuccessResultWhenNoDefault()
				=> CreateData<(int Item1, int Item2)>((7, 7)).Map(x => Result.Success<int, ValidationError>(50)).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void ValidBecauseNormal()
				=> CreateData<(int Item1, int Item2)>((7, 7)).Map(x => 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void InvalidDespiteDefaultIsValid()
				=> CreateData<(int Item1, int Item2)>((7,7)).Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof((int, int)), typeof(int))), 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Invalid);
		}

		public class DefaultedNullable
		{
			private static DefaultedNullableStateValidator<T> CreateData<T>(T value) => Data.Defaulted<T>(value).Nullable();

			[Fact]
			public void InvalidBecauseFailureResult()
				=> CreateData<int>(7).Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int))), -1).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void InvalidBecauseFailureResultAndNoDefault()
				=> CreateData<int>(7).Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof(int), typeof(int)))).InRange(1).Data.WithValue(500).Verify(new object()).State.Should().Be(DataState.Invalid);

			[Fact]
			public void ValidBecauseSuccessResult()
				=> CreateData<(int Item1, int Item2)>((7, 7)).Map(x => Result.Success<int, ValidationError>(50), -1).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void ValidBecauseSuccessResultWhenNoDefault()
				=> CreateData<(int Item1, int Item2)>((7, 7)).Map(x => Result.Success<int, ValidationError>(50)).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void ValidBecauseNormal()
				=> CreateData<(int Item1, int Item2)>((7, 7)).Map(x => 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Valid);

			[Fact]
			public void InvalidDespiteDefaultIsValid()
				=> CreateData<(int Item1, int Item2)>((7, 7)).Map(x => Result.Failure<int, ValidationError>(MappingError.Create("An error for the ages", typeof((int, int)), typeof(int))), 50).InRange(1).Data.WithValue((100, 200)).Verify(new object()).State.Should().Be(DataState.Invalid);
		}
	}
}
