using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public static class NonNullableModelValidatorSet
	{
		public static NonNullableModelValidatorSet<TModel, TValue> Empty<TModel, TValue>()
			=> NonNullableModelValidatorSet<TModel, TValue>.Empty;

		public static NonNullableModelValidatorSet<TModel, TValue> Required<TModel, TValue>()
			=> NonNullableModelValidatorSet<TModel, TValue>.Required;

		public static NonNullableModelValidatorSet<TModel, TValue> Optional<TModel, TValue>()
			=> NonNullableModelValidatorSet<TModel, TValue>.Optional;

		public static NonNullableModelValidatorSet<TModel, TValue> Defaulted<TModel, TValue>()
			=> NonNullableModelValidatorSet<TModel, TValue>.Defaulted;
	}

	public class NonNullableModelValidatorSet<TModel, TValue> : IModelValidatorSet<TModel, TValue>
	{
		internal static NonNullableModelValidatorSet<TModel, TValue> Empty { get; }

		internal static NonNullableModelValidatorSet<TModel, TValue> Required { get; }

		internal static NonNullableModelValidatorSet<TModel, TValue> Optional { get; }

		internal static NonNullableModelValidatorSet<TModel, TValue> Defaulted { get; }

		IReadOnlyList<IValidator> IValidatorSet.Validators => Validators;

		public IReadOnlyList<IValidator<TValue>> Validators { get; }

		public NonNullableModelValidatorSet(IEnumerable<IValidator<TValue>> validators)
			=> Validators = validators.ToArray();

		public NullableModelValidatorSet<TModel, TValue> Nullable()
			=> new NullableModelValidatorSet<TModel, TValue>(Validators);

		public IValidatorSet<TValue> AddValidator(IValidator<TValue> value)
			=> new ValidatorSet<TValue>(Validators.Append(value));
	}
}
