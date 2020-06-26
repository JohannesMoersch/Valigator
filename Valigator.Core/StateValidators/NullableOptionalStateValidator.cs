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
	public struct NullableOptionalStateValidator<TValue> : IStateValidator<Optional<Option<TValue>>, TValue>
	{
		private static IDataContainer<Optional<Option<TValue>>> Instance { get; } = CreateContainer(new NullableOptionalStateValidator<TValue>());

		private static IDataContainer<Optional<Option<TValue>>> CreateContainer(NullableOptionalStateValidator<TValue> stateValidator)
			=> new OptionalNullableDataContainer<NullableOptionalStateValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance);

		public Data<Optional<Option<TValue>>> Data => new Data<Optional<Option<TValue>>>(Instance);

		public DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TValue, TValue>, Optional<Option<TValue>>, TValue, TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue>
			=> new DataSourceStandard<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TValue, TValue>, Optional<Option<TValue>>, TValue, TValueValidator>(new OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue> MappedFrom<TSource>(Func<TSource, Option<TValue>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue> MappedFrom<TSource>(Func<TSource, Result<Option<TValue>, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue> MappedFrom<TSource>(Func<TSource, Option<TValue>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue> MappedFrom<TSource>(Func<TSource, Result<Option<TValue>, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Optional<Option<TValue>>, TValue>(new OptionalNullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>(this, mapping));

		IStateDescriptor IStateValidator<Optional<Option<TValue>>, TValue>.GetDescriptor()
			=> new StateDescriptor(Option.None<object>());

		IValueDescriptor[] IStateValidator<Optional<Option<TValue>>, TValue>.GetImplicitValueDescriptors()
			=> Array.Empty<IValueDescriptor>();

		Result<Optional<Option<TValue>>, ValidationError[]> IStateValidator<Optional<Option<TValue>>, TValue>.Validate(Optional<Option<TValue>> value)
			=> Result.Success<Optional<Option<TValue>>, ValidationError[]>(value);

		public static implicit operator Data<Optional<Option<TValue>>>(NullableOptionalStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
