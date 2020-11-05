using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models
{
	public static class NonNullableModelValidatorSet
	{
		public static IModelValidatorSet<TModel, TValue> Empty<TModel, TValue>()
			=> NonNullableModelValidatorSet<TModel, TValue>.Empty;

		public static IModelValidatorSet<TModel, TValue> Required<TModel, TValue>()
			=> NonNullableModelValidatorSet<TModel, TValue>.Required;

		public static IModelValidatorSet<TModel, TValue> Optional<TModel, TValue>()
			=> NonNullableModelValidatorSet<TModel, TValue>.Optional;

		public static IModelValidatorSet<TModel, TValue> Defaulted<TModel, TValue>()
			=> NonNullableModelValidatorSet<TModel, TValue>.Defaulted;
	}

	public class NonNullableModelValidatorSet<TModel, TValue> : IModelValidatorSet<TModel, TValue>
	{
		internal static IModelValidatorSet<TModel, TValue> Empty { get; }

		internal static IModelValidatorSet<TModel, TValue> Required { get; }

		internal static IModelValidatorSet<TModel, TValue> Optional { get; }

		internal static IModelValidatorSet<TModel, TValue> Defaulted { get; }

		IReadOnlyList<IValidator> IValidatorSet.Validators => Validators;

		public IReadOnlyList<IValidator<TValue>> Validators { get; }

		public NonNullableModelValidatorSet(IEnumerable<IValidator<TValue>> validators)
			=> Validators = validators.ToArray();

		public IValidatorSet<TValue> AddValidator(IValidator<TValue> value)
			=> new ValidatorSet<TValue>(Validators.Append(value));
	}
}
