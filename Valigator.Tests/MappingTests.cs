using FluentAssertions;
using Functional;
using Valigator.Core;
using Valigator.Core.StateValidators;
using Valigator.Core.ValueDescriptors;
using Valigator.Tests.Common;
using Xunit;

namespace Valigator.Tests
{
	public class MappingTests
	{
		private static readonly ValidationError[] _testErrors = new[] { new ValidationError("Test Error", new CustomDescriptor("Test Description")) };

		public class Required
		{
			private static RequiredStateValidator<T> CreateData<T>() => Data.Required<T>();

			[Fact]
			public void InvalidBecauseFailureResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Failure<float, ValidationError[]>(_testErrors))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(_testErrors);

			[Fact]
			public void InvalidBecauseSourceValidations()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<float, ValidationError[]>(x + 0.5f), o => o.InSet(100))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertFailure()
					.Should()
					.OnlyContain(e => e.ValueDescriptor.Equals(new InSetDescriptor(new object[] { 100 })));

			[Fact]
			public void ValidBecauseSuccessResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<float, ValidationError[]>(x + 0.5f))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertSuccess()
					.Should()
					.Be(500.5f);
		}

		public class RequiredNullable
		{
			private static NullableRequiredStateValidator<T> CreateData<T>() => Data.Required<T>().Nullable();

			[Fact]
			public void InvalidBecauseFailureResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Failure<Option<float>, ValidationError[]>(_testErrors))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(_testErrors);

			[Fact]
			public void InvalidBecauseSourceValidations()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<Option<float>, ValidationError[]>(Option.Some(x + 0.5f)), o => o.InSet(100))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertFailure()
					.Should()
					.OnlyContain(e => e.ValueDescriptor.Equals(new InSetDescriptor(new object[] { 100 })));

			[Fact]
			public void ValidSomeBecauseSuccessSomeResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<Option<float>, ValidationError[]>(Option.Some(x + 0.5f)))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.Be(500.5f);

			[Fact]
			public void ValidNoneBecauseSuccessNoneResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<Option<float>, ValidationError[]>(Option.None<float>()))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();
		}

		public class Optional
		{
			private static OptionalStateValidator<T> CreateData<T>() => Data.Optional<T>();

			[Fact]
			public void InvalidBecauseFailureResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Failure<float, ValidationError[]>(_testErrors))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(_testErrors);

			[Fact]
			public void InvalidBecauseSourceValidations()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<float, ValidationError[]>(x + 0.5f), o => o.InSet(100))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertFailure()
					.Should()
					.OnlyContain(e => e.ValueDescriptor.Equals(new InSetDescriptor(new object[] { 100 })));

			[Fact]
			public void ValidBecauseSuccessResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<float, ValidationError[]>(x + 0.5f))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.Be(500.5f);
		}

		public class OptionalNullable
		{
			private static NullableOptionalStateValidator<T> CreateData<T>() => Data.Optional<T>().Nullable();

			[Fact]
			public void InvalidBecauseFailureResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Failure<Option<float>, ValidationError[]>(_testErrors))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(_testErrors);

			[Fact]
			public void InvalidBecauseSourceValidations()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<Option<float>, ValidationError[]>(Option.Some(x + 0.5f)), o => o.InSet(100))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertFailure()
					.Should()
					.OnlyContain(e => e.ValueDescriptor.Equals(new InSetDescriptor(new object[] { 100 })));

			[Fact]
			public void ValidSomeBecauseSuccessSomeResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<Option<float>, ValidationError[]>(Option.Some(x + 0.5f)))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.Be(500.5f);

			[Fact]
			public void ValidNoneBecauseSuccessNoneResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<Option<float>, ValidationError[]>(Option.None<float>()))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();
		}

		public class Defaulted
		{
			private static DefaultedStateValidator<T> CreateData<T>() => Data.Defaulted(default(T));

			[Fact]
			public void InvalidBecauseFailureResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Failure<float, ValidationError[]>(_testErrors))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(_testErrors);

			[Fact]
			public void InvalidBecauseSourceValidations()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<float, ValidationError[]>(x + 0.5f), o => o.InSet(100))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertFailure()
					.Should()
					.OnlyContain(e => e.ValueDescriptor.Equals(new InSetDescriptor(new object[] { 100 })));

			[Fact]
			public void ValidBecauseSuccessResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<float, ValidationError[]>(x + 0.5f))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertSuccess()
					.Should()
					.Be(500.5f);
		}

		public class DefaultedNullable
		{
			private static NullableDefaultedStateValidator<T> CreateData<T>() => Data.Defaulted(default(T)).Nullable();

			[Fact]
			public void InvalidBecauseFailureResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Failure<Option<float>, ValidationError[]>(_testErrors))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertFailure()
					.Should()
					.BeEquivalentTo(_testErrors);

			[Fact]
			public void InvalidBecauseSourceValidations()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<Option<float>, ValidationError[]>(Option.Some(x + 0.5f)), o => o.InSet(100))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertFailure()
					.Should()
					.OnlyContain(e => e.ValueDescriptor.Equals(new InSetDescriptor(new object[] { 100 })));

			[Fact]
			public void ValidSomeBecauseSuccessSomeResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<Option<float>, ValidationError[]>(Option.Some(x + 0.5f)))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertSuccess()
					.AssertSome()
					.Should()
					.Be(500.5f);

			[Fact]
			public void ValidNoneBecauseSuccessNoneResult()
				=> CreateData<float>()
					.MappedFrom<int>(x => Result.Success<Option<float>, ValidationError[]>(Option.None<float>()))
					.Data
					.WithMappedValue(500)
					.Verify(new object())
					.TryGetValue()
					.AssertSuccess()
					.AssertNone();
		}
	}
}
