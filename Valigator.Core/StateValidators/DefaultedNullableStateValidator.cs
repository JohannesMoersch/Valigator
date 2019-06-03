using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct DefaultedNullableStateValidator<TValue> : IStateValidator<Option<TValue>>
	{
		private static DataValidator<DefaultedNullableStateValidator<TValue>, Option<TValue>> Instance { get; } = new DataValidator<DefaultedNullableStateValidator<TValue>, Option<TValue>>(default);

		public Data<Option<TValue>> Data
		{
			get
			{
				if (_defaultValueFactory == null && !_defaultValue.TryGetValue(out var value))
					return new Data<Option<TValue>>(Instance);

				return new Data<Option<TValue>>(new DataValidator<DefaultedNullableStateValidator<TValue>, Option<TValue>>(this));
			}
		}

		private readonly Option<TValue> _defaultValue;

		private readonly Func<TValue> _defaultValueFactory;

		public DefaultedNullableStateValidator(TValue defaultValue)
		{
			_defaultValue = Option.Some(defaultValue != null ? defaultValue : throw new ArgumentNullException(nameof(defaultValue)));
			_defaultValueFactory = null;
		}

		public DefaultedNullableStateValidator(Func<TValue> defaultValueFactory)
		{
			_defaultValue = Option.None<TValue>();
			_defaultValueFactory = defaultValueFactory ?? throw new ArgumentNullException(nameof(defaultValueFactory));
		}

		private TValue GetDefaultValue()
			=> _defaultValueFactory != null ? _defaultValueFactory.Invoke() : _defaultValue.Match(_ => _, () => default);

		IStateDescriptor IStateValidator<Option<TValue>>.GetDescriptor()
			=> new DefaultedStateDescriptor(true, GetDefaultValue());

		Result<Option<TValue>, ValidationError[]> IStateValidator<Option<TValue>>.Validate(object model, bool isSet, Option<TValue> value)
			=> Result.Success<Option<TValue>, ValidationError[]>(isSet ? value : Option.Some(GetDefaultValue()));

		public static implicit operator Data<Option<TValue>>(DefaultedNullableStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
