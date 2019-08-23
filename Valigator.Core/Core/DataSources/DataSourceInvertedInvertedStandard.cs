﻿using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.DataSources
{
	public struct DataSourceInvertedInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue>
		where TStateValidator : IStateValidator<TSource>
		where TValueValidatorOne : IValueValidator<TValue>
		where TValueValidatorTwo : IValueValidator<TValue>
		where TValueValidatorThree : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;
		private readonly TValueValidatorTwo _valueValidatorTwo;
		private readonly TValueValidatorThree _valueValidatorThree;

		private readonly Mapping<TSource, TValue> _mapper;

		public Data<TSource> Data => new Data<TSource>(new DataValidator<TStateValidator, InvertValidator<TValueValidatorOne, TValue>, InvertValidator<TValueValidatorTwo, TValue>, TValueValidatorThree, TSource, TValue>(_stateValidator, new InvertValidator<TValueValidatorOne, TValue>(_valueValidatorOne), new InvertValidator<TValueValidatorTwo, TValue>(_valueValidatorTwo), _valueValidatorThree, _mapper));

		public DataSourceInvertedInvertedStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, TValueValidatorTwo valueValidatorTwo, TValueValidatorThree valueValidatorThree, Mapping<TSource, TValue> mapper)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_valueValidatorTwo = valueValidatorTwo;
			_valueValidatorThree = valueValidatorThree;
			_mapper = mapper;
		}

		internal DataSourceInvertedInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> InvertThree()
			=> new DataSourceInvertedInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue>(_stateValidator, _valueValidatorOne, _valueValidatorTwo, _valueValidatorThree, _mapper);

		public static implicit operator Data<TSource>(DataSourceInvertedInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValueValidatorThree, TSource, TValue> dataSource)
			=> dataSource.Data;
	}
}