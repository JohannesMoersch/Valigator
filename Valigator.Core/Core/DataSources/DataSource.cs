using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core.DataSources
{
	public struct DataSource<TStateValidator, TDataValue, TValue, TSource>
		where TStateValidator : IStateValidator<TDataValue, TValue>
	{
		private readonly TStateValidator _stateValidator;

		public Data<TSource> Data => new Data<TSource>(new DataValidator<TStateValidator, TSource>(_stateValidator));

		public DataSource(TStateValidator stateValidator) 
			=> _stateValidator = stateValidator;

		public static implicit operator Data<TSource>(DataSource<TStateValidator, TSource> dataSource)
			=> dataSource.Data;
	}
}
