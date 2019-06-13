using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public class DataValidator<TStateValidator, TValue> : IDataValidatorOrErrors<TValue>
		where TStateValidator : IStateValidator<TValue>
	{
		public DataDescriptor DataDescriptor => new DataDescriptor(typeof(TValue), _stateValidator.GetDescriptor(), _stateValidator.GetImplicitValueDescriptors());

		private readonly TStateValidator _stateValidator;

		public DataValidator(TStateValidator stateValidator) 
			=> _stateValidator = stateValidator;

		public Result<TValue, ValidationError[]> Validate(object model, bool isSet, TValue value)
		{
			if (_stateValidator.Validate(model, isSet, value).TryGetValue(out var success, out var failure))
			{
				return Model<TValue>
					.Verify(success)
					.Select(_ => success);
			}

			return Result.Failure<TValue, ValidationError[]>(failure);
		}

		public Option<ValidationError[]> GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
