using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Valigator.Core.Tests
{
	public class ForEachKeyValidatorTests
	{
		[Fact]
		public void ValidIsSuccess()
			=> new ValidationData<Dictionary<int, string>>()
				.ForEachKey(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new Dictionary<int, string>() { { 0, "A" } })
				.AssertSuccess();

		[Fact]
		public void InvalidIsFailure()
			=> new ValidationData<Dictionary<int, string>>()
				.ForEachKey(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new Dictionary<int, string>() { { 1, "B" } })
				.AssertFailure();

		[Fact]
		public void ValidAndInvalidIsFailure()
			=> new ValidationData<Dictionary<int, string>>()
				.ForEachKey(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new Dictionary<int, string>() { { 0, "A" }, { 1, "B" } })
				.AssertFailure();

		[Fact]
		public void InvalidAndValidIsFailure()
			=> new ValidationData<Dictionary<int, string>>()
				.ForEachKey(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new Dictionary<int, string>() { { 1, "B" }, { 0, "A" } })
				.AssertFailure();

		[Fact]
		public void InvalidErrorsAreCorrect()
			=> new ValidationData<Dictionary<int, string>>()
				.ForEachKey(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { Errors.One }))))
				.Process(new Dictionary<int, string>() { { 1, "B" } })
				.AssertFailure();

		[Fact]
		public void InvalidAndInvalidErrorsAreCorrect()
			=> new ValidationData<Dictionary<int, string>>()
				.ForEachKey(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { i == 1 ? Errors.One : Errors.Two }))))
				.Process(new Dictionary<int, string>() { { 1, "B" }, { 0, "A" }, { 3, "D" } })
				.AssertFailure()
				.Should()
				.BeEquivalentTo(new[] { Errors.One, Errors.Two });
	}
}
