using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalOptionDictionaryModelValidationData<TModel, TKey, TValue> : ModelValidationDataBase<TModel, Optional<IReadOnlyDictionary<TKey, Option<TValue>>>>, IModelPropertyData<TModel, IReadOnlyDictionary<TKey, Option<TValue>>, Optional<IReadOnlyDictionary<TKey, Option<TValue>>>>, IRootModelValidationData<OptionalOptionDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, Option<TValue>>>
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

		public override Result<Optional<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(Optional.Unset<IReadOnlyDictionary<TKey, Option<TValue>>>());

		public override Result<Optional<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]> CoerceNone()
			=> Result.Failure<Optional<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<Optional<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> Result.Success<Optional<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(Optional.Set(value));

		public override Result<Unit, ValidationError[]> Validate(TModel model, Optional<IReadOnlyDictionary<TKey, Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
