using Functional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Valigator.Core;

namespace Valigator.ModelValidationData
{
	public class RequiredNullableOptionCollectionModelValidationData<TModel, TValue> : IModelPropertyData<TModel, IReadOnlyList<Option<TValue>>, Option<IReadOnlyList<Option<TValue>>>>, IRootModelValidationData<RequiredNullableOptionCollectionModelValidationData<TModel, TValue>, TModel, IReadOnlyList<Option<TValue>>>
	{
		private readonly ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> _validationData;

		public RequiredNullableOptionCollectionModelValidationData(ValidationData<ModelValue<TModel, IReadOnlyList<Option<TValue>>>> validationData)
			=> _validationData = validationData;

		public RequiredNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IValidator<IReadOnlyList<Option<TValue>>> value)
			=> new RequiredNullableOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableValidator<IReadOnlyList<Option<TValue>>> value)
			=> new RequiredNullableOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new RequiredNullableOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public RequiredNullableOptionCollectionModelValidationData<TModel, TValue> WithValidator(IInvertableModelValidator<TModel, IReadOnlyList<Option<TValue>>> value)
			=> new RequiredNullableOptionCollectionModelValidationData<TModel, TValue>(_validationData.WithValidator(value));

		public Result<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]> CoerceUnset()
			=> Result.Failure<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(new[] { ValidationErrors.UnsetValuesNotAllowed() });

		public Result<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]> CoerceNone()
			=> Result.Success<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Option.None<IReadOnlyList<Option<TValue>>>());

		public Result<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]> CoerceValue(IReadOnlyList<Option<TValue>> value)
			=> Result.Success<Option<IReadOnlyList<Option<TValue>>>, ValidationError[]>(Option.Some(value));

		public Result<Unit, ValidationError[]> Validate(TModel model, Option<IReadOnlyList<Option<TValue>>> value)
		{
			if (value.TryGetValue(out var item))
				return _validationData.Process(ModelValue.Create(model, item));

			return Result.Unit<ValidationError[]>();
		}

		public static ModelDefinition<TModel>.Property<Option<IReadOnlyList<Option<TValue>>>> ToProperty(RequiredNullableOptionCollectionModelValidationData<TModel, TValue> data)
			=> new ModelDefinition<TModel>.Property<Option<IReadOnlyList<Option<TValue>>>>(data);

		public static implicit operator ModelDefinition<TModel>.Property<Option<IReadOnlyList<Option<TValue>>>>(RequiredNullableOptionCollectionModelValidationData<TModel, TValue> data)
			=> ToProperty(data);
	}
}
