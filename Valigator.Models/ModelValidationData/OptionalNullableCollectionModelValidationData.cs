using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalNullableCollectionModelValidationData<TModel, TValue> : IModelPropertyData<TModel, IReadOnlyList<Option<TValue>>, Optional<Option<IReadOnlyList<TValue>>>>, IRootModelValidationData<OptionalNullableCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<TValue>>
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

		public Result<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(Optional.Unset<Option<IReadOnlyList<TValue>>>());

		public Result<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]> CoerceNone()
			=> Result.Success<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(Optional.Set(Option.None<IReadOnlyList<TValue>>()));

		public Result<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(Optional.Set(Option.Some(values)))
				: Result.Failure<Optional<Option<IReadOnlyList<TValue>>>, ValidationError[]>(nullIndices.Select(i => ValidationErrors.NullValueAtIndexIsNotAllowed(i)).ToArray());

		public Result<Unit, ValidationError[]> Validate(TModel model, Optional<Option<IReadOnlyList<TValue>>> value)
		{
			if (value.TryGetValue(out var option) && option.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}

		public static ModelDefinition<TModel>.Property<Optional<Option<IReadOnlyList<TValue>>>> ToProperty(OptionalNullableCollectionModelValidationData<TModel, TValue> data)
			=> new ModelDefinition<TModel>.Property<Optional<Option<IReadOnlyList<TValue>>>>(data);

		public static implicit operator ModelDefinition<TModel>.Property<Optional<Option<IReadOnlyList<TValue>>>>(OptionalNullableCollectionModelValidationData<TModel, TValue> data)
			=> ToProperty(data);
	}
}
