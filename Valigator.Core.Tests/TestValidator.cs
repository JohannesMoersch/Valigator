using Functional;
using System;
using Xunit;

namespace Valigator.Core.Tests
{
	public class TestValidator : IInvertableValidator<int>
	{
		private readonly Func<int, Result<Unit, ValidationError[]>> _result;

		private TestValidator(Func<int, Result<Unit, ValidationError[]>> result) 
			=> _result = result;

		public Result<Unit, ValidationError[]> Validate(int value)
			=> _result.Invoke(value);

		public Result<Unit, ValidationError[]> InverseValidate(int value)
			=> _result.Invoke(value);

		public static IValidator<int> Create(Func<int, Result<Unit, ValidationError[]>> result)
			=> new TestValidator(result);

		public static IValidator<int> Valid()
			=> new TestValidator(_ => Result.Unit<ValidationError[]>());

		public static IInvertableValidator<int> InvertValid(params ValidationError[] errors)
			=> new TestValidator(_ => Result.Failure<Unit, ValidationError[]>(errors));

		public static IValidator<int> Invalid(params ValidationError[] errors)
			=> new TestValidator(_ => Result.Failure<Unit, ValidationError[]>(errors));

		public static IInvertableValidator<int> InvertInvalid()
			=> new TestValidator(_ => Result.Unit<ValidationError[]>());
	}
}
