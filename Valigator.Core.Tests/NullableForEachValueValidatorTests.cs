using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Valigator.Core.Tests
{
	public class NullableForEachValueValidatorTests
	{
		[Fact]
		public void ValidIsSuccess()
			=> new ValidationData<Dictionary<string, Option<int>>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new Dictionary<string, Option<int>>() { { "A", Option.Some(0) } })
				.AssertSuccess();

		[Fact]
		public void NoneIsSuccess()
			=> new ValidationData<Dictionary<string, Option<int>>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Invalid()))
				.Process(new Dictionary<string, Option<int>>() { { String.Empty, Option.None<int>() } })
				.AssertSuccess();

		[Fact]
		public void InvalidIsFailure()
			=> new ValidationData<Dictionary<string, Option<int>>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new Dictionary<string, Option<int>>() { { "B", Option.Some(1) } })
				.AssertFailure();

		[Fact]
		public void ValidAndInvalidIsFailure()
			=> new ValidationData<Dictionary<string, Option<int>>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new Dictionary<string, Option<int>>() { { "A", Option.Some(0) }, { "B", Option.Some(1) } })
				.AssertFailure();

		[Fact]
		public void InvalidAndValidIsFailure()
			=> new ValidationData<Dictionary<string, Option<int>>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new Dictionary<string, Option<int>>() { { "B", Option.Some(1) }, { "A", Option.Some(0) } })
				.AssertFailure();

		[Fact]
		public void InvalidErrorsAreCorrect()
			=> new ValidationData<Dictionary<string, Option<int>>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { Errors.One }))))
				.Process(new Dictionary<string, Option<int>>() { { "B", Option.Some(1) } })
				.AssertFailure();

		[Fact]
		public void InvalidAndInvalidErrorsAreCorrect()
			=> new ValidationData<Dictionary<string, Option<int>>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { i == 1 ? Errors.One : Errors.Two }))))
				.Process(new Dictionary<string, Option<int>>() { { "B", Option.Some(1) }, { "A", Option.Some(0) }, { "D", Option.Some(3) } })
				.AssertFailure()
				.Should()
				.BeEquivalentTo(new[] { Errors.One, Errors.Two });
	}
}
