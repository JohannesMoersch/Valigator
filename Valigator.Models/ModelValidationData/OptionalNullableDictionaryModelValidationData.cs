using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalNullableDictionaryModelValidationData<TModel, TKey, TValue> : IModelPropertyData<TModel, IReadOnlyDictionary<TKey, Option<TValue>>, Optional<Option<IReadOnlyDictionary<TKey, TValue>>>>, IRootModelValidationData<OptionalNullableDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, TValue>>
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

		public Result<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]>(Optional.Unset<Option<IReadOnlyDictionary<TKey, TValue>>>());

		public Result<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]> CoerceNone()
			=> Result.Success<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]>(Optional.Set(Option.None<IReadOnlyDictionary<TKey, TValue>>()));

		public Result<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]>(Optional.Set(Option.Some(values)))
				: Result.Failure<Optional<Option<IReadOnlyDictionary<TKey, TValue>>>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());

		public Result<Unit, ValidationError[]> Validate(TModel model, Optional<Option<IReadOnlyDictionary<TKey, TValue>>> value)
		{
			if (value.TryGetValue(out var option) && option.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
