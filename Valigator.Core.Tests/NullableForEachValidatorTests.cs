using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Valigator.Core.Tests
{
	public class NullableForEachValidatorTests
	{
		[Fact]
		public void ValidIsSuccess()
			=> new ValidationData<Option<int>[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new[] { Option.Some(0) })
				.AssertSuccess();

		[Fact]
		public void NoneIsSuccess()
			=> new ValidationData<Option<int>[]>()
				.ForEach(o => o.WithValidator(TestValidator.Invalid()))
				.Process(new[] { Option.None<int>() })
				.AssertSuccess();

		[Fact]
		public void InvalidIsFailure()
			=> new ValidationData<Option<int>[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new[] { Option.Some(1) })
				.AssertFailure();

		[Fact]
		public void ValidAndInvalidIsFailure()
			=> new ValidationData<Option<int>[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new[] { Option.Some(0), Option.Some(1) })
				.AssertFailure();

		[Fact]
		public void InvalidAndValidIsFailure()
			=> new ValidationData<Option<int>[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new[] { Option.Some(1), Option.Some(0) })
				.AssertFailure();

		[Fact]
		public void InvalidErrorsAreCorrect()
			=> new ValidationData<Option<int>[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { Errors.One }))))
				.Process(new[] { Option.Some(1) })
				.AssertFailure();

		[Fact]
		public void InvalidAndInvalidErrorsAreCorrect()
			=> new ValidationData<Option<int>[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { i == 1 ? Errors.One : Errors.Two }))))
				.Process(new[] { Option.Some(1), Option.Some(0), Option.Some(3) })
				.AssertFailure()
				.Should()
				.BeEquivalentTo(new[] { Errors.One, Errors.Two });
	}
}
