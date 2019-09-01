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
	public struct OptionalStateValidator<TValue> : IStateValidator<Option<TValue>, TValue>
	{
		private static IDataContainer<Option<TValue>> Instance { get; } = CreateContainer(new OptionalStateValidator<TValue>());

		private static IDataContainer<Option<TValue>> CreateContainer(OptionalStateValidator<TValue> stateValidator)
			=> new NullableDataContainer<OptionalStateValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance);

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(Instance);

		public NullableOptionalStateValidator<TValue> Nullable()
			=> new NullableOptionalStateValidator<TValue>();

		public DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue>
			=> new DataSourceStandard<NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, TValueValidator>(new NullableDataContainerFactory<OptionalStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		public DataSource<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Func<TSource, TValue> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper)
			=> MappedFrom(Mapping.Create(mapper));

		public DataSource<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Func<TSource, TValue> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		public DataSource<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Func<TSource, Result<TValue, ValidationError[]>> mapper, Func<RequiredStateValidator<TSource>, Data<TSource>> sourceValidations)
			=> MappedFrom(Mapping.Create(mapper, sourceValidations));

		private DataSource<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue> MappedFrom<TSource>(Mapping<TSource, TValue> mapping)
			=> new DataSource<NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>, Option<TValue>, TValue>(new NullableDataContainerFactory<OptionalStateValidator<TValue>, TSource, TValue>(this, mapping));

		IStateDescriptor IStateValidator<Option<TValue>, TValue>.GetDescriptor()
			=> new StateDescriptor(Option.None<object>());

		IValueDescriptor[] IStateValidator<Option<TValue>, TValue>.GetImplicitValueDescriptors()
			=> new[] { new NotNullDescriptor() };

		Result<Option<TValue>, ValidationError[]> IStateValidator<Option<TValue>, TValue>.Validate(Option<Option<TValue>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
					return Result.Success<Option<TValue>, ValidationError[]>(Option.Some(notNull));

				return Result.Failure<Option<TValue>, ValidationError[]>(new[] { ValidationErrors.NotNull() });
			}

			return Result.Success<Option<TValue>, ValidationError[]>(Option.None<TValue>());
		}

		public static implicit operator Data<Option<TValue>>(OptionalStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
