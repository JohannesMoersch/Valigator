using Functional;
using System;
using Xunit;

namespace Valigator.Core.Tests
{
	public static class TestValidator
	{
		public static ValidationError Error { get; } = new ValidationError(String.Empty);
	}

	public class TestValidator<TValue> : IValidator<TValue>
	{
		private bool _isValid;

		private TestValidator(bool isValid) 
			=> _isValid = isValid;

		public Result<Unit, ValidationError[]> Validate(TValue _)
			=> Result.Create(_isValid, Unit.Value, new[] { TestValidator.Error });

		public static IValidator<TValue> Valid()
			=> new TestValidator<TValue>(true);

		public static IValidator<TValue> Invalid()
			=> new TestValidator<TValue>(false);
	}
}
