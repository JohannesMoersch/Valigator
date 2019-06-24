using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct NullableDataSourceInverted<TStateValidator, TValueValidatorOne, TSource, TValue>
		where TStateValidator : IStateValidator<Option<TSource>>
		where TValueValidatorOne : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;

		public TValueValidatorOne ValueValidator => _valueValidatorOne;

		public Data<Option<TSource>> Data => new Data<Option<TSource>>(new NullableDataValidator<TStateValidator, InvertValidator<TValueValidatorOne, TValue>, TSource, TValue>(_stateValidator, new InvertValidator<TValueValidatorOne, TValue>(_valueValidatorOne)));

		public NullableDataSourceInverted(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
		}

		internal NullableDataSourceInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue> Add<TValueValidatorTwo>(TValueValidatorTwo valueValidator)
			where TValueValidatorTwo : IValueValidator<TValue>
			=> new NullableDataSourceInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue>(_stateValidator, _valueValidatorOne, valueValidator);

		public static implicit operator Data<Option<TSource>>(NullableDataSourceInverted<TStateValidator, TValueValidatorOne, TSource, TValue> dataSource)
			=> dataSource.Data;
	}
}
