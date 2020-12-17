using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class RequiredOptionCollectionModelValidationData<TModel, TValue> : IValidationData<RequiredOptionCollectionModelValidationData<TModel, TValue>, IReadOnlyList<Option<TValue>>>, IInvertableValidationData<RequiredOptionCollectionModelValidationData<TModel, TValue>, IReadOnlyList<Option<TValue>>>, IModelValidationData<RequiredOptionCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<Option<TValue>>>, IInvertableModelValidationData<RequiredOptionCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<Option<TValue>>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> _validationData;

		public RequiredOptionCollectionModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> validationData)
			=> _validationData = validationData;

		public RequiredOptionCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new RequiredOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new RequiredOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredOptionCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new RequiredOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new RequiredOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public Result<IReadOnlyList<Option<TValue>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<IReadOnlyList<Option<TValue>>, ValidationError[]>(item);

				return Result.Failure<IReadOnlyList<Option<TValue>>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Failure<IReadOnlyList<Option<TValue>>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, IReadOnlyList<Option<TValue>> value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
