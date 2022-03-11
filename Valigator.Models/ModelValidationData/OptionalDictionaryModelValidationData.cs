using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalDictionaryModelValidationData<TModel, TKey, TValue> : ModelValidationDataBase<TModel, Optional<IReadOnlyDictionary<TKey, TValue>>>, IModelPropertyData<TModel, IReadOnlyDictionary<TKey, Option<TValue>>, Optional<IReadOnlyDictionary<TKey, TValue>>>, IRootModelValidationData<OptionalDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, TValue>>
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

		public override Result<Optional<IReadOnlyDictionary<TKey, TValue>>, CoercionValidationError[]> CoerceUnset()
			=> Result.Success<Optional<IReadOnlyDictionary<TKey, TValue>>, CoercionValidationError[]>(Optional.Unset<IReadOnlyDictionary<TKey, TValue>>());

		public override Result<Optional<IReadOnlyDictionary<TKey, TValue>>, CoercionValidationError[]> CoerceNone()
			=> Result.Failure<Optional<IReadOnlyDictionary<TKey, TValue>>, CoercionValidationError[]>(new[] { CoercionValidationErrors.NullValuesNotAllowed() });

		public Result<Optional<IReadOnlyDictionary<TKey, TValue>>, CoercionValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Optional<IReadOnlyDictionary<TKey, TValue>>, CoercionValidationError[]>(Optional.Set(values))
				: Result.Failure<Optional<IReadOnlyDictionary<TKey, TValue>>, CoercionValidationError[]>(nullIndices.Select(i => CoercionValidationErrors.NullValueAtKeyIsNotAllowed(i)).ToArray());

		public override Result<Unit, ValidationError[]> Validate(TModel model, Optional<IReadOnlyDictionary<TKey, TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
