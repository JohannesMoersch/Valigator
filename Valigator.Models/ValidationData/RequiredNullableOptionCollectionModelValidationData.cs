using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class RequiredNullableOptionCollectionModelValidationData<TModel, TValue> : IValidationData<RequiredNullableOptionCollectionModelValidationData<TModel, TValue>, Option<IReadOnlyList<Option<TValue>>>>, IInvertableValidationData<RequiredNullableOptionCollectionModelValidationData<TModel, TValue>, Option<IReadOnlyList<Option<TValue>>>>, IModelValidationData<RequiredNullableOptionCollectionModelValidationData<TModel, TValue>, TModel, Option<IReadOnlyList<Option<TValue>>>>, IInvertableModelValidationData<RequiredNullableOptionCollectionModelValidationData<TModel, TValue>, TModel, Option<IReadOnlyList<Option<TValue>>>>
	{
		private readonly ValidationData<ModelValue<TModel, Option<IReadOnlyList<Option<TValue>>>>> _validationData;

		public RequiredNullableOptionCollectionModelValidationData(ValidationData<ModelValue<TModel, Option<IReadOnlyList<Option<TValue>>>>> validationData)
			=> _validationData = validationData;

		public RequiredNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<Option<IReadOnlyList<Option<TValue>>>> value)
			=> new RequiredNullableOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<Option<IReadOnlyList<Option<TValue>>>> value)
			=> new RequiredNullableOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, Option<IReadOnlyList<Option<TValue>>>> value)
			=> new RequiredNullableOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, Option<IReadOnlyList<Option<TValue>>>> value)
			=> new RequiredNullableOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public Result<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Option.Some<IReadOnlyList<Option<TValue>>>(item));

				return Result.Success<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Option.None<IReadOnlyList<Option<TValue>>>());
			}

			return Result.Failure<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, Option<IReadOnlyList<Option<TValue>>> value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
