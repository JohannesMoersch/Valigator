using Functional;
using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public class ForEachValueValidator<TKey, TValue> : IValidator<IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly IValidator<TValue> _validator;

		public ForEachValueValidator(IValidator<TValue> validator)
			=> _validator = validator;

		public Result<Unit, ValidationError[]> Validate(IReadOnlyDictionary<TKey, TValue> value)
		{
			List<ValidationError>? errors = null;

			foreach (var kvp in value)
			{
				var result = _validator.Validate(kvp.Value);

				if (result.Match<ValidationError[]?>(static _ => null, static e => e) is ValidationError[] newErrors)
					(errors ??= new List<ValidationError>()).AddRange(newErrors);
			}

			if (errors != null)
				return Result.Failure<Unit, ValidationError[]>(errors.ToArray());

			return Result.Unit<ValidationError[]>();
		}
	}
}
