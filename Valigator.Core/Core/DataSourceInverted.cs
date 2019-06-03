using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct DataSourceInverted<TStateValidator, TValueValidatorOne, TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValueValidatorOne : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;

		internal TValueValidatorOne ValueValidator => _valueValidatorOne;

		public Data<TValue> Data => new Data<TValue>(new DataValidator<TStateValidator, InvertValidator<TValueValidatorOne, TValue>, TValue>(_stateValidator, new InvertValidator<TValueValidatorOne, TValue>(_valueValidatorOne)));

		public DataSourceInverted(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
		}

		internal DataSourceInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue> Add<TValueValidatorTwo>(TValueValidatorTwo valueValidator)
			where TValueValidatorTwo : IValueValidator<TValue>
			=> new DataSourceInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>(_stateValidator, _valueValidatorOne, valueValidator);

		public static implicit operator Data<TValue>(DataSourceInverted<TStateValidator, TValueValidatorOne, TValue> dataSource)
			=> dataSource.Data;
	}
}
