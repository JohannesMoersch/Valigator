using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class RequiredOptionDictionaryModelValidationData<TModel, TKey, TValue> : ModelValidationDataBase<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>, IModelPropertyData<TModel, IReadOnlyDictionary<TKey, Option<TValue>>, IReadOnlyDictionary<TKey, Option<TValue>>>, IRootModelValidationData<RequiredOptionDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>> _validationData;

		public RequiredOptionDictionaryModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>> validationData)
			=> _validationData = validationData;

		public RequiredOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new RequiredOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public RequiredOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new RequiredOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public RequiredOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IModelValidator<TModel, IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new RequiredOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public RequiredOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new RequiredOptionDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public override Result<IReadOnlyDictionary<TKey, Option<TValue>>, CoercionValidationError[]> CoerceUnset()
			=> Result.Failure<IReadOnlyDictionary<TKey, Option<TValue>>, CoercionValidationError[]>(new[] { CoercionValidationErrors.UnsetValuesNotAllowed() });

		public override Result<IReadOnlyDictionary<TKey, Option<TValue>>, CoercionValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyDictionary<TKey, Option<TValue>>, CoercionValidationError[]>(new[] { CoercionValidationErrors.NullValuesNotAllowed() });

		public Result<IReadOnlyDictionary<TKey, Option<TValue>>, CoercionValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> Result.Success<IReadOnlyDictionary<TKey, Option<TValue>>, CoercionValidationError[]>(value);

		public override Result<Unit, ValidationError[]> Validate(TModel model, IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
