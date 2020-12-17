using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class DefaultedValueModelValidationData<TModel, TValue> : IValidationData<DefaultedValueModelValidationData<TModel, TValue>, TValue>, IInvertableValidationData<DefaultedValueModelValidationData<TModel, TValue>, TValue>, IModelValidationData<DefaultedValueModelValidationData<TModel, TValue>, TModel, TValue>, IInvertableModelValidationData<DefaultedValueModelValidationData<TModel, TValue>, TModel, TValue>
	{
		private readonly TValue _defaultValue;

		private readonly ValidationData<ModelValue<TModel, TValue>> _validationData;

		public DefaultedValueModelValidationData(TValue defaultValue, ValidationData<ModelValue<TModel, TValue>> validationData)
		{
			_defaultValue = defaultValue;
			_validationData = validationData;
		}

		public DefaultedValueModelValidationData<TModel, TValue> WithValidator(IValidator<TValue> value)
			=> new DefaultedValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedValueModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new DefaultedValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedValueModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, TValue> value)
			=> new DefaultedValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public DefaultedValueModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> new DefaultedValueModelValidationData<TModel, TValue>(_defaultValue, _validationData.WithValidator(value));

		public Result<TValue, ValidationError[]> Process(TModel model, Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (_validationData.Process(ModelValue.Create(model, item)).TryGetValue(out var _, out var errors))
						return Result.Success<TValue, ValidationError[]>(item);

					return Result.Failure<TValue, ValidationError[]>(errors);
				}

				return Result.Failure<TValue, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<TValue, ValidationError[]>(_defaultValue);
		}
	}
}
