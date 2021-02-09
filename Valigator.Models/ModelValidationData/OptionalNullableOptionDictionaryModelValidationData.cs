using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> : ModelValidationDataBase<TModel, Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>>, IModelPropertyData<TModel, IReadOnlyDictionary<TKey, Option<TValue>>, Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>>, IRootModelValidationData<OptionalNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>> _validationData;

		public OptionalNullableOptionDictionaryModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>> validationData)
			=> _validationData = validationData;

		public OptionalNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new OptionalNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public OptionalNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new OptionalNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public OptionalNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IModelValidator<TModel, IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new OptionalNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public OptionalNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new OptionalNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public override Result<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, ValidationError[]>(Optional.Unset<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>());

		public override Result<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, ValidationError[]> CoerceNone()
			=> Result.Success<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, ValidationError[]>(Optional.Set(Option.None<IReadOnlyDictionary<TKey, Option<TValue>>>()));

		public Result<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, ValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> Result.Success<Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, ValidationError[]>(Optional.Set(Option.Some(value)));

		public override Result<Unit, ValidationError[]> Validate(TModel model, Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option) && option.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
