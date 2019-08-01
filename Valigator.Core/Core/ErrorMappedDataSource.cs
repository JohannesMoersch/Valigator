using Functional;
using System;

namespace Valigator.Core
{
	public struct ErrorMappedDataSource<TStateValidator, TSource, TValue>
		where TStateValidator : IStateValidator<TSource>
	{
		//todo: Nathan better name for class?
		private readonly TStateValidator _stateValidator;

		private readonly Func<TSource, Result<TValue, MappingError>> _mapper;
		private readonly TValue _defaultValue;

		public Data<TSource> Data => new Data<TSource>(new DataValidator<TStateValidator, TSource>(_stateValidator));

		public ErrorMappedDataSource(TStateValidator stateValidator, Func<TSource, Result<TValue, MappingError>> mapper, TValue defaultValue)
		{
			_stateValidator = stateValidator;
			_mapper = mapper;
			_defaultValue = defaultValue;
		}

		internal DataSourceStandard<TStateValidator, TValueValidatorOne, TSource, TValue> Add<TValueValidatorOne>(TValueValidatorOne valueValidator)
			where TValueValidatorOne : IValueValidator<TValue>
		{
			var mapper = _mapper;
			var defaultValue = _defaultValue;
			return new DataSourceStandard<TStateValidator, TValueValidatorOne, TSource, TValue>(_stateValidator, valueValidator, value => mapper.Invoke(value).Match(s => s, f => defaultValue));
		}

		public static implicit operator Data<TSource>(ErrorMappedDataSource<TStateValidator, TSource, TValue> dataSource)
			=> dataSource.Data;

		
	}
}
