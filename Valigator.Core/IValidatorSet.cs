using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface sIValidatorSet<TValidatorSet, TValue>
		where TValidatorSet : IValidatorSet<TValidatorSet, TValue>
	{
		TValidatorSet AddValidator(IValidator<TValue> value);
	}

	public interface sIValidatorSet<TInput>
		where TValidatorSet : IValidatorSet<TValidatorSet, TValue>
	{
		Result<TInput, ValidationError[]> Process(TInput value);
	}
}
