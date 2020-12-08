using System;
using Valigator.Core;

namespace Valigator.Validators
{
	public class StringLengthValidator : IInvertableValidator<string>
	{
		private readonly int _minimumLength;

		private readonly int _maximumLength;

		public StringLengthValidator(int minimumLength, int maximumLength)
		{
			_minimumLength = minimumLength;
			_maximumLength = maximumLength;
		}

		public ValidatorResult Validate(string value)
			=> MeetsCondition(value)
				? ValidatorResult.Success()
				: ValidatorResult.Failure(new[] { new ValidationError() });

		public ValidatorResult InverseValidate(string value)
			=> MeetsCondition(value)
				? ValidatorResult.Failure(new[] { new ValidationError() })
				: ValidatorResult.Success();

		private bool MeetsCondition(string value)
			=> value.Length >= _minimumLength && value.Length <= _maximumLength;
	}
}
