using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation
{
	public class DataValidator<TStateValidator, TValueValidator, TValue> : IDataValidator<TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValueValidator : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;

		private readonly TValueValidator _valueValidator;

		public DataValidator(TStateValidator stateValidator, TValueValidator valueValidator)
		{
			_stateValidator = stateValidator;
			_valueValidator = valueValidator;
		}

		public Result<TValue, ValidationError> Validate(object model, bool isSet, TValue value)
			=> _stateValidator
				.Validate(model, isSet, value)
				.Match
				(
					success => _valueValidator
						.Validate(success)
						.Match
						(
							_ => Result.Success<TValue, ValidationError>(success), 
							Result.Failure<TValue, ValidationError>
						),
					Result.Failure<TValue, ValidationError>
				);
	}
}
