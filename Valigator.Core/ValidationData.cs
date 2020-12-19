using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Core
{
	public class ValidationData<TValue> : IRootValidationData<ValidationData<TValue>, TValue>
	{
		private IReadOnlyList<IValidator<TValue>> _validators;

		public ValidationData()
			=> _validators = Array.Empty<IValidator<TValue>>();

		public ValidationData(IEnumerable<IValidator<TValue>> validators) 
			=> _validators = validators.ToArray();

		public ValidationData<TValue> WithValidator(IValidator<TValue> value)
			=> new ValidationData<TValue>(_validators.Concat(new[] { value }));

		public ValidationData<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new ValidationData<TValue>(_validators.Concat(new[] { value }));

		public Result<Unit, ValidationError[]> Process(TValue value)
		{
			List<ValidationError>? errors = null;

			for (int i = 0; i < _validators.Count; ++i)
			{
				var result = _validators[i].Validate(value);

				if (!result.TryGetValue(out var _, out ValidationError[] newErrors))
					(errors ??= new List<ValidationError>()).AddRange(newErrors);
			}

			if (errors != null)
				return Result.Failure<Unit, ValidationError[]>(errors.ToArray());

			return Result.Unit<ValidationError[]>();
		}
	}
}
