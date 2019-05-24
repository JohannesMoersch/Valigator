using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation.DataValidators
{
	public struct ValueTypeNotDefaultValidator<TSecondaryValidator, TValue> : ITertiaryValidator<TValue>
		where TSecondaryValidator : ISecondaryValidator<TValue>
		where TValue : struct
	{
		private readonly TSecondaryValidator _secondaryValidator;

		public Result<Option<TValue>, ValidationError> Validate(TValue value)
			=> Result.Create(!value.Equals(default(TValue)), () => Option.Some(value), () => new ValidationError("Value must not be default."));
	}
}
