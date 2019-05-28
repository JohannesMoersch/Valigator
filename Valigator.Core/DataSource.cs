using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core;

namespace Valigator
{
	public struct DataSource<TStateValidator, TValueValidator, TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValueValidator : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidator _valueValidator;

		public Data<TValue> Data => new Data<TValue>(new DataValidator<TStateValidator, TValueValidator, TValue>(_stateValidator, _valueValidator));

		public DataSource(TStateValidator stateValidator, TValueValidator valueValidator)
		{
			_stateValidator = stateValidator;
			_valueValidator = valueValidator;
		}

		public static implicit operator Data<TValue>(DataSource<TStateValidator, TValueValidator, TValue> dataSource)
			=> dataSource.Data;
	}
}
