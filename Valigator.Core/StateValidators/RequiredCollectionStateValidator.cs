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
	public struct RequiredCollectionStateValidator<TValue> : ICollectionStateValidator<TValue[], TValue>
	{
		private static IDataContainer<TValue[]> CreateContainer(RequiredCollectionStateValidator<TValue> stateValidator)
			=> new CollectionDataContainer<RequiredCollectionStateValidator<TValue>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, DummyValidator<TValue[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance, DummyValidator<TValue[]>.Instance);

		public Data<TValue[]> Data => new Data<TValue[]>(CreateContainer(this));

		private readonly Data<TValue> _item;

		public RequiredCollectionStateValidator(Data<TValue> item) 
			=> _item = item;

		public NullableRequiredCollectionStateValidator<TValue> Nullable()
			=> new NullableRequiredCollectionStateValidator<TValue>(_item);

		public DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TValue, TValue>, TValue[], TValue[], TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue[]>
			=> new DataSourceStandard<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TValue, TValue>, TValue[], TValue[], TValueValidator>(new CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]> MappedFrom<TSource>(Func<TSource, TValue> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]> MappedFrom<TSource>(Func<TSource, TValue> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>, TValue[], TValue[]>(new CollectionDataContainerFactory<RequiredCollectionStateValidator<TValue>, TSource, TValue>(this, mapping));

		IStateDescriptor IStateValidator<TValue[], Option<TValue>[]>.GetDescriptor()
			=> new CollectionStateDescriptor(Option.None<object[]>(), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<TValue[], Option<TValue>[]>.GetImplicitValueDescriptors()
			=> new IValueDescriptor[] { new RequiredDescriptor(), new NotNullDescriptor() };

		Result<TValue[], ValidationError[]> IStateValidator<TValue[], Option<TValue>[]>.Validate(Option<Option<Option<TValue>[]>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
				{
					if (StateValidatorHelpers.ValidateCollectionNotNull(notNull).TryGetValue(out var success, out var failure))
						return Result.Success<TValue[], ValidationError[]>(success);

					return Result.Failure<TValue[], ValidationError[]>(failure);
				}

				return Result.Failure<TValue[], ValidationError[]>(new[] { ValidationErrors.NotNull() });
			}

			return Result.Failure<TValue[], ValidationError[]>(new[] { ValidationErrors.Required() });
		}

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, TValue[] value)
			=> StateValidatorHelpers.IsCollectionValid(_item, model, value);

		public static implicit operator Data<TValue[]>(RequiredCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
