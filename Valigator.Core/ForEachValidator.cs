using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Core
{
	public class ForEachValidator<TValue> : IValidator<IEnumerable<TValue>>
	{
		private readonly IValidator<TValue> _validator;

		public ForEachValidator(IValidator<TValue> validator) 
			=> _validator = validator;

		public Result<Unit, ValidationError[]> Validate(IEnumerable<TValue> value)
		{
			List<ValidationError>? errors = null;

			foreach (var v in value)
			{
				var result = _validator.Validate(v);

				if (!result.TryGetValue(out var _, out ValidationError[] newErrors))
					(errors ??= new List<ValidationError>()).AddRange(newErrors);
			}

			if (errors != null)
				return Result.Failure<Unit, ValidationError[]>(errors.ToArray());

			return Result.Unit<ValidationError[]>();
		}
	}
}
