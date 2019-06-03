using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct DataSourceInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;

		public Data<TValue> Data => new Data<TValue>(new DataValidator<TStateValidator, InvertValidator<TValueValidatorOne, TValue>, TValueValidatorTwo, TValue>(_stateValidator, new InvertValidator<TValueValidatorOne, TValue>(_valueValidatorOne), _valueValidatorTwo));

		public DataSourceInvertedStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
		}

		internal DataSourceInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue> InvertTwo()
			=> new DataSourceInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo);

		public static implicit operator Data<TValue>(DataSourceInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue> dataSource)
			=> dataSource.Data;
	}
}
