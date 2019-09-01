using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.DataContainers;
using Valigator.Core.DataContainers.Factories;
using Valigator.Core.DataSources;
using Valigator.Core.Helpers;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct NullableRequiredCollectionStateValidator<TValue> : ICollectionStateValidator<Option<TValue[]>, TValue>
	{
		private static IDataContainer<Option<TValue[]>> CreateContainer(NullableRequiredCollectionStateValidator<TValue> stateValidator)
			=> new NullableCollectionDataContainer<NullableRequiredCollectionStateValidator<TValue>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance);

		public Data<Option<TValue[]>> Data => new Data<Option<TValue[]>>(CreateContainer(this));

		private readonly Data<TValue> _item;

		public NullableRequiredCollectionStateValidator(Data<TValue> item) 
			=> _item = item;

		public DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> new DataSourceStandard<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue[]>, TValue[], TValueValidator>(new NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> MappedFrom<TSource>(Func<TSource, TValue> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> MappedFrom<TSource>(Func<TSource, TValue> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue[]>, TValue[]>(new NullableCollectionDataContainerFactory<NullableRequiredCollectionStateValidator<TValue>, TSource, TValue>(this, mapping));

		IStateDescriptor IStateValidator<Option<TValue[]>, Option<TValue>[]>.GetDescriptor()
			=> new CollectionStateDescriptor(Option.None<object[]>(), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<Option<TValue[]>, Option<TValue>[]>.GetImplicitValueDescriptors()
			=> new IValueDescriptor[] { new RequiredDescriptor() };

		Result<Option<TValue[]>, ValidationError[]> IStateValidator<Option<TValue[]>, Option<TValue>[]>.Validate(Option<Option<Option<TValue>[]>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
				{
					if (StateValidatorHelpers.ValidateCollectionNotNull(notNull).TryGetValue(out var success, out var failure))
						return Result.Success<Option<TValue[]>, ValidationError[]>(Option.Some(success));

					return Result.Failure<Option<TValue[]>, ValidationError[]>(failure);
				}

				return Result.Success<Option<TValue[]>, ValidationError[]>(Option.None<TValue[]>());
			}

			return Result.Failure<Option<TValue[]>, ValidationError[]>(new[] { ValidationErrors.Required() });
		}

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Option<TValue[]> value)
			=> StateValidatorHelpers.IsCollectionValid(_item, model, value);

		public static implicit operator Data<Option<TValue[]>>(NullableRequiredCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
