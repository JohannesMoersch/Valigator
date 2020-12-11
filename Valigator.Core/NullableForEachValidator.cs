using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Core
{
	public class NullableForEachValidator<TValue> : IValidator<IReadOnlyList<Option<TValue>>>
	{
		private readonly IValidator<TValue> _validator;

		public NullableForEachValidator(IValidator<TValue> validator)
			=> _validator = validator;

		public Result<Unit, ValidationError[]> Validate(IReadOnlyList<Option<TValue>> value)
		{
			List<ValidationError>? errors = null;

			for (int i = 0; i < value.Count; ++i)
			{
				if (value[i].Match<TValue?>(o => o, () => default) is TValue item)
				{
					var result = _validator.Validate(item);

					if (result.Match<ValidationError[]?>(static _ => null, static e => e) is ValidationError[] newErrors)
						(errors ??= new List<ValidationError>()).AddRange(newErrors);
				}
			}

			if (errors != null)
				return Result.Failure<Unit, ValidationError[]>(errors.ToArray());

			return Result.Unit<ValidationError[]>();
		}
	}
}
