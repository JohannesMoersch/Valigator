using Functional;
using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator.Models.ValidationData
{
	public class OptionalNullableValueModelValidationData<TModel, TValue> : IValidationData<OptionalNullableValueModelValidationData<TModel, TValue>, TValue>, IInvertableValidationData<OptionalNullableValueModelValidationData<TModel, TValue>, TValue>, IModelValidationData<OptionalNullableValueModelValidationData<TModel, TValue>, TModel, TValue>, IInvertableModelValidationData<OptionalNullableValueModelValidationData<TModel, TValue>, TModel, TValue>
	{
		private readonly ValidationData<ModelValue<TModel, TValue>> _validationData;

		public OptionalNullableValueModelValidationData(ValidationData<ModelValue<TModel, TValue>> validationData)
			=> _validationData = validationData;

		public OptionalNullableValueModelValidationData<TModel, TValue> WithValidator(IValidator<TValue> value)
			=> new OptionalNullableValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalNullableValueModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<TValue> value)
			=> new OptionalNullableValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalNullableValueModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, TValue> value)
			=> new OptionalNullableValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public OptionalNullableValueModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, TValue> value)
			=> new OptionalNullableValueModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public Result<Optional<Option<TValue>>, ValidationError[]> Process(TModel model, Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var option))
			{
				if (option.TryGetValue(out var item))
				{
					if (_validationData.Process(ModelValue.Create(model, item)).TryGetValue(out var _, out var errors))
						return Result.Success<Optional<Option<TValue>>, ValidationError[]>(Optional.Set(Option.Some(item)));

					return Result.Failure<Optional<Option<TValue>>, ValidationError[]>(errors);
				}

				return Result.Success<Optional<Option<TValue>>, ValidationError[]>(Optional.Set(Option.None<TValue>()));
			}

			return Result.Success<Optional<Option<TValue>>, ValidationError[]>(Optional.Unset<Option<TValue>>());
		}
	}
}
