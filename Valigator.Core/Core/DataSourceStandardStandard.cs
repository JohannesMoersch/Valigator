using System;
using System.Collections.Generic;
using System.Text;

namespace Valigator.Core
{
	public struct DataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue>
		where TStateValidator : IStateValidator<TSource>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;

		public Data<TSource> Data => new Data<TSource>(new DataValidator<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo));

		public DataSourceStandardStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
		}

		internal DataSourceStandardInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue> InvertTwo()
			=> new DataSourceStandardInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo);

		internal DataSourceStandardStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> Add<TValueValidatorThree>(TValueValidatorThree valueValidator)
			where TValueValidatorThree : IValueValidator<TValue>
			=> new DataSourceStandardStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo, valueValidator);

		public static implicit operator Data<TSource>(DataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue> dataSource)
			=> dataSource.Data;
	}
}
