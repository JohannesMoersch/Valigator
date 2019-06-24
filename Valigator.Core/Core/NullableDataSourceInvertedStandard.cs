using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct NullableDataSourceInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue>
		where TStateValidator : IStateValidator<Option<TSource>>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;

		public Data<Option<TSource>> Data => new Data<Option<TSource>>(new NullableDataValidator<TStateValidator, InvertValidator<TValueValidatorOne, TValue>, TValueValidatorTwo, TSource, TValue>(_stateValidator, new InvertValidator<TValueValidatorOne, TValue>(_valueValidatorOne), _valueValidatorTwo));

		public NullableDataSourceInvertedStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
		}

		internal NullableDataSourceInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue> InvertTwo()
			=> new NullableDataSourceInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo);

		internal NullableDataSourceInvertedStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> Add<TValueValidatorThree>(TValueValidatorThree valueValidator)
			where TValueValidatorThree : IValueValidator<TValue>
			=> new NullableDataSourceInvertedStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo, valueValidator);

		public static implicit operator Data<Option<TSource>>(NullableDataSourceInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue> dataSource)
			=> dataSource.Data;
	}
}
