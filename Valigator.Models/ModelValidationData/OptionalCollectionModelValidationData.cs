﻿using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalCollectionModelValidationData<TModel, TValue> : ModelValidationDataBase<TModel, Optional<IReadOnlyList<TValue>>>, IModelPropertyData<TModel, IReadOnlyList<Option<TValue>>, Optional<IReadOnlyList<TValue>>>, IRootModelValidationData<OptionalCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<TValue>>
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

		public override Result<Optional<IReadOnlyList<TValue>>, CoercionValidationError[]> CoerceUnset()
			=> Result.Success<Optional<IReadOnlyList<TValue>>, CoercionValidationError[]>(Optional.Unset<IReadOnlyList<TValue>>());

		public override Result<Optional<IReadOnlyList<TValue>>, CoercionValidationError[]> CoerceNone()
			=> Result.Failure<Optional<IReadOnlyList<TValue>>, CoercionValidationError[]>(new[] { CoercionValidationErrors.NullValuesNotAllowed() });

		public Result<Optional<IReadOnlyList<TValue>>, CoercionValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Optional<IReadOnlyList<TValue>>, CoercionValidationError[]>(Optional.Set(values))
				: Result.Failure<Optional<IReadOnlyList<TValue>>, CoercionValidationError[]>(nullIndices.Select(i => CoercionValidationErrors.NullValueAtIndexIsNotAllowed(i)).ToArray());

		public override Result<Unit, ValidationError[]> Validate(TModel model, Optional<IReadOnlyList<TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
