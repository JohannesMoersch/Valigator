using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct InvertedDataSource<TStateValidator, TValueValidator, TValue>
		where TStateValidator : IStateValidator<TValue>
		where TValueValidator : IValueValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;
		private readonly TValueValidator _valueValidator;

		public Data<TValue> Data => new Data<TValue>(new DataValidator<TStateValidator, InvertValidator<TValueValidator, TValue>, TValue>(_stateValidator, new InvertValidator<TValueValidator, TValue>(_valueValidator)));

		public InvertedDataSource(TStateValidator stateValidator, TValueValidator valueValidator)
		{
			_stateValidator = stateValidator;
			_valueValidator = valueValidator;
		}

		public static implicit operator Data<TValue>(InvertedDataSource<TStateValidator, TValueValidator, TValue> dataSource)
			=> dataSource.Data;
	}
}
