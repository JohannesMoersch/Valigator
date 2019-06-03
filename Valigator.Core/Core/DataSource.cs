using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct DataSource<TStateValidator, TValue>
		where TStateValidator : IStateValidator<TValue>
	{
		private readonly TStateValidator _stateValidator;

		public Data<TValue> Data => new Data<TValue>(new DataValidator<TStateValidator, TValue>(_stateValidator));

		public DataSource(TStateValidator stateValidator) 
			=> _stateValidator = stateValidator;

		public static implicit operator Data<TValue>(DataSource<TStateValidator, TValue> dataSource)
			=> dataSource.Data;
	}
}
