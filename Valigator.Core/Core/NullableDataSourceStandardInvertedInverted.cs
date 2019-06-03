using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct NullableDataSourceStandardInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue>
		where TStateValidator : IStateValidator<Option<TValue>>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
		where TValueValidatorThree : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;
		private readonly TValueValidatorThree _valueValidatorThree;

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(new NullableDataValidator<TStateValidator, TValueValidatorOne, InvertValidator<TValueValidatorTwo, TValue>, TValueValidatorThree, TValue>(_stateValidator, _valueValidatorOne, new InvertValidator<TValueValidatorTwo, TValue>(_valueValidatorTwo), _valueValidatorThree));

		public NullableDataSourceStandardInvertedInverted(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
		}

		public static implicit operator Data<Option<TValue>>(NullableDataSourceStandardInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TValue> dataSource)
			=> dataSource.Data;
	}
}
