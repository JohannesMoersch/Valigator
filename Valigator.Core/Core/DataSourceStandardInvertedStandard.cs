using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct DataSourceStandardInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
		where TValueValidatorThree : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;
		private readonly TValueValidatorThree _valueValidatorThree;

		public Data<TValue> Data => new Data<TValue>(new DataValidator<TStateValidator, TValueValidatorOne, InvertValidator<TValueValidatorTwo, TValue>, TValueValidatorThree, TValue>(_stateValidator, _valueValidatorOne, new InvertValidator<TValueValidatorTwo, TValue>(_valueValidatorTwo), _valueValidatorThree));

		public DataSourceStandardInvertedStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		internal DataSourceStandardInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue> InvertThree()
			=> new DataSourceStandardInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree);

		public static implicit operator Data<TValue>(DataSourceStandardInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue> dataSource)
			=> dataSource.Data;
	}
}
