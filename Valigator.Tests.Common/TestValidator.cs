using Functional;
using System;

namespace Valigator
{
	public class TestValidator
	{
		public static ValidationError Error { get; } = new ValidationError(String.Empty);

		public static IValidator<int> Create(Func<int, Result<Unit, ValidationError[]>> result)
			=> new TestValidator<int>(result);

		public static IValidator<int> Valid()
			=> new TestValidator<int>(_ => Result.Unit<ValidationError[]>());

		public static IInvertableValidator<int> InvertValid(params ValidationError[] errors)
			=> new TestValidator<int>(_ => Result.Failure<Unit, ValidationError[]>(errors));

		public static IValidator<int> Invalid(params ValidationError[] errors)
			=> new TestValidator<int>(_ => Result.Failure<Unit, ValidationError[]>(errors));

		public static IInvertableValidator<int> InvertInvalid()
			=> new TestValidator<int>(_ => Result.Unit<ValidationError[]>());
	}

	public class TestValidator<TValue> : IInvertableValidator<TValue>
	{
		private readonly Func<TValue, Result<Unit, ValidationError[]>> _result;

		internal TestValidator(Func<TValue, Result<Unit, ValidationError[]>> result)
			=> _result = result;

		public Result<Unit, ValidationError[]> Validate(TValue value)
			=> _result.Invoke(value);

		public Result<Unit, ValidationError[]> InverseValidate(TValue value)
			=> _result.Invoke(value);

		public static IValidator<TValue> Valid()
			=> new TestValidator<TValue>(_ => Result.Unit<ValidationError[]>());

		public static IValidator<TValue> Invalid()
			=> new TestValidator<TValue>(_ => Result.Failure<Unit, ValidationError[]>(new[] { TestValidator.Error }));
	}
}
