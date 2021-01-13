using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Valigator.Core.Tests
{
	public class ForEachValueValidatorTests
	{
		[Fact]
		public void ValidIsSuccess()
			=> new ValidationData<Dictionary<string, int>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new Dictionary<string, int>() { { "A", 0 } })
				.AssertSuccess();

		[Fact]
		public void InvalidIsFailure()
			=> new ValidationData<Dictionary<string, int>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new Dictionary<string, int>() { { "B", 1 } })
				.AssertFailure();

		[Fact]
		public void ValidAndInvalidIsFailure()
			=> new ValidationData<Dictionary<string, int>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new Dictionary<string, int>() { { "A", 0 }, { "B", 1 } })
				.AssertFailure();

		[Fact]
		public void InvalidAndValidIsFailure()
			=> new ValidationData<Dictionary<string, int>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new Dictionary<string, int>() { { "B", 1 }, { "A", 0 } })
				.AssertFailure();

		[Fact]
		public void InvalidErrorsAreCorrect()
			=> new ValidationData<Dictionary<string, int>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { Errors.One }))))
				.Process(new Dictionary<string, int>() { { "B", 1 } })
				.AssertFailure();

		[Fact]
		public void InvalidAndInvalidErrorsAreCorrect()
			=> new ValidationData<Dictionary<string, int>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { i == 1 ? Errors.One : Errors.Two }))))
				.Process(new Dictionary<string, int>() { { "B", 1 }, { "A", 0 }, { "D", 3 } })
				.AssertFailure()
				.Should()
				.BeEquivalentTo(new[] { Errors.One, Errors.Two });
	}
}
