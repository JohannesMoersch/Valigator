using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class DefaultedNullableCollectionModelValidationData<TModel, TValue> : IModelPropertyData<TModel,IReadOnlyList<Option<TValue>>, Option<IReadOnlyList<TValue>>>, IRootModelValidationData<DefaultedNullableCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<TValue>>
	{
		private readonly Option<IReadOnlyList<TValue>> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> _validationData;

		public DefaultedNullableCollectionModelValidationData(Option<IReadOnlyList<TValue>> defaultValue, ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new DefaultedNullableCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new DefaultedNullableCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new DefaultedNullableCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new DefaultedNullableCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<Option<IReadOnlyList<TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(_defaultValue);

		public Result<Option<IReadOnlyList<TValue>>, ValidationError[]> CoerceNone()
			=> Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(Option.None<IReadOnlyList<TValue>>());

		public Result<Option<IReadOnlyList<TValue>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<Option<IReadOnlyList<TValue>>, ValidationError[]>(Option.Some(values))
				: Result.Failure<Option<IReadOnlyList<TValue>>, ValidationError[]>(nullIndices.Select(i => ValidationErrors.NullValueAtIndexIsNotAllowed(i)).ToArray());

		public Result<Unit, ValidationError[]> Validate(TModel model, Option<IReadOnlyList<TValue>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}

		public static ModelDefinition<TModel>.Property<Option<IReadOnlyList<TValue>>> ToProperty(DefaultedNullableCollectionModelValidationData<TModel, TValue> data)
			=> new ModelDefinition<TModel>.Property<Option<IReadOnlyList<TValue>>>(data);

		public static implicit operator ModelDefinition<TModel>.Property<Option<IReadOnlyList<TValue>>>(DefaultedNullableCollectionModelValidationData<TModel, TValue> data)
			=> ToProperty(data);
	}
}
