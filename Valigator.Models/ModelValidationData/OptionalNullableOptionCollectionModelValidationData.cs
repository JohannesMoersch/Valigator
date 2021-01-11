using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalNullableOptionCollectionModelValidationData<TModel, TValue> : IModelPropertyData<TModel, Optional<Option<IReadOnlyList<Option<TValue>>>>, Optional<Option<IReadOnlyList<Option<TValue>>>>>, IRootModelValidationData<OptionalNullableOptionCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<Option<TValue>>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> _validationData;

		public OptionalNullableOptionCollectionModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> validationData)
			=> _validationData = validationData;

		public OptionalNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new OptionalNullableOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new OptionalNullableOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new OptionalNullableOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new OptionalNullableOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public Result<Optional<Option<IReadOnlyList<Option<TValue>>>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<Optional<Option<IReadOnlyList<Option<TValue>>>>, ValidationError[]>(Optional.Set(Option.Some(item)));

				return Result.Success<Optional<Option<IReadOnlyList<Option<TValue>>>>, ValidationError[]>(Optional.Set(Option.None<IReadOnlyList<Option<TValue>>>()));
			}

			return Result.Failure<Optional<Option<IReadOnlyList<Option<TValue>>>>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option) && option.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
