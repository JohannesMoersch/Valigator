using Functional;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Valigator.Core;
using Valigator.ModelValidationData;
using Valigator.Validators;

namespace Valigator
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class RootModelValidationDataExtensions
	{
		public static TNext Not<TNext, TModel, TValue>(this IRootModelValidationData<TNext, TModel, TValue> data, Func<InvertableModelValidatorValidationData<TModel, TValue>, NotValidator<TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableModelValidatorValidationData<TModel, TValue>()));

		public static TNext Not<TNext, TModel, TValue>(this IRootModelValidationData<TNext, TModel, TValue> data, Func<InvertableModelValidatorValidationData<TModel, TValue>, NotModelValidator<TModel, TValue>> selector)
			=> data.WithValidator(selector.Invoke(new InvertableModelValidatorValidationData<TModel, TValue>()));

		public static TNext ForEach<TNext, TModel, TValue>(this IRootModelValidationData<TNext, TModel, IReadOnlyList<TValue>> data, Func<ModelValidatorValidationData<TModel, TValue>, IValidator<TValue>> selector)
			=> data.WithValidator(new ForEachValidator<TValue>(selector.Invoke(new ModelValidatorValidationData<TModel, TValue>())));

		public static TNext ForEach<TNext, TModel, TValue>(this IRootModelValidationData<TNext, TModel, IReadOnlyList<TValue>> data, Func<ModelValidatorValidationData<TModel, TValue>, IModelValidator<TModel, TValue>> selector)
			=> data.WithValidator(new ForEachModelValidator<TModel, TValue>(selector.Invoke(new ModelValidatorValidationData<TModel, TValue>())));

		public static TNext ForEach<TNext, TModel, TValue>(this IRootModelValidationData<TNext, TModel, IReadOnlyList<Option<TValue>>> data, Func<ModelValidatorValidationData<TModel, TValue>, IValidator<TValue>> selector)
			=> data.WithValidator(new NullableForEachValidator<TValue>(selector.Invoke(new ModelValidatorValidationData<TModel, TValue>())));

		public static TNext ForEach<TNext, TModel, TValue>(this IRootModelValidationData<TNext, TModel, IReadOnlyList<Option<TValue>>> data, Func<ModelValidatorValidationData<TModel, TValue>, IModelValidator<TModel, TValue>> selector)
			=> data.WithValidator(new NullableForEachModelValidator<TModel, TValue>(selector.Invoke(new ModelValidatorValidationData<TModel, TValue>())));

		public static TNext ForEach<TNext, TModel, TKey, TValue>(this IRootModelValidationData<TNext, TModel, IReadOnlyDictionary<TKey, TValue>> data, Func<ModelValidatorValidationData<TModel, KeyValuePair<TKey, TValue>>, IValidator<KeyValuePair<TKey, TValue>>> selector)
			=> data.WithValidator(new ForEachValidator<KeyValuePair<TKey, TValue>>(selector.Invoke(new ModelValidatorValidationData<TModel, KeyValuePair<TKey, TValue>>())));

		public static TNext ForEach<TNext, TModel, TKey, TValue>(this IRootModelValidationData<TNext, TModel, IReadOnlyDictionary<TKey, TValue>> data, Func<ModelValidatorValidationData<TModel, KeyValuePair<TKey, TValue>>, IModelValidator<TModel, KeyValuePair<TKey, TValue>>> selector)
			=> data.WithValidator(new ForEachModelValidator<TModel, KeyValuePair<TKey, TValue>>(selector.Invoke(new ModelValidatorValidationData<TModel, KeyValuePair<TKey, TValue>>())));

		public static TNext ForEachKey<TNext, TModel, TKey, TValue>(this IRootModelValidationData<TNext, TModel, IReadOnlyDictionary<TKey, TValue>> data, Func<ModelValidatorValidationData<TModel, TKey>, IValidator<TKey>> selector)
			=> data.WithValidator(new ForEachKeyValidator<TKey, TValue>(selector.Invoke(new ModelValidatorValidationData<TModel, TKey>())));

		public static TNext ForEachKey<TNext, TModel, TKey, TValue>(this IRootModelValidationData<TNext, TModel, IReadOnlyDictionary<TKey, TValue>> data, Func<ModelValidatorValidationData<TModel, TKey>, IModelValidator<TModel, TKey>> selector)
			=> data.WithValidator(new ForEachKeyModelValidator<TModel, TKey, TValue>(selector.Invoke(new ModelValidatorValidationData<TModel, TKey>())));

		public static TNext ForEachValue<TNext, TModel, TKey, TValue>(this IRootModelValidationData<TNext, TModel, IReadOnlyDictionary<TKey, TValue>> data, Func<ModelValidatorValidationData<TModel, TValue>, IValidator<TValue>> selector)
			=> data.WithValidator(new ForEachValueValidator<TKey, TValue>(selector.Invoke(new ModelValidatorValidationData<TModel, TValue>())));

		public static TNext ForEachValue<TNext, TModel, TKey, TValue>(this IRootModelValidationData<TNext, TModel, IReadOnlyDictionary<TKey, TValue>> data, Func<ModelValidatorValidationData<TModel, TValue>, IModelValidator<TModel, TValue>> selector)
			=> data.WithValidator(new ForEachValueModelValidator<TModel, TKey, TValue>(selector.Invoke(new ModelValidatorValidationData<TModel, TValue>())));

		public static TNext ForEachValue<TNext, TModel, TKey, TValue>(this IRootModelValidationData<TNext, TModel, IReadOnlyDictionary<TKey, Option<TValue>>> data, Func<ModelValidatorValidationData<TModel, TValue>, IValidator<TValue>> selector)
			=> data.WithValidator(new NullableForEachValueValidator<TKey, TValue>(selector.Invoke(new ModelValidatorValidationData<TModel, TValue>())));

		public static TNext ForEachValue<TNext, TModel, TKey, TValue>(this IRootModelValidationData<TNext, TModel, IReadOnlyDictionary<TKey, Option<TValue>>> data, Func<ModelValidatorValidationData<TModel, TValue>, IModelValidator<TModel, TValue>> selector)
			=> data.WithValidator(new NullableForEachValueModelValidator<TModel, TKey, TValue>(selector.Invoke(new ModelValidatorValidationData<TModel, TValue>())));
	}
}
