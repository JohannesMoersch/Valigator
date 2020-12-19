using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class RequiredOptionDictionaryModelValidationData<TModel, TKey, TValue> : IModelPropertyData<TModel, Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, IReadOnlyDictionary<TKey, Option<TValue>>>, IRootModelValidationData<RequiredOptionDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, Option<TValue>>>
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

		public Result<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(item);

				return Result.Failure<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Failure<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
