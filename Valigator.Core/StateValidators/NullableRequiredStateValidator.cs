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
	public struct NullableRequiredStateValidator<TValue> : IStateValidator<Option<TValue>, TValue>
	{
		private static IDataContainer<Option<TValue>> Instance { get; } = CreateContainer(new NullableRequiredStateValidator<TValue>());

		private static IDataContainer<Option<TValue>> CreateContainer(NullableRequiredStateValidator<TValue> stateValidator)
			=> new NullableDataContainer<NullableRequiredStateValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance);

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(Instance);

		public DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, TValueValidator> Add<TValueValidator>(TValueValidator valueValidator)
			where TValueValidator : struct, IValueValidator<TValue>
			=> new DataSourceStandard<NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>, Option<TValue>, TValue, TValueValidator>(new NullableDataContainerFactory<NullableRequiredStateValidator<TValue>, TValue, TValue>(this, Mapping.CreatePassthrough<TValue>()), valueValidator);

		IStateDescriptor IStateValidator<Option<TValue>, TValue>.GetDescriptor()
			=> new StateDescriptor(Option.None<object>());

		IValueDescriptor[] IStateValidator<Option<TValue>, TValue>.GetImplicitValueDescriptors()
			=> new IValueDescriptor[] { new RequiredDescriptor() };

		Result<Option<TValue>, ValidationError[]> IStateValidator<Option<TValue>, TValue>.Validate(Option<Option<TValue>> value)
		{
			if (value.TryGetValue(out var isSet))
				return Result.Success<Option<TValue>, ValidationError[]>(isSet);

			return Result.Failure<Option<TValue>, ValidationError[]>(new[] { ValidationErrors.Required() });
		}

		public static implicit operator Data<Option<TValue>>(NullableRequiredStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
