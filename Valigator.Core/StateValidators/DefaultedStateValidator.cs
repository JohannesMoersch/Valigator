using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct DefaultedStateValidator<TValue> : IStateValidator<TValue>
	{
		private static DataValidator<DefaultedStateValidator<TValue>, TValue> Instance { get; } = new DataValidator<DefaultedStateValidator<TValue>, TValue>(default);

		public Data<TValue> Data
		{
			get
			{
				if (_defaultValueFactory == null && !_defaultValue.TryGetValue(out var value))
					return new Data<TValue>(Instance);

				return new Data<TValue>(new DataValidator<DefaultedStateValidator<TValue>, TValue>(this));
			}
		}

		private readonly Option<TValue> _defaultValue;

		private readonly Func<TValue> _defaultValueFactory;

		public DefaultedStateValidator(TValue defaultValue)
		{
			_defaultValue = Option.Some(defaultValue != null ? defaultValue : throw new ArgumentNullException(nameof(defaultValue)));
			_defaultValueFactory = null;
		}

		public DefaultedStateValidator(Func<TValue> defaultValueFactory)
		{
			_defaultValue = Option.None<TValue>();
			_defaultValueFactory = defaultValueFactory;
		}

		public DefaultedNullableStateValidator<TValue> Nullable()
		{
			if (_defaultValueFactory != null)
				return new DefaultedNullableStateValidator<TValue>(_defaultValueFactory);

			if (_defaultValue.TryGetValue(out var value))
				return new DefaultedNullableStateValidator<TValue>(value);

			return new DefaultedNullableStateValidator<TValue>();
		}

		private TValue GetDefaultValue()
			=> _defaultValueFactory != null ? _defaultValueFactory.Invoke() : _defaultValue.Match(_ => _, () => default);

		IStateDescriptor IStateValidator<TValue>.GetDescriptor()
			=> new DefaultedStateDescriptor(false, GetDefaultValue());

		IValueDescriptor[] IStateValidator<TValue>.GetImplicitValueDescriptors()
			=> new[] { new NotNullDescriptor() };

		Result<TValue, ValidationError[]> IStateValidator<TValue>.Validate(object model, bool isSet, TValue value)
			=> !isSet || value != null
				? Result.Success<TValue, ValidationError[]>(isSet ? value : GetDefaultValue())
				: Result.Failure<TValue, ValidationError[]>(new[] { ValidationErrors.NotNull() });

		public static implicit operator Data<TValue>(DefaultedStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
