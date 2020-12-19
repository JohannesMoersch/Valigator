using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class RequiredNullableCollectionModelValidationData<TModel, TValue> : IModelPropertyData<TModel, Optional<Option<IReadOnlyList<Option<TValue>>>>, Option<IReadOnlyList<TValue>>>, IRootModelValidationData<RequiredNullableCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<TValue>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> _validationData;

		public RequiredNullableCollectionModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> validationData)
			=> _validationData = validationData;

		public RequiredNullableCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new RequiredNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new RequiredNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new RequiredNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new RequiredNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public Result<Option<IReadOnlyList<TValue>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (item.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices))
						return Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(Option.Some<IReadOnlyList<TValue>>(values));
					
					return Result.Failure<Option<IReadOnlyList<TValue>>, ValidationError[]>(nullIndices.Select(i => new ValidationError($"Null value in index {i} is not allowed.")).ToArray());
				}

				return Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(Option.None<IReadOnlyList<TValue>>());
			}

			return Result.Failure<Option<IReadOnlyList<TValue>>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, Option<IReadOnlyList<TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
