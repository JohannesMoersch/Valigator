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
	public struct OptionalStateValidator<TValue> : IStateValidator<Optional<TValue>, TValue>
	{
		private static IDataContainer<Optional<TValue>> Instance { get; } = CreateContainer(new OptionalStateValidator<TValue>());

		private static IDataContainer<Optional<TValue>> CreateContainer(OptionalStateValidator<TValue> stateValidator)
			=> new OptionalDataContainer<OptionalStateValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance);

		public Data<Optional<TValue>> Data => new Data<Optional<TValue>>(Instance);

		public NullableOptionalStateValidator<TValue> Nullable()
			=> new NullableOptionalStateValidator<TValue>();

		public DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Optional<TValue>, TValue, TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue>
			=> new DataSourceStandard<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Optional<TValue>, TValue, TValueValidator>(new OptionalDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue> MappedFrom<TSource>(Func<TSource, TValue> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue> MappedFrom<TSource>(Func<TSource, TValue> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Optional<TValue>, TValue>(new OptionalDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>(this, mapping));

		IStateDescriptor IStateValidator<Optional<TValue>, TValue>.GetDescriptor()
			=> new StateDescriptor(Option.None<object>());

		IValueDescriptor[] IStateValidator<Optional<TValue>, TValue>.GetImplicitValueDescriptors()
			=> new[] { new NotNullDescriptor() };

		Result<Optional<TValue>, ValidationError[]> IStateValidator<Optional<TValue>, TValue>.Validate(Optional<Option<TValue>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
					return Result.Success<Optional<TValue>, ValidationError[]>(Optional.Set(notNull));

				return Result.Failure<Optional<TValue>, ValidationError[]>(new[] { ValidationErrors.NotNull() });
			}

			return Result.Success<Optional<TValue>, ValidationError[]>(Optional.Unset<TValue>());
		}

		public static implicit operator Data<Optional<TValue>>(OptionalStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
