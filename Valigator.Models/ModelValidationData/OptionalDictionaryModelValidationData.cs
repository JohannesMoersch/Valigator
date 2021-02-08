using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalDictionaryModelValidationData<TModel, TKey, TValue> : IModelPropertyData<TModel, IReadOnlyDictionary<TKey, Option<TValue>>, Optional<IReadOnlyDictionary<TKey, TValue>>>, IRootModelValidationData<OptionalDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, TValue>>
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

		public Result<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(Optional.Unset<IReadOnlyDictionary<TKey, TValue>>());

		public Result<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]> CoerceNone()
			=> Result.Failure<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(Optional.Set(values))
				: Result.Failure<Optional<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(nullIndices.Select(i => ValidationErrors.NullValueAtKeyIsNotAllowed(i)).ToArray());

		public Result<Unit, ValidationError[]> Validate(TModel model, Optional<IReadOnlyDictionary<TKey, TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}

		public static ModelDefinition<TModel>.Property<Optional<IReadOnlyDictionary<TKey, TValue>>> ToProperty(OptionalDictionaryModelValidationData<TModel, TKey, TValue> data)
			=> new ModelDefinition<TModel>.Property<Optional<IReadOnlyDictionary<TKey, TValue>>>(data);

		public static implicit operator ModelDefinition<TModel>.Property<Optional<IReadOnlyDictionary<TKey, TValue>>>(OptionalDictionaryModelValidationData<TModel, TKey, TValue> data)
			=> ToProperty(data);
	}
}
