using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Valigator.Core
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ValidatorResultExtensions
	{
		public static ValidatorSetResult<TValue> Process<TValue>(this IReadOnlyList<IValidator<TValue>> validators, TValue value)
		{
			List<ValidationError>? errors = null;

			for (int i = 0; i < validators.Count; ++i)
			{
				var result = validators[i].Validate(value);

				if (result.Match<ValidationError[]?>(static _ => null, static e => e) is ValidationError[] newErrors)
					(errors ??= new List<ValidationError>()).AddRange(newErrors);
			}

			if (errors != null)
				return ValidatorSetResult.Failure<TValue>(errors.ToArray());

			return ValidatorSetResult.Success(value);
		}
	}
}
