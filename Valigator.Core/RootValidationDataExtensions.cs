using Functional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Valigator.Core
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class RootValidationDataExtensions
	{
		public static TNext Not<TNext, TValue>(this IRootValidationData<TNext, TValue> data, Func<InvertableValidatorValidationData<TValue>, NotValidator<TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableValidatorValidationData<TValue>()));

		public static TNext ForEach<TNext, TValue>(this IRootValidationData<TNext, IReadOnlyList<TValue>> data, Func<ValidatorValidationData<TValue>, IValidator<TValue>> selector)
			=> data.WithValidator(new ForEachValidator<TValue>(selector.Invoke(new ValidatorValidationData<TValue>())));

		public static TNext ForEach<TNext, TValue>(this IRootValidationData<TNext, IReadOnlyList<Option<TValue>>> data, Func<ValidatorValidationData<TValue>, IValidator<TValue>> selector)
			=> data.WithValidator(new NullableForEachValidator<TValue>(selector.Invoke(new ValidatorValidationData<TValue>())));

		public static TNext ForEach<TNext, TKey, TValue>(this IRootValidationData<TNext, IReadOnlyDictionary<TKey, TValue>> data, Func<ValidatorValidationData<KeyValuePair<TKey, TValue>>, IValidator<KeyValuePair<TKey, TValue>>> selector)
			=> data.WithValidator(new ForEachValidator<KeyValuePair<TKey, TValue>>(selector.Invoke(new ValidatorValidationData<KeyValuePair<TKey, TValue>>())));

		public static TNext ForEachKey<TNext, TKey, TValue>(this IRootValidationData<TNext, IReadOnlyDictionary<TKey, TValue>> data, Func<ValidatorValidationData<TKey>, IValidator<TKey>> selector)
			=> data.WithValidator(new ForEachKeyValidator<TKey, TValue>(selector.Invoke(new ValidatorValidationData<TKey>())));

		public static TNext ForEachValue<TNext, TKey, TValue>(this IRootValidationData<TNext, IReadOnlyDictionary<TKey, TValue>> data, Func<ValidatorValidationData<TValue>, IValidator<TValue>> selector)
			=> data.WithValidator(new ForEachValueValidator<TKey, TValue>(selector.Invoke(new ValidatorValidationData<TValue>())));

		public static TNext ForEachValue<TNext, TKey, TValue>(this IRootValidationData<TNext, IReadOnlyDictionary<TKey, Option<TValue>>> data, Func<ValidatorValidationData<TValue>, IValidator<TValue>> selector)
			=> data.WithValidator(new NullableForEachValueValidator<TKey, TValue>(selector.Invoke(new ValidatorValidationData<TValue>())));
	}
}
