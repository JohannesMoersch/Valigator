using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Xunit;

namespace Valigator.Models.Tests
{
	public class ForEachModelValidatorTests
	{
		[Fact]
		public void ValidIsSuccess()
			=> new ModelValidationData<ForEachModelValidatorTests, int[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new[] { 0 })
				.AssertSuccess();

		[Fact]
		public void InvalidIsFailure()
			=> new ModelValidationData<ForEachModelValidatorTests, int[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new[] { 1 })
				.AssertFailure();

		[Fact]
		public void ValidAndInvalidIsFailure()
			=> new ModelValidationData<ForEachModelValidatorTests, int[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new[] { 0, 1 })
				.AssertFailure();

		[Fact]
		public void InvalidAndValidIsFailure()
			=> new ModelValidationData<ForEachModelValidatorTests, int[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(this, new[] { 1, 0 })
				.AssertFailure();

		[Fact]
		public void InvalidErrorsAreCorrect()
			=> new ModelValidationData<ForEachModelValidatorTests, int[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { Errors.One }))))
				.Process(this, new[] { 1 })
				.AssertFailure();

		[Fact]
		public void InvalidAndInvalidErrorsAreCorrect()
			=> new ModelValidationData<ForEachModelValidatorTests, int[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { i == 1 ? Errors.One : Errors.Two }))))
				.Process(this, new[] { 1, 0, 3 })
				.AssertFailure()
				.Should()
				.BeEquivalentTo(new[] { Errors.One, Errors.Two });
	}
}
