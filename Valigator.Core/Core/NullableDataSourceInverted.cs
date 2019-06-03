using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct NullableDataSourceInverted<TStateValidator, TValueValidatorOne, TValue>
		where TStateValidator : IStateValidator<Option<TValue>>
		where TValueValidatorOne : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;

		public TValueValidatorOne ValueValidator => _valueValidatorOne;

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(new NullableDataValidator<TStateValidator, InvertValidator<TValueValidatorOne, TValue>, TValue>(_stateValidator, new InvertValidator<TValueValidatorOne, TValue>(_valueValidatorOne)));

		public NullableDataSourceInverted(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
		}

		internal NullableDataSourceInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue> Add<TValueValidatorTwo>(NullableDataSourceStandard<TStateValidator, TValueValidatorTwo, TValue> dataSource)
			where TValueValidatorTwo : IValueValidator<TValue>
			=> new NullableDataSourceInvertedStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>(_stateValidator, _valueValidatorOne, dataSource.ValueValidator);

		internal NullableDataSourceInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue> Add<TValueValidatorTwo>(NullableDataSourceInverted<TStateValidator, TValueValidatorTwo, TValue> dataSource)
			where TValueValidatorTwo : IValueValidator<TValue>
			=> new NullableDataSourceInvertedInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>(_stateValidator, _valueValidatorOne, dataSource.ValueValidator);

		public static implicit operator Data<Option<TValue>>(NullableDataSourceInverted<TStateValidator, TValueValidatorOne, TValue> dataSource)
			=> dataSource.Data;
	}
}
