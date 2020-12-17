using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public class NullableForEachValueValidator<TKey, TValue> : IValidator<IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly IValidator<TValue> _validator;

		public NullableForEachValueValidator(IValidator<TValue> validator)
			=> _validator = validator;

		public Result<Unit, ValidationError[]> Validate(IReadOnlyDictionary<TKey, Option<TValue>> value)
		{
			List<ValidationError>? errors = null;

			foreach (var kvp in value)
			{
				if (kvp.Value.TryGetValue(out TValue item))
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
