using Functional;
using System;
using Xunit;

namespace Valigator.Core.Tests
{
	public class TestValidator : IInvertableValidator<string>
	{
		private readonly Result<Unit, ValidationError[]> _result;

		private TestValidator(Result<Unit, ValidationError[]> result) 
			=> _result = result;

		public Result<Unit, ValidationError[]> Validate(string _)
			=> _result;

		public Result<Unit, ValidationError[]> InverseValidate(string _)
			=> _result;

		public static IValidator<string> Valid()
			=> new TestValidator(Result.Unit<ValidationError[]>());

		public static IValidator<string> InvertedValid(params ValidationError[] errors)
			=> new TestValidator(Result.Failure<Unit, ValidationError[]>(errors));

		public static IValidator<string> Invalid(params ValidationError[] errors)
			=> new TestValidator(Result.Failure<Unit, ValidationError[]>(errors));

		public static IValidator<string> InvertedInvalid()
			=> new TestValidator(Result.Unit<ValidationError[]>());
	}
}
