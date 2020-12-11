using Functional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Valigator.Core
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class ValidationDataExtensions
	{
		public static ValidationData<TValue> Not<TValue>(this ValidationData<TValue> data, Func<InvertableValidatorValidationData<TValue>, NotValidator<TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableValidatorValidationData<TValue>()));

		public static ValidationData<IReadOnlyList<TValue>> ForEach<TValue>(this ValidationData<IReadOnlyList<TValue>> data, Func<ValidatorValidationData<TValue>, IValidator<TValue>> selector)
			=> data.WithValidator(new ForEachValidator<TValue>(selector.Invoke(new ValidatorValidationData<TValue>())));

		public static ValidationData<IReadOnlyList<Option<TValue>>> ForEach<TValue>(this ValidationData<IReadOnlyList<Option<TValue>>> data, Func<ValidatorValidationData<TValue>, IValidator<TValue>> selector)
			=> data.WithValidator(new NullableForEachValidator<TValue>(selector.Invoke(new ValidatorValidationData<TValue>())));
	}
}
