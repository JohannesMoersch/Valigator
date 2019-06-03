using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public struct DataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;

		public Data<TValue> Data => new Data<TValue>(new DataValidator<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo));

		public DataSourceStandardStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
		}

		internal DataSourceStandardInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue> InvertTwo()
			=> new DataSourceStandardInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo);

		internal DataSourceStandardStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue> Add<TValueValidatorThree>(TValueValidatorThree valueValidator)
			where TValueValidatorThree : IValueValidator<TValue>
			=> new DataSourceStandardStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo, valueValidator);

		public static implicit operator Data<TValue>(DataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue> dataSource)
			=> dataSource.Data;
	}
}
