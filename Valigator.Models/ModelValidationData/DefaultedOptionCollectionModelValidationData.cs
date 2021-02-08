using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class DefaultedOptionCollectionModelValidationData<TModel, TValue> : IModelPropertyData<TModel, IReadOnlyList<Option<TValue>>, IReadOnlyList<Option<TValue>>>, IRootModelValidationData<DefaultedOptionCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<Option<TValue>>>
	{
		private readonly IReadOnlyList<Option<TValue>> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> _validationData;

		public DefaultedOptionCollectionModelValidationData(IReadOnlyList<Option<TValue>> defaultValue, ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedOptionCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedOptionCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedOptionCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedOptionCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedOptionCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedOptionCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<IReadOnlyList<Option<TValue>>, ValidationError[]> CoerceUnset()
			=> Result.Success<IReadOnlyList<Option<TValue>>, ValidationError[]>(_defaultValue);

		public Result<IReadOnlyList<Option<TValue>>, ValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyList<Option<TValue>>, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<IReadOnlyList<Option<TValue>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> Result.Success<IReadOnlyList<Option<TValue>>, ValidationError[]>(value);

		public Result<Unit, ValidationError[]> Validate(TModel model, IReadOnlyList<Option<TValue>> value)
			=> _validationData.Process(ModelValue.Create(model, value));

		public static ModelDefinition<TModel>.Property<IReadOnlyList<Option<TValue>>> ToProperty(DefaultedOptionCollectionModelValidationData<TModel, TValue> data)
			=> new ModelDefinition<TModel>.Property<IReadOnlyList<Option<TValue>>>(data);

		public static implicit operator ModelDefinition<TModel>.Property<IReadOnlyList<Option<TValue>>>(DefaultedOptionCollectionModelValidationData<TModel, TValue> data)
			=> ToProperty(data);
	}
}
