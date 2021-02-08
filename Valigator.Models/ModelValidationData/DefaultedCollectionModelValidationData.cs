using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class DefaultedCollectionModelValidationData<TModel, TValue> : IModelPropertyData<TModel, IReadOnlyList<Option<TValue>>, IReadOnlyList<TValue>>, IRootModelValidationData<DefaultedCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<TValue>>
	{
		private readonly IReadOnlyList<TValue> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> _validationData;

		public DefaultedCollectionModelValidationData(IReadOnlyList<TValue> defaultValue, ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<TValue>> value)
			=> new DefaultedCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<TValue>> value)
			=> new DefaultedCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new DefaultedCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<TValue>> value)
			=> new DefaultedCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<IReadOnlyList<TValue>, ValidationError[]> CoerceUnset()
			=> Result.Success<IReadOnlyList<TValue>, ValidationError[]>(_defaultValue);

		public Result<IReadOnlyList<TValue>, ValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyList<TValue>, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<IReadOnlyList<TValue>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<IReadOnlyList<TValue>, ValidationError[]>(values)
				: Result.Failure<IReadOnlyList<TValue>, ValidationError[]>(nullIndices.Select(i => ValidationErrors.NullValueAtIndexIsNotAllowed(i)).ToArray());

		public Result<Unit, ValidationError[]> Validate(TModel model, IReadOnlyList<TValue> value)
			=> _validationData.Process(ModelValue.Create(model, value));

		public static ModelDefinition<TModel>.Property<IReadOnlyList<TValue>> ToProperty(DefaultedCollectionModelValidationData<TModel, TValue> data)
			=> new ModelDefinition<TModel>.Property<IReadOnlyList<TValue>>(data);

		public static implicit operator ModelDefinition<TModel>.Property<IReadOnlyList<TValue>>(DefaultedCollectionModelValidationData<TModel, TValue> data)
			=> ToProperty(data);
	}
}
