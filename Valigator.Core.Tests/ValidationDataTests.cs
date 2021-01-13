using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Valigator.Core.Tests
{
	public class ValidationDataTests
	{
		[Fact]
		public void ValidIsSuccess()
			=> new ValidationData<int>()
				.WithValidator(TestValidator.Valid())
				.Process(0)
				.AssertSuccess();

		[Fact]
		public void ValidAndInvalidIsFailure()
			=> new ValidationData<int>()
				.WithValidator(TestValidator.Valid())
				.WithValidator(TestValidator.Invalid())
				.Process(0)
				.AssertFailure();

		[Fact]
		public void InvalidAndValidIsFailure()
			=> new ValidationData<int>()
				.WithValidator(TestValidator.Invalid())
				.WithValidator(TestValidator.Valid())
				.Process(0)
				.AssertFailure();

		[Fact]
		public void InvalidIsFailure()
			=> new ValidationData<int>()
				.WithValidator(TestValidator.Invalid())
				.Process(0)
				.AssertFailure();

		[Fact]
		public void InvalidErrorsAreCorrect()
			=> new ValidationData<int>()
				.WithValidator(TestValidator.Invalid(Errors.One, Errors.Two))
				.Process(0)
				.AssertFailure()
				.Should()
				.BeEquivalentTo(Errors.One, Errors.Two);

		[Fact]
		public void InvalidAndInvalidErrorsAreCorrect()
			=> new ValidationData<int>()
				.WithValidator(TestValidator.Invalid(Errors.One))
				.WithValidator(TestValidator.Invalid(Errors.Two, Errors.Three))
				.Process(0)
				.AssertFailure()
				.Should()
				.BeEquivalentTo(Errors.One, Errors.Two, Errors.Three);
	}
}
