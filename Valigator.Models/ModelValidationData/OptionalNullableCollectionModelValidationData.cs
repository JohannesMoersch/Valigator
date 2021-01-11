using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalNullableCollectionModelValidationData<TModel, TValue> : IModelPropertyData<TModel, Optional<Option<IReadOnlyList<Option<TValue>>>>, Optional<Option<IReadOnlyList<TValue>>>>, IRootModelValidationData<OptionalNullableCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<TValue>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> _validationData;

		public OptionalNullableCollectionModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> validationData)
			=> _validationData = validationData;

		public OptionalNullableCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new OptionalNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalNullableCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new OptionalNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalNullableCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new OptionalNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalNullableCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new OptionalNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public Result<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (item.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices))
						return Result.Success<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(Optional.Set(Option.Some<IReadOnlyList<TValue>>(values)));
					
					return Result.Failure<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());
				}

				return Result.Success<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(Optional.Set(Option.None<IReadOnlyList<TValue>>()));
			}

			return Result.Failure<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, Optional<Option<IReadOnlyList<TValue>>> value)
		{
			if (value.TryGetValue(out var option) && option.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
