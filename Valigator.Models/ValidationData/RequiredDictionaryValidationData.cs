using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class RequiredDictionaryValidationData<TKey, TValue> : IPropertyData<IReadOnlyDictionary<TKey, Option<TValue>>, IReadOnlyDictionary<TKey, TValue>>, IRootValidationData<RequiredDictionaryValidationData<TKey, TValue>, IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly ValidationData<IReadOnlyDictionary<TKey, TValue>> _validationData;

		public RequiredDictionaryValidationData(ValidationData<IReadOnlyDictionary<TKey, TValue>> validationData)
			=> _validationData = validationData;

		public RequiredDictionaryValidationData<TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new RequiredDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public RequiredDictionaryValidationData<TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new RequiredDictionaryValidationData<TKey, TValue>(_validationData.WithValidator(value));

		public Result<IReadOnlyDictionary<TKey, TValue>, ValidationError[]> CoerceUnset()
			=> Result.Failure<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(new[] { ValidationErrors.UnsetValuesNotAllowed() });

		public Result<IReadOnlyDictionary<TKey, TValue>, ValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<IReadOnlyDictionary<TKey, TValue>, ValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(values)
				: Result.Failure<IReadOnlyDictionary<TKey, TValue>, ValidationError[]>(nullIndices.Select(i => ValidationErrors.NullValueAtKeyIsNotAllowed(i)).ToArray());

		public Result<Unit, ValidationError[]> Validate(IReadOnlyDictionary<TKey, TValue> value)
			=> _validationData.Process(value);
	}
}
