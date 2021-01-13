using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedOptionCollectionValidationData<TValue> : IPropertyData<IReadOnlyList<Option<TValue>>, IReadOnlyList<Option<TValue>>>, IRootValidationData<DefaultedOptionCollectionValidationData<TValue>, IReadOnlyList<Option<TValue>>>
	{
		private readonly IReadOnlyList<Option<TValue>> _defaultValue;

		private readonly ValidationData<IReadOnlyList<Option<TValue>>> _validationData;

		public DefaultedOptionCollectionValidationData(IReadOnlyList<Option<TValue>> defaultValue, ValidationData<IReadOnlyList<Option<TValue>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedOptionCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedOptionCollectionValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedOptionCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedOptionCollectionValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<IReadOnlyList<Option<TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Success<IReadOnlyList<Option<TValue>>, ValidationError[]>(_defaultValue);

		public Result<IReadOnlyList<Option<TValue>>, ValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyList<Option<TValue>>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });

		public Result<IReadOnlyList<Option<TValue>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> Result.Success<IReadOnlyList<Option<TValue>>, ValidationError[]>(value);

		public Result<Unit, ValidationError[]> Validate(IReadOnlyList<Option<TValue>> value)
			=> _validationData.Process(value);
	}
}
