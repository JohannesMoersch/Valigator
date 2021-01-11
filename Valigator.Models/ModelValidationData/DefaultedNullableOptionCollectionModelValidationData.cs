using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class DefaultedNullableOptionCollectionModelValidationData<TModel, TValue> : IModelPropertyData<TModel, Optional<Option<IReadOnlyList<Option<TValue>>>>, Option<IReadOnlyList<Option<TValue>>>>, IRootModelValidationData<DefaultedNullableOptionCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<Option<TValue>>>
	{
		private readonly Option<IReadOnlyList<Option<TValue>>> _defaultValue;

		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> _validationData;

		public DefaultedNullableOptionCollectionModelValidationData(Option<IReadOnlyList<Option<TValue>>> defaultValue, ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedNullableOptionCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedNullableOptionCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedNullableOptionCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new DefaultedNullableOptionCollectionModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]> Coerce(Optional<Option<IReadOnlyList<Option<TValue>>>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
					return Result.Success<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Option.Some(item));

				return Result.Success<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Option.None<IReadOnlyList<Option<TValue>>>());
			}

			return Result.Failure<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(new[] { new ValidationError("Unset values not allowed.") });
		}

		public Result<Unit, ValidationError[]> Validate(TModel model, Option<IReadOnlyList<Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}
	}
}
