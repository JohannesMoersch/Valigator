using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public struct NullableDataSourceStandard<TStateValidator, TValueValidatorOne, TSource, TValue>
		where TStateValidator : IStateValidator<Option<TSource>>
		where TValueValidatorOne : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;

		public TValueValidatorOne ValueValidator => _valueValidatorOne;

		public Data<Option<TSource>> Data => new Data<Option<TSource>>(new NullableDataValidator<TStateValidator, TValueValidatorOne, TSource, TValue>(_stateValidator, _valueValidatorOne));

		public NullableDataSourceStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
		}

		internal NullableDataSourceInverted<TStateValidator, TValueValidatorOne, TSource, TValue> InvertOne()
			=> new NullableDataSourceInverted<TStateValidator, TValueValidatorOne, TSource, TValue>(_stateValidator, _valueValidatorOne);

		internal NullableDataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue> Add<TValueValidatorTwo>(TValueValidatorTwo valueValidator)
			where TValueValidatorTwo : IValueValidator<TValue>
			=> new NullableDataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue>(_stateValidator, _valueValidatorOne, valueValidator);

		public static implicit operator Data<Option<TSource>>(NullableDataSourceStandard<TStateValidator, TValueValidatorOne, TSource, TValue> dataSource)
			=> dataSource.Data;
	}
}
