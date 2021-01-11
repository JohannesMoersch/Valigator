using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Validators
{
	public class NullableForEachValidator<TValue> : IValidator<IEnumerable<Option<TValue>>>
	{
		private readonly IValidator<TValue> _validator;

		public NullableForEachValidator(IValidator<TValue> validator)
			=> _validator = validator;

		public Result<Unit, ValidationError[]> Validate(IEnumerable<Option<TValue>> value)
		{
			List<ValidationError>? errors = null;

			foreach (var v in value)
			{
				if (v.TryGetValue(out TValue item))
				{
					var result = _validator.Validate(item);

					if (!result.TryGetValue(out var _, out ValidationError[] newErrors))
						(errors ??= new List<ValidationError>()).AddRange(newErrors);
				}
			}

			if (errors != null)
				return Result.Failure<Unit, ValidationError[]>(errors.ToArray());

			return Result.Unit<ValidationError[]>();
		}
	}
}
