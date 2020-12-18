using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class OptionalOptionCollectionModelValidationData<TModel, TValue> : IModelPropertyData<TModel, Optional<Option<IReadOnlyList<Option<TValue>>>>, Optional<IReadOnlyList<Option<TValue>>>>, IValidationData<OptionalOptionCollectionModelValidationData<TModel, TValue>, IReadOnlyList<Option<TValue>>>, IInvertableValidationData<OptionalOptionCollectionModelValidationData<TModel, TValue>, IReadOnlyList<Option<TValue>>>, IModelValidationData<OptionalOptionCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<Option<TValue>>>, IInvertableModelValidationData<OptionalOptionCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<Option<TValue>>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> _validationData;

		public OptionalOptionCollectionModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> validationData)
			=> _validationData = validationData;

		public OptionalOptionCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new OptionalOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new OptionalOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalOptionCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new OptionalOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new OptionalOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public Result<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Optional.Set(item));

				return Result.Failure<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Optional.Unset<IReadOnlyList<Option<TValue>>>());
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, Optional<IReadOnlyList<Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
