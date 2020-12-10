using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Core
{
	public class NullableValueValidatorSet<TValue> : IValidatorSet<Option<TValue>, Option<TValue>>
	{
		private readonly IReadOnlyList<IValidator<TValue>> _validators;

		public NullableValueValidatorSet(IEnumerable<IValidator<TValue>> validators)
			=> _validators = validators.ToArray();

		public ValidatorSetResult<Option<TValue>> Process(Option<TValue> input)
		{
			if (input.Match<TValue?>(o => o, () => default) is TValue value)
			{
				return _validators
					.Process(value)
					.Match
					(
						o => ValidatorSetResult.Success(Option.Some(o)), 
						ValidatorSetResult.Failure<Option<TValue>>
					);
			}

			return ValidatorSetResult.Success(Option.None<TValue>());
		}
	}
}
