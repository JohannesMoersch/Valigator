using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Validators
{
	public class NullableForEachModelValidator<TModel, TValue> : IModelValidator<TModel, IEnumerable<Option<TValue>>>
	{
		private readonly IModelValidator<TModel, TValue> _validator;

		public NullableForEachModelValidator(IModelValidator<TModel, TValue> validator)
			=> _validator = validator;

		public Result<Unit, ValidationError[]> Validate(TModel model, IEnumerable<Option<TValue>> value)
		{
			List<ValidationError>? errors = null;

			foreach (var v in value)
			{
				if (v.TryGetValue(out TValue item))
				{
					var result = _validator.Validate(model, item);

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
