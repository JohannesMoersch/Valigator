using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class OptionalCollectionModelValidationData<TModel, TValue> : IModelPropertyData<TModel, Optional<Option<IReadOnlyList<Option<TValue>>>>, Optional<IReadOnlyList<TValue>>>, IRootModelValidationData<OptionalCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<TValue>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> _validationData;

		public OptionalCollectionModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> validationData)
			=> _validationData = validationData;

		public OptionalCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new OptionalCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new OptionalCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new OptionalCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new OptionalCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public Result<Optional<IReadOnlyList<TValue>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (item.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices))
						return Result.Success<Optional<IReadOnlyList<TValue>>, ValidationError[]>(Optional.Set<IReadOnlyList<TValue>>(values));
					
					return Result.Failure<Optional<IReadOnlyList<TValue>>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());
				}

				return Result.Failure<Optional<IReadOnlyList<TValue>>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<Optional<IReadOnlyList<TValue>>, ValidationError[]>(Optional.Unset<IReadOnlyList<TValue>>());
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, Optional<IReadOnlyList<TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
