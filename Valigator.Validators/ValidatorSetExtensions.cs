using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Validators
{
	public static class ValidatorSetExtensions
	{
		public static TValidatorSet Length<TValidatorSet>(this TValidatorSet validatorSet, int length)
			where TValidatorSet : IValidatorSet<TValidatorSet, string>
			=> validatorSet.AddValidator(new StringLengthValidator(length, length));
	}
}
