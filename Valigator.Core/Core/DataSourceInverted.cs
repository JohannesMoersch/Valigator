using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct DataSourceInverted<TStateValidator, TValueValidatorOne, TSource, TValue>
		where TStateValidator : IStateValidator<TSource>
		where TValueValidatorOne : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;

		internal TValueValidatorOne ValueValidator => _valueValidatorOne;

		public Data<TSource> Data => new Data<TSource>(new DataValidator<TStateValidator, InvertValidator<TValueValidatorOne, TValue>, TSource, TValue>(_stateValidator, new InvertValidator<TValueValidatorOne, TValue>(_valueValidatorOne)));

		public DataSourceInverted(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
		}

		internal DataSourceInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue> Add<TValueValidatorTwo>(TValueValidatorTwo valueValidator)
			where TValueValidatorTwo : IValueValidator<TValue>
			=> new DataSourceInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue>(_stateValidator, _valueValidatorOne, valueValidator);

		public static implicit operator Data<TSource>(DataSourceInverted<TStateValidator, TValueValidatorOne, TSource, TValue> dataSource)
			=> dataSource.Data;
	}
}
