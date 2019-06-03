using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct OptionalNullableStateValidator<TValue> : IStateValidator<Option<TValue>>
	{
		private static DataValidator<OptionalNullableStateValidator<TValue>, Option<TValue>> Instance { get; } = new DataValidator<OptionalNullableStateValidator<TValue>, Option<TValue>>(default);

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(Instance);

		IStateDescriptor IStateValidator<Option<TValue>>.GetDescriptor()
			=> new OptionalStateDescriptor(true);

		Result<Option<TValue>, ValidationError[]> IStateValidator<Option<TValue>>.Validate(object model, bool isSet, Option<TValue> value)
			=> Result.Success<Option<TValue>, ValidationError[]>(value);

		public static implicit operator Data<Option<TValue>>(OptionalNullableStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
