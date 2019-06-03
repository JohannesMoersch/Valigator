using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public struct NullableDataSource<TStateValidator, TValue>
		where TStateValidator : IStateValidator<Option<TValue>>
	{
		private readonly TStateValidator _stateValidator;

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(new NullableDataValidator<TStateValidator, TValue>(_stateValidator));

		public NullableDataSource(TStateValidator stateValidator) 
			=> _stateValidator = stateValidator;

		public static implicit operator Data<Option<TValue>>(NullableDataSource<TStateValidator, TValue> dataSource)
			=> dataSource.Data;
	}
}
