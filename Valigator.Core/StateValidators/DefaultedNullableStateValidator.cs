using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Descriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct DefaultedNullableStateValidator<TValue> : IStateValidator<Option<TValue>>
	{
		private static DataValidator<DefaultedNullableStateValidator<TValue>, PassthroughValidator<Option<TValue>>, Option<TValue>> Instance { get; } = new DataValidator<DefaultedNullableStateValidator<TValue>, PassthroughValidator<Option<TValue>>, Option<TValue>>(default, default);

		public Data<Option<TValue>> Data
		{
			get
			{
				var instance = this;

				var validator = _defaultValue
					.Match
					(
						value => new DataValidator<DefaultedNullableStateValidator<TValue>, PassthroughValidator<Option<TValue>>, Option<TValue>>(instance, default),
						() => Instance
					);

				return new Data<Option<TValue>>(validator);
			}
		}

		private readonly Option<TValue> _defaultValue;

		public DefaultedNullableStateValidator(TValue defaultValue) 
			=> _defaultValue = Option.Some(defaultValue != null ? defaultValue : throw new ArgumentNullException(nameof(defaultValue)));

		IStateDescriptor IStateValidator<Option<TValue>>.GetDescriptor()
			=> new DefaultedStateDescriptor(true, _defaultValue.Match(_ => _, () => default));

		Result<Option<TValue>, ValidationError[]> IStateValidator<Option<TValue>>.Validate(object model, bool isSet, Option<TValue> value)
			=> Result.Success<Option<TValue>, ValidationError[]>(isSet ? value : _defaultValue);

		public static implicit operator Data<Option<TValue>>(DefaultedNullableStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
