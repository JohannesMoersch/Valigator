using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class RequiredDictionaryModelValidationData<TModel, TKey, TValue> : IModelPropertyData<TModel, Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, IReadOnlyDictionary<TKey, TValue>>, IValidationData<RequiredDictionaryModelValidationData<TModel, TKey, TValue>, IReadOnlyDictionary<TKey, TValue>>, IInvertableValidationData<RequiredDictionaryModelValidationData<TModel, TKey, TValue>, IReadOnlyDictionary<TKey, TValue>>, IModelValidationData<RequiredDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, TValue>>, IInvertableModelValidationData<RequiredDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, TValue>>
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

		public Result<IReadOnlyDictionary<TKey, TValue>, ValidationError[]> Coerce(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (item.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices))
						return Result.Success<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(values);
					
					return Result.Failure<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());
				}

				return Result.Failure<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Failure<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, IReadOnlyDictionary<TKey, TValue> value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
