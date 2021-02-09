using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class RequiredNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> : ModelValidationDataBase<TModel, Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, IModelPropertyData<TModel, IReadOnlyDictionary<TKey, Option<TValue>>, Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, IRootModelValidationData<RequiredNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>> _validationData;

		public RequiredNullableOptionDictionaryModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>> validationData)
			=> _validationData = validationData;

		public RequiredNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new RequiredNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public RequiredNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new RequiredNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public RequiredNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IModelValidator<TModel, IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new RequiredNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public RequiredNullableOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new RequiredNullableOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public override Result<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(Option.None<IReadOnlyDictionary<TKey, Option<TValue>>>());

		public override Result<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]> CoerceNone()
			=> Result.Failure<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(new[] { ValidationErrors.UnsetValuesNotAllowed() });

		public Result<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> Result.Success<Option<IReadOnlyDictionary<TKey, Option<TValue>>>, ValidationError[]>(Option.Some(value));

		public override Result<Unit, ValidationError[]> Validate(TModel model, Option<IReadOnlyDictionary<TKey, Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
