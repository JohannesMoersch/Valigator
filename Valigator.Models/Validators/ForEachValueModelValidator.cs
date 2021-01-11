using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Validators
{
	public class ForEachValueModelValidator<TModel, TKey, TValue> : IModelValidator<TModel, IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly IModelValidator<TModel, TValue> _validator;

		public ForEachValueModelValidator(IModelValidator<TModel, TValue> validator)
			=> _validator = validator;

		public Result<Unit, ValidationError[]> Validate(TModel model, IReadOnlyDictionary<TKey, TValue> value)
		{
			List<ValidationError>? errors = null;

			foreach (var kvp in value)
			{
				var result = _validator.Validate(model, kvp.Value);

				if (!result.TryGetValue(out var _, out ValidationError[] newErrors))
					(errors ??= new List<ValidationError>()).AddRange(newErrors);
			}

			if (errors != null)
				return Result.Failure<Unit, ValidationError[]>(errors.ToArray());

			return Result.Unit<ValidationError[]>();
		}
	}
}
