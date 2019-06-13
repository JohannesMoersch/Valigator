using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public class NullableDataValidator<TStateValidator, TValue> : IDataValidatorOrErrors<Option<TValue>>
		where TStateValidator : IStateValidator<Option<TValue>>
	{
		public DataDescriptor DataDescriptor => new DataDescriptor(typeof(TValue), _stateValidator.GetDescriptor(), _stateValidator.GetImplicitValueDescriptors());

		private readonly TStateValidator _stateValidator;

		public NullableDataValidator(TStateValidator stateValidator) 
			=> _stateValidator = stateValidator;

		public Result<Option<TValue>, ValidationError[]> Validate(object model, bool isSet, Option<TValue> value)
		{
			if (_stateValidator.Validate(model, isSet, value).TryGetValue(out var success, out var failure))
			{
				if (!success.TryGetValue(out var some))
					return Result.Success<Option<TValue>, ValidationError[]>(success);

				return Model<TValue>
					.Verify(some)
					.Select(_ => success);
			}

			return Result.Failure<Option<TValue>, ValidationError[]>(failure);
		}

		public Option<ValidationError[]> GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
