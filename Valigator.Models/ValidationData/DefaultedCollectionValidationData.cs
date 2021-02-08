using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedCollectionValidationData<TValue> : ValidationDataBase<IReadOnlyList<TValue>>, IPropertyData<IReadOnlyList<Option<TValue>>, IReadOnlyList<TValue>>, IRootValidationData<DefaultedCollectionValidationData<TValue>, IReadOnlyList<TValue>>
	{
		private readonly IReadOnlyList<TValue> _defaultValue;

		private readonly ValidationData<IReadOnlyList<TValue>> _validationData;

		public DefaultedCollectionValidationData(IReadOnlyList<TValue> defaultValue, ValidationData<IReadOnlyList<TValue>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedCollectionValidationData<TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new DefaultedCollectionValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedCollectionValidationData<TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new DefaultedCollectionValidationData<TValue>(_defaultValue, _validationData.WithValidator(value));

		public override Result<IReadOnlyList<TValue>, ValidationError[]> CoerceUnset()
			=> Result.Success<IReadOnlyList<TValue>, ValidationError[]>(_defaultValue);

		public override Result<IReadOnlyList<TValue>, ValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyList<TValue>, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<IReadOnlyList<TValue>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<IReadOnlyList<TValue>, ValidationError[]>(values)
				: Result.Failure<IReadOnlyList<TValue>, ValidationError[]>(nullIndices.Select(i => ValidationErrors.NullValueAtIndexIsNotAllowed(i)).ToArray());

		public override Result<Unit, ValidationError[]> Validate(IReadOnlyList<TValue> value)
			=> _validationData.Process(value);
	}
}
