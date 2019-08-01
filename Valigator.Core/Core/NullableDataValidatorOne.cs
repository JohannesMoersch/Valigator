using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Functional;
using Valigator.Core.Helpers;
using Valigator.Core.ValueDescriptors;

namespace Valigator.Core
{
	public class NullableDataValidator<TStateValidator, TValueValidatorOne, TSource, TValue> : IDataValidatorOrErrors<Option<TSource>>
		where TStateValidator : IStateValidator<Option<TSource>>
		where TValueValidatorOne : IValueValidator<TValue>
	{
		public DataDescriptor DataDescriptor => new DataDescriptor(typeof(TValue), _stateValidator.GetDescriptor(), _stateValidator.GetImplicitValueDescriptors().Append(_valueValidatorOne.GetDescriptor()).ToArray());

		private readonly TStateValidator _stateValidator;

		private readonly TValueValidatorOne _valueValidatorOne;

		private readonly Mapping<TSource, TValue> _mapper;

		public NullableDataValidator(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, Mapping<TSource, TValue> mapper)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_mapper = mapper;
		}

		public Result<Option<TSource>, ValidationError[]> Validate(object model, bool isSet, Option<TSource> value)
		{
			if (_stateValidator.Validate(model, isSet, value).TryGetValue(out var success, out var failure))
			{
				if (!success.TryGetValue(out var some))
					return Result.Success<Option<TSource>, ValidationError[]>(success);

				return ValidatorHelpers.Validate(success, some, _valueValidatorOne, _mapper);
			}

			return Result.Failure<Option<TSource>, ValidationError[]>(failure);
		}

		public Option<ValidationError[]> GetErrors()
			=> Option.None<ValidationError[]>();
	}
}
