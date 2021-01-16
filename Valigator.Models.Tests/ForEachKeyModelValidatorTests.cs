using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Xunit;

namespace Valigator.Models.Tests
{
	public class ForEachKeyModelValidatorTests
	{
		[Fact]
		public void ValidIsSuccess()
			=> new ModelValidationData<ForEachKeyModelValidatorTests, Dictionary<int, string>>()
				.ForEachKey(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new Dictionary<int, string>() { { 0, "A" } })
				.AssertSuccess();

		[Fact]
		public void InvalidIsFailure()
			=> new ModelValidationData<ForEachKeyModelValidatorTests, Dictionary<int, string>>()
				.ForEachKey(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new Dictionary<int, string>() { { 1, "B" } })
				.AssertFailure();

		[Fact]
		public void ValidAndInvalidIsFailure()
			=> new ModelValidationData<ForEachKeyModelValidatorTests, Dictionary<int, string>>()
				.ForEachKey(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new Dictionary<int, string>() { { 0, "A" }, { 1, "B" } })
				.AssertFailure();

		[Fact]
		public void InvalidAndValidIsFailure()
			=> new ModelValidationData<ForEachKeyModelValidatorTests, Dictionary<int, string>>()
				.ForEachKey(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new Dictionary<int, string>() { { 1, "B" }, { 0, "A" } })
				.AssertFailure();

		[Fact]
		public void InvalidErrorsAreCorrect()
			=> new ModelValidationData<ForEachKeyModelValidatorTests, Dictionary<int, string>>()
				.ForEachKey(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { Errors.One }))))
				.Process(this, new Dictionary<int, string>() { { 1, "B" } })
				.AssertFailure();

		[Fact]
		public void InvalidAndInvalidErrorsAreCorrect()
			=> new ModelValidationData<ForEachKeyModelValidatorTests, Dictionary<int, string>>()
				.ForEachKey(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { i == 1 ? Errors.One : Errors.Two }))))
				.Process(this, new Dictionary<int, string>() { { 1, "B" }, { 0, "A" }, { 3, "D" } })
				.AssertFailure()
				.Should()
				.BeEquivalentTo(new[] { Errors.One, Errors.Two });
	}
}
