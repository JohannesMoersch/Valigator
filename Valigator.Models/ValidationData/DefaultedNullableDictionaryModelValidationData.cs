using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class DefaultedNullableDictionaryModelValidationData<TModel, TKey, TValue> : IModelPropertyData<TModel, Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>>, Option<IReadOnlyDictionary<TKey, TValue>>>, IRootModelValidationData<DefaultedNullableDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly Option<IReadOnlyDictionary<TKey, TValue>> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>> _validationData;

		public DefaultedNullableDictionaryModelValidationData(Option<IReadOnlyDictionary<TKey, TValue>> defaultValue, ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new DefaultedNullableDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new DefaultedNullableDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IModelValidator<TModel, IReadOnlyDictionary<TKey, TValue>> value)
			=> new DefaultedNullableDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyDictionary<TKey, TValue>> value)
			=> new DefaultedNullableDictionaryModelValidationData<TModel, TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<Option<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyDictionary<TKey, Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (item.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices))
						return Result.Success<Option<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(Option.Some<IReadOnlyDictionary<TKey, TValue>>(values));
					
					return Result.Failure<Option<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());
				}

				return Result.Success<Option<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(Option.None<IReadOnlyDictionary<TKey, TValue>>());
			}

			return Result.Success<Option<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(_defaultValue);
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, Option<IReadOnlyDictionary<TKey, TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
