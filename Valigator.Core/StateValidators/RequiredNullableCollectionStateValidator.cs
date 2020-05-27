using System;
using System.Collections.Generic;
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
	public struct RequiredNullableCollectionStateValidator<TValue> : ICollectionStateValidator<Option<TValue>[], TValue>
	{
		private static IDataContainer<Option<TValue>[]> CreateContainer(RequiredNullableCollectionStateValidator<TValue> stateValidator)
			=> new CollectionNullableDataContainer<RequiredNullableCollectionStateValidator<TValue>, DummyValidator<Option<TValue>[]>, DummyValidator<Option<TValue>[]>, DummyValidator<Option<TValue>[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<Option<TValue>[]>.Instance, DummyValidator<Option<TValue>[]>.Instance, DummyValidator<Option<TValue>[]>.Instance);

		public Data<Option<TValue>[]> Data => new Data<Option<TValue>[]>(CreateContainer(this));

		private readonly Data<Option<TValue>> _item;

		public RequiredNullableCollectionStateValidator(Data<Option<TValue>> item)
			=> _item = item;

		public NullableRequiredNullableCollectionStateValidator<TValue> Nullable()
			=> new NullableRequiredNullableCollectionStateValidator<TValue>(_item);

		public DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[], TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> new DataSourceStandard<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TValue, TValue>, Option<TValue>[], Option<TValue>[], TValueValidator>(new CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Option<TValue>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Result<Option<TValue>, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Option<TValue>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Result<Option<TValue>, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[]> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>, Option<TValue>[], Option<TValue>[]>(new CollectionNullableDataContainerFactory<RequiredNullableCollectionStateValidator<TValue>, TSource, TValue>(this, mapping));

		IStateDescriptor IStateValidator<Option<TValue>[], Option<TValue>[]>.GetDescriptor()
			=> new CollectionStateDescriptor(Option.None<object[]>(), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<Option<TValue>[], Option<TValue>[]>.GetImplicitValueDescriptors()
			=> new IValueDescriptor[] { new RequiredDescriptor(), new NotNullDescriptor() };

		Result<Option<TValue>[], ValidationError[]> IStateValidator<Option<TValue>[], Option<TValue>[]>.Validate(Optional<Option<Option<TValue>[]>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
					return Result.Success<Option<TValue>[], ValidationError[]>(notNull);

				return Result.Failure<Option<TValue>[], ValidationError[]>(new[] { ValidationErrors.NotNull() });
			}

			return Result.Failure<Option<TValue>[], ValidationError[]>(new[] { ValidationErrors.Required() });
		}

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Option<TValue>[] value)
			=> StateValidatorHelpers.IsCollectionValid(_item, model, value);

		public static implicit operator Data<Option<TValue>[]>(RequiredNullableCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
