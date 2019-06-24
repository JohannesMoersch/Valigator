using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public struct NullableDataSource<TStateValidator, TSource>
		where TStateValidator : IStateValidator<Option<TSource>>
	{
		private readonly TStateValidator _stateValidator;

		public Data<Option<TSource>> Data => new Data<Option<TSource>>(new NullableDataValidator<TStateValidator, TSource>(_stateValidator));

		public NullableDataSource(TStateValidator stateValidator) 
			=> _stateValidator = stateValidator;

		public static implicit operator Data<Option<TSource>>(NullableDataSource<TStateValidator, TSource> dataSource)
			=> dataSource.Data;
	}
}
