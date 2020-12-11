using Functional;
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

		public Result<TValue, ValidationError[]> Process(TValue input)
			=> _validators.Process(input);
	}
}
