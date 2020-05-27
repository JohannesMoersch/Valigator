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
	public struct NullableOptionalStateValidator<TValue> : IStateValidator<Option<TValue>, TValue>
	{
		private static IDataContainer<Option<TValue>> Instance { get; } = CreateContainer(new NullableOptionalStateValidator<TValue>());

		private static IDataContainer<Option<TValue>> CreateContainer(NullableOptionalStateValidator<TValue> stateValidator)
			=> new NullableDataContainer<NullableOptionalStateValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance);

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(Instance);

		public DataSourceStandard<NullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue>
			=> new DataSourceStandard<NullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, TValueValidator>(new NullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<NullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Func<TSource, Option<TValue>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<NullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Func<TSource, Result<Option<TValue>, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<NullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Func<TSource, Option<TValue>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<NullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Func<TSource, Result<Option<TValue>, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<NullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<NullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue>(new NullableDataContainerFactory<NullableOptionalStateValidator<TValue>, TSource, TValue>(this, mapping));

		IStateDescriptor IStateValidator<Option<TValue>, TValue>.GetDescriptor()
			=> new StateDescriptor(Option.None<object>());

		IValueDescriptor[] IStateValidator<Option<TValue>, TValue>.GetImplicitValueDescriptors()
			=> Array.Empty<IValueDescriptor>();

		Result<Option<TValue>, ValidationError[]> IStateValidator<Option<TValue>, TValue>.Validate(Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var isSet))
				return Result.Success<Option<TValue>, ValidationError[]>(isSet);

			return Result.Success<Option<TValue>, ValidationError[]>(Option.None<TValue>());
		}

		public static implicit operator Data<Option<TValue>>(NullableOptionalStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
