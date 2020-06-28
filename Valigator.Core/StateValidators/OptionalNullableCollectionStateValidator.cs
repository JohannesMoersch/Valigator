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
	public struct OptionalNullableCollectionStateValidator<TValue> : ICollectionStateValidator<Optional<Option<TValue>[]>, TValue>
	{
		private static IDataContainer<Optional<Option<TValue>[]>> CreateContainer(OptionalNullableCollectionStateValidator<TValue> stateValidator)
			=> new OptionalCollectionNullableDataContainer<OptionalNullableCollectionStateValidator<TValue>, DummyValidator<Option<TValue>[]>, DummyValidator<Option<TValue>[]>, DummyValidator<Option<TValue>[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<Option<TValue>[]>.Instance, DummyValidator<Option<TValue>[]>.Instance, DummyValidator<Option<TValue>[]>.Instance);

		public Data<Optional<Option<TValue>[]>> Data => new Data<Optional<Option<TValue>[]>>(CreateContainer(this));

		private readonly Data<Option<TValue>> _item;

		public OptionalNullableCollectionStateValidator(Data<Option<TValue>> item)
			=> _item = item;

		public NullableOptionalNullableCollectionStateValidator<TValue> Nullable()
			=> new NullableOptionalNullableCollectionStateValidator<TValue>(_item);

		public DataSourceStandard<OptionalCollectionNullableDataContainerFactory<OptionalNullableCollectionStateValidator<TValue>, TValue, TValue>, Optional<Option<TValue>[]>, Option<TValue>[], TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> new DataSourceStandard<OptionalCollectionNullableDataContainerFactory<OptionalNullableCollectionStateValidator<TValue>, TValue, TValue>, Optional<Option<TValue>[]>, Option<TValue>[], TValueValidator>(new OptionalCollectionNullableDataContainerFactory<OptionalNullableCollectionStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<OptionalCollectionNullableDataContainerFactory<OptionalNullableCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>[]>, Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Option<TValue>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<OptionalCollectionNullableDataContainerFactory<OptionalNullableCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>[]>, Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Result<Option<TValue>, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<OptionalCollectionNullableDataContainerFactory<OptionalNullableCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>[]>, Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Option<TValue>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<OptionalCollectionNullableDataContainerFactory<OptionalNullableCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>[]>, Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Result<Option<TValue>, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<OptionalCollectionNullableDataContainerFactory<OptionalNullableCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>[]>, Option<TValue>[]> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<OptionalCollectionNullableDataContainerFactory<OptionalNullableCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>[]>, Option<TValue>[]>(new OptionalCollectionNullableDataContainerFactory<OptionalNullableCollectionStateValidator<TValue>, TSource, TValue>(this, mapping));

		IStateDescriptor IStateValidator<Optional<Option<TValue>[]>, Option<TValue>[]>.GetDescriptor()
			=> new CollectionStateDescriptor(Option.None<object[]>(), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<Optional<Option<TValue>[]>, Option<TValue>[]>.GetImplicitValueDescriptors()
			=> new[] { new NotNullDescriptor() };

		Result<Optional<Option<TValue>[]>, ValidationError[]> IStateValidator<Optional<Option<TValue>[]>, Option<TValue>[]>.Validate(Optional<Option<Option<TValue>[]>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
					return Result.Success<Optional<Option<TValue>[]>, ValidationError[]>(Optional.Set(notNull));

				return Result.Failure<Optional<Option<TValue>[]>, ValidationError[]>(new[] { ValidationErrors.NotNull() });
			}

			return Result.Success<Optional<Option<TValue>[]>, ValidationError[]>(Optional.Unset<Option<TValue>[]>());
		}

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Optional<Option<TValue>[]> value)
			=> StateValidatorHelpers.IsCollectionValid(_item, model, value);

		public Result<Optional<Option<TValue>[]>, ValidationError[]> Validate() => throw new NotImplementedException();

		public static implicit operator Data<Optional<Option<TValue>[]>>(OptionalNullableCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
