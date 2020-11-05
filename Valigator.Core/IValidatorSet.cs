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

		IValidatorSet<TValue> AddValidator(IValidator<TValue> value);
	}
}
