using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct DefaultedStateValidator<TValue> : IStateValidator<TValue>
	{
		private static DataValidator<DefaultedStateValidator<TValue>, PassthroughValidator<TValue>, TValue> Instance { get; } = new DataValidator<DefaultedStateValidator<TValue>, PassthroughValidator<TValue>, TValue>(default, default);

		public Data<TValue> Data
		{
			get
			{
				var instance = this;

				var validator = _defaultValue
					.Match
					(
						value => new DataValidator<DefaultedStateValidator<TValue>, PassthroughValidator<TValue>, TValue>(instance, default),
						() => Instance
					);

				return new Data<TValue>(validator);
			}
		}

		private readonly Option<TValue> _defaultValue;

		public DefaultedStateValidator(TValue defaultValue)
			=> _defaultValue = Option.Some(defaultValue != null ? defaultValue : throw new ArgumentNullException(nameof(defaultValue)));

		public DefaultedNullableStateValidator<TValue> Nullable()
			=> _defaultValue
				.Match
				(
					value => new DefaultedNullableStateValidator<TValue>(value),
					() => new DefaultedNullableStateValidator<TValue>()
				);

		IStateDescriptor IStateValidator<TValue>.GetDescriptor()
			=> new DefaultedStateDescriptor(false, _defaultValue.Match(_ => _, () => default));

		Result<TValue, ValidationError> IStateValidator<TValue>.Validate(object model, bool isSet, TValue value)
			=> !isSet || value != null
				? Result.Success<TValue, ValidationError>(isSet ? value : _defaultValue.Match(_ => _, () => default))
				: Result.Failure<TValue, ValidationError>(new ValidationError("Value cannot be null."));

		public static implicit operator Data<TValue>(DefaultedStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
