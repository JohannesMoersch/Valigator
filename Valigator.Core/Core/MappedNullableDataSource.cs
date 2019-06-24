using System;
using System.Collections.Generic;
using System.Text;
using Functional;

namespace Valigator.Core
{
	public struct MappedNullableDataSource<TStateValidator, TSource, TValue>
		where TStateValidator : IStateValidator<Option<TSource>>
	{
		private readonly TStateValidator _stateValidator;

		private readonly Func<TSource, TValue> _mapper;

		public Data<Option<TSource>> Data => new Data<Option<TSource>>(new NullableDataValidator<TStateValidator, TSource>(_stateValidator));

		public MappedNullableDataSource(TStateValidator stateValidator, Func<TSource, TValue> mapper)
		{
			_stateValidator = stateValidator;
			_mapper = mapper;
		}

		internal NullableDataSourceStandard<TStateValidator, TValueValidatorOne, TSource, TValue> Add<TValueValidatorOne>(TValueValidatorOne valueValidator)
			where TValueValidatorOne : IValueValidator<TValue>
			=> new NullableDataSourceStandard<TStateValidator, TValueValidatorOne, TSource, TValue>(_stateValidator, valueValidator, _mapper);

		public static implicit operator Data<Option<TSource>>(MappedNullableDataSource<TStateValidator, TSource, TValue> dataSource)
			=> dataSource.Data;
	}
}
