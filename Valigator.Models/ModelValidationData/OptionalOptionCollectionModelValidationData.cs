using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class OptionalOptionCollectionModelValidationData<TModel, TValue> : ModelValidationDataBase<TModel, Optional<IReadOnlyList<Option<TValue>>>>, IModelPropertyData<TModel, IReadOnlyList<Option<TValue>>, Optional<IReadOnlyList<Option<TValue>>>>, IRootModelValidationData<OptionalOptionCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<Option<TValue>>>
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

		public override Result<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]> CoerceUnset()
			=> Result.Success<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Optional.Unset<IReadOnlyList<Option<TValue>>>());

		public override Result<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]> CoerceNone()
			=> Result.Failure<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]>(new[] { ValidationErrors.NullValuesNotAllowed() });

		public Result<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> Result.Success<Optional<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Optional.Set(value));

		public override Result<Unit, ValidationError[]> Validate(TModel model, Optional<IReadOnlyList<Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
