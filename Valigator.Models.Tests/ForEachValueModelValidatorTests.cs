using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Xunit;

namespace Valigator.Models.Tests
{
	public class ForEachValueModelValidatorTests
	{
		[Fact]
		public void ValidIsSuccess()
			=> new ModelValidationData<ForEachValueModelValidatorTests, Dictionary<string, int>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new Dictionary<string, int>() { { "A", 0 } })
				.AssertSuccess();

		[Fact]
		public void InvalidIsFailure()
			=> new ModelValidationData<ForEachValueModelValidatorTests, Dictionary<string, int>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new Dictionary<string, int>() { { "B", 1 } })
				.AssertFailure();

		[Fact]
		public void ValidAndInvalidIsFailure()
			=> new ModelValidationData<ForEachValueModelValidatorTests, Dictionary<string, int>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new Dictionary<string, int>() { { "A", 0 }, { "B", 1 } })
				.AssertFailure();

		[Fact]
		public void InvalidAndValidIsFailure()
			=> new ModelValidationData<ForEachValueModelValidatorTests, Dictionary<string, int>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new Dictionary<string, int>() { { "B", 1 }, { "A", 0 } })
				.AssertFailure();

		[Fact]
		public void InvalidErrorsAreCorrect()
			=> new ModelValidationData<ForEachValueModelValidatorTests, Dictionary<string, int>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { Errors.One }))))
				.Process(this, new Dictionary<string, int>() { { "B", 1 } })
				.AssertFailure();

		[Fact]
		public void InvalidAndInvalidErrorsAreCorrect()
			=> new ModelValidationData<ForEachValueModelValidatorTests, Dictionary<string, int>>()
				.ForEachValue(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { i == 1 ? Errors.One : Errors.Two }))))
				.Process(this, new Dictionary<string, int>() { { "B", 1 }, { "A", 0 }, { "D", 3 } })
				.AssertFailure()
				.Should()
				.BeEquivalentTo(new[] { Errors.One, Errors.Two });
	}
}
