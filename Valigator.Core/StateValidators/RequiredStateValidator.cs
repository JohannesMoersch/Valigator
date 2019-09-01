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
	public struct RequiredStateValidator<TValue> : IStateValidator<TValue, TValue>
	{
		private static IDataContainer<TValue> Instance { get; } = CreateContainer(new RequiredStateValidator<TValue>());

		private static IDataContainer<TValue> CreateContainer(RequiredStateValidator<TValue> stateValidator)
			=> new DataContainer<RequiredStateValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance);

		public Data<TValue> Data => new Data<TValue>(Instance);

		public NullableRequiredStateValidator<TValue> Nullable()
			=> new NullableRequiredStateValidator<TValue>();

		public DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TValue, TValue>, TValue, TValue, TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue>
			=> new DataSourceStandard<DataContainerFactory<RequiredStateValidator<TValue>, TValue, TValue>, TValue, TValue, TValueValidator>(new DataContainerFactory<RequiredStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		IStateDescriptor IStateValidator<TValue, TValue>.GetDescriptor()
			=> new StateDescriptor(Option.None<object>());

		IValueDescriptor[] IStateValidator<TValue, TValue>.GetImplicitValueDescriptors()
			=> new IValueDescriptor[] { new RequiredDescriptor(), new NotNullDescriptor() };

		Result<TValue, ValidationError[]> IStateValidator<TValue, TValue>.Validate(Option<Option<TValue>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
					return Result.Success<TValue, ValidationError[]>(notNull);

				return Result.Failure<TValue, ValidationError[]>(new[] { ValidationErrors.NotNull() });
			}

			return Result.Failure<TValue, ValidationError[]>(new[] { ValidationErrors.Required() });
		}

		public static implicit operator Data<TValue>(RequiredStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
