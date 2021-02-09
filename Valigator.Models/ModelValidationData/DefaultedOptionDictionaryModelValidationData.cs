using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue> : ModelValidationDataBase<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>, IModelPropertyData<TModel, IReadOnlyDictionary<TKey, Option<TValue>>, IReadOnlyDictionary<TKey, Option<TValue>>>, IRootModelValidationData<DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly IReadOnlyDictionary<TKey, Option<TValue>> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>> _validationData;

		public DefaultedOptionDictionaryModelValidationData(IReadOnlyDictionary<TKey, Option<TValue>> defaultValue, ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, Option<TValue>>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IModelValidator<TModel, IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedOptionDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public override Result<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Success<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(_defaultValue);

		public override Result<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> Result.Success<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(value);

		public override Result<Unit, ValidationError[]> Validate(TModel model, IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
