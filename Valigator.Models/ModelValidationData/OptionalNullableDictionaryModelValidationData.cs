using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalNullableDictionaryModelValidationData<TModel, TKey, TValue> : IModelPropertyData<TModel, Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, Optional<Option<IReadOnlyDictionary<TKey, TValue>>>>, IRootModelValidationData<OptionalNullableDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>> _validationData;

		public OptionalNullableDictionaryModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>> validationData)
			=> _validationData = validationData;

		public OptionalNullableDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new OptionalNullableDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public OptionalNullableDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new OptionalNullableDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public OptionalNullableDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IModelValidator<TModel, IReadOnlyDictionary<TKey, TValue>> value)
			=> new OptionalNullableDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public OptionalNullableDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyDictionary<TKey, TValue>> value)
			=> new OptionalNullableDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public Result<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (item.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices))
						return Result.Success<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]>(Optional.Set(Option.Some<IReadOnlyDictionary<TKey, TValue>>(values)));
					
					return Result.Failure<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());
				}

				return Result.Success<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]>(Optional.Set(Option.None<IReadOnlyDictionary<TKey, TValue>>()));
			}

			return Result.Failure<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, Optional<Option<IReadOnlyDictionary<TKey, TValue>>> value)
		{
			if (value.TryGetValue(out var option) && option.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
