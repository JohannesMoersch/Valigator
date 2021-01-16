using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;
using Xunit;

namespace Valigator.Models.Tests
{
	public class NotModelValidatorTests
	{
		[Fact]
		public void NotValidIsFailure()
			=> new ModelValidationData<NotModelValidatorTests, int>()
				.Not(o => o.WithValidator(TestValidator.InvertValid(Errors.One)))
				.Process(this, 0)
				.AssertFailure();

		[Fact]
		public void NotInvalidIsSuccess()
			=> new ModelValidationData<NotModelValidatorTests, int>()
				.Not(o => o.WithValidator(TestValidator.InvertInvalid()))
				.Process(this, 0)
				.AssertSuccess();

		[Fact]
		public void NotValidInForEachIsFailure()
			=> new ModelValidationData<NotModelValidatorTests, int[]>()
				.ForEach(o => o.Not(x => x.WithValidator(TestValidator.InvertValid(Errors.One))))
				.Process(this, new[] { 0 })
				.AssertFailure();

		[Fact]
		public void NotInvalidInForEachIsSuccess()
			=> new ModelValidationData<NotModelValidatorTests, int[]>()
				.ForEach(o => o.Not(x => x.WithValidator(TestValidator.InvertInvalid())))
				.Process(this, new[] { 0 })
				.AssertSuccess();
	}
}
