using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public struct NullableDataSource<TStateValidator, TValueValidator, TValue>
		where TStateValidator : IStateValidator<Option<TValue>>
		where TValueValidator : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidator _valueValidator;

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(new NullableDataValidator<TStateValidator, TValueValidator, TValue>(_stateValidator, _valueValidator));

		public NullableDataSource(TStateValidator stateValidator, TValueValidator valueValidator)
		{
			_stateValidator = stateValidator;
			_valueValidator = valueValidator;
		}

		internal InvertedNullableDataSource<TStateValidator, TValueValidator, TValue> Invert()
			=> new InvertedNullableDataSource<TStateValidator, TValueValidator, TValue>(_stateValidator, _valueValidator);

		public static implicit operator Data<Option<TValue>>(NullableDataSource<TStateValidator, TValueValidator, TValue> dataSource)
			=> dataSource.Data;
	}
}
