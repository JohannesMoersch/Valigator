using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valigator.Core
{
	public class ValidationData<TValue> : IValidationData<ValidationData<TValue>, TValue>, IInvertableValidationData<ValidationData<TValue>, TValue>, IValidatorSet<TValue>
	{
		public IReadOnlyList<IValidator<TValue>> Validators { get; }

		public ValidationData()
			=> Validators = Array.Empty<IValidator<TValue>>();

		public ValidationData(IEnumerable<IValidator<TValue>> validators) 
			=> Validators = validators.ToArray();

		public ValidationData<TValue> WithValidator(IValidator<TValue> value)
			=> new ValidationData<TValue>(Validators.Concat(new[] { value }));

		public ValidationData<TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new ValidationData<TValue>(Validators.Concat(new[] { value }));
	}
}
