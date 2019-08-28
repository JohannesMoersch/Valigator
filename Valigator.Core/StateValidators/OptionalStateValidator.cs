using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.DataContainers;
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

		IStateDescriptor IStateValidator<Option<TValue>, TValue>.GetDescriptor()
			=> new OptionalStateDescriptor(false);

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
