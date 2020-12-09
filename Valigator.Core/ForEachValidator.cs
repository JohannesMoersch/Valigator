using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Core
{
	public class ForEachValidator<TValue> : IValidator<TValue[]>
	{
		private readonly IValidator<TValue> _validator;

		public ForEachValidator(IValidator<TValue> validator) 
			=> _validator = validator;

		public ValidatorResult Validate(TValue[] value)
		{
			List<ValidationError>? errors = null;

			for (int i = 0; i < value.Length; ++i)
			{
				var result = _validator.Validate(value[i]);

				if (result.Match<ValidationError[]?>(static _ => null, static e => e) is ValidationError[] newErrors)
					(errors ??= new List<ValidationError>()).AddRange(newErrors);
			}

			if (errors != null)
				return ValidatorResult.Failure(errors.ToArray());

			return ValidatorResult.Success();
		}
	}
}
