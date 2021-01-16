using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedDictionaryValidationData<TKey, TValue> : IPropertyData<IReadOnlyDictionary<TKey, Option<TValue>>, IReadOnlyDictionary<TKey, TValue>>, IRootValidationData<DefaultedDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly IReadOnlyDictionary<TKey, TValue> _defaultValue;

		private readonly ValidationData<IReadOnlyDictionary<TKey, TValue>> _validationData;

		public DefaultedDictionaryValidationData(IReadOnlyDictionary<TKey, TValue> defaultValue, ValidationData<IReadOnlyDictionary<TKey, TValue>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new DefaultedDictionaryValidationData<TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new DefaultedDictionaryValidationData<TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<IReadOnlyDictionary<TKey, TValue>, ValidationError[]> CoerceUnset()
			=> Result.Success<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(_defaultValue);

		public Result<IReadOnlyDictionary<TKey, TValue>, ValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<IReadOnlyDictionary<TKey, TValue>, ValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(values)
				: Result.Failure<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(nullIndices.Select(i => ValidationErrors.NullValueAtKeyIsNotAllowed(i)).ToArray());

		public Result<Unit, ValidationError[]> Validate(IReadOnlyDictionary<TKey, TValue> value)
			=> _validationData.Process(value);

		public Data<IReadOnlyDictionary<TKey, TValue>> ToData()
			=> new Data<IReadOnlyDictionary<TKey, TValue>>(this);

		public static implicit operator Data<IReadOnlyDictionary<TKey, TValue>>(DefaultedDictionaryValidationData<TKey, TValue> propertyData)
			=> propertyData.ToData();
	}
}
