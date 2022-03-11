﻿using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class RequiredNullableDictionaryModelValidationData<TModel, TKey, TValue> : ModelValidationDataBase<TModel, Option<IReadOnlyDictionary<TKey, TValue>>>, IModelPropertyData<TModel, IReadOnlyDictionary<TKey, Option<TValue>>, Option<IReadOnlyDictionary<TKey, TValue>>>, IRootModelValidationData<RequiredNullableDictionaryModelValidationData<TModel, TKey, TValue>, TModel, IReadOnlyDictionary<TKey, TValue>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>> _validationData;

		public RequiredNullableDictionaryModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyDictionary<TKey, TValue>>> validationData)
			=> _validationData = validationData;

		public RequiredNullableDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new RequiredNullableDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public RequiredNullableDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableValidator<IReadOnlyDictionary<TKey, TValue>> value)
			=> new RequiredNullableDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public RequiredNullableDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IModelValidator<TModel, IReadOnlyDictionary<TKey, TValue>> value)
			=> new RequiredNullableDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public RequiredNullableDictionaryModelValidationData<TModel, TKey, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyDictionary<TKey, TValue>> value)
			=> new RequiredNullableDictionaryModelValidationData<TModel, TKey, TValue>(_validationData.WithValidator(value));

		public override Result<Option<IReadOnlyDictionary<TKey, TValue>>, CoercionValidationError[]> CoerceUnset()
			=> Result.Failure<Option<IReadOnlyDictionary<TKey, TValue>>, CoercionValidationError[]>(new[] { CoercionValidationErrors.UnsetValuesNotAllowed() });

		public override Result<Option<IReadOnlyDictionary<TKey, TValue>>, CoercionValidationError[]> CoerceNone()
			=> Result.Success<Option<IReadOnlyDictionary<TKey, TValue>>, CoercionValidationError[]>(Option.None<IReadOnlyDictionary<TKey, TValue>>());

		public Result<Option<IReadOnlyDictionary<TKey, TValue>>, CoercionValidationError[]> CoerceValue(IReadOnlyDictionary<TKey, Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Option<IReadOnlyDictionary<TKey, TValue>>, CoercionValidationError[]>(Option.Some(values))
				: Result.Failure<Option<IReadOnlyDictionary<TKey, TValue>>, CoercionValidationError[]>(nullIndices.Select(i => CoercionValidationErrors.NullValueAtKeyIsNotAllowed(i)).ToArray());

		public override Result<Unit, ValidationError[]> Validate(TModel model, Option<IReadOnlyDictionary<TKey, TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
