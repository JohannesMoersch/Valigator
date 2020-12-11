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

		public Result<Option<TValue>, ValidationError[]> Process(Option<TValue> input)
		{
			if (input.Match<TValue?>(o => o, () => default) is TValue value)
			{
				return _validators
					.Process(value)
					.Match
					(
						o => Result.Success<Option<TValue>, ValidationError[]>(Option.Some(o)), 
						Result.Failure<Option<TValue>, ValidationError[]>
					);
			}

			return Result.Success<Option<TValue>, ValidationError[]>(Option.None<TValue>());
		}
	}
}
