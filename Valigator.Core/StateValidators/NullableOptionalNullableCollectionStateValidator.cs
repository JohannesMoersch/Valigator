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
	public struct NullableOptionalNullableCollectionStateValidator<TValue> : ICollectionStateValidator<Optional<Option<Option<TValue>[]>>, TValue>
	{
		private static IDataContainer<Optional<Option<Option<TValue>[]>>> CreateContainer(NullableOptionalNullableCollectionStateValidator<TValue> stateValidator)
			=> new OptionalNullableCollectionNullableDataContainer<NullableOptionalNullableCollectionStateValidator<TValue>, DummyValidator<Option<TValue>[]>, DummyValidator<Option<TValue>[]>, DummyValidator<Option<TValue>[]>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<Option<TValue>[]>.Instance, DummyValidator<Option<TValue>[]>.Instance, DummyValidator<Option<TValue>[]>.Instance);

		public Data<Optional<Option<Option<TValue>[]>>> Data => new Data<Optional<Option<Option<TValue>[]>>>(CreateContainer(this));

		private readonly Data<Option<TValue>> _item;

		public NullableOptionalNullableCollectionStateValidator(Data<Option<TValue>> item)
			=> _item = item;

		public DataSourceStandard<OptionalNullableCollectionNullableDataContainerFactory<NullableOptionalNullableCollectionStateValidator<TValue>, TValue, TValue>, Optional<Option<Option<TValue>[]>>, Option<TValue>[], TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<Option<TValue>[]>
			=> new DataSourceStandard<OptionalNullableCollectionNullableDataContainerFactory<NullableOptionalNullableCollectionStateValidator<TValue>, TValue, TValue>, Optional<Option<Option<TValue>[]>>, Option<TValue>[], TValueValidator>(new OptionalNullableCollectionNullableDataContainerFactory<NullableOptionalNullableCollectionStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<OptionalNullableCollectionNullableDataContainerFactory<NullableOptionalNullableCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<Option<TValue>[]>>, Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Option<TValue>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<OptionalNullableCollectionNullableDataContainerFactory<NullableOptionalNullableCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<Option<TValue>[]>>, Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Result<Option<TValue>, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<OptionalNullableCollectionNullableDataContainerFactory<NullableOptionalNullableCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<Option<TValue>[]>>, Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Option<TValue>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<OptionalNullableCollectionNullableDataContainerFactory<NullableOptionalNullableCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<Option<TValue>[]>>, Option<TValue>[]> MappedFrom<TSource>(Func<TSource, Result<Option<TValue>, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<OptionalNullableCollectionNullableDataContainerFactory<NullableOptionalNullableCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<Option<TValue>[]>>, Option<TValue>[]> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<OptionalNullableCollectionNullableDataContainerFactory<NullableOptionalNullableCollectionStateValidator<TValue>, TSource, TValue>, Optional<Option<Option<TValue>[]>>, Option<TValue>[]>(new OptionalNullableCollectionNullableDataContainerFactory<NullableOptionalNullableCollectionStateValidator<TValue>, TSource, TValue>(this, mapping));

		IStateDescriptor IStateValidator<Optional<Option<Option<TValue>[]>>, Option<TValue>[]>.GetDescriptor()
			=> new CollectionStateDescriptor(Option.None<object[]>(), _item.DataDescriptor);

		IValueDescriptor[] IStateValidator<Optional<Option<Option<TValue>[]>>, Option<TValue>[]>.GetImplicitValueDescriptors()
			=> Array.Empty<IValueDescriptor>();

		Result<Optional<Option<Option<TValue>[]>>, ValidationError[]> IStateValidator<Optional<Option<Option<TValue>[]>>, Option<TValue>[]>.Validate(Optional<Option<Option<TValue>[]>> value)
			=> Result.Success<Optional<Option<Option<TValue>[]>>, ValidationError[]>(value);

		public Result<Unit, ValidationError[]> IsValid(Option<object> model, Optional<Option<Option<TValue>[]>> value)
			=> StateValidatorHelpers.IsCollectionValid(_item, model, value);

		public Result<Optional<Option<Option<TValue>[]>>, ValidationError[]> Validate() => throw new NotImplementedException();

		public static implicit operator Data<Optional<Option<Option<TValue>[]>>>(NullableOptionalNullableCollectionStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
