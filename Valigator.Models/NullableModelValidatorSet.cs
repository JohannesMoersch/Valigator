using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public class NullableModelValidatorSet<TModel, TValue> : IModelValidatorSet<TModel, TValue>
	{
		IReadOnlyList<IValidator> IValidatorSet.Validators => Validators;

		public IReadOnlyList<IValidator<TValue>> Validators { get; }

		public NullableModelValidatorSet(IEnumerable<IValidator<TValue>> validators)
			=> Validators = validators.ToArray();

		public IValidatorSet<TValue> AddValidator(IValidator<TValue> value)
			=> new ValidatorSet<TValue>(Validators.Append(value));
	}
}
