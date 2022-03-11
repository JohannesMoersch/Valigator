using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class RequiredDictionaryModelValidationData<TModel, TKey, TValue> : ModelValidationDataBase<TModel, IReadOnlyDictionary<TKey, TValue>>, IModelPropertyData<TModel, IReadOnlyDictionary<TKey, Option<TValue>>, IReadOnlyDictionary<TKey, TValue>>, IRootModelValidationData<RequiredDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>> _validationData;

		public RequiredDictionaryModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>> validationData)
			=> _validationData = validationData;

		public RequiredDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new RequiredDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public RequiredDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new RequiredDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public RequiredDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IModelValidator<TModel, IReadOnlyDictionary<TKey, TValue>> value)
			=> new RequiredDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public RequiredDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyDictionary<TKey, TValue>> value)
			=> new RequiredDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public override Result<IReadOnlyDictionary<TKey, TValue>, CoercionValidationError[]> CoerceUnset()
			=> Result.Failure<IReadOnlyDictionary<TKey, TValue>, CoercionValidationError[]>(new[] { CoercionValidationErrors.UnsetValuesNotAllowed() });

		public override Result<IReadOnlyDictionary<TKey, TValue>, CoercionValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyDictionary<TKey, TValue>, CoercionValidationError[]>(new[] { CoercionValidationErrors.NullValuesNotAllowed() });

		public Result<IReadOnlyDictionary<TKey, TValue>, CoercionValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<IReadOnlyDictionary<TKey, TValue>, CoercionValidationError[]>(values)
				: Result.Failure<IReadOnlyDictionary<TKey, TValue>, CoercionValidationError[]>(nullIndices.Select(i => CoercionValidationErrors.NullValueAtKeyIsNotAllowed(i)).ToArray());

		public override Result<Unit, ValidationError[]> Validate(TModel model, IReadOnlyDictionary<TKey, TValue> value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
