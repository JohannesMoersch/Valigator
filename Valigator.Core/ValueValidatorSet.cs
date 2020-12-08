using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Core
{
	public class ValueValidatorSet<TValue> : IValidatorSet<TValue, TValue>
	{
		private readonly IReadOnlyList<IValidator<TValue>> _validators;

		public ValueValidatorSet(IEnumerable<IValidator<TValue>> validators)
			=> _validators = validators.ToArray();

		public ValidatorSetResult<TValue> Process(TValue input)
		{
			List<ValidationError>? errors = null;

			for (int i = 0; i < _validators.Count; ++i)
			{
				var result = _validators[i].Validate(input);

				if (result.Match<ValidationError[]?>(static _ => null, static e => e) is ValidationError[] newErrors)
					(errors ??= new List<ValidationError>()).AddRange(newErrors);
			}

			if (errors != null)
				return ValidatorSetResult.Failure<TValue>(errors.ToArray());

			return ValidatorSetResult.Success(input);
		}
	}
}
