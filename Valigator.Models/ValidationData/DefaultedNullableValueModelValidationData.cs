using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class DefaultedNullableValueModelValidationData<TModel, TValue> : IValidationData<DefaultedNullableValueModelValidationData<TModel, TValue>, TValue>, IInvertableValidationData<DefaultedNullableValueModelValidationData<TModel, TValue>, TValue>, IModelValidationData<DefaultedNullableValueModelValidationData<TModel, TValue>, TModel, TValue>, IInvertableModelValidationData<DefaultedNullableValueModelValidationData<TModel, TValue>, TModel, TValue>
	{
		private readonly TValue _defaultValue;

		private readonly ValidationData<ModelValue<TModel, TValue>> _validationData;

		public DefaultedNullableValueModelValidationData(TValue defaultValue, ValidationData<ModelValue<TModel, TValue>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedNullableValueModelValidationData<TModel, TValue> WithValidator(IValidator<TValue> value)
			=> new DefaultedNullableValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableValueModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new DefaultedNullableValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableValueModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, TValue> value)
			=> new DefaultedNullableValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedNullableValueModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> new DefaultedNullableValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<Option<TValue>, ValidationError[]> Process(TModel model, Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (_validationData.Process(ModelValue.Create(model, item)).TryGetValue(out var _, out var errors))
						return Result.Success<Option<TValue>, ValidationError[]>(Option.Some(item));

					return Result.Failure<Option<TValue>, ValidationError[]>(errors);
				}

				return Result.Success<Option<TValue>, ValidationError[]>(Option.None<TValue>());
			}

			return Result.Success<Option<TValue>, ValidationError[]>(Option.Some(_defaultValue));
		}
	}
}
