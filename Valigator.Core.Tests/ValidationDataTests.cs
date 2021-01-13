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
			=> new ValidationData<string>()
				.WithValidator(TestValidator.Valid())
				.Process(String.Empty)
				.AssertSuccess();

		[Fact]
		public void ValidAndInvalidIsFailure()
			=> new ValidationData<string>()
				.WithValidator(TestValidator.Valid())
				.WithValidator(TestValidator.Invalid())
				.Process(String.Empty)
				.AssertFailure();

		[Fact]
		public void InvalidAndValidIsFailure()
			=> new ValidationData<string>()
				.WithValidator(TestValidator.Invalid())
				.WithValidator(TestValidator.Valid())
				.Process(String.Empty)
				.AssertFailure();

		[Fact]
		public void InvalidIsFailure()
			=> new ValidationData<string>()
				.WithValidator(TestValidator.Invalid())
				.Process(String.Empty)
				.AssertFailure();

		[Fact]
		public void InvalidErrorsAreCorrect()
			=> new ValidationData<string>()
				.WithValidator(TestValidator.Invalid(Errors.One, Errors.Two))
				.Process(String.Empty)
				.AssertFailure()
				.Should()
				.BeEquivalentTo(Errors.One, Errors.Two);

		[Fact]
		public void InvalidAndInvalidErrorsAreCorrect()
			=> new ValidationData<string>()
				.WithValidator(TestValidator.Invalid(Errors.One))
				.WithValidator(TestValidator.Invalid(Errors.Two, Errors.Three))
				.Process(String.Empty)
				.AssertFailure()
				.Should()
				.BeEquivalentTo(Errors.One, Errors.Two, Errors.Three);
	}
}
