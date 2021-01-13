using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Valigator.Core.Tests
{
	public class NotValidatorTests
	{
		[Fact]
		public void NotValidIsFailure()
			=> new ValidationData<int>()
				.Not(o => o.WithValidator(TestValidator.InvertValid(Errors.One)))
				.Process(0)
				.AssertFailure();

		[Fact]
		public void NotInvalidIsSuccess()
			=> new ValidationData<int>()
				.Not(o => o.WithValidator(TestValidator.InvertInvalid()))
				.Process(0)
				.AssertSuccess();

		[Fact]
		public void NotValidInForEachIsFailure()
			=> new ValidationData<int[]>()
				.ForEach(o => o.Not(x => x.WithValidator(TestValidator.InvertValid(Errors.One))))
				.Process(new[] { 0 })
				.AssertFailure();

		[Fact]
		public void NotInvalidInForEachIsSuccess()
			=> new ValidationData<int[]>()
				.ForEach(o => o.Not(x => x.WithValidator(TestValidator.InvertInvalid())))
				.Process(new[] { 0 })
				.AssertSuccess();
	}
}
