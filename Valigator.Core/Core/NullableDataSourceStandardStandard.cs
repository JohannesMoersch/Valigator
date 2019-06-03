using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public struct NullableDataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>
		where TStateValidator : IStateValidator<Option<TValue>>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(new NullableDataValidator<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo));

		public NullableDataSourceStandardStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
		}

		internal NullableDataSourceStandardInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue> InvertTwo()
			=> new NullableDataSourceStandardInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo);

		internal NullableDataSourceStandardStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue> Add<TValueValidatorThree>(TValueValidatorThree valueValidator)
			where TValueValidatorThree : IValueValidator<TValue>
			=> new NullableDataSourceStandardStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo, valueValidator);

		public static implicit operator Data<Option<TValue>>(NullableDataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue> dataSource)
			=> dataSource.Data;
	}
}
