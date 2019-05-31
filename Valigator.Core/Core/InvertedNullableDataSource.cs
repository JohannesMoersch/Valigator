using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct InvertedNullableDataSource<TStateValidator, TValueValidator, TValue>
		where TStateValidator : IStateValidator<Option<TValue>>
		where TValueValidator : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidator _valueValidator;

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(new NullableDataValidator<TStateValidator, InvertValidator<TValueValidator, TValue>, TValue>(_stateValidator, new InvertValidator<TValueValidator, TValue>(_valueValidator)));

		public InvertedNullableDataSource(TStateValidator stateValidator, TValueValidator valueValidator)
		{
			_stateValidator = stateValidator;
			_valueValidator = valueValidator;
		}

		public static implicit operator Data<Option<TValue>>(InvertedNullableDataSource<TStateValidator, TValueValidator, TValue> dataSource)
			=> dataSource.Data;
	}
}
