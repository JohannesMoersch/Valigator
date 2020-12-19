using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue> : IModelPropertyData<TModel, Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, IReadOnlyDictionary<TKey, Option<TValue>>>, IRootModelValidationData<DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly IReadOnlyDictionary<TKey, Option<TValue>> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>> _validationData;

		public DefaultedOptionDictionaryModelValidationData(IReadOnlyDictionary<TKey, Option<TValue>> defaultValue, ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IModelValidator<TModel, IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(item);

				return Result.Failure<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(_defaultValue);
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
