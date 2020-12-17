using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class OptionalValueModelValidationData<TModel, TValue> : IValidationData<OptionalValueModelValidationData<TModel, TValue>, TValue>, IInvertableValidationData<OptionalValueModelValidationData<TModel, TValue>, TValue>, IModelValidationData<OptionalValueModelValidationData<TModel, TValue>, TModel, TValue>, IInvertableModelValidationData<OptionalValueModelValidationData<TModel, TValue>, TModel, TValue>
	{
		private readonly ValidationData<ModelValue<TModel, TValue>> _validationData;

		public OptionalValueModelValidationData(ValidationData<ModelValue<TModel, TValue>> validationData)
			=> _validationData = validationData;

		public OptionalValueModelValidationData<TModel, TValue> WithValidator(IValidator<TValue> value)
			=> new OptionalValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalValueModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new OptionalValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalValueModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, TValue> value)
			=> new OptionalValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalValueModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> new OptionalValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public Result<Optional<TValue>, ValidationError[]> Process(TModel model, Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (_validationData.Process(ModelValue.Create(model, item)).TryGetValue(out var _, out var errors))
						return Result.Success<Optional<TValue>, ValidationError[]>(Optional.Set(item));

					return Result.Failure<Optional<TValue>, ValidationError[]>(errors);
				}

				return Result.Failure<Optional<TValue>, ValidationError[]>(new[] { new ValidationError("Null values not allowed.") });
			}

			return Result.Success<Optional<TValue>, ValidationError[]>(Optional.Unset<TValue>());
		}
	}
}
