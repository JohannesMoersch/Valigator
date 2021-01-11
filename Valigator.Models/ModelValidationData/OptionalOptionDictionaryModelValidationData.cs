using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalOptionDictionaryModelValidationData<TModel, TKey, TValue> : IModelPropertyData<TModel, Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, Optional<IReadOnlyDictionary<TKey, Option<TValue>>>>, IRootModelValidationData<OptionalOptionDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>> _validationData;

		public OptionalOptionDictionaryModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>> validationData)
			=> _validationData = validationData;

		public OptionalOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new OptionalOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public OptionalOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new OptionalOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public OptionalOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IModelValidator<TModel, IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new OptionalOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public OptionalOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new OptionalOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public Result<Optional<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<Optional<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(Optional.Set(item));

				return Result.Failure<Optional<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<Optional<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(Optional.Unset<IReadOnlyDictionary<TKey, Option<TValue>>>());
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, Optional<IReadOnlyDictionary<TKey, Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
