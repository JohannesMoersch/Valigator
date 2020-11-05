using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Core
{
	public static class ValidatorSet
	{
		public static IValidatorSet<TValue> Empty<TValue>()
			=> ValidatorSet<TValue>.Empty;
	}

	public class ValidatorSet<TValue> : IValidatorSet<TValue>
	{
		internal static IValidatorSet<TValue> Empty { get; } = new ValidatorSet<TValue>(Enumerable.Empty<IValidator<TValue>>());

		IReadOnlyList<IValidator> IValidatorSet.Validators => Validators;

		public IReadOnlyList<IValidator<TValue>> Validators { get; }

		public ValidatorSet(IEnumerable<IValidator<TValue>> validators)
			=> Validators = validators.ToArray();

		public IValidatorSet<TValue> AddValidator(IValidator<TValue> value)
			=> new ValidatorSet<TValue>(Validators.Append(value));
	}
}
