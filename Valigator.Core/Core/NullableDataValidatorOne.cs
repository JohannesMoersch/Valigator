using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public class NullableDataValidator<TStateValidator, TValueValidatorOne, TValue> : IDataValidatorOrErrors<Option<TValue>>
		where TStateValidator : IStateValidator<Option<TValue>>
		where TValueValidatorOne : IValueValidator<TValue>
	{
		public DataDescriptor DataDescriptor => new DataDescriptor(typeof(TValue), _stateValidator.GetDescriptor(), _stateValidator.GetImplicitValueDescriptors().Append(_valueValidatorOne.GetDescriptor()).ToArray());

		private readonly TStateValidator _stateValidator;

		private readonly TValueValidatorOne _valueValidatorOne;

		public NullableDataValidator(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
		}

		public Result<Option<TValue>, ValidationError[]> Validate(object model, bool isSet, Option<TValue> value)
		{
			if (_stateValidator.Validate(model, isSet, value).TryGetValue(out var success, out var failure))
			{
				if (!success.TryGetValue(out var some))
					return Result.Success<Option<TValue>, ValidationError[]>(success);

				if (!_valueValidatorOne.IsValid(some))
					return Result.Failure<Option<TValue>, ValidationError[]>(new[] { _valueValidatorOne.GetError(some, false) });

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
