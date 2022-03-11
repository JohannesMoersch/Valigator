using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class DefaultedCollectionModelValidationData<TModel, TValue> : ModelValidationDataBase<TModel, IReadOnlyList<TValue>>, IModelPropertyData<TModel, IReadOnlyList<Option<TValue>>, IReadOnlyList<TValue>>, IRootModelValidationData<DefaultedCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<TValue>>
	{
		private readonly Func<IReadOnlyList<TValue>> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> _validationData;

		public DefaultedCollectionModelValidationData(Func<IReadOnlyList<TValue>> defaultValue, ValidationData<ModelValue<TModel, IReadOnlyList<TValue>>> validationData)
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

		public override Result<IReadOnlyList<TValue>, CoercionValidationError[]> CoerceUnset()
			=> Result.Success<IReadOnlyList<TValue>, CoercionValidationError[]>(_defaultValue.Invoke());

		public override Result<IReadOnlyList<TValue>, CoercionValidationError[]> CoerceNone()
			=> Result.Failure<IReadOnlyList<TValue>, CoercionValidationError[]>(new[] { CoercionValidationErrors.NullValuesNotAllowed() });

		public Result<IReadOnlyList<TValue>, CoercionValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> value.GetValuesOrNullIndices().TryGetValue(out var values, out var nullIndices)
				? Result.Success<IReadOnlyList<TValue>, CoercionValidationError[]>(values)
				: Result.Failure<IReadOnlyList<TValue>, CoercionValidationError[]>(nullIndices.Select(i => CoercionValidationErrors.NullValueAtIndexIsNotAllowed(i)).ToArray());

		public override Result<Unit, ValidationError[]> Validate(TModel model, IReadOnlyList<TValue> value)
			=> _validationData.Process(ModelValue.Create(model, value));
	}
}
