using System;
using System.Collections.Generic;
using System.Text;
using Valigator.Core.ValueValidators;

namespace Valigator.Core
{
	public struct MappedDataSource<TStateValidator, TSource, TValue>
		where TStateValidator : IStateValidator<TSource>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Func<TSource, TValue> _mapper;

		public Data<TSource> Data => new Data<TSource>(new DataValidator<TStateValidator, TSource>(_stateValidator));

		public MappedDataSource(TStateValidator stateValidator, Func<TSource, TValue> mapper)
		{
			_stateValidator = stateValidator;
			_mapper = mapper;
		}

		internal DataSourceStandard<TStateValidator, TValueValidatorOne, TSource, TValue> Add<TValueValidatorOne>(TValueValidatorOne valueValidator)
			where TValueValidatorOne : IValueValidator<TValue>
			=> new DataSourceStandard<TStateValidator, TValueValidatorOne, TSource, TValue>(_stateValidator, valueValidator, _mapper);

		public static implicit operator Data<TSource>(MappedDataSource<TStateValidator, TSource, TValue> dataSource)
			=> dataSource.Data;
	}
}
