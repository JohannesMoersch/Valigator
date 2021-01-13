using FluentAssertions;
using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Valigator.Core.Tests
{
	public class ForEachValidatorTests
	{
		[Fact]
		public void ValidIsSuccess()
			=> new ValidationData<int[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new[] { 0 })
				.AssertSuccess();

		[Fact]
		public void InvalidIsFailure()
			=> new ValidationData<int[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new[] { 1 })
				.AssertFailure();

		[Fact]
		public void ValidAndInvalidIsFailure()
			=> new ValidationData<int[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new[] { 0, 1 })
				.AssertFailure();

		[Fact]
		public void InvalidAndValidIsFailure()
			=> new ValidationData<int[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, Array.Empty<ValidationError>))))
				.Process(new[] { 1, 0 })
				.AssertFailure();

		[Fact]
		public void InvalidErrorsAreCorrect()
			=> new ValidationData<int[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { Errors.One }))))
				.Process(new[] { 1 })
				.AssertFailure();

		[Fact]
		public void InvalidAndInvalidErrorsAreCorrect()
			=> new ValidationData<int[]>()
				.ForEach(o => o.WithValidator(TestValidator.Create(i => Result.Create(i % 2 == 0, () => Unit.Value, new[] { i == 1 ? Errors.One : Errors.Two }))))
				.Process(new[] { 1, 0, 3 })
				.AssertFailure()
				.Should()
				.BeEquivalentTo(new[] { Errors.One, Errors.Two });
	}
}
