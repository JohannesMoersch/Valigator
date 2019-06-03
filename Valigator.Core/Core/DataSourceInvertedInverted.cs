using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct DataSourceInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;

		public Data<TValue> Data => new Data<TValue>(new DataValidator<TStateValidator, InvertValidator<TValueValidatorOne, TValue>, InvertValidator<TValueValidatorTwo, TValue>, TValue>(_stateValidator, new InvertValidator<TValueValidatorOne, TValue>(_valueValidatorOne), new InvertValidator<TValueValidatorTwo, TValue>(_valueValidatorTwo)));

		public DataSourceInvertedInverted(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
		}

		internal DataSourceInvertedInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue> Add<TValueValidatorThree>(TValueValidatorThree valueValidator)
			where TValueValidatorThree : IValueValidator<TValue>
			=> new DataSourceInvertedInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo, valueValidator);

		public static implicit operator Data<TValue>(DataSourceInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue> dataSource)
			=> dataSource.Data;
	}
}
