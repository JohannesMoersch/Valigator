using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.StateDescriptors;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.StateValidators
{
	public struct RequiredStateValidator<TValue> : IStateValidator<TValue>
	{
		private static DataValidator<RequiredStateValidator<TValue>, TValue> Instance { get; } = new DataValidator<RequiredStateValidator<TValue>, TValue>(default);

		public Data<TValue> Data => new Data<TValue>(Instance);

		public RequiredNullableStateValidator<TValue> Nullable()
			=> new RequiredNullableStateValidator<TValue>();

		IStateDescriptor IStateValidator<TValue>.GetDescriptor()
			=> new RequiredStateDescriptor(false);

		Result<TValue, ValidationError[]> IStateValidator<TValue>.Validate(object model, bool isSet, TValue value)
			=> isSet
				? (value != null ? Result.Success<TValue, ValidationError[]>(value) : Result.Failure<TValue, ValidationError[]>(new[] { new ValidationError("") }))
				: Result.Failure<TValue, ValidationError[]>(new[] { new ValidationError("") });

		public static implicit operator Data<TValue>(RequiredStateValidator<TValue> stateValidator)
			=> stateValidator.Data;
	}
}
