using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public interface IValidatorSet
	{
		IReadOnlyList<IValidator> Validators { get; }
	}
	
	public interface IValidatorSet<TValue> : IValidatorSet
	{
		new IReadOnlyList<IValidator<TValue>> Validators { get; }
	}

	public interface IValidatorSet<TValidatorSet, TValue> : IValidatorSet<TValue>
		where TValidatorSet : IValidatorSet<TValidatorSet, TValue>
	{
		TValidatorSet AddValidator(IValidator<TValue> value);
	}
}
