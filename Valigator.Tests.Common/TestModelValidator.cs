using Functional;
using System;

namespace Valigator
{
	public class TestModelValidator
	{
		public static ValidationError Error { get; } = new ValidationError(String.Empty);

		public static IModelValidator<TModel, int> Create<TModel>(Func<int, Result<Unit, ValidationError[]>> result)
			=> new TestModelValidator<TModel, int>(result);

		public static IModelValidator<TModel, int> Valid<TModel>()
			=> new TestModelValidator<TModel, int>(_ => Result.Unit<ValidationError[]>());

		public static IInvertableModelValidator<TModel, int> InvertValid<TModel>(params ValidationError[] errors)
			=> new TestModelValidator<TModel, int>(_ => Result.Failure<Unit, ValidationError[]>(errors));

		public static IModelValidator<TModel, int> Invalid<TModel>(params ValidationError[] errors)
			=> new TestModelValidator<TModel, int>(_ => Result.Failure<Unit, ValidationError[]>(errors));

		public static IInvertableModelValidator<TModel, int> InvertInvalid<TModel>()
			=> new TestModelValidator<TModel, int>(_ => Result.Unit<ValidationError[]>());
	}

	public class TestModelValidator<TModel, TValue> : IInvertableModelValidator<TModel, TValue>
	{
		private readonly Func<TValue, Result<Unit, ValidationError[]>> _result;

		internal TestModelValidator(Func<TValue, Result<Unit, ValidationError[]>> result)
			=> _result = result;

		public Result<Unit, ValidationError[]> Validate(TModel model, TValue value)
			=> _result.Invoke(value);

		public Result<Unit, ValidationError[]> InverseValidate(TModel model, TValue value)
			=> _result.Invoke(value);

		public static IModelValidator<TModel, TValue> Valid()
			=> new TestModelValidator<TModel, TValue>(_ => Result.Unit<ValidationError[]>());

		public static IModelValidator<TModel, TValue> Invalid()
			=> new TestModelValidator<TModel, TValue>(_ => Result.Failure<Unit, ValidationError[]>(new[] { TestModelValidator.Error }));
	}
}
