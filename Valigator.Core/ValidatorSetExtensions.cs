using Functional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Valigator.Core
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ValidatorSetExtensions
	{
		public static Result<TValue, ValidationError[]> Process<TValue>(this IValidatorSet<TValue> validatorSet, TValue value)
		{
			List<ValidationError>? errors = null;

			for (int i = 0; i < validatorSet.Validators.Count; ++i)
			{
				var result = validatorSet.Validators[i].Validate(value);

				if (result.Match<ValidationError[]?>(static _ => null, static e => e) is ValidationError[] newErrors)
					(errors ??= new List<ValidationError>()).AddRange(newErrors);
			}

			if (errors != null)
				return Result.Failure<TValue, ValidationError[]>(errors.ToArray());

			return Result.Success<TValue, ValidationError[]>(value);
		}
	}
}
