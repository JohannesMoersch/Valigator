using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Validators
{
	public class ForEachKeyValidator<TKey, TValue> : IValidator<IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly IValidator<TKey> _validator;

		public ForEachKeyValidator(IValidator<TKey> validator)
			=> _validator = validator;

		public Result<Unit, ValidationError[]> Validate(IReadOnlyDictionary<TKey, TValue> value)
		{
			List<ValidationError>? errors = null;

			foreach (var key in value.Keys)
			{
				var result = _validator.Validate(key);

				if (!result.TryGetValue(out var _, out ValidationError[] newErrors))
					(errors ??= new List<ValidationError>()).AddRange(newErrors);
			}

			if (errors != null)
				return Result.Failure<Unit, ValidationError[]>(errors.ToArray());

			return Result.Unit<ValidationError[]>();
		}
	}
}
