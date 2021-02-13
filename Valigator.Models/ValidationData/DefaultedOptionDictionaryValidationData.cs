using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedOptionDictionaryValidationData<TKey, TValue> : ValidationDataBase<IReadOnlyDictionary<TKey, Option<TValue>>>, IPropertyData<IReadOnlyDictionary<TKey, Option<TValue>>, IReadOnlyDictionary<TKey, Option<TValue>>>, IRootValidationData<DefaultedOptionDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, Option<TValue>>>
	{
		private readonly Func<IReadOnlyDictionary<TKey, Option<TValue>>> _defaultValue;

		private readonly ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>> _validationData;

		public DefaultedOptionDictionaryValidationData(Func<IReadOnlyDictionary<TKey, Option<TValue>>> defaultValue, ValidationData<IReadOnlyDictionary<TKey, Option<TValue>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedOptionDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedOptionDictionaryValidationData<TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedOptionDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, Option<TValue>>> value)
			=> new DefaultedOptionDictionaryValidationData<TKey, TValue>(_defaultValue, _validationData.WithValidator(value));

		public override Result<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Success<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(_defaultValue.Invoke());

		public override Result<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> Result.Success<IReadOnlyDictionary<TKey, Option<TValue>>, ValidationError[]>(value);

		public override Result<Unit, ValidationError[]> Validate(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> _validationData.Process(value);
	}
}
