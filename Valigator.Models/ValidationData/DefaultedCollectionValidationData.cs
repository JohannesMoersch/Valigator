using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ValidationData
{
	public class DefaultedCollectionValidationData<TValue> : IPropertyData<Optional<Option<IReadOnlyList<Option<TValue>>>>, IReadOnlyList<TValue>>, IRootValidationData<DefaultedCollectionValidationData<TValue>, IReadOnlyList<TValue>>
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

		public Result<IReadOnlyList<TValue>, ValidationError[]> Coerce(Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (item.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices))
						return Result.Success<IReadOnlyList<TValue>, ValidationError[]>(values);
					
					return Result.Failure<IReadOnlyList<TValue>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());
				}

				return Result.Failure<IReadOnlyList<TValue>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<IReadOnlyList<TValue>, ValidationError[]>(_defaultValue);
		}

		public Result<Unit, ValidationError[]> Validate(IReadOnlyList<TValue> value)
			=> _validationData.Process(value);
	}
}
