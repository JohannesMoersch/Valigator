using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class DefaultedCollectionModelValidationData<TModel, TValue> : IModelPropertyData<TModel, Optional<Option<IReadOnlyList<Option<TValue>>>>, IReadOnlyList<TValue>>, IRootModelValidationData<DefaultedCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<TValue>>
	{
		private readonly IReadOnlyList<TValue> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> _validationData;

		public DefaultedCollectionModelValidationData(IReadOnlyList<TValue> defaultValue, ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new DefaultedCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new DefaultedCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new DefaultedCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new DefaultedCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

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

		public Result<Unit, ValidationError[]> Validate(TModel model, IReadOnlyList<TValue> value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
