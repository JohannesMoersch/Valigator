using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct DataSourceInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue>
		where TStateValidator : IStateValidator<TSource>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;

		private readonly Func<TSource, TValue> _mapper;

		public Data<TSource> Data => new Data<TSource>(new DataValidator<TStateValidator, InvertValidator<TValueValidatorOne, TValue>, TValueValidatorTwo, TSource, TValue>(_stateValidator, new InvertValidator<TValueValidatorOne, TValue>(_valueValidatorOne), _valueValidatorTwo, _mapper));

		public DataSourceInvertedStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, Func<TSource, TValue> mapper)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_mapper = mapper;
		}

		internal DataSourceInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue> InvertTwo()
			=> new DataSourceInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo, _mapper);

		internal DataSourceInvertedStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> Add<TValueValidatorThree>(TValueValidatorThree valueValidator)
			where TValueValidatorThree : IValueValidator<TValue>
			=> new DataSourceInvertedStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo, valueValidator, _mapper);

		public static implicit operator Data<TSource>(DataSourceInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue> dataSource)
			=> dataSource.Data;
	}
}
