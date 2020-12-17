using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class RequiredNullableCollectionModelValidationData<TModel, TValue> : IValidationData<RequiredNullableCollectionModelValidationData<TModel, TValue>, Option<IReadOnlyList<TValue>>>, IInvertableValidationData<RequiredNullableCollectionModelValidationData<TModel, TValue>, Option<IReadOnlyList<TValue>>>, IModelValidationData<RequiredNullableCollectionModelValidationData<TModel, TValue>, TModel, Option<IReadOnlyList<TValue>>>, IInvertableModelValidationData<RequiredNullableCollectionModelValidationData<TModel, TValue>, TModel, Option<IReadOnlyList<TValue>>>
	{
		private readonly ValidationData<ModelValue<TModel, Option<IReadOnlyList<TValue>>>> _validationData;

		public RequiredNullableCollectionModelValidationData(ValidationData<ModelValue<TModel, Option<IReadOnlyList<TValue>>>> validationData)
			=> _validationData = validationData;

		public RequiredNullableCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<Option<IReadOnlyList<TValue>>> value)
			=> new RequiredNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<Option<IReadOnlyList<TValue>>> value)
			=> new RequiredNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, Option<IReadOnlyList<TValue>>> value)
			=> new RequiredNullableCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, Option<IReadOnlyList<TValue>>> value)
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
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
