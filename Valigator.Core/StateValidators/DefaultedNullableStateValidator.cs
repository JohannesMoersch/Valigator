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
	public struct DefaultedNullableStateValidator<TValue> : IStateValidator<Option<TValue>, TValue>
	{
		private static IDataContainer<Option<TValue>> Instance { get; } = CreateContainer(new DefaultedNullableStateValidator<TValue>(Option.None<TValue>()));

		private static IDataContainer<Option<TValue>> CreateContainer(DefaultedNullableStateValidator<TValue> stateValidator)
			=> new NullableDataContainer<DefaultedNullableStateValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance);

		public Data<Option<TValue>> Data
		{
			get
			{
				if (_defaultValueFactory == null && !_defaultValue.TryGetValue(out var value))
					return new Data<Option<TValue>>(Instance);

				return new Data<Option<TValue>>(CreateContainer(this));
			}
		}

		private readonly Option<TValue> _defaultValue;

		private readonly Func<TValue> _defaultValueFactory;

		public DefaultedNullableStateValidator(TValue defaultValue)
		{
			_defaultValue = Option.Some(defaultValue != null ? defaultValue : throw new NullDefaultException());
			_defaultValueFactory = null;
		}

		public DefaultedNullableStateValidator(Func<TValue> defaultValueFactory)
		{
			_defaultValue = Option.None<TValue>();
			_defaultValueFactory = defaultValueFactory ?? throw new ArgumentNullException(nameof(defaultValueFactory));
		}

		private Option<TValue> GetDefaultValue()
			=> Option.Some(this.GetDefaultValue(_defaultValue, _defaultValueFactory));

		IStateDescriptor IStateValidator<Option<TValue>, TValue>.GetDescriptor()
			=> new DefaultedStateDescriptor(true, GetDefaultValue());

		IValueDescriptor[] IStateValidator<Option<TValue>, TValue>.GetImplicitValueDescriptors()
			=> Array.Empty<IValueDescriptor>();

		Result<Option<TValue>, ValidationError[]> IStateValidator<Option<TValue>, TValue>.Validate(Option<Option<TValue>> value)
		{
			if (value.TryGetValue(out var isSet))
				return Result.Success<Option<TValue>, ValidationError[]>(isSet);

			return Result.Success<Option<TValue>, ValidationError[]>(GetDefaultValue());
		}

		public static implicit operator Data<Option<TValue>>(DefaultedNullableStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
