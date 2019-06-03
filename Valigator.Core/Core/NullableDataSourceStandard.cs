using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public struct NullableDataSourceStandard<TStateValidator, TValueValidatorOne, TValue>
		where TStateValidator : IStateValidator<Option<TValue>>
		where TValueValidatorOne : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidatorOne _valueValidatorOne;

		public TValueValidatorOne ValueValidator => _valueValidatorOne;

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(new NullableDataValidator<TStateValidator, TValueValidatorOne, TValue>(_stateValidator, _valueValidatorOne));

		public NullableDataSourceStandard(TStateValidator stateValidator, TValueValidatorOne valueValidatorOne)
		{
			_stateValidator = stateValidator;
			_valueValidatorOne = valueValidatorOne;
		}

		internal NullableDataSourceInverted<TStateValidator, TValueValidatorOne, TValue> Invert()
			=> new NullableDataSourceInverted<TStateValidator, TValueValidatorOne, TValue>(_stateValidator, _valueValidatorOne);

		internal NullableDataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue> Add<TValueValidatorTwo>(NullableDataSourceStandard<TStateValidator, TValueValidatorTwo, TValue> dataSource)
			where TValueValidatorTwo : IValueValidator<TValue>
			=> new NullableDataSourceStandardStandard<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>(_stateValidator, _valueValidatorOne, dataSource.ValueValidator);

		internal NullableDataSourceStandardInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue> Add<TValueValidatorTwo>(NullableDataSourceInverted<TStateValidator, TValueValidatorTwo, TValue> dataSource)
			where TValueValidatorTwo : IValueValidator<TValue>
			=> new NullableDataSourceStandardInverted<TStateValidator, TValueValidatorOne, TValueValidatorTwo, TValue>(_stateValidator, _valueValidatorOne, dataSource.ValueValidator);

		public static implicit operator Data<Option<TValue>>(NullableDataSourceStandard<TStateValidator, TValueValidatorOne, TValue> dataSource)
			=> dataSource.Data;
	}
}
