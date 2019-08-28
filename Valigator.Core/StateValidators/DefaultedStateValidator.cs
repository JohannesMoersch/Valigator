using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.DataContainers;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct DefaultedStateValidator<TValue> : IStateValidator<TValue, TValue>
	{
		private static IDataContainer<TValue> Instance { get; } = CreateContainer(new DefaultedStateValidator<TValue>(default(TValue)));

		private static IDataContainer<TValue> CreateContainer(DefaultedStateValidator<TValue> stateValidator)
			=> new DataContainer<DefaultedStateValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, DummyValidator<TValue>, TValue, TValue>(Mapping.CreatePassthrough<TValue>(), stateValidator, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance, DummyValidator<TValue>.Instance);

		public Data<TValue> Data
		{
			get
			{
				if (_defaultValueFactory == null && !_defaultValue.TryGetValue(out var value))
					return new Data<TValue>(Instance);

				return new Data<TValue>(CreateContainer(this));
			}
		}

		private readonly Option<TValue> _defaultValue;

		private readonly Func<TValue> _defaultValueFactory;

		public DefaultedStateValidator(TValue defaultValue)
		{
			_defaultValue = Option.Some(defaultValue != null ? defaultValue : throw new NullDefaultException());
			_defaultValueFactory = null;
		}

		public DefaultedStateValidator(Func<TValue> defaultValueFactory)
		{
			_defaultValue = Option.None<TValue>();
			_defaultValueFactory = defaultValueFactory;
		}

		public NullableDefaultedStateValidator<TValue> Nullable()
		{
			if (_defaultValueFactory != null)
				return new NullableDefaultedStateValidator<TValue>(_defaultValueFactory);

			if (_defaultValue.TryGetValue(out var some))
				return new NullableDefaultedStateValidator<TValue>(some);

			return new NullableDefaultedStateValidator<TValue>();
		}

		private TValue GetDefaultValue()
			=> this.GetDefaultValue(_defaultValue, _defaultValueFactory);

		IStateDescriptor IStateValidator<TValue, TValue>.GetDescriptor()
			=> new DefaultedStateDescriptor(false, GetDefaultValue());

		IValueDescriptor[] IStateValidator<TValue, TValue>.GetImplicitValueDescriptors()
			=> new[] { new NotNullDescriptor() };

		Result<TValue, ValidationError[]> IStateValidator<TValue, TValue>.Validate(Option<Option<TValue>> value)
		{
			if (value.TryGetValue(out var isSet))
			{
				if (isSet.TryGetValue(out var notNull))
					return Result.Success<TValue, ValidationError[]>(notNull);

				return Result.Failure<TValue, ValidationError[]>(new[] { ValidationErrors.NotNull() });
			}

			return Result.Success<TValue, ValidationError[]>(GetDefaultValue());
		}

		public static implicit operator Data<TValue>(DefaultedStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
