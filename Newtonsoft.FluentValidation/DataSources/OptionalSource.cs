using System;
using System.Collections.Generic;
using System.Text;
using Functional;
using Newtonsoft.FluentValidation.ValueValidators;

namespace Newtonsoft.FluentValidation.DataSources
{
	public class OptionalSource<TValue> : IDataSource<Option<TValue>>
	{
		private static DataValidator<OptionalSource<TValue>, PassthroughValidator<Option<TValue>>, Option<TValue>> Instance { get; } = new DataValidator<OptionalSource<TValue>, PassthroughValidator<Option<TValue>>, Option<TValue>>(default, default);

		public Data<Option<TValue>> Data => new Data<Option<TValue>>(Instance);

		public OptionalNullableSource<TValue> Nullable()
			=> new OptionalNullableSource<TValue>();

		public Result<Option<TValue>, ValidationError> Validate(object model, bool isSet, Option<TValue> value)
			=> isSet
				? value.Match(some => Result.Success<Option<TValue>, ValidationError>(Option.Some(some)), () => Result.Failure<Option<TValue>, ValidationError>(new ValidationError("")))
				: Result.Success<Option<TValue>, ValidationError>(Option.None<TValue>());
			

		public static implicit operator Data<Option<TValue>>(OptionalSource<TValue> dataSource)
			=> dataSource.Data;
	}
}
