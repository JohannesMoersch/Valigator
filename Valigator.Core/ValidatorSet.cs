using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IValidationProcessor<TInput, TValue>
	{
		Result<TInput, ValidationError[]> Process(TInput value, IValidatorSet<TValue> validatorSet);
	}

	public interface IValidatorSet<TValue>
	{
		IReadOnlyList<IValidator<TValue>> Validators { get; }
	}

	public interface IValidatorSet<TValidatorSet, TValue>
		where TValidatorSet : IValidatorSet<TValidatorSet, TValue>
	{
		TValidatorSet WithValidation(IValidator<TValue> validator);
	}

	public interface IModelValidatorSet<TModelValidatorSet, TModel, TValue>
		where TModelValidatorSet : IModelValidatorSet<TModelValidatorSet, TModel, TValue>
	{
		TModelValidatorSet WithValidation(IValidator<ModelValue<TModel, TValue>> validator);
	}

	public struct ValidationData<TInput, TValue>
	{
		public IValidationProcessor<TInput, TValue> ValidationProcessor { get; }

		public IValidatorSet<TValue> ValidatorSet { get; }

		public ValidationData(IValidationProcessor<TInput, TValue> validationProcessor, IValidatorSet<TValue> validatorSet)
		{
			ValidationProcessor = validationProcessor;
			ValidatorSet = validatorSet;
		}
	}

	public class NullableCollectionValidationProcessor<TValue> : IValidationProcessor<Option<TValue[]>, TValue[]>
	{
		public Result<Option<TValue[]>, ValidationError[]> Process(Option<TValue[]> value, IValidatorSet<TValue[]> validatorSet) 
			=> throw new NotImplementedException();
	}

	public static class TestExtensions
	{
		public static ValidationData<TInput, TValue> Length<TInput, TValue>(this ValidationData<TInput, TValue> validatorSet, int length)
			=> new ValidationData<TInput, TValue>(validatorSet.ValidationProcessor, validatorSet.ValidatorSet.WithValidation(null));
	}

	public class Stuff
	{
		public Stuff()
		{
			new ValidationData<Option<int[]>, int[]>().Length(10);
		}
	}
}
