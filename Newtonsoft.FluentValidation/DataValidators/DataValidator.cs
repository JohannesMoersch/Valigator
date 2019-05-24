﻿using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Newtonsoft.FluentValidation.DataValidators
{
	public class DataValidator<TStateValidator, TValueValidator, TValue> : IDataValidator<TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValueValidator : IStateValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;

		private readonly TValueValidator _valueValidator;

		public DataValidator(TStateValidator stateValidator, TValueValidator valueValidator)
		{
			_stateValidator = stateValidator;
			_valueValidator = valueValidator;
		}

		public Result<TValue, ValidationError> Validate(bool isSet, TValue value) 
			=> throw new NotImplementedException();
	}
}
