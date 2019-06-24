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

		private readonly Func<TSource, TValue> _mapper;

		public Data<Option<TSource>> Data => new Data<Option<TSource>>(new NullableDataValidator<TStateValidator, TValueValidatorOne, TSource, TValue>(_stateValidator, _valueValidatorOne, _mapper));

		public NullableDataSourceStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne, Func<TSource, TValue> mapper)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
			_mapper = mapper;
		}

		internal NullableDataSourceInverted<TStateValidator, TValueValidatorOne, TSource, TValue> InvertOne()
			=> new NullableDataSourceInverted<TStateValidator, TValueValidatorOne, TSource, TValue>(_stateValidator, _valueValidatorOne, _mapper);

		internal NullableDataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue> Add<TValueValidatorTwo>(TValueValidatorTwo valueValidator)
			where TValueValidatorTwo : IValueValidator<TValue>
			=> new NullableDataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TSource, TValue>(_stateValidator, _valueValidatorOne, valueValidator, _mapper);

		public static implicit operator Data<Option<TSource>>(NullableDataSourceStandard<TStateValidator, TValueValidatorOne, TSource, TValue> dataSource)
			=> dataSource.Data;
	}
}
