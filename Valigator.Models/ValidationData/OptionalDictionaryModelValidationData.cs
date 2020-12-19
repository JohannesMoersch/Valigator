using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class OptionalDictionaryModelValidationData<TModel, TKey, TValue> : IModelPropertyData<TModel, Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, Optional<IReadOnlyDictionary<TKey, TValue>>>, IRootModelValidationData<OptionalDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>> _validationData;

		public OptionalDictionaryModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>> validationData)
			=> _validationData = validationData;

		public OptionalDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new OptionalDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public OptionalDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new OptionalDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public OptionalDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IModelValidator<TModel, IReadOnlyDictionary<TKey, TValue>> value)
			=> new OptionalDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public OptionalDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyDictionary<TKey, TValue>> value)
			=> new OptionalDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public Result<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (item.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices))
						return Result.Success<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(Optional.Set<IReadOnlyDictionary<TKey, TValue>>(values));
					
					return Result.Failure<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());
				}

				return Result.Failure<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(Optional.Unset<IReadOnlyDictionary<TKey, TValue>>());
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, Optional<IReadOnlyDictionary<TKey, TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
