using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedNullableDictionaryValidationData<TKey, TValue> : ValidationDataBase<Option<IReadOnlyDictionary<TKey, TValue>>>, IPropertyData<IReadOnlyDictionary<TKey, Option<TValue>>, Option<IReadOnlyDictionary<TKey, TValue>>>, IRootValidationData<DefaultedNullableDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly Func<Option<IReadOnlyDictionary<TKey, TValue>>> _defaultValue;

		private readonly ValidationData<IReadOnlyDictionary<TKey, TValue>> _validationData;

		public DefaultedNullableDictionaryValidationData(Func<Option<IReadOnlyDictionary<TKey, TValue>>> defaultValue, ValidationData<IReadOnlyDictionary<TKey, TValue>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new DefaultedNullableDictionaryValidationData<TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new DefaultedNullableDictionaryValidationData<TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public override Result<Option<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Option<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(_defaultValue.Invoke());

		public override Result<Option<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]> CoerceNone()
			=> Result.Success<Option<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(Option.None<IReadOnlyDictionary<TKey, TValue>>());

		public Result<Option<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Option<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(Option.Some(values))
				: Result.Failure<Option<IReadOnlyDictionary<TKey, TValue>>, ValidationError[]>(nullIndices.Select(i => CoercionValidationErrors.NullValueAtKeyIsNotAllowed(i)).ToArray());

		public override Result<Unit, ValidationError[]> Validate(Option<IReadOnlyDictionary<TKey, TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(item);

			return Result.Unit<ValidationError[]>();
		}
	}
}
